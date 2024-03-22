using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionEngndro : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("Piedras")){
            GetComponent<Animator>().SetTrigger("CaeryRodar");
        }
    }
}
