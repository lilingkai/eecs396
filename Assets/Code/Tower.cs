using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {
    public const int cost = 20;
    public float FIRING_RATE;
    protected float _lastShot;
    protected Gun _gun;

	// Use this for initialization
	protected virtual void Start() {
        this._lastShot = Time.time;
        this._gun = GetComponentInChildren<Gun>();
	}

    // Finds nearest enemy
    public Enemy GetNearestEnemy()
    {
        Enemy nearest = null;
        Vector3 distance = Vector3.positiveInfinity;
        foreach (Enemy enemy in GameObject.FindObjectsOfType<Enemy>())
        {
            Vector3 currentDistance = enemy.transform.position - this.transform.position;
            if (currentDistance.sqrMagnitude < distance.sqrMagnitude)
            {
                distance = currentDistance;
                nearest = enemy;
            }
        }
        return nearest;
    }

    // Update is called once per frame
    protected void Update() {
        Enemy nearestEnemy = GetNearestEnemy();
        // Rotates the tower in the direction of the nearest enemy, if there is one
        if (nearestEnemy == null)
        {
            return;
        }
        Vector3 distance = nearestEnemy.transform.position - this.transform.position;
        this.transform.rotation = Quaternion.LookRotation(new Vector3(distance.x, 0, distance.z), Vector3.up);

        // Fires bullet at FIRING_RATE
        if ((Time.time - _lastShot) > FIRING_RATE)
        {
            _lastShot = Time.time;
            this._gun.Fire();
        }
	}
}
