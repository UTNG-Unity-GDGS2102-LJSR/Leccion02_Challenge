//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E 29/09/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
      private float tiemEsp =1;
    private float tiemDisparo = 0;

    void Update()
    {
      
        // Tiempo para el disparo
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiemDisparo)
        {   
            // Muestra un perro cada cierto tiempo 
            tiemDisparo = Time.time + tiemEsp;
            // Se crean copias del perro donde se encuentre el jugador
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        }
    }
}
