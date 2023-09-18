using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public Transform[] spawnLocation;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatTospawnClone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       ifButtonPressed();
        
    }
    void spawnBall()
    {
        whatTospawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocation[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
    }
    void ifButtonPressed()
    {
        if (Input.GetKeyDown("space")){
            spawnBall();
        }
    }
    
}
