using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    //public Button button;
    public Text buttonText;
    public AudioSource backgroundMusic;
    public AudioSource buttonSound;
    bool soundOn = true;
    private void Start()
    {
        backgroundMusic.Play();
    }

    //Audio on/off
    public void onSoundButton()
    {
        buttonSound.Play();
        soundOn = !soundOn;
        if (soundOn)
        {
            buttonText.text = "Sound On";
            backgroundMusic.Play();
        }
        else
        {
            buttonText.text = "Sound Off";
            backgroundMusic.Pause();
        }
    }
}
