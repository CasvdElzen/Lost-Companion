using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portals : MonoBehaviour
{
    public Animator transition;


    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Okay");

        if (collision.gameObject.CompareTag("Portals") && Input.GetKey(KeyCode.W))
        {
            Debug.Log("Play");


            transition.SetTrigger("Start");
            StartCoroutine(Portal());

        }

        IEnumerator Portal()
        {
            yield return new WaitForSeconds(3.65f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }

}
