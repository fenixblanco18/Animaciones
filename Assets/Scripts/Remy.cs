using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remy : MonoBehaviour
{

    [SerializeField]
    private float walkSpeed;
    [SerializeField]
    private float runSpeed;
    [SerializeField]
    private float angularSpeed;

    private float speed;

    private float h, v;

    bool Andando = false;
    bool Corriendo = false;

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        Animar();
        Mover();
    }
    void Animar()
    {
        if (v > 0)
        {
            Andando = true;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Corriendo = true;
            }
            else
            {
                Corriendo = false;
            }
        }
        else
        {
            Andando = false;
            Corriendo = false;
        }
        GetComponent<Animator>().SetBool("Andando", Andando);
        GetComponent<Animator>().SetBool("Corriendo", Corriendo);
    }
    void Mover()
    {
        if (v > 0)
        {
            if (Corriendo)
            {
                speed = runSpeed;
            }
            else if (Andando)
            {
                speed = walkSpeed;
            }
            transform.Translate(0, 0, v * speed * Time.deltaTime);
        }
        transform.Rotate(0, h * angularSpeed * Time.deltaTime, 0);
    }
}
