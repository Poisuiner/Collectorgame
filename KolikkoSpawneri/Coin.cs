using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour {

    public static int CoinCount = 0;
    public static int vic=0;
    void Awake()
        {
            ++Coin.CoinCount;
        }
    public void OnTriggerEnter(Collider Col)
        {
        Debug.Log(Col);
         if (!Col.CompareTag("SpawnArea"))
            {
            Destroy(gameObject); 
            }
        if (Col.CompareTag("Player"))
        {
            Destroy(gameObject);    
        }   
        }

    void OnDestroy()
    {
        --Coin.CoinCount;

        if (Coin.CoinCount <= 0)
        {
            GameObject Tim = GameObject.Find("LevelTimer");
            Destroy(Tim);

            GameObject[] FireworkSystems =
            GameObject.FindGameObjectsWithTag("Fireworks");
            foreach (GameObject GO in FireworkSystems)
            GO.GetComponent<ParticleSystem>().Play();
            vic++;
        }
    }
   

}
