
//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E 29/09/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Son destruidos los objetos
    }
}
