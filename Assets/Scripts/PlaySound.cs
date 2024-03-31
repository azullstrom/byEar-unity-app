using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour {

    AudioSource source;
    [SerializeField] GameObject[] soundObject, mediumSoundObject, hardSoundObject;
    GameObject randomChord;
    public Button playChordButton;
    int mode;
    GameObject[] modeSoundObject;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

    }

    public void PlaySoundEffect() {
        source.Play();
    }

    public GameObject GetRandomChord() {
        return randomChord;
    }

    public GameObject GetSoundObject(int i) {
        return modeSoundObject[i];
    }

    public void SetSoundObjectDifficulty(int mode) {
        this.mode = mode;
        if(mode == 0) {
            randomChord = soundObject[Random.Range(0, soundObject.Length)];
            source = randomChord.GetComponent<AudioSource>();
            modeSoundObject = soundObject;
        }
        else if(mode == 1) {
            randomChord = mediumSoundObject[Random.Range(0, mediumSoundObject.Length)];
            source = randomChord.GetComponent<AudioSource>();
            modeSoundObject = mediumSoundObject;
        }
        else if(mode == 2) {
            randomChord = hardSoundObject[Random.Range(0, hardSoundObject.Length)];
            source = randomChord.GetComponent<AudioSource>();
            modeSoundObject = hardSoundObject;
        }
    }

    public int GetMode() {
        return this.mode;
    }
}
