using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
    public Object[,] cells;
    public int[,] _track;

    private static Object _towerprefab;
    // Use this for initialization
    void Start () {
        _track = new int[5, 5];
        cells = new Object[5, 5];
        _towerprefab = Resources.Load("Tower");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Object cell = Object.Instantiate(Resources.Load("Cell"),
                    new Vector3(i, 0f, j),
                    Quaternion.identity,
                    this.transform);
                cells[i, j] = cell;
                _track[i, j] = 0;
            }
        }

        cells[4, 4] = Game.Base;
        //cells[2, 3] = Game.Tower;
    }

    public void newTower(int x, int z)
    {
        if (x != 4 || z != 4)
        {
            if (_track[x, z] != 1)
            {
                cells[x, z] = Game.Tower;
                _track[x, z] = 1;
                GameObject new_enemy = (GameObject)Object.Instantiate(_towerprefab, new Vector3(x, 1f, z), Quaternion.identity);
            }
         }
     }
    // Update is called once per frame
    void Update () {
		
	}
}
