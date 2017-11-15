using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Money : MonoBehaviour
{
    public GameObject _moneybar;
    public int money;
    public Text _text;
    // Use this for initialization
    void Start()
    {
        money = 50;
        _text =  GetComponent<Text>();
        _text.text = money.ToString();
    }

    public void update_score(int value)
    {
        money += value;
    }
    // Update is called once per frame
    void Update()
    {
        _text.text = money.ToString();
    }
}
