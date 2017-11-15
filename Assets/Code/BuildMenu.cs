using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuildMenu : MonoBehaviour
{
    public Button _button;
    public int x;
    public int z;
    // Use this for initialization
    void Start()
    {
        Button btn  = _button.GetComponent<Button>();
       // btn.GetComponent<Image>().gameObject.SetActive(false);
        _button.GetComponentInChildren<Text>().text = "Build Tower";
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        _button.gameObject.SetActive(false);
        FindObjectOfType<Grid>().newTower(x, z);
    }
    public void appear(int xc, int zc)
    {
        x = xc;
        z = zc;
       // _button.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
