using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTune : MonoBehaviour {

    public AudioSource[] tune;
    public GameObject[] frets;
    private bool[] stringPlucked;
    GuessButtonController guessController;
    [SerializeField] GameObject guessButtonController;
    [SerializeField] GameObject[] guitarString;
    [SerializeField] Material notPluckedMat;
    [SerializeField] Material pluckedMat;

    // Start is called before the first frame update
    void Start() {
        guessController = guessButtonController.GetComponent<GuessButtonController>();
        stringPlucked = new bool[6];
    }

    // Update is called once per frame
    void Update() {

    }

    public void PlayEString() {

        stringPlucked[0] = true;
        guitarString[0].GetComponent<Image>().material = pluckedMat;

        // E1
        if (!frets[0].activeInHierarchy
        && !frets[1].activeInHierarchy
        && !frets[2].activeInHierarchy) {
            tune[0].Play();
        }
        // F1
        else if(frets[0].activeInHierarchy) {
            tune[1].Play();
        }
        // F#1
        else if (frets[1].activeInHierarchy) {
            tune[2].Play();
        }
        // G1
        else if (frets[2].activeInHierarchy) {
            tune[3].Play();
        }
        guessController.CheckChord();

        StartCoroutine(ResetPlucked(0));
    }

    public void PlayAString() {

        stringPlucked[1] = true;
        guitarString[1].GetComponent<Image>().material = pluckedMat;

        // A1
        if (!frets[3].activeInHierarchy
        && !frets[4].activeInHierarchy
        && !frets[5].activeInHierarchy) {
            tune[4].Play();
        }
        // A#1
        else if (frets[3].activeInHierarchy) {
            tune[5].Play();
        }
        // B1
        else if (frets[4].activeInHierarchy) {
            tune[6].Play();
        }
        // C2
        else if (frets[5].activeInHierarchy) {
            tune[7].Play();
        }
        guessController.CheckChord();

        StartCoroutine(ResetPlucked(1));
    }

    public void PlayDString() {

        stringPlucked[2] = true;
        guitarString[2].GetComponent<Image>().material = pluckedMat;

        // D2
        if (!frets[6].activeInHierarchy
        && !frets[7].activeInHierarchy
        && !frets[8].activeInHierarchy) {
            tune[8].Play();
        }
        // D#2
        else if (frets[6].activeInHierarchy) {
            tune[9].Play();
        }
        // E2
        else if (frets[7].activeInHierarchy) {
            tune[10].Play();
        }
        // F2
        else if (frets[8].activeInHierarchy) {
            tune[11].Play();
        }
        guessController.CheckChord();

        StartCoroutine(ResetPlucked(2));
    }

    public void PlayGString() {

        stringPlucked[3] = true;
        guitarString[3].GetComponent<Image>().material = pluckedMat;

        // G2
        if (!frets[9].activeInHierarchy
        && !frets[10].activeInHierarchy
        && !frets[11].activeInHierarchy) {
            tune[12].Play();
        }
        // G#2
        else if (frets[9].activeInHierarchy) {
            tune[13].Play();
        }
        // A2
        else if (frets[10].activeInHierarchy) {
            tune[14].Play();
        }
        // A#2
        else if (frets[11].activeInHierarchy) {
            tune[15].Play();
        }
        guessController.CheckChord();

        StartCoroutine(ResetPlucked(3));
    }

    public void PlayBString() {

        stringPlucked[4] = true;
        guitarString[4].GetComponent<Image>().material = pluckedMat;

        // B2
        if (!frets[12].activeInHierarchy
        && !frets[13].activeInHierarchy
        && !frets[14].activeInHierarchy) {
            tune[16].Play();
        }
        // C3
        else if (frets[12].activeInHierarchy) {
            tune[17].Play();
        }
        // C#3
        else if (frets[13].activeInHierarchy) {
            tune[18].Play();
        }
        // D3
        else if (frets[14].activeInHierarchy) {
            tune[19].Play();
        }
        guessController.CheckChord();

        StartCoroutine(ResetPlucked(4));
    }

    public void PlayELightString() {

        stringPlucked[5] = true;
        guitarString[5].GetComponent<Image>().material = pluckedMat;

        // E3
        if (!frets[15].activeInHierarchy
        && !frets[16].activeInHierarchy
        && !frets[17].activeInHierarchy) {
            tune[20].Play();
        }
        // F3
        else if (frets[15].activeInHierarchy) {
            tune[21].Play();
        }
        // F#3
        else if (frets[16].activeInHierarchy) {
            tune[22].Play();
        }
        // G3
        else if (frets[17].activeInHierarchy) {
            tune[23].Play();
        }
        guessController.CheckChord();

        StartCoroutine(ResetPlucked(5));
    }

    IEnumerator ResetPlucked(int i) {
        yield return new WaitForSeconds(0.5f);
        guitarString[i].GetComponent<Image>().material = notPluckedMat;
        yield return new WaitForSeconds(2.5f);
        stringPlucked[i] = false;
    }

    public bool[] GetStringPlucked() {
        return stringPlucked;
    }
}
