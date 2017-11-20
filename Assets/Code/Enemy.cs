using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    private int health;
    private Rigidbody _rb;
    private int damage;
    private int rewardMoney;
    
	void Start () {
        health = 100;
        damage = 5;
        _rb = GetComponent<Rigidbody>();
        rewardMoney = 10;
	}
	
	// Update is called once per frame
	void Update () {
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
            Object.FindObjectOfType<Money>().UpdateScore(rewardMoney);
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
