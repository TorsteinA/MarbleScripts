using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {


	public GameController gameController;
	public AudioScript audioScript;
    public MagnetScript magnet;

    void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Collectable"){
			gameController.collectItem ();
			audioScript.PickUp ();
			Destroy (other.gameObject);
		} else if (other.gameObject.tag == "Beacon"){
            Destroy(other.transform.parent.gameObject);
            magnet.Push();
            gameController.Win ();
			audioScript.Win ();
		}

	}
}
