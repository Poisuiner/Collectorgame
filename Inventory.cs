using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public muuri muuri;
    public bool haveAvain = false;
    public GameObject Avain;
    public GameObject AvainPrefab;

    public void AvainPickup()
    {
        haveAvain = true;
        
    }
   
}

    



