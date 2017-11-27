using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public int xa, za;
    // Use this for initialization
    void Start()
    {
        xa = 6;
        za = 6;
    }

    private void OnMouseDown()
    {
        Vector3 pos = gameObject.transform.position;
        if (xa == (int) pos.x && za == (int) pos.z)
        {
            Game.x = (int) pos.x;
            Game.z = (int) pos.z;
            Game.Grid.Unselect();
            FindObjectOfType<SellButton>().Hide();
            FindObjectOfType<BuildButton>().Hide();
            xa = 555; za = 555;
        }
        else
        {
            xa = (int)pos.x;
            za = (int)pos.z;

            int x = (int)pos.x
                , z = (int)pos.z;

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
            GameObject contents = (GameObject)Game.Grid.cells[x, z];

            if (!contents)
            {
                FindObjectOfType<BuildButton>().Appear();
                FindObjectOfType<SellButton>().Hide();
            }
            else if (contents && contents.GetComponent<Tower>())
            {
                FindObjectOfType<SellButton>().Appear();
                FindObjectOfType<BuildButton>().Hide();
            }
        }
    }
}