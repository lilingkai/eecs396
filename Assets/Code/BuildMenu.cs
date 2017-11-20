using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildMenu : MonoBehaviour
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
        Button btn  = _button.GetComponent<Button>();
       // btn.GetComponent<Image>().gameObject.SetActive(false);
        _button.GetComponentInChildren<Text>().text = "Build Tower";
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
        if (_money.money >= 20)
        {
            _transform.position = offposition;
            FindObjectOfType<Grid>().newTower(x, z);
            _money.money -= 20;
           
        }
    }
    public void appear(int xc, int zc)
    {
        

        
        if (x != xc || z != zc)
        {
            x = xc;
            z = zc;
            _transform.position = onposition;
            if (_money.money < 20)
            {
                _button.GetComponent<Image>().color = Color.gray;
                _transform.position = onposition;
            }
        }
        else
        {
            x = 6;
            z = 6;
            _transform.position = offposition;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
