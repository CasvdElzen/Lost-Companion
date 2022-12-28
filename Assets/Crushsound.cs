using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crushsound : MonoBehaviour
{
    [SerializeField] AudioSource crush;
    [SerializeField] AudioSource tick;
    [SerializeField] private GameObject DeadParticles;
    [SerializeField] private GameObject Charge;

    public void Crushstompsound()
    {
        crush.Play();
        GameObject obj = Instantiate(DeadParticles, transform.position - (Vector3.up * transform.localScale.y / 2), Quaternion.Euler(-90, 0, 0));
        Destroy(obj, 1);
    }

    public void Tick()
    {
        tick.Play();
    }
    public void charge()
    {
        GameObject obj2 = Instantiate(Charge, transform.position - (Vector3.up * transform.localScale.y / 2), Quaternion.Euler(-90, 0, 0));
        Destroy(obj2, 1);
    }


}
