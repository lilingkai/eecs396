using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {
    public readonly int x, z;
	// Use this for initialization
	void Start () {

	}

    private void OnMouseDown()
    {
        Vector3 pos = gameObject.transform.position;
        int x = (int) pos.x
            , z = (int) pos.z;

        Game.x = x;
        Game.z = z;
        if ((x == Grid.GRID_SIZE - 1 && z == Grid.GRID_SIZE - 1)
            || (x == 0 && z == 0)
            || Game.Grid.OutOfBounds(x, z))
        {
            foreach (MenuButton btn in FindObjectsOfType<MenuButton>())
            {
                btn.Hide();
            }
            return;
        }

        Game.Grid.Unselect();
        Game.Grid.Select(this);
        GameObject contents = (GameObject) Game.Grid.cells[x, z];

        if (!contents)
        {
            FindObjectOfType<BuildButton>().Appear();
            FindObjectOfType<SellButton>().Hide();
        } else if (contents && contents.GetComponent<Tower>())
        {
            FindObjectOfType<SellButton>().Appear();
            FindObjectOfType<BuildButton>().Hide();
        }
    }
}
