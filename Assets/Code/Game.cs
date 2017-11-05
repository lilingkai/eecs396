using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public static Grid Grid;
    public static Base Base;
    public static EnemyManager EnemyManager;
    public static Tower Tower;
	// Use this for initialization
	void Start () {
        Game.Grid = GameObject.FindObjectOfType<Grid>();
        Game.Base = GameObject.FindObjectOfType<Base>();
        Game.EnemyManager = GameObject.FindObjectOfType<EnemyManager>();

        //GameObject home = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        //home.transform.position = new Vector3(4, 1, 4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
