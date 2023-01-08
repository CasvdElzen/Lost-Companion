using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FoxScript : MonoBehaviour
{
    public Animator Detected;
    [SerializeField] private AudioSource FoxHI;
    [SerializeField] private GameObject ScreamParticles;

    public Animator transition;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Detected.SetTrigger("FoxFound");
            Debug.Log("Fox");



            
        }
    }

    public void ScreamSound()
    {
        FoxHI.Play();
    }

    public void JumpPart()
    {
        GameObject obj = Instantiate(ScreamParticles, transform.position - (Vector3.up * transform.localScale.y / 2), Quaternion.Euler(-90, 0, 0));
        Destroy(obj, 1);
    }

    public void FoxEnd()
    {
        transition.SetTrigger("Start");
        StartCoroutine(Portal());

        IEnumerator Portal()
        {
            yield return new WaitForSeconds(3.65f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }




}