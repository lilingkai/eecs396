using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


/// <summary>
/// Bullet manager for spawning and tracking all of the game's bullets
/// </summary>
public class BulletManager
{
    private readonly Transform _holder;

    /// <summary>
    /// Bullet prefab. Use GameObject.Instantiate with this to make a new bullet.
    /// </summary>
    private readonly Object _bullet;

    public BulletManager () {
        _bullet = Resources.Load("Bullet");
    }

    // TODO fill me in
    public void ForceSpawn (Vector3 pos, Quaternion rotation, Vector3 velocity, int damage, float deathtime) {
        GameObject newBullet = (GameObject) Object.Instantiate(_bullet, pos, rotation);
        newBullet.GetComponent<Bullet>().Initialize(velocity, damage, deathtime);
    }
}