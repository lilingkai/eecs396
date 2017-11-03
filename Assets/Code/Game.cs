using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Object cell = Instantiate(Resources.Load("Platform"), new Vector3(i, 0f, j), Quaternion.identity);
            }
        }

        //GameObject home = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        //home.transform.position = new Vector3(4, 1, 4);

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
