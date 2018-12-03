using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looptyloop : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int sum = 0;
        for( int i = 1; i < 11; i++)
        {
            Debug.Log("iteration" + i);
        }
        for(int i = 176; i < 1000; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
        for (int i = 1; i < 101; i++)
        {
            var die1 = Random.Range(1, 7);
            var die2 = Random.Range(1, 7);
            Debug.Log("rolled a" + (die1 + die2));
            if(die1 + die2 == 12)
            {
                Debug.Log("rolled a 12,Crit");
               break;
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
