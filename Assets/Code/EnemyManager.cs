using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;


public class EnemyManager : MonoBehaviour
{
    public  float WAVE_SPAWN_TIME;
    private static Object _enemyPrefab;
    private float _lastspawn;
    private Transform _holder;
    private static Object _wave;
    public int over;
    public int _wavenumber;

    internal void Start()
    {
        _wavenumber = 0;
        over = 0;
        _lastspawn = 5;
        _enemyPrefab = Resources.Load("Enemy");
        _holder = transform;
        WAVE_SPAWN_TIME = 10f;
    }

    internal void Update()
    {
        if(_wavenumber==1)
        {
            WAVE_SPAWN_TIME = 30f;
        }
        else if (_wavenumber == 2)
        {
            WAVE_SPAWN_TIME = 30f;
        }
        if ((Time.time - _lastspawn) < WAVE_SPAWN_TIME) return;
        _lastspawn = Time.time;
        Spawn();
    }

    // TODO fill me in
    //normal ones
    public void Spawn2()
    {   
        if (over == 0)
        {
            GameObject newEnemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 1.5f, 0), Quaternion.identity);
            newEnemy.transform.SetParent(_holder.transform);
        }
    }
    //faster ones
    public void Spawn3()
    {
        if (over == 0)
        {
            GameObject newEnemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 1.5f, 0), Quaternion.identity);
            newEnemy.transform.SetParent(_holder.transform);
            newEnemy.GetComponent<NavMeshAgent>().speed = 1.8f;
            newEnemy.GetComponent<Enemy>().rewardMoney = 15;
        }
    }
    //stronger ones
    public void Spawn4()
    {
        if (over == 0)
        {
            GameObject newEnemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 1.5f, 0), Quaternion.identity);
            newEnemy.transform.SetParent(_holder.transform);
            newEnemy.GetComponent<Enemy>().damage = 50;
            newEnemy.GetComponent<Enemy>().rewardMoney = 20;
        }
    }
    public void Spawn()
    {
        // should handle spawning 3 waves instead of enemies themselves.
        //time between each enemy is shown
        if (_wavenumber == 0)
        {
            _wavenumber++;
            Invoke("Spawn2", 2);
            Invoke("Spawn2", 3);
            Invoke("Spawn2", 4);
            
        }

        else if (_wavenumber == 1)
        {
            _wavenumber++;
            Invoke("Spawn2", 2);
            Invoke("Spawn2", 3);
            Invoke("Spawn2", 4);
            Invoke("Spawn3", 8);
            Invoke("Spawn3", 9);
            Invoke("Spawn4", 10);
        }

        else if (_wavenumber == 2)
        {
            _wavenumber++;
            Invoke("Spawn2", 2);
            Invoke("Spawn2", 3);
            Invoke("Spawn2", 4);
            Invoke("Spawn3", 8);
            Invoke("Spawn3", 9);
            Invoke("Spawn3", 10);
            Invoke("Spawn4", 11);
            Invoke("Spawn4", 12);
            Invoke("Spawn4", 13);


        }

    }

}

