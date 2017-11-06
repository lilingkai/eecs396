using UnityEngine;


public class Bullet : MonoBehaviour
{
    public static float LIFETIME = 7.5f; // bullets last this long

    private float _deathtime;
    private int _damage;

    public void Initialize (Vector3 velocity, int damage, float deathtime) {
        GetComponent<Rigidbody>().velocity = velocity;
        _deathtime = deathtime;
        _damage = damage;
        
    }

    internal void Update () {
        if (Time.time > _deathtime) { Die(); }
    }

    internal void OnCollisionEnter(Collision other) {
        if (other.gameObject.GetComponent<Enemy>())
        {
            Die();
        }
    }

    private void Die () {
        Destroy(gameObject);
    }

    public int getDamage()
    {
        return _damage;
    }
}