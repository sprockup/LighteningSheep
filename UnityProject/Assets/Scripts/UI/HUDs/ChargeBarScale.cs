using UnityEngine;
using System.Collections;

public class ChargeBarScale : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	
		float newScale = Screen.width - 160;
	
		foreach( Transform child in transform)
		{
			
			if (child.name == "Background")
			{
				child.localScale = new Vector3(newScale, child.localScale.y);
				//child.localScale = new Vector3(newScale, child.localScale.y);
			}

			
			
			//child.position.x = newScale
		}
		
		
		//float tmp = this.transform.position.x
		//this.transform.position = new Vector3(-.6f, this.transform.position.y);
		
		//this.transform.localScale = new Vector3(Screen.width - 160, 1);
		//this.transform.position = new Vector3(Screen.width / 2, 5);
	}
}
