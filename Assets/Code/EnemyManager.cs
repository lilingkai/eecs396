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
        over = 0;
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
    public void normal()
    {
        if (over == 0)
        {
            GameObject newEnemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 1.5f, 0), Quaternion.identity);
            newEnemy.transform.SetParent(_holder.transform);
            newEnemy.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            newEnemy.GetComponent<Renderer>().material.color = Color.blue;

            newEnemy.transform.position = new Vector3(newEnemy.transform.position.x, 1.01f, newEnemy.transform.position.z);
        }
    }
    //faster ones
    public void fast()
    {
        if (over == 0)
        {
            GameObject newEnemy = (GameObject)Object.Instantiate(_enemyPrefab, new Vector3(0, 1.5f, 0), Quaternion.identity);
            newEnemy.transform.SetParent(_holder.transform);
            newEnemy.GetComponent<NavMeshAgent>().speed = 2f;
            newEnemy.GetComponent<Enemy>().health = 50;
            newEnemy.GetComponent<Renderer>().material.color = Color.yellow;
            newEnemy.transform.localScale = new Vector3(0.5f, 0.25f, 0.5f);
            newEnemy.transform.position = new Vector3(newEnemy.transform.position.x, 0.6f, newEnemy.transform.position.z);
        }
    }
    //stronger ones
    public void strong()
    {
        if (over == 0)
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
    }
    public void Spawn()
    {
        // should handle spawning 3 waves instead of enemies themselves.
        //time between each enemy is shown
        if (_wavenumber == 0)
        {
            _wavenumber++;
            Invoke("normal", 2);
            Invoke("normal", 3);
            Invoke("normal", 4);
            Invoke("normal", 5);
            Invoke("normal", 6);

        }

        else if (_wavenumber == 1)
        {
            _wavenumber++;
            Invoke("normal", 2);
            Invoke("normal", 3);
            Invoke("normal", 4);
            Invoke("normal", 5);
            Invoke("normal", 6);
            Invoke("normal", 7);
            Invoke("normal", 8);
            Invoke("normal", 9);
            Invoke("normal", 10);
            Invoke("normal", 11);
        }

        else if (_wavenumber == 2)
        {
            _wavenumber++;
            Invoke("normal", 2);
            Invoke("normal", 3);
            Invoke("normal", 4);
            Invoke("normal", 5);
            Invoke("normal", 6);

            Invoke("fast", 8);
            Invoke("fast", 9);
            Invoke("fast", 10);
            Invoke("fast", 11);
            Invoke("fast", 12);

            Invoke("normal", 13);
            Invoke("normal", 14);
            Invoke("normal", 15);
            Invoke("normal", 16);
            Invoke("normal", 17);

        }

        else if (_wavenumber == 3)
        {
            _wavenumber++;
            Invoke("normal", 2);
            Invoke("normal", 3);
            Invoke("normal", 4);
            Invoke("normal", 5);
            Invoke("normal", 6);

            Invoke("strong", 8);
            Invoke("strong", 10);

            Invoke("normal", 12);
            Invoke("normal", 13);
            Invoke("normal", 14);
            Invoke("normal", 15);
            Invoke("normal", 16);

        }

        else if (_wavenumber == 4)
        {
            _wavenumber++;
            Invoke("normal", 2);
            Invoke("normal", 3);
            Invoke("normal", 4);
            Invoke("normal", 5);
            Invoke("normal", 6);
            Invoke("normal", 7);
            Invoke("normal", 8);
            Invoke("normal", 9);
            Invoke("normal", 10);
            Invoke("normal", 11);

            Invoke("strong", 12);
            Invoke("strong", 14);
            Invoke("strong", 16);
            Invoke("strong", 18);

            Invoke("normal", 20);
            Invoke("normal", 21);
            Invoke("normal", 22);
            Invoke("normal", 23);
            Invoke("normal", 24);
            Invoke("normal", 25);
            Invoke("normal", 26);
            Invoke("normal", 27);
            Invoke("normal", 28);
            Invoke("normal", 29);
        }

        else if (_wavenumber == 5)
        {
            _wavenumber++;
            Invoke("normal", 2);
            Invoke("normal", 3);
            Invoke("normal", 4);
            Invoke("normal", 5);
            Invoke("normal", 6);
            Invoke("normal", 7);
            Invoke("normal", 8);
            Invoke("normal", 9);
            Invoke("normal", 10);
            Invoke("normal", 11);

            Invoke("strong", 12);
            Invoke("strong", 14);
            Invoke("strong", 16);
            Invoke("strong", 18);
            
            Invoke("fast", 20);
            Invoke("fast", 21);
            Invoke("fast", 22);
            Invoke("fast", 23);
            Invoke("fast", 24);
            Invoke("fast", 25);
            Invoke("fast", 26);
            Invoke("fast", 28);
            Invoke("fast", 29);
            Invoke("fast", 30);
        }

        else if (_wavenumber == 6 || _wavenumber == 7)
        {
            _wavenumber++;
            Invoke("normal", 2);
            Invoke("normal", 3);
            Invoke("normal", 4);
                        
        }
        else if (_wavenumber == 8)
        {
            Invoke("normal", 2);
            Invoke("normal", 3);
            Invoke("normal", 4);
            Invoke("WaveNumber", 10);
        }
    }
    public void WaveNumber()
    {
        _wavenumber = 20;
    }

}

