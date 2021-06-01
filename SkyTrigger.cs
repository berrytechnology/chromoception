
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class SkyTrigger : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField]private Animator MyAnimationController;

    public float PrevSpeed { get; private set; }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mazer"))
        {

            MyAnimationController.SetBool("SkyTrigger 0", true);


        }

    }

}
