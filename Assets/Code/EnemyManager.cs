﻿using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Assets.Code
{

    public class EnemyManager : MonoBehaviour
    {
        private const float SpawnTime = 3f;
        private static Object _enemyPrefab;
        private float _lastspawn;
        private Transform _holder;

        internal void Start()
        {
            _lastspawn = 0;
            _enemyPrefab = Resources.Load("Enemy");
            _holder = transform;
        }

        internal void Update()
        {
            if ((Time.time - _lastspawn) < SpawnTime) return;
            _lastspawn = Time.time;
            Spawn();
        }

        // TODO fill me in
        public void Spawn()
        {
            GameObject new_enemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 0.6f, 0), Quaternion.identity);
            new_enemy.transform.SetParent(_holder.transform);
        }
    }
}