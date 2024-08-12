using UnityEngine.UI;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Text scoreText;
    private short _score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            _score++;
            scoreText.text = "Score: " + _score.ToString();
            
            if(PlayerPrefs.GetInt("score") < _score)
                PlayerPrefs.SetInt("score", _score);
        }
    }
}
