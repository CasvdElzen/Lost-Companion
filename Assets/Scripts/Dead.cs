using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    [SerializeField] private GameObject DeadParticles;
    [SerializeField] private AudioSource Deadd;
    [SerializeField] private AudioSource Deaddd;
    public Animator transition;
    public Animator transition1;

    
    private Rigidbody2D rb;

    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.CompareTag("KillZone"))
        {
            transition1.SetTrigger("SceneDie");
            transition.SetTrigger("Dead");
            GameObject obj = Instantiate(DeadParticles, transform.position - (Vector3.up * transform.localScale.y / 2), Quaternion.Euler(-90, 0, 0));
            rb = GetComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Static;
            StartCoroutine(Dying());

            GetComponent<PlayerAnimator>().enabled = false;

        }

        IEnumerator Dying()
        {
            Deadd.Play();
            Deaddd.Play();
           
            yield return new WaitForSeconds(3.65f);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }








    }


}
