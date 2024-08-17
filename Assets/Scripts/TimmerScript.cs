using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private float timerDuration = 150f;
    [SerializeField] private TMP_Text timerText;

    private float timeRemaining;

    void Start()
    {
        timeRemaining = timerDuration;
        UpdateTimerDisplay();
        StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine()
    {
        while (timeRemaining > 0)
        {
            yield return new WaitForSeconds(1f);
            timeRemaining--;
            UpdateTimerDisplay();
        }

        OnTimerComplete();
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void OnTimerComplete()
    {
        SceneManager.LoadScene("ScoreScene"); 
    }
}
