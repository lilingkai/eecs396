using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public static int x;
    public static int z;
    public static Camera Camera;
    public static Grid Grid;
    public static Money Money;
    public static EnemyManager EnemyManager;
    public static BulletManager BulletManager;
    public static Base Base;
    public static Tower[] Towers;

	// Use this for initialization
	void Start () {
        Game.Camera = GameObject.FindObjectOfType<Camera>();
        Game.Grid = GameObject.FindObjectOfType<Grid>();
        Game.Money = GameObject.FindObjectOfType<Money>();
        Game.Base = GameObject.FindObjectOfType<Base>();
        Game.EnemyManager = GameObject.FindObjectOfType<EnemyManager>();
        Game.BulletManager = new BulletManager();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
