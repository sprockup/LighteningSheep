using UnityEngine;
using System.Collections;

public class ChargeManager : MonoBehaviour {

	private static float currentCharge;

	//private static float staticDischargeRate = 0.5f;
	private static float chargeKillLevel = 20.0f;
	
	public enum ChargeState {NotReady, ReadyToDischarge};
	private static ChargeState currentState;

	// Charge characteristics
	public const float CHARGEMULTIPLIER = 0.5f;
	public const float MAXCHARGE = 500f;
	
	void OnGUI()
	{
		// Dynamic width & height based on screen size
		/*float boxHeight, boxWidth;
		boxWidth = Screen.width * .95f;
		boxHeight = Screen.height * .15f;
		// Create rect on top of level
		Rect winScreenRect = new Rect((Screen.width/2) - (boxHeight/2), 
		                              (Screen.height/2) - (boxHeight/2), 
		                              boxWidth, boxHeight);
		GUI.Box(winScreenRect, "Charge");*/
	
		GUILayout.Label("Charge = " + currentCharge);
		GUILayout.Label("State  = " + currentState);
	}

	public static float AddToCharge(float amountToAdd)
	{
		// Add to the current charge and return the total
		currentCharge += amountToAdd;
		
		// Cap the charge at its maximum
		if (currentCharge > MAXCHARGE)
			currentCharge = MAXCHARGE;

		// Indicate we are ready for discharge
		SetState (ChargeState.ReadyToDischarge);

		//Debug.Log ("ChargeManager::AddToCharge(" + amountToAdd + "): " + currentCharge);
		return currentCharge;
	}

	public static void SetCharge(float newCharge)
	{
		currentCharge = newCharge;
		//Debug.Log ("ChargeManager::SetCharge = " + currentCharge);
	}

	public static float GetChargeLevel()
	{
		return currentCharge;
	}

	public static float GetChargeKillLevel()
	{
		return chargeKillLevel;
	}

	public static void SetState(ChargeState state)
	{
		// Update the current state from the passed value
		currentState = state;
		// If the current state is NotReady then reset the charge
		if (currentState == ChargeState.NotReady)
		{
			currentCharge = 0;
		}
		//Debug.Log ("ChargeManager::SetState to " + state);
	}

	public static ChargeState GetState()
	{
		return currentState;
	}
}
