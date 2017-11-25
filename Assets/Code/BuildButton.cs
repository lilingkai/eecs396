using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.AI;

public class BuildButton : MenuButton
{
    private static Object _tower;

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        _button.GetComponentInChildren<Text>().text = "Build Tower";
        _tower = Resources.Load("Tower");
    }

    protected override void OnClick()
    {
        if (Game.Money.money >= Tower.cost)
        {
            _button.transform.position = hiddenPosition;
            NewTower(Game.x, Game.z);
            Game.Money.money -= Tower.cost;

        }
    }

    private void NewTower(int x, int z)
    {
        if (x == Grid.GRID_SIZE - 1 && z == Grid.GRID_SIZE - 1)
        {
            throw new System.Exception("Cannot build tower on base");
        }
        else if (x == 0 && z == 0)
        {
            throw new System.Exception("Cannot build tower on enemy spawner");
        }
        else if (Game.Grid.OutOfBounds(x, z))
        {
            throw new System.Exception("Cannot build tower out of bounds");
        }

        StartCoroutine(TryNewTower(x, z));
    }

    public override void Appear()
    {
        base.Appear();
        if (Game.Money.money < Tower.cost)
        {
            _button.GetComponent<Image>().color = Color.gray;
        }
    }

    IEnumerator TryNewTower(int x, int z)
    {
        Game.Grid.Unselect();

        // Check if there is an enemy
        RaycastHit hit;
        Physics.SphereCast(new Vector3(x, 0f, z), 0.5f, Vector3.up, out hit, 1f);
        if (hit.collider && hit.collider.GetComponent<Enemy>())
        {
            yield break;
        }

        // Tentatively create tower
        GameObject tower = (GameObject) Object.Instantiate(_tower, new Vector3(x, 0.5f, z), Quaternion.identity);
        foreach (Renderer r in tower.GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
        yield return 0; // waits a frame

        // Check if there exists a path from spawner to base
        NavMeshPath path = new NavMeshPath();
        bool pathExists = NavMesh.CalculatePath(Game.EnemyManager.transform.position,
            Game.Base.transform.position,
            NavMesh.AllAreas,
            path);

        if (!pathExists || path.status != NavMeshPathStatus.PathComplete)
        {
            Game.Money.money += Tower.cost;
            Destroy(tower);
        }
        else
        {
            foreach (Renderer r in tower.GetComponentsInChildren<Renderer>())
            {
                r.enabled = true;
            }
            Game.Grid.cells[x, z] = tower;
        }
    }
}
