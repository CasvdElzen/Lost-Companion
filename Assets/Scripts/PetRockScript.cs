using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetRockScript : MonoBehaviour
{
    public Animator Detected;
    [SerializeField] private AudioSource Scream;
    [SerializeField] private GameObject ScreamParticles;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Detected.SetTrigger("Activated");
            Debug.Log("ROCK");
        }
    }

    public void ScreamSound()
    {
        Scream.Play();
    }


}