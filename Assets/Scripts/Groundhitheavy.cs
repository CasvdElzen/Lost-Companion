using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundhitheavy : MonoBehaviour
{
    [SerializeField] private GameObject PPSHHH;
    [SerializeField] private AudioSource BAM;
    private bool Switcher = true;
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Boom") && Switcher == true)
        {
            BAM.Play();
            GameObject obj = Instantiate(PPSHHH, transform.position - (Vector3.up * transform.localScale.y / 2), Quaternion.Euler(-90, 0, 0));
            Switcher = false;
            
        }
    }
}
