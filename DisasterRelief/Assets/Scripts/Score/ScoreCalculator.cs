using System;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    public static Action OnScoreUpdated;

    private void Start()
    {
        PackageDrop.OnDrop += RecalculateScore;
    }

    public void RecalculateScore(Transform package)
    {
        Debug.Log("Invoked");
        Transform waypoint = GameObject.FindGameObjectWithTag("Waypoint").transform;
        if (waypoint == null) return;

        Vector3 distance = waypoint.position - package.position;
        Debug.Log(distance.magnitude);
    }
}
