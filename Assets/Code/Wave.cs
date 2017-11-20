using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public int arrival_time;
    public int num_enemies;
    public int[] enemy_types;
    public int spawn_interval;
    public Object[] arr_enemy;
    

    public void Initialize(int t, int n, int[] types, int interval, Object[] arr)
    {
        arrival_time = t;
        num_enemies = n;
        enemy_types = types;
        spawn_interval = interval;
        arr_enemy = arr;
    }

    // Use this for initialization
    void Start () {
        arrival_time = 10;
        num_enemies = 5;
        enemy_types = new int[] { 2, 1, 2 };
        spawn_interval = 3;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Spawn()
    {
        // handle spawning enemies specified in enemy_types 
    }
}
