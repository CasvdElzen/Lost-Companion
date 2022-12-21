using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SanityMeter : MonoBehaviour
{
    [Header("Sanity")]
    [SerializeField] private float sanity = 300;
    public SliderChanger slider;

    [SerializeField] private GameObject DeadParticles;
    [SerializeField] private AudioSource Deadd;
    [SerializeField] private AudioSource Deaddd;
    public Animator transition;
    public Animator transition1;

    private Rigidbody2D rb;

    private bool inLight;
    private bool DeathCheck;

    void Start()
    { 
        slider.SetMaxValue(sanity);
        DeathCheck = true;
    }

    void Update()
    {
        slider.SetValue(sanity);
        if (sanity >= 0 && !inLight) 
        { 
            sanity = sanity - (Time.deltaTime * 20);
        }
        if (sanity <= 300 && inLight) 
        { 
            sanity = sanity + (Time.deltaTime * 140);
        }
        if (sanity <= 0 && DeathCheck == true)
        {
            DeathCheck = false;
            //SceneManager.LoadScene("Demo");
            transition1.SetTrigger("SceneDie");
            transition.SetTrigger("Dead");
            GameObject obj = Instantiate(DeadParticles, transform.position - (Vector3.up * transform.localScale.y / 2), Quaternion.Euler(-90, 0, 0));
            rb = GetComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Static;
            StartCoroutine(Dying());
        }
    }

    IEnumerator Dying()
    {
        Deadd.Play();
        Deaddd.Play();
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Light")) 
        { 
            inLight = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D col) 
    { 
        inLight = false;
    }










}
