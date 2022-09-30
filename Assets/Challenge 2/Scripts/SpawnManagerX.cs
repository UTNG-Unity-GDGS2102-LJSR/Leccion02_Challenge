//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E 29/09/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
         // Se genera un índice de forma aleatoria
        int balon = Random.Range(0,3);
        
        // Se crea un balón en un lugar aleatorio
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
    
        // Se instancia el balón en un lugar de forma aleatoria
        Instantiate(ballPrefabs[balon], spawnPos, ballPrefabs[balon].transform.rotation);
       
        startDelay = Random.Range(1,5);
        Invoke("SpawnRandomBall", startDelay);

    }

}
