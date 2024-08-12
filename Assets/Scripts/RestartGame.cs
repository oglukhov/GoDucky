using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class RestartGame : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        /*losePanel.SetActive(false);*/
    }
}
