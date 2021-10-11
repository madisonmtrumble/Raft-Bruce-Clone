using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileHealth : MonoBehaviour
{
    public int health = 3;

    public GameObject enemy;

    public GameObject tile;
    void Start()
    {
        enemy = GameObject.Find("Enemy");
        tile = GameObject.Find("Tile");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == enemy && health >= 2)
        {
            health--;
            Debug.Log("Enemy hit Tile.");
        }
        if(collision.gameObject == enemy && health == 1)
        {
            health--;
            Destroy(tile);
            Debug.Log("Enemy destroyed Tile.");
            
        }
    }
    void Update()
    {
        
    }
}
