using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveUI : MonoBehaviour {
    public Text _text1;
    public Text _text2;
    public Text _text3;
    public Transform _transform1;
    public Transform _transform2;
    public Transform _transform3;
    public float distancePerSecond = 10f;
    public float w1start = 180f;
    public float w2start = 480f;
    public float w3start = 780f;

	// Use this for initialization
	void Start () {
        Text wave1 = _text1.GetComponent<Text>();
        _transform1 = wave1.GetComponent<Transform>();
        _transform1.position = new Vector3(w1start, 75f, 0f);
        
        Text wave2 = _text2.GetComponent<Text>();
        _transform2 = wave2.GetComponent<Transform>();
        _transform2.position = new Vector3(w2start, 75f, 0f);

        Text wave3 = _text3.GetComponent<Text>();
        _transform3 = wave3.GetComponent<Transform>();
        _transform3.position = new Vector3(w3start, 75f, 0f);
        
	}
	
	// Update is called once per frame
	void Update () {
        _transform1.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform2.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform3.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
    }


}
