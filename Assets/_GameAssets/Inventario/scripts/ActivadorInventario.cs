using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActivadorInventario : MonoBehaviour
{
    public GameObject panelInventario;
    private bool inventarioActivo = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)){
            inventarioActivo=!inventarioActivo;
            panelInventario.SetActive(inventarioActivo);
        }
    }
}
