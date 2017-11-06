using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public static Grid Grid;
    public static EnemyManager EnemyManager;
    public static BulletManager BulletManager;
    public static Base Base;
    public static Tower Tower;

	// Use this for initialization
	void Start () {
        Game.Grid = GameObject.FindObjectOfType<Grid>();
        Game.Base = GameObject.FindObjectOfType<Base>();
        Game.EnemyManager = GameObject.FindObjectOfType<EnemyManager>();
        Game.BulletManager = new BulletManager();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
