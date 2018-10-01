using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tehdaankolikoita : MonoBehaviour {
    public GameObject coin2;
    Vector3 coinposition;
    bool jatketaan = true;
    int i;
    public float x1;
    public float x2;
    public float y1;
    public float z1;
    public float z2;

    void Start() {
        CheckCoin();
    }
    public void CheckCoin() {
        do
        {
            if (i <= 10)
            {
                coinposition = new Vector3(Random.Range(x1, x2), y1, Random.Range(z1, z2));
                Instantiate(coin2, coinposition, Quaternion.identity);
                i++;          
            }
            else if( i > 10)
            { jatketaan = false; }
            
        } while (jatketaan == true); 
    }
}
