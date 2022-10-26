using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrok : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player_w"))
        {
            
            anim.Play("Sweep Fall");
        }
    }
}
