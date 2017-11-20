using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;


public class EnemyManager : MonoBehaviour
{
    private const float WAVE_SPAWN_TIME = 60f;
    private static Object _enemyPrefab;
    private float _lastspawn;
    private Transform _holder;
    private static Object _wave;

    internal void Start()
    {
        _lastspawn = 5;
        _enemyPrefab = Resources.Load("Enemy");
        _holder = transform;
    }

    internal void Update()
    {
        if ((Time.time - _lastspawn) < WAVE_SPAWN_TIME) return;
        _lastspawn = Time.time;
        Spawn();
    }

    // TODO fill me in
    public void Spawn()
    {
        // should handle spawning 3 waves instead of enemies themselves.
        GameObject newEnemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 1.5f, 0), Quaternion.identity);
        newEnemy.transform.SetParent(_holder.transform);
        
        
    }
}

