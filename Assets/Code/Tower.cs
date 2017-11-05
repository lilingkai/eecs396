using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
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

        if (nearest != null)
        {
            this.transform.rotation = Quaternion.LookRotation(distance, Vector3.up);
        }
	}
}
