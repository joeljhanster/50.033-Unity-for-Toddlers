using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBrick : MonoBehaviour
{
    public GameObject debris;
    // public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player")) {
            // assumer we have 5 debris per box
            debris.SetActive(true);
            gameObject.transform.parent.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.parent.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<AudioSource>().Play();
            // coin.SetActive(true);
            GetComponent<EdgeCollider2D>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
