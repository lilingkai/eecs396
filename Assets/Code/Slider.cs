using UnityEngine;
using System.Collections;

public class Slider : MonoBehaviour
{
    private int health;
    // Use this for initialization
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        health = FindObjectOfType<Base>().health;
    }
}
