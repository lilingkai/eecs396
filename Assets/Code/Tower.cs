using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {
    public const int cost = 20;
    private const float FIRING_RATE = 0.5f;

    private float _lastShot;
    private Gun _gun;

	// Use this for initialization
	void Start () {
        this._lastShot = Time.time;
        this._gun = GetComponentInChildren<Gun>();
	}

    // Update is called once per frame
    void Update() {
        // Finds nearest enemy
        Enemy nearest = null;
        Vector3 distance = Vector3.positiveInfinity;
        foreach (Enemy enemy in GameObject.FindObjectsOfType<Enemy>()) {
            Vector3 currentDistance = enemy.transform.position - this.transform.position;
            if (currentDistance.sqrMagnitude < distance.sqrMagnitude)
            {
                distance = currentDistance;
                nearest = enemy;
            }
        }
        // Rotates the tower in the direction of the nearest enemy, if there is one
        if (nearest != null)
        {
            this.transform.rotation = Quaternion.LookRotation(new Vector3(distance.x, 0, distance.z), Vector3.up);
        }
        // Fires bullet at FIRING_RATE
        if ((Time.time - _lastShot) < FIRING_RATE)
        {
            _lastShot = Time.time;
            this._gun.Fire();
        }
	}
}
