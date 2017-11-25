using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FreezeTower : MonoBehaviour {
    public const int cost = 100;
    public int _destroy;
    private int AOE;
    private float FREEZE_RATE;

	// Use this for initialization
	void Start () {
        _destroy = 0;
        FREEZE_RATE = 2f / 3f;
        AOE = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (_destroy == 0)
        {
            Enemy[] nearest = new Enemy[8];
            Vector3 distance = Vector3.positiveInfinity;
            foreach (Enemy enemy in GameObject.FindObjectsOfType<Enemy>())
            {
                Vector3 currentDistance = enemy.transform.position - this.transform.position;
                if (currentDistance.sqrMagnitude <= 1f)
                {
                    enemy.GetComponent<NavMeshAgent>().speed *= FREEZE_RATE;
                    enemy.gameObject.GetComponent<Enemy>().TakeDamage(AOE);
                }
            }
        }
	}
}
