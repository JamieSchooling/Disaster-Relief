using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class Compass : MonoBehaviour
{
	[SerializeField] GameObject iconPrefab;
	[SerializeField] RawImage compassImage;
	[SerializeField] Transform player;

	List<Waypoint> waypoints = new List<Waypoint>();

	float compassUnit;

	public Waypoint tmpWaypoint;

    void Start()
    {
		compassUnit = compassImage.rectTransform.rect.width / 360f;

		AddWaypoint(tmpWaypoint);
    }

    void Update()
	{
		compassImage.uvRect = new Rect(player.localEulerAngles.y / 360f, 0f, 1f, 1f);

		foreach (Waypoint waypoint in waypoints)
        {
			waypoint.image.rectTransform.anchoredPosition = GetPosOnCompass(waypoint);
        }
	}

	public void AddWaypoint(Waypoint waypoint)
    {
		GameObject newWaypoint = Instantiate(iconPrefab, compassImage.transform);
		waypoint.image = newWaypoint.GetComponent<Image>();
		waypoint.image.sprite = waypoint.icon;

		waypoints.Add(waypoint);
    }

	Vector2 GetPosOnCompass(Waypoint waypoint)
    {
		Vector2 playerPos = new Vector2(player.transform.position.x, player.transform.position.z);
		Vector2 playerForward = new Vector2(player.transform.forward.x, player.transform.forward.z);

		float angle = Vector2.SignedAngle(waypoint.position - playerPos, playerForward);

		return new Vector2(compassUnit * angle, 0f);
    }
}