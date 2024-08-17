using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    // SerializeField variables
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private GameObject foodPrefab;
    [SerializeField] private GameObject gameManagerPrefab;

    // Private variables
    private float horicontalInput;
    private float boundary = 20.0f;
 
    void Update()
    {
        horicontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horicontalInput);
     
        if (transform.position.x < -boundary)
        {
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundary)
        {
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }

        // food through
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }

        if (gameManagerPrefab.GetComponent<SpawningAnimalScript>().GetCanIncreaseSpeed() == true)
        {
            speed += 0.6f;
            gameManagerPrefab.GetComponent<SpawningAnimalScript>().SetCanIncreaseSpeed();
        }
    }
}
