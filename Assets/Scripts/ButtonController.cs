using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    public GameObject buttonImage;
    public int id;
    GuessButtonController guessController;
    [SerializeField] GameObject guessButton; // SerializeField är som private fast den syns i editorn också

    void Awake() {
        guessController = guessButton.GetComponent<GuessButtonController>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void SetFretActive() {
        buttonImage.SetActive(true);
        guessController.SetClickedFret(id - 1, true);
    }

    public void SetFretInactive() {
        buttonImage.SetActive(false);
        guessController.SetClickedFret(id - 1, false);
    }
}
