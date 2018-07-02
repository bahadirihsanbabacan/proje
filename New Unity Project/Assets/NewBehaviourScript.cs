using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    

    static void degertipi(out int x)
    {
        x = 110;
    }
    

	// Use this for initialization
	void Start () {


        int x ;
        degertipi(out x);
        Debug.Log(x);
		
	}
	
	
}
