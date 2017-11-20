using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Grid : MonoBehaviour {
    public const int GRID_SIZE = 5;
    public Cell selected;
    public Object[,] cells;

    // Use this for initialization
    void Start () {
        cells = new Object[GRID_SIZE, GRID_SIZE];
        cells[GRID_SIZE-1, GRID_SIZE-1] = Game.Base;
    }

    public bool OutOfBounds(int x, int z)
    {
        return (x < 0 || z < 0 || x > GRID_SIZE - 1 || z > GRID_SIZE - 1);
    }

    public void Unselect()
    {
        if (Game.Grid.selected)
        {
            Game.Grid.selected.GetComponent<Renderer>().material.color = Color.white;
        }
    }

    public void Select(Cell cell)
    {
        cell.GetComponent<Renderer>().material.color = Color.cyan;
        Game.Grid.selected = cell;
    }
}
