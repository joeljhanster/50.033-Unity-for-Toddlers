using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDebris : MonoBehaviour
{
    public GameObject debris;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < GameConstants.spawnNumberOfDebris; x++) {
            Instantiate(debris, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
