
using System.Collections.Generic;
using UnityEngine;

public class buildcity : MonoBehaviour {

    public GameObject[] buildings;
    public int mapWidht = 20;
    public int mapHeight = 20;
    int buildingFootprint = 20;

	void Start () {
		for(int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w < mapWidht; w++)
                {
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                    int n = Random.Range(0, buildings.Length);
                Instantiate(buildings[n], pos, Quaternion.identity);
                }

        }
	}
	
	
}
