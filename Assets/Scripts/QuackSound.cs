using System;
using System.Collections;
using UnityEngine;

public class QuackSound : MonoBehaviour
{
    private bool isSpawn;
    public float waitTime = 3f;
    private AudioSource duckAudio;
   

    private void Start()
    {
        duckAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (StartGame.isStart && !isSpawn)
        {
            StartCoroutine(spawnAudio());
            isSpawn = true;
        }
    }

    IEnumerator spawnAudio()
    {
        while (StartGame.isStart == true)
        {
            duckAudio.Play();
            yield return new WaitForSeconds(waitTime);
        }
    }
}
