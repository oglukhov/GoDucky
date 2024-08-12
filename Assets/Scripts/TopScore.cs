using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TopScore : MonoBehaviour
{ 
    void Start()
    {
        GetComponent<Text>().text = "Top Score: " + PlayerPrefs.GetInt("score").ToString();
    }
}
