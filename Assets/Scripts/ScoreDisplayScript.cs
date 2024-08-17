using UnityEngine;
using TMPro;

public class ScoreDisplayScript : MonoBehaviour
{
    public TMP_Text scoreText;

    void Start()
    {
        // Ensure the GameManager instance is available
        if (GameManagerScript.Instance != null)
        {
            scoreText.text = GameManagerScript.Instance.Score.ToString();
        }
    }
}
