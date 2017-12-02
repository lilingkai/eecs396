using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System.Collections;

public class GameOver : MonoBehaviour {
    Text _text;

	// Use this for initialization
	void Start() {
        _text = GetComponent<Text>();
	}
    
    // Stops gameplay
    void Halt()
    {
        Destroy(Game.Money.GetComponent<Money>());
        Destroy(FindObjectOfType<SellButton>().GetComponent<SellButton>());
        Destroy(FindObjectOfType<BuildButton>().GetComponent<BuildButton>());
        Destroy(Game.EnemyManager.GetComponent<EnemyManager>());

        foreach (Tower tower in FindObjectsOfType<Tower>())
        {
            tower.GetComponent<Tower>().enabled = false;
        }

        foreach (Bullet bullet in FindObjectsOfType<Bullet>())
        {
            bullet.GetComponent<Bullet>().enabled = false;
            bullet.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        foreach (Enemy enemy in FindObjectsOfType<Enemy>())
        {
            enemy.GetComponent<NavMeshAgent>().isStopped = true;
        }

        foreach (Bullet bullet in FindObjectsOfType<Bullet>())
        {
            Destroy(bullet);
        }
        Destroy(FindObjectOfType<WaveUI>());
        Destroy(this);
    }
	
	// Update is called once per frame
	void Update() {
        if (FindObjectOfType<BaseHealth>().currentHealth <= 0)
        {
            _text.text = "You Lost :(";
            Halt();
            
        }
        else if (FindObjectOfType<EnemyManager>()._wavenumber == 20)
        {
            _text.text = "You Won!";
            Halt();
        }
	}
}
