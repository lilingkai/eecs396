using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    private int health;
    private Rigidbody _rb;
    private int damage;
   
    
	void Start () {
        health = 100;
        damage = 5;
        _rb = GetComponent<Rigidbody>();

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
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Base base_ = collision.gameObject.GetComponent<Base>();
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        print(collision.collider);
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
