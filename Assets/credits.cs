using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class credits : MonoBehaviour
{
    public Animator transition;



    public void Theend()
    {

        transition.SetTrigger("Start");
        StartCoroutine(Portal());

    }

    IEnumerator Portal()
    {
        yield return new WaitForSeconds(3.65f);
        SceneManager.LoadScene(0);
    }
}

