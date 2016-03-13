using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//objects, scripts
	public GameObject marble;
	public MvmtScript mvmt;
	public GravityScript planet;
	public AudioScript audioScript;
    public GameObject trackOne;
    public GameObject trackTwo;
    public GameObject beacon;
    public int items;
    public int stageOne;
    public int stageTwo;
	public int stageThree;

	//game states
	private bool running;
	private bool paused;
	public bool countDown;
	public float timeLimit = 180;
	private float remainingTime;

	//UI
	public Text gameOverText;
	public Text pauseText;
	public Text victoryText;
	public Text scoreText;
	public Text timer;

	// Use this for initialization
	void Start (){
		items = 0;
		running = true;
		paused = false;
		scoreText.text = items.ToString () + "/" + stageThree.ToString ();
		scoreText.enabled = true;
		audioScript.StartGame ();
		remainingTime = timeLimit;
		timer.text = formatTimeString (remainingTime);
		countDown = false;
        trackOne.SetActive(false);
        trackTwo.SetActive(false);
        beacon.SetActive(false);
	}
    // Update is called once per frame
    void Update()
    {
        if (running)
        {
            if (Input.GetKeyDown("escape"))
            {
                if (Time.timeScale == 1.0f)
                {
                    Time.timeScale = 0.0f;
                    pauseText.enabled = true;


                }
                else if (Time.timeScale == 0.0f)
                {
                    Time.timeScale = 1.0f;
                    pauseText.enabled = false;
                }
            }
            if (Time.timeScale == 1.0f && countDown)
            {
                remainingTime -= Time.deltaTime;
                timer.text = formatTimeString(remainingTime);
            }


        }
        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene("SpaceStation v3");
        }

        if (remainingTime <= 0)
        {
            GameOver();
        }
    }

    string formatTimeString (float time){
		//var intTime = Mathf.Floor (time);
		string displayTime = String.Format ("{0:00}:{1:00}", Mathf.Floor (time / 60), Mathf.Floor (time % 60));
		return displayTime;
	}

	public void GameOver (){
		if (running){
			running = false;
			mvmt.enabled = false;
			gameOverText.enabled = true;
			audioScript.GameOver ();
		}
	}

	public void collectItem (){
		items++;
		scoreText.text = items.ToString () + "/" + stageThree.ToString ();
		itemCheck ();
	}

	void itemCheck (){
        if(items == 1) {
            countDown = true;
        } else if (items == stageOne) {
            trackOne.SetActive(true);
            audioScript.Appeared();
        } else if (items == stageTwo) {
            trackTwo.SetActive(true);
            audioScript.Appeared();
        } else if (items == stageThree) {
            beacon.SetActive(true);
            audioScript.Appeared();
        }
	}

	public void StartCountDown (){
		countDown = true;
	}

	public void RemoveControl (){
		mvmt.enabled = false;
	}

	public void AddControl (){
		mvmt.enabled = true;
	}

	public void Win (){
		mvmt.enabled = false;
		victoryText.text += "\n" + formatTimeString (timeLimit - remainingTime);
		victoryText.enabled = true;
		running = false;
        Invoke("AddPull", 1f);   
    }

    void AddPull() {
        planet.Pull();
    }
}
