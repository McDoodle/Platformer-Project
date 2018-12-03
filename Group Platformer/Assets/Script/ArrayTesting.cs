using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTesting : MonoBehaviour {

    public bool[] boolArray;
	// Use this for initialization
	void Start () {
        //log the value from the array at index 2
        //Debug.Log(boolArray[2]);
        boolArray[1] = true;

        //boolArray[5] = false;
        //can't reference an index that doesn't exist
        //Debug.Log(boolArray.Length);
        //Debug.Log(boolArray[boolArray.Length - 1]);

        bool special = true;
        for (int i = 0; i < boolArray.Length; i++)
        {
            //Debug.Log(boolArray[i]);
            if (boolArray[i] == false)
            {
                //we missed one of thee objectives
                special = false;
                Debug.Log("YOU LOSE. GOOD DAY SIR");
                break;
            }
        }
        if (special)
        {
            Debug.Log("there was much rejoicing");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
