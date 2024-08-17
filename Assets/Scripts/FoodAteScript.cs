using UnityEngine;

public class FoodAteScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Food eaten");
        Destroy(gameObject);
        Destroy(other.gameObject);
        if (GameManagerScript.Instance != null)
        {
            GameManagerScript.Instance.Score++;
            Debug.Log("Score: " + GameManagerScript.Instance.Score);
        }
    }
}
