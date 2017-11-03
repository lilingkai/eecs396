using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    private int health;
    private Rigidbody _rb;
    private int damage;
    private bool check_hit;
    
	void Start () {
        health = 100;
        damage = 5;
        check_hit = false;
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
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(4, 1, 4), 2f * Time.fixedDeltaTime);
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.GetComponent<Base>()!=null && check_hit==false)
        {
            collision.collider.GetComponent<Base>().health = collision.collider.GetComponent<Base>().health - damage;
            print(collision.collider.GetComponent<Base>().health);
            Destroy(gameObject);
            check_hit = true;
        }
    }
}
