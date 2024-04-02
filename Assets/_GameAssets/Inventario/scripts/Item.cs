using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Inventario
{
    public class Item : MonoBehaviour
    {
        public string nombre;
        public int numeroItems;

        public Sprite imagenUI;

        public GameObject panelInventario;
        public GameObject prefabItemPanel;
    }
}
