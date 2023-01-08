using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicstop : MonoBehaviour
{
    private GameObject WOW;

    void Start()
    {
        
        WOW = GameObject.FindGameObjectWithTag("Music");
        Destroy(WOW);
    }


}
