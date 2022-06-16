using System;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    public static Action OnScoreUpdated;

    [SerializeField] Transform waypoint;

    private void Start()
    {
        PackageDrop.OnDrop += RecalculateScore;
    }

    public void RecalculateScore(Transform package)
    {
        Debug.Log("Invoked");
        if (waypoint == null) return;

        Vector3 distanceV3 = waypoint.position - package.position;
        Vector2 distance = new Vector2(distanceV3.x, distanceV3.z);

        Debug.Log(distance.magnitude);
        if (distance.magnitude < 100f)
        {
            Debug.Log("Successfully Dropped Package");
        }
        else if (distance.magnitude < 150f)
        {
            Debug.Log("Almost there");
        }
        else
        {
            Debug.Log("You missed.");
        }
    }
}