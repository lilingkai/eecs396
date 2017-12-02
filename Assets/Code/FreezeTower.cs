using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FreezeTower : MonoBehaviour {
    public const int cost = 100;
    private int AOE;
    private float FREEZE_RATE;
    protected float _lastShot;

    // Use this for initialization
    void Start () {
        FREEZE_RATE = 2f / 3f;
        AOE = 10;
        _lastShot = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 distance = Vector3.positiveInfinity;
        foreach (Enemy enemy in GameObject.FindObjectsOfType<Enemy>())
        {
            Vector3 currentDistance = enemy.transform.position - this.transform.position;
            if (currentDistance.sqrMagnitude <= 2f)
            {
                enemy.GetComponent<NavMeshAgent>().speed = FREEZE_RATE;
                if ((Time.time - _lastShot) > 1f)
                {
                    enemy.gameObject.GetComponent<Enemy>().TakeDamage(AOE);
                    _lastShot = Time.time;
                }
            }
            else
            {
                enemy.GetComponent<NavMeshAgent>().speed = 1;
            }
        } 
	}
}
