using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : Gun
{
    public override void Fire()
    {
        Game.BulletManager.ForceSpawn(
            transform.position + 0.2f * transform.up,
            transform.rotation,
            transform.up,
            25,
            Time.time + Bullet.LIFETIME);
    }
}
