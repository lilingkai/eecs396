using System;
using UnityEngine;

public class ShockTower : Tower
{
	protected override void Start()
    {
        base.Start();
        FIRING_RATE = 3f;
    }
}
