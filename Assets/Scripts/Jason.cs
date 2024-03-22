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

    bool Andar = false;
    bool Correr = false;
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
            Andar=true;
        } else {
            Andar = false;
            Correr = false;
        }    
        if (Input.GetKey(KeyCode.LeftShift))
            {
                Correr = true;
            }
            else
            {
                Correr = false;
            }
        
        GetComponent<Animator>().SetBool("Andar",Andar);
        GetComponent<Animator>().SetBool("Correr",Correr);
    }
    void Mover(){
        transform.Translate(0,0,v*speed*Time.deltaTime);
        transform.Rotate(0,h*angularSpeed*Time.deltaTime,0);
    }
}
