using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChaseScript : MonoBehaviour
{
    public flying[] enemyArray;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            foreach (flying enemy in enemyArray)
            {
                enemy.chase = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            foreach (flying enemy in enemyArray)
            {
                enemy.chase = false;
            }
        }
    }



    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }
}