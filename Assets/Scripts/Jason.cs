using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jason : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float angularSpeed;

    private float h, v;

    bool andando = false;
    bool corriendo = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        Animar();
        Mover();
    }
    void Animar(){
        if (v>0){
            andando=true;
        } else {
            andando=false;
        }
        GetComponent<Animator>().SetBool("Andar",andando);
    }
    void Mover(){
        transform.Translate(0,0,v*speed*Time.deltaTime);
        transform.Rotate(0,h*angularSpeed*Time.deltaTime,0);
    }
}
