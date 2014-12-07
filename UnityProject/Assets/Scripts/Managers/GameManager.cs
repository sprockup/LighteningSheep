using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private int currentScore;
	private int highScore;

	private int currentLevel = 0;
	private int unlockedLevel;

	public GUISkin skin;
	public Rect timerRect;
	public Rect sheepCountRect;
	public float startTime = 60.0f;
	private string currentTime;
	
	private bool showWinScreen = false;
	private int sheepCount;
	
	public ScoreManager scoreManager;
	public GameObject spawnLocation;
	
	public GameObject levelCompletePanel;
	
	void Start()
	{

		scoreManager = new ScoreManager();
		/**
		totalTokenCount = tokenParent.transform.childCount;
		currentLevel = PlayerPrefs.GetInt("Level Completed");
		if (PlayerPrefs.GetInt("Level Completed") <= 0)
		{
			currentLevel = 0;
		}
		*/
		
		// Start function to spawn sheep
		//StartCoroutine(SpawnSheep());
		
		levelCompletePanel.SetActive(false);
	}

	void Update()
	{
		if (!showWinScreen)
		{
			startTime -= Time.deltaTime;
			currentTime = string.Format("{0:0.00}", startTime);
		}
						
		// Count the sheep
		GameObject[] sheep = GameObject.FindGameObjectsWithTag("Sheep");
		sheepCount = sheep.GetLength(0);
		((UILabel)GameObject.Find("Sheep Count Label").GetComponent<UILabel>()).text = sheepCount.ToString();
		((UILabel)GameObject.Find("Score Label").GetComponent<UILabel>()).text = ScoreManager.GetScore().ToString();
		
		if (startTime <= 0 || sheepCount <= 0)
		{
			CompleteLevel();
		}
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel("main_menu"); 
		}
	}

	void OnGUI()
	{
		GUI.skin = skin;
		GUI.Label(timerRect, currentTime, skin.GetStyle("Timer"));
		//GUI.Label(sheepCountRect, sheepCount.ToString(), skin.GetStyle("SheepCount"));
		
		if (showWinScreen)
		{
			levelCompletePanel.SetActive(true);
		/*
			// Dynamic width & height based on screen size
			float boxHeight, boxWidth;
			boxWidth = Screen.width * .8f;
			boxHeight = Screen.height * .4f;
			// Create rect on top of level
			Rect winScreenRect = new Rect((Screen.width/2) - (boxHeight/2), 
			                              (Screen.height/2) - (boxHeight/2), 
			                              boxWidth, boxHeight);
			GUI.Box(winScreenRect, "Level Completed!");
			
			if (GUI.Button(new Rect(winScreenRect.x + winScreenRect.width - 170, 
			                    winScreenRect.y + winScreenRect.height - 50,
			                    150, 40), "Continue"))
            {
            	// Quit clicked
				showWinScreen = false;
				Application.LoadLevel("main_menu");
            }
            
			if (GUI.Button(new Rect(winScreenRect.x + 10, 
			                        winScreenRect.y + winScreenRect.height - 50,
			                        100, 40), "Quit"))
			{
				// Quit clicked
				showWinScreen = false;
				Application.LoadLevel("main_menu");
			}
            
            GUI.Label(new Rect(winScreenRect.x + 20, winScreenRect.y + 40, 300, 50), startTime.ToString());
            */
		}
	}

	public void OnContinueButtonClick()
	{
		// Quit clicked
		showWinScreen = false;
		Application.LoadLevel("main_menu");
	}
	
	public void OnQuitButtonClick()
	{
		// Quit clicked
		showWinScreen = false;
		Application.LoadLevel("main_menu");
	}
	

	public void CompleteLevel()
	{
		showWinScreen = true;
	}
	
	void LoadNextLevel()
	{
		currentLevel = 0;
		Application.LoadLevel(currentLevel);
	}
	
	void SaveGame()
	{
		
	}
	
	IEnumerator SpawnSheep()
	{
		bool spawning = true;
		
		while (spawning)
		{
			GameObject barn = GameObject.Find("Barn");
			//barn.
			// Wait for that amount of time
			yield return new WaitForSeconds(30f);
		}
	}
}
