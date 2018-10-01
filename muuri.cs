using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muuri : MonoBehaviour {
    
    public Inventory Inventory;
   

    public void OnTriggerEnter(Collider Col)
    {
            if (Col.CompareTag("Player"))
            {
                if (Inventory.haveAvain == true)
                {
                Destroy(gameObject);
                }
            }
        
    }
}
