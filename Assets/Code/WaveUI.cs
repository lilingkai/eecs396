using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveUI : MonoBehaviour {
    public Text _text1;
    public Text _text2;
    public Text _text3;
    public Text _text4;
    public Text _text5;
    public Text _text6;
    public Text _text7;
    public Text _text8;
    public Text _text9;

    public Transform _transform1;
    public Transform _transform2;
    public Transform _transform3;
    public Transform _transform4;
    public Transform _transform5;
    public Transform _transform6;
    public Transform _transform7;
    public Transform _transform8;
    public Transform _transform9;

    public float distancePerSecond = 10f;
    public float w1start = 180f;
    public float w2start = 380f;
    public float w3start = 580f;
    public float w4start = 780f;
    public float w5start = 1130f;
    public float w6start = 1480f;
    public float w7start = 1680f;
    public float w8start = 1880f;
    public float w9start = 2080f;

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

        Text wave4 = _text4.GetComponent<Text>();
        _transform4 = wave4.GetComponent<Transform>();
        _transform4.position = new Vector3(w4start, 75f, 0f);

        Text wave5 = _text5.GetComponent<Text>();
        _transform5 = wave5.GetComponent<Transform>();
        _transform5.position = new Vector3(w5start, 75f, 0f);

        Text wave6 = _text6.GetComponent<Text>();
        _transform6 = wave6.GetComponent<Transform>();
        _transform6.position = new Vector3(w6start, 75f, 0f);

        Text wave7 = _text7.GetComponent<Text>();
        _transform7 = wave7.GetComponent<Transform>();
        _transform7.position = new Vector3(w7start, 75f, 0f);

        Text wave8 = _text8.GetComponent<Text>();
        _transform8 = wave8.GetComponent<Transform>();
        _transform8.position = new Vector3(w8start, 75f, 0f);

        Text wave9 = _text9.GetComponent<Text>();
        _transform9 = wave9.GetComponent<Transform>();
        _transform9.position = new Vector3(w9start, 75f, 0f);
        

    }
	
	// Update is called once per frame
	void Update () {
        _transform1.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform2.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform3.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform4.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform5.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform6.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform7.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform8.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
        _transform9.Translate(-1 * distancePerSecond * Time.deltaTime, 0, 0);
    }


}
