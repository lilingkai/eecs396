using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject home = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        home.transform.position = new Vector3(4, 1, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
