using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    private Animator _fall;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            //_fall.Play("Sweep Fall");
        }
        
    }

    void Start()
    {
        _fall = this.transform.parent.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        }
}
