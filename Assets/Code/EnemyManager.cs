using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;


public class EnemyManager : MonoBehaviour
{
    public float WAVE_SPAWN_TIME;
    private static Object _enemyPrefab;
    private float _lastspawn;
    private Transform _holder;
    private static Object _wave;
    public int over;
    public int _wavenumber;

    internal void Start()
    {
        _wavenumber = 0;
        _lastspawn = 5;
        _enemyPrefab = Resources.Load("Enemy");
        _holder = transform;
        WAVE_SPAWN_TIME = 5f;
    }

    internal void Update()
    {
        if(_wavenumber==4 || _wavenumber == 5)
        {
            WAVE_SPAWN_TIME = 35f;
        }
        else if(_wavenumber!=0)
        {
            WAVE_SPAWN_TIME = 20f;
        }
        if ((Time.time - _lastspawn) < WAVE_SPAWN_TIME) return;
        _lastspawn = Time.time;
        Spawn();
    }

    // TODO fill me in
    //normal ones
    public void Normal()
    {
        GameObject newEnemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 1.5f, 0), Quaternion.identity);
        newEnemy.transform.SetParent(_holder.transform);
        newEnemy.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        newEnemy.GetComponent<Renderer>().material.color = Color.blue;
        newEnemy.transform.position = new Vector3(newEnemy.transform.position.x, 1.01f, newEnemy.transform.position.z);
    }
    //faster ones
    public void Fast()
    {
        GameObject newEnemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 1.5f, 0), Quaternion.identity);
        newEnemy.transform.SetParent(_holder.transform);
        newEnemy.GetComponent<NavMeshAgent>().speed = 2f;
        newEnemy.GetComponent<Enemy>().health = 50;
        newEnemy.GetComponent<Renderer>().material.color = Color.yellow;
        newEnemy.transform.localScale = new Vector3(0.5f, 0.25f, 0.5f);
        newEnemy.transform.position = new Vector3(newEnemy.transform.position.x, 0.6f, newEnemy.transform.position.z);
    }
    //stronger ones
    public void Strong()
    {
        GameObject newEnemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 1.5f, 0), Quaternion.identity);
        newEnemy.transform.SetParent(_holder.transform);
        newEnemy.GetComponent<Enemy>().damage = 50;
        newEnemy.GetComponent<Enemy>().health = 1000;
        newEnemy.GetComponent<NavMeshAgent>().speed = .5f;
        newEnemy.transform.localScale = new Vector3(0.5f, 1f, 0.5f);
        newEnemy.GetComponent<Renderer>().material.color = Color.black;
        newEnemy.transform.position = new Vector3(newEnemy.transform.position.x, 1.4f, newEnemy.transform.position.z);
    }
    public void Spawn()
    {
        // should handle spawning 3 waves instead of enemies themselves.
        //time between each enemy is shown
        if (_wavenumber == 0)
        {
            _wavenumber++;
            Invoke("Normal", 2);
            Invoke("Normal", 3);
            Invoke("Normal", 4);
            Invoke("Normal", 5);
            Invoke("Normal", 6);

        }

        else if (_wavenumber == 1)
        {
            _wavenumber++;
            Invoke("Normal", 2);
            Invoke("Normal", 3);
            Invoke("Normal", 4);
            Invoke("Normal", 5);
            Invoke("Normal", 6);
            Invoke("Normal", 7);
            Invoke("Normal", 8);
            Invoke("Normal", 9);
            Invoke("Normal", 10);
            Invoke("Normal", 11);
        }

        else if (_wavenumber == 2)
        {
            _wavenumber++;
            Invoke("Normal", 2);
            Invoke("Normal", 3);
            Invoke("Normal", 4);
            Invoke("Normal", 5);
            Invoke("Normal", 6);

            Invoke("Fast", 8);
            Invoke("Fast", 9);
            Invoke("Fast", 10);
            Invoke("Fast", 11);
            Invoke("Fast", 12);

            Invoke("Normal", 13);
            Invoke("Normal", 14);
            Invoke("Normal", 15);
            Invoke("Normal", 16);
            Invoke("Normal", 17);

        }

        else if (_wavenumber == 3)
        {
            _wavenumber++;
            Invoke("Normal", 2);
            Invoke("Normal", 3);
            Invoke("Normal", 4);
            Invoke("Normal", 5);
            Invoke("Normal", 6);

            Invoke("Strong", 8);
            Invoke("Strong", 10);

            Invoke("Normal", 12);
            Invoke("Normal", 13);
            Invoke("Normal", 14);
            Invoke("Normal", 15);
            Invoke("Normal", 16);

        }

        else if (_wavenumber == 4)
        {
            _wavenumber++;
            Invoke("Normal", 2);
            Invoke("Normal", 3);
            Invoke("Normal", 4);
            Invoke("Normal", 5);
            Invoke("Normal", 6);
            Invoke("Normal", 7);
            Invoke("Normal", 8);
            Invoke("Normal", 9);
            Invoke("Normal", 10);
            Invoke("Normal", 11);

            Invoke("Strong", 12);
            Invoke("Strong", 14);
            Invoke("Strong", 16);
            Invoke("Strong", 18);

            Invoke("Normal", 20);
            Invoke("Normal", 21);
            Invoke("Normal", 22);
            Invoke("Normal", 23);
            Invoke("Normal", 24);
            Invoke("Normal", 25);
            Invoke("Normal", 26);
            Invoke("Normal", 27);
            Invoke("Normal", 28);
            Invoke("Normal", 29);
        }

        else if (_wavenumber == 5)
        {
            _wavenumber++;
            Invoke("Normal", 2);
            Invoke("Normal", 3);
            Invoke("Normal", 4);
            Invoke("Normal", 5);
            Invoke("Normal", 6);
            Invoke("Normal", 7);
            Invoke("Normal", 8);
            Invoke("Normal", 9);
            Invoke("Normal", 10);
            Invoke("Normal", 11);

            Invoke("Strong", 12);
            Invoke("Strong", 14);
            Invoke("Strong", 16);
            Invoke("Strong", 18);
            
            Invoke("Fast", 20);
            Invoke("Fast", 21);
            Invoke("Fast", 22);
            Invoke("Fast", 23);
            Invoke("Fast", 24);
            Invoke("Fast", 25);
            Invoke("Fast", 26);
            Invoke("Fast", 28);
            Invoke("Fast", 29);
            Invoke("Fast", 30);
        }

        else if (_wavenumber == 6 || _wavenumber == 7)
        {
            _wavenumber++;
            Invoke("Normal", 2);
            Invoke("Normal", 3);
            Invoke("Normal", 4);
                        
        }
        else if (_wavenumber == 8)
        {
            Invoke("Normal", 2);
            Invoke("Normal", 3);
            Invoke("Normal", 4);
            Invoke("WaveNumber", 10);
        }
    }
    public void WaveNumber()
    {
        _wavenumber = 20;
    }

}

