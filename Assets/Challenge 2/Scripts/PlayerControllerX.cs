using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float dogWait;

    private const float TimeBetweenDog = 1.0f;

    private bool spawnDog = false;

    void Update()
    {

        if (dogWait > 0)
        {
            dogWait -= Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (dogWait <= 0)
            {
                dogWait = TimeBetweenDog;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
            
        }
    }
}
