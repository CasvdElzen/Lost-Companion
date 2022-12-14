using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashCollect : MonoBehaviour
{
    [SerializeField] private AudioSource Gotten;
    [SerializeField] private GameObject Achieve;
    public DemoManager demoManager;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dash"))
        {

            Gotten.Play();


            Destroy(collision.gameObject);
            demoManager.DashCheck = 1;
            GameObject obj = Instantiate(Achieve, transform.position - (Vector3.up * transform.localScale.y / 2), Quaternion.Euler(-90, 0, 0));
        }
    }
}
