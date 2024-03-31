using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeController : MonoBehaviour {

    [SerializeField] Button easyButton, mediumButton, hardButton, backButton;
    [SerializeField] GameObject gameScreen, modeScreen;
    PlaySound playSound;
    [SerializeField] GameObject playSoundObject;

    // Start is called before the first frame update
    void Start() {
        playSound = playSoundObject.GetComponent<PlaySound>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void StartGame(int mode) {
        gameScreen.SetActive(true);
        modeScreen.SetActive(false);

        if(mode == 0) {
            playSound.SetSoundObjectDifficulty(0);
        }
        else if(mode == 1) {
            playSound.SetSoundObjectDifficulty(1);
        }
        else if(mode == 2) {
            playSound.SetSoundObjectDifficulty(2);
        }
    }

    public void ToMainMenu() {
        gameScreen.SetActive(false);
        modeScreen.SetActive(true);
    }
}
