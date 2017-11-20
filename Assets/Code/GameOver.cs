using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System.Collections;

public class GameOver : MonoBehaviour {

    public Text _text;
    public int _over;
	// Use this for initialization
	void Start () {
        _text = GetComponent<Text>();
        _over = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (_over != 1)
        {
            if (FindObjectOfType<BaseHealth>().currentHealth <= 0)
            {
                _text.text = "You Lost :(";
                _over = 1;
                Destroy(FindObjectOfType<Money>());
                Destroy(FindObjectOfType<UpgradeButton>());
                Destroy(FindObjectOfType<BuildMenu>());
                Enemy[] _enemies;
                Tower[] _towers;
                _towers = FindObjectsOfType<Tower>();
                FindObjectOfType<EnemyManager>().SPAWN_TIME = 50000f;

                foreach (Tower _object in _towers)
                {
                    _object.FIRING_RATE = 50000000f;
                    Destroy(_object.GetComponent<Gun>());
                    _object.destroy = 1;
                }

                _enemies =  FindObjectsOfType<Enemy>();
                foreach (Enemy _object in _enemies)
                {
                    Destroy(_object.GetComponent<NavMeshAgent>());
                }
            }
            //else if (FindObjectOfType<EnemyManager>().waveOver == 1)
            //{
            //    _text.text = "You Won!";
            //    _over = 1;
            //    Destroy(FindObjectOfType<Money>());
            //    Destroy(FindObjectOfType<UpgradeButton>());
            //    Destroy(FindObjectOfType<BuildMenu>());
            //    Enemy[] _enemies;
            //    Tower[] _towers;
            //    _towers = FindObjectsOfType<Tower>();
            //    FindObjectOfType<EnemyManager>().SPAWN_TIME = 50000f;

            //    foreach (Tower _object in _towers)
            //    {
            //        _object.FIRING_RATE = 50000000f;
            //        Destroy(_object.GetComponent<Gun>());
            //        _object.destroy = 1;
            //    }

            //    _enemies = FindObjectsOfType<Enemy>();
            //    foreach (Enemy _object in _enemies)
            //    {
            //        Destroy(_object.GetComponent<NavMeshAgent>());
            //    }
            //}
        }


	}
}
