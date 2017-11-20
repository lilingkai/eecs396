﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    private int health;
    private Rigidbody _rb;
    private int damage;
    private int reward_money;
   
    
	void Start () {
        health = 100;
        damage = 5;
        _rb = GetComponent<Rigidbody>();
        reward_money = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (health<=0)
        {
            Destroy(gameObject);
           
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(4, 1, 4), Time.fixedDeltaTime);
        }
	}

    private void Die()
    {
        Destroy(gameObject);
    }

    private void TakeDamage(int damage)
    {
        this.health -= damage;
        if (health <= 0)
        {
            Object.FindObjectOfType<Money>().update_score(reward_money);
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Base base_ = collision.gameObject.GetComponent<Base>();
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if (base_)
        {
            collision.gameObject.GetComponent<BaseHealth>().TakeDamage(damage);
            Die();
        }
        else if (bullet)
        {
            TakeDamage(bullet.getDamage());
            Destroy(bullet.gameObject);
        }
    }
}
