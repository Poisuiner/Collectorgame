using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stairsbutton : MonoBehaviour {

    public GameObject Stairs;
    int i = 0 ;

    void OnTriggerEnter(Collider col)
    {
        while (i < 1)
        {
            if (col.gameObject.tag == "Player")
            {
                Instantiate(Stairs, new Vector3(-6, -1, 12), Quaternion.identity);
                i++;
            }
        }
        

        

        
    }

}
