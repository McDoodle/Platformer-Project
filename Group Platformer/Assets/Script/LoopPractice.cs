using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPractice : MonoBehaviour {

    public GameObject prefab;
    // Use this for initialization
    void Start() {
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum = +i;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
                Instantiate(prefab, new Vector3(j, i, 0), Quaternion.identity);
        }

        int num = 0;
        while (num < 10)
        {
            num++;
            //break;
        }




        //create a for loop to add up all the numbers
        //between 76 and 103
        int newSum = 0;
        for(int i = 76; i<= 102; i++)
        {
            newSum += i;
        }

  }

	// Update is called once per frame
	void Update () {
		
	}
}
