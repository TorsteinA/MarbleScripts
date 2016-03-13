using UnityEngine;
using System.Collections;

public class BorderScript : MonoBehaviour {

    public GameController gameController;

    void OnTriggerExit() {
        gameController.GameOver();
    }
}