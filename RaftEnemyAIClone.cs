using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftEnemyAIClone : MonoBehaviour
{
    public GameObject idlePos;

    public GameObject attackTarget;

    public GameObject enemy;

    public bool hitTile;

    public List<GameObject> raftTiles = new List<GameObject>();
    void Start()
    {
        raftTiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));

        enemy = GameObject.Find("Enemy");
        
        hitTile = false;
        Idle();
    }

    void Idle()
    {
        InvokeRepeating("Attack", 2.0f, 3.0f);
        gameObject.transform.position = idlePos.transform.position;
        hitTile = false;
    }

    void Attack()
    {
        attackTarget = raftTiles[Random.Range(0, raftTiles.Count)];

        /*
        if (attackTarget != null)
        {
            Debug.Log("Made it this far.");
            enemy.transform.position = attackTarget.transform.position;
            hitTile = true;
        }
        else
        {
            Debug.Log("No selected target...");
        }
        
        if(hitTile == true)
        {
            Idle();
        }
        */
        
    }
    void Update()
    {
        enemy.transform.position = attackTarget.transform.position;

        raftTiles.RemoveAll(item => item == null);
    }
}
