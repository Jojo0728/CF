using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Script : MonoBehaviour {

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        float DashBack = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", DashBack);
    }
}