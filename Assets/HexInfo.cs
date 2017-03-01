using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexInfo : MonoBehaviour
{
    public int oil;
    public int food, water;


    // Use this for initialization
    void Start()
    {
        int rand = Random.Range(0, 3);
        switch (rand)
        {
            case 0:
                oil = Random.Range(3, 8);
                break;
            case 1:
                food = Random.Range(3, 8);
                break;
            case 2:
                water = Random.Range(3, 8);
                return;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
