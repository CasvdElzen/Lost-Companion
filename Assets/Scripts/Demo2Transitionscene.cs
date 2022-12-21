using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Demo2Transitionscene : MonoBehaviour
{
    public Animator transition;
    private GameObject WOW;


    private Rigidbody2D rb;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transition.SetTrigger("Start");
            StartCoroutine(Dying());

        }

        IEnumerator Dying()
        {
            yield return new WaitForSeconds(2f);

            SceneManager.LoadScene("DemoTransition");
            GameObject.FindGameObjectWithTag("Music").GetComponent<music2scene>().StopMusic();

            WOW = GameObject.FindGameObjectWithTag("Music");
            Destroy(WOW);
            
        }

    }

}
