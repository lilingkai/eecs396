using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    public int health;
    private Rigidbody _rb;
    public int damage;
    public int rewardMoney;
    
	void Start () {
        health = 50;
        damage = 50;
        _rb = GetComponent<Rigidbody>();
        rewardMoney = 10;
	}

    private void Die()
    {
        Destroy(gameObject);
    }

    public void Modify(int h, int d, int m)
    {
        health = h;
        damage = d;
        rewardMoney = m;
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
