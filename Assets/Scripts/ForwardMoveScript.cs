using UnityEngine;
using UnityEngine.SceneManagement;


public class ForwardMoveScript : MonoBehaviour
{
    // SerializeField variables
    [SerializeField] private float throughSpeed = 30.0f;

    // Private variables
    private float topBound = 30.0f;
    private float bottomBound = -13.75f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * throughSpeed);
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < bottomBound)
        {
            //SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
        }
    }
}
