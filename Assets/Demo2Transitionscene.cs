using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Demo2Transitionscene : MonoBehaviour
{
    public Animator transition;
    


    private Rigidbody2D rb;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //transition.SetTrigger("Dead");
            StartCoroutine(Dying());

        }

        IEnumerator Dying()
        {
            yield return new WaitForSeconds(0.3f);

            SceneManager.LoadScene("DemoTransition");
        }

    }

}
