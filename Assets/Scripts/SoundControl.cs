using System;
using UnityEngine.UI;
using UnityEngine;
using Button = UnityEngine.UIElements.Button;

public class SoundControl : MonoBehaviour
{
    public AudioListener _audioListener;
    public Sprite on, off;
    private Image button;
    public GameObject quack, loose, back;

    private void Awake()
    {
        button = GetComponent<Image>();
        if (PlayerPrefs.GetString("music" ) == "off")
        {
            button.sprite = off;
            button.GetComponentInChildren<Image>().color = Color.black;
            _audioListener.enabled = false;
            quack.GetComponent<AudioSource>().volume = 0f;
            loose.GetComponent<AudioSource>().volume = 0f;
            back.GetComponent<AudioSource>().volume = 0f;
        }
        
    }

    private void Update()
    {
        if(StartGame.isStart == true)
            gameObject.SetActive(false);
    }

    public void setMusic()
    {
        _audioListener.enabled = !_audioListener.enabled;
        
        if (_audioListener.enabled) //music on
        {
            quack.GetComponent<AudioSource>().volume = 1f;
            loose.GetComponent<AudioSource>().volume = 1f;
            back.GetComponent<AudioSource>().volume = 1f;
            button.sprite = on;
            button.GetComponentInChildren<Image>().color = new Color(1, 180,255,255);
            PlayerPrefs.SetString("music", "on");
        }
        else
        {
            quack.GetComponent<AudioSource>().volume = 0f;
            loose.GetComponent<AudioSource>().volume = 0f;
            back.GetComponent<AudioSource>().volume = 0f;
            button.sprite = off;
            button.GetComponentInChildren<Image>().color = Color.black;
            PlayerPrefs.SetString("music", "off");
        }
        
    }
}
