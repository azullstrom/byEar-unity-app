using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GuessButtonController : MonoBehaviour {

    public TMP_Text rightGuessText, wrongGuessText;
    private bool[] clickedFret;
    PlaySound playSound;
    PlayTune playTune;
    [SerializeField] GameObject randomChord;
    [SerializeField] GameObject allTunes;
    private bool[] stringPlucked;
    [SerializeField] GameObject winScreenFilter, loseScreenFilter;
    int wrongAnswerCount;

    // Start is called before the first frame update
    void Start() {
        clickedFret = new bool[18];
        rightGuessText.enabled = false;
        wrongGuessText.enabled = false;
        playSound = randomChord.GetComponent<PlaySound>();
        playTune = allTunes.GetComponent<PlayTune>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void SetClickedFret(int i, bool b) {
        clickedFret[i] = b;
    }

    public void CheckChord() {
        GameObject chord = playSound.GetRandomChord();
        stringPlucked = playTune.GetStringPlucked();
        bool allStringsPlucked, fiveStringsPlucked, fourStringsPlucked;

        // Checking how many strings are plucked within the next 3 seconds
        if (stringPlucked[0] && stringPlucked[1] && stringPlucked[2] && stringPlucked[3] && stringPlucked[4] && stringPlucked[5])
            allStringsPlucked = true;
        else
            allStringsPlucked = false;

        if (!stringPlucked[0] && stringPlucked[1] && stringPlucked[2] && stringPlucked[3] && stringPlucked[4] && stringPlucked[5])
            fiveStringsPlucked = true;
        else
            fiveStringsPlucked = false;

        if (!stringPlucked[0] && !stringPlucked[1] && stringPlucked[2] && stringPlucked[3] && stringPlucked[4] && stringPlucked[5])
            fourStringsPlucked = true;
        else
            fourStringsPlucked = false;

        // EASY MODE --------------------------------------------------------------
        if (playSound.GetMode() == 0) {

            // G chord
            if (chord == playSound.GetSoundObject(0)) {
                if (!clickedFret[0] && !clickedFret[1] && clickedFret[2] && !clickedFret[3] && clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && !clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && clickedFret[17]
                && allStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: G");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("G"));
                    }
                }
            }
            // C chord
            else if (chord == playSound.GetSoundObject(1)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: C");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("C"));
                    }
                }
            }
            // Am chord
            else if (chord == playSound.GetSoundObject(2)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Am");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Am"));
                    }
                }
            }
            // Em chord
            else if (chord == playSound.GetSoundObject(3)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && allStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Em");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Em"));
                    }
                }
            }
            // D chord
            else if (chord == playSound.GetSoundObject(4)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && !clickedFret[7] && !clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && clickedFret[14] && !clickedFret[15] && clickedFret[16] && !clickedFret[17]
                && fourStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: D");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("D"));
                    }
                }
            }
            // Dm Chord
            else if (chord == playSound.GetSoundObject(5)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && !clickedFret[7] && !clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && clickedFret[14] && clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fourStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Dm");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Dm"));
                    }
                }
            }
            // A Chord
            else if (chord == playSound.GetSoundObject(6)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: A");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("A"));
                    }
                }
            }
            // E Chord
            else if (chord == playSound.GetSoundObject(7)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && allStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: E");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("E"));
                    }
                }
            }
        }
        // MEDIUM MODE --------------------------------------------------------------
        else if (playSound.GetMode() == 1) {

            // C7 Chord
            if (chord == playSound.GetSoundObject(0)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && clickedFret[11]
                && clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: C7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("C7"));
                    }
                }
            }
            // D7 Chord
            else if (chord == playSound.GetSoundObject(1)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && !clickedFret[7] && !clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && clickedFret[16] && !clickedFret[17]
                && fourStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: D7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("D7"));
                    }
                }
            }
            // A7 Chord
            else if (chord == playSound.GetSoundObject(2)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: A7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("A7"));
                    }
                }
            }
            // E7 Chord
            else if (chord == playSound.GetSoundObject(3)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && !clickedFret[7] && !clickedFret[8] && clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && allStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: E7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("E7"));
                    }
                }
            }
            // Cadd9 Chord
            else if (chord == playSound.GetSoundObject(4)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Cadd9");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Cadd9"));
                    }
                }
            }
            // Fmaj7 Chord
            else if (chord == playSound.GetSoundObject(5)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && !clickedFret[7] && clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fourStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Fmaj7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Fmaj7"));
                    }
                }
            }
            // Em7 Chord
            else if (chord == playSound.GetSoundObject(6)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && !clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && allStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Em7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Em7"));
                    }
                }
            }
            // B7
            else if (chord == playSound.GetSoundObject(7)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && clickedFret[4] && !clickedFret[5]
                && clickedFret[6] && !clickedFret[7] && !clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: B7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("B7"));
                    }
                }
            }

        }
        // HARD MODE --------------------------------------------------------------
        else if (playSound.GetMode() == 2) {

            // Cmaj7 Chord
            if (chord == playSound.GetSoundObject(0)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Cmaj7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Cmaj7"));
                    }
                }
            }
            // Dsus4 Chord
            else if (chord == playSound.GetSoundObject(1)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && !clickedFret[7] && !clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && clickedFret[14] && !clickedFret[15] && !clickedFret[16] && clickedFret[17]
                && fourStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Dsus4");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Dsus4"));
                    }
                }
            }
            // Amaj7 Chord
            else if (chord == playSound.GetSoundObject(2)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Amaj7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Amaj7"));
                    }
                }
            }
            // Eadd9 Chord
            else if (chord == playSound.GetSoundObject(3)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && clickedFret[16] && !clickedFret[17]
                && allStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Eadd9");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Eadd9"));
                    }
                }
            }
            // Am7 Chord
            else if (chord == playSound.GetSoundObject(4)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Am7");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Am7"));
                    }
                }
            }
            // F6 Chord
            else if (chord == playSound.GetSoundObject(5)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && !clickedFret[7] && clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && clickedFret[14] && clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fourStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: F6");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("F6"));
                    }
                }
            }
            // Emadd9 Chord
            else if (chord == playSound.GetSoundObject(6)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && !clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && clickedFret[16] && !clickedFret[17]
                && allStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Emadd9");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Emadd9"));
                    }
                }
            }
            // Asus2
            else if (chord == playSound.GetSoundObject(7)) {
                if (!clickedFret[0] && !clickedFret[1] && !clickedFret[2] && !clickedFret[3] && !clickedFret[4] && !clickedFret[5]
                && !clickedFret[6] && clickedFret[7] && !clickedFret[8] && !clickedFret[9] && clickedFret[10] && !clickedFret[11]
                && !clickedFret[12] && !clickedFret[13] && !clickedFret[14] && !clickedFret[15] && !clickedFret[16] && !clickedFret[17]
                && fiveStringsPlucked) {
                    // Right
                    rightGuessText.enabled = true;
                    rightGuessText.SetText("CORRECT! Chord: Asus2");
                    wrongGuessText.enabled = false;
                    StartCoroutine(RightAnswer());
                } else {
                    // Wrong
                    if (allStringsPlucked || fiveStringsPlucked || fourStringsPlucked) {
                        wrongGuessText.enabled = true;
                        rightGuessText.enabled = false;
                        StartCoroutine(WrongAnswer("Asus2"));
                    }
                }
            }
        }
    }

    IEnumerator RightAnswer() {
        playSound.playChordButton.enabled = false;

        // Green flash effect
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 5);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 10);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 15);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 20);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 25);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 30);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 35);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 40);
        yield return new WaitForSeconds(1f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 35);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 30);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 25);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 20);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 15);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 10);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 5);
        yield return new WaitForSeconds(0.05f);
        winScreenFilter.GetComponent<Image>().color = new Color32(10, 255, 0, 0);
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1.2f);

        // New random chord
        playSound.SetSoundObjectDifficulty(playSound.GetMode());
        rightGuessText.enabled = false;
        playSound.playChordButton.enabled = true;
    }

    IEnumerator WrongAnswer(string chordName) {

        wrongAnswerCount++;

        if (wrongAnswerCount >= 5) {
            // Make frets clicked for 3 sec and write name of the chord then set new random chord
            wrongGuessText.enabled = true;
            wrongGuessText.SetText("The chord was: " + chordName);
            playSound.playChordButton.enabled = false;
        }

        // Red flash effect
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 5);
        yield return new WaitForSeconds(0.01f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 10);
        yield return new WaitForSeconds(0.01f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 15);
        yield return new WaitForSeconds(0.01f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 20);
        yield return new WaitForSeconds(0.01f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 25);
        yield return new WaitForSeconds(0.01f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 30);
        yield return new WaitForSeconds(0.01f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 35);
        yield return new WaitForSeconds(0.01f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 40);
        yield return new WaitForSeconds(0.02f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 35);
        yield return new WaitForSeconds(0.02f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 30);
        yield return new WaitForSeconds(0.02f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 25);
        yield return new WaitForSeconds(0.02f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 20);
        yield return new WaitForSeconds(0.02f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 15);
        yield return new WaitForSeconds(0.02f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 10);
        yield return new WaitForSeconds(0.02f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 5);
        yield return new WaitForSeconds(0.02f);
        winScreenFilter.GetComponent<Image>().color = new Color32(255, 5, 0, 0);
        yield return new WaitForSeconds(1f);

        if (wrongAnswerCount >= 5) {
            yield return new WaitForSeconds(2f);
            // New random chord
            playSound.SetSoundObjectDifficulty(playSound.GetMode());
            playSound.playChordButton.enabled = true;
            wrongGuessText.enabled = false;
            wrongGuessText.SetText("TRY AGAIN");
            wrongAnswerCount = 0;
        }

        wrongGuessText.enabled = false;
    }
}
