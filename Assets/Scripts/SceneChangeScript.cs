using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    public void onPlayPress()
    {
       SceneManager.LoadScene("PlayScene");
    }
    
    public void onExitPress()
    {
       Application.Quit();
    }

    public void onContinuePress()
    {
       SceneManager.LoadScene("HomeScene");
    }
}
