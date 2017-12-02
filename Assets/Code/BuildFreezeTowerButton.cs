using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.AI;

public class BuildFreezeTowerButton : BuildButton
{
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        _button.GetComponentInChildren<Text>().text = "Build Freeze Tower";
        _tower = Resources.Load("FreezeTower");
    }
}
