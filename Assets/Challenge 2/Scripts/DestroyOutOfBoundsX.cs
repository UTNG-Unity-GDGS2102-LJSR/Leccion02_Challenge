//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E 29/09/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    // Se establecen los límites 
    private float leftLimit = -38;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Se destruyen los perros en la línea X 
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Se destruyen los balones en la línea Y
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
