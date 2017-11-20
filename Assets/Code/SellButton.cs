using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SellButton : MenuButton
{
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        _button.GetComponentInChildren<Text>().text = "Sell Tower";
    }

    protected override void OnClick()
    {
        Hide();
        Destroy(Game.Grid.cells[Game.x, Game.z]);
        Game.Grid.cells[Game.x, Game.z] = null;
        Game.Money.money += (int)(Tower.cost * .9f);
    }
}
