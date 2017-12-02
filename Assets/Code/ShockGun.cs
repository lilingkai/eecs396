using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockGun : Gun
{
    List<Enemy> chainedEnemies = new List<Enemy>();
    List<Vector3> chained = new List<Vector3>();
    public Material mat;
    const float RANGE = 2f;
    float _lastShot;

    public Enemy GetNearestEnemyInRange()
    {
        Enemy nearest = null;
        Vector3 distance = Vector3.positiveInfinity;
        foreach (Enemy enemy in GameObject.FindObjectsOfType<Enemy>())
        {
            Vector3 currentDistance = enemy.transform.position - this.transform.position;
            if (currentDistance.sqrMagnitude <= RANGE 
                && currentDistance.sqrMagnitude < distance.sqrMagnitude)
            {
                distance = currentDistance;
                nearest = enemy;
            }
        }
        return nearest;
    }

    public override void Fire()
    {
        chained = new List<Vector3>();
        chainedEnemies = new List<Enemy>();
        Enemy nearest = GetNearestEnemyInRange();
        // && nearest.transform.position.sqrMagnitude - transform.position.sqrMagnitude <= RANGE
        while (nearest && chained.Count < 3)
        {
            chained.Add(nearest.transform.position);
            chainedEnemies.Add(nearest);
            nearest.TakeDamage(20);
            nearest = GetNextNearestEnemyInRange(nearest);
        }
        print(chained.Count);
        _lastShot = Time.time;
    }

    internal void OnGUI()
    {
        if (chained.Count > 0 && (Time.time - _lastShot) < .2f)
        {
            mat.SetPass(0);
            GL.PushMatrix();
            GL.LoadProjectionMatrix(Game.Camera.projectionMatrix);
            GL.modelview = Game.Camera.worldToCameraMatrix;
            GL.Color(Color.magenta);
            GL.Begin(GL.LINES);
            DrawLine(transform.position, chained[0]);
            for (int i = 1; i < chained.Count; ++i)
            {
                DrawLine(chained[i - 1], chained[i]);
            }
            GL.End();
            GL.PopMatrix();
        }
    }

    protected bool CanChain(Enemy enemy)
    {
        foreach (Enemy e in chainedEnemies)
        {
            if (enemy == e) { return false; }
        }
        return true;
    }

    protected Enemy GetNextNearestEnemyInRange(Enemy enemy)
    {
        Enemy nearest = null;
        Vector3 distance = Vector3.positiveInfinity;
        foreach (Enemy e in GameObject.FindObjectsOfType<Enemy>())
        {
            if (e == enemy || !CanChain(e)) { continue; }
            Vector3 currentDistance = e.transform.position - enemy.transform.position;
            if (currentDistance.sqrMagnitude < distance.sqrMagnitude && currentDistance.sqrMagnitude < RANGE)
            {
                distance = currentDistance;
                nearest = e;
            }
        }
        return nearest;
    }

    protected void DrawLine(Vector3 a, Vector3 b) {
        GL.Vertex3(a.x, a.y, a.z);
        GL.Vertex3(b.x, b.y, b.z);
    }
}
