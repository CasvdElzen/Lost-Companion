using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class randomtext : MonoBehaviour
{
    public Animator transition;

    public void Finish()
    {

        transition.SetTrigger("Start");
        StartCoroutine(Portal());

    }

    IEnumerator Portal()
    {
        yield return new WaitForSeconds(3.65f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
