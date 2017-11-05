using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
    public Object[,] cells;

    // Use this for initialization
    void Start () {
        cells = new Object[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Object cell = Object.Instantiate(Resources.Load("Cell"),
                    new Vector3(i, 0f, j),
                    Quaternion.identity,
                    this.transform);
                cells[i, j] = cell;
            }
        }

        cells[4, 4] = Game.Base;
        cells[2, 3] = Game.Tower;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
