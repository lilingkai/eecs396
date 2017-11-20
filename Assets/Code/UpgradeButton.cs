using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Button _button;
    public int x;
    public int z;
    public Transform _transform;
    public Vector3 offposition;
    public Vector3 onposition;
    public Money _money;
    public int cost;
    // Use this for initialization
    void Start()
    {
        Button btn = _button.GetComponent<Button>();
        // btn.GetComponent<Image>().gameObject.SetActive(false);
        _button.GetComponentInChildren<Text>().text = "Sell Tower";
        btn.onClick.AddListener(TaskOnClick);
        _transform = btn.GetComponent<Transform>();
        offposition.x = 500000;
        offposition.y = 500000;
        offposition.z = 500000;
        onposition = _transform.position;
        _transform.position = offposition;
        cost = 20;
        _money = FindObjectOfType<Money>();
    }

    void TaskOnClick()
    {
            _transform.position = offposition;
            FindObjectOfType<Grid>().cells[x,z]=null;
            _money.money += 18;
    }
    public void appear(int xc, int zc)
    {
            x = xc;
            z = zc;
            _transform.position = onposition;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
