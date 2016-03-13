using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	public AudioSource winAudio;
	public AudioSource gameOverAudio;
	public AudioSource startAudio;
	public AudioSource pickUpAudio;
	public AudioSource appearanceAudio;
	public AudioSource backdropAudio;


	void Start (){
		var clip = GetComponents<AudioSource> ();
		winAudio = clip [1];
		gameOverAudio = clip [2];
		startAudio = clip [3];
		pickUpAudio = clip [4];
		appearanceAudio = clip [5];
	}

	public void GameOver (){
		gameOverAudio.Play ();
		backdropAudio.Stop ();
	}

	public void StartGame (){
		startAudio.Play ();
	}

	public void Win (){
		winAudio.Play ();
	}

	public void PickUp (){
		pickUpAudio.Play ();
	}

	public void Appeared (){
		appearanceAudio.Play ();
	}
}
