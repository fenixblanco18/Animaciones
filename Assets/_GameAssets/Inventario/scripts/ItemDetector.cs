using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ItemDetector : MonoBehaviour
{
    public string tagInventariable;
    void OnTriggerEnter(Collider c){
        if (c.transform.CompareTag(tagInventariable)){
            //Llevarme el Item al Inventario
            Inventario.Item i = c.transform.GetComponentInParent<Inventario.Item>();
            //Activamos el panel principal
            i.panelInventario.SetActive(true);
            //Instanciamos el PanelItem y se agrega al panel principal
            GameObject panelItem = Instantiate(i.prefabItemPanel, i.panelInventario.transform);
            //Asignar la imagen al item
            panelItem.GetComponentsInChildren<UnityEngine.UI.Image>()[1].sprite=i.imagenUI;
            //Asignamos el valor del item al texto
            panelItem.GetComponentInChildren<TextMeshProUGUI>().text="x"+i.numeroItems;
            //Desactivamos de nuevo el panel
            i.panelInventario.SetActive(false);            

            //Destruir el Item
            Destroy(c.transform.parent.gameObject);
        }
    }
}
