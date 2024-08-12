using System;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject logoText;
    public float hideSpeed = 5f;
    public static bool isStart;
    public GameObject scoreText;

    private void Update()
    {
        if(isStart)
            if(isStart && logoText != null)
                logoText.transform.Translate(Vector2.up * hideSpeed * Time.deltaTime);
    }

    public void startGame()
    {
        if(isStart)
            return;
        
        isStart = true;
        logoText.GetComponent<Animator>().enabled = false;
        Destroy(logoText, 1.5f);
        GetComponent<Animation>().Play("HidePlayBtn");
        GetComponent<Button>().enabled = false;
        scoreText.SetActive(true);
    }
}
