using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour
{
    public int health;
    // Use this for initialization
    void Start()
    {
        health = 100;
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.position = new Vector3(4, 1, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
