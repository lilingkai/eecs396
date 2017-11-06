using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    private const float FireCooldown = 1f;
    private float _lastFire;

    public void Fire()
    {
        float time = Time.time;
        if (time < _lastFire + FireCooldown) { return; }
        _lastFire = time;

        Game.BulletManager.ForceSpawn(
            transform.position + 0.2f * transform.up,
            transform.rotation,
            transform.up,
            50,
            time + Bullet.LIFETIME);
    }
}
