using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class Compass : MonoBehaviour
{
	[SerializeField]
	RawImage compassImage;
	[SerializeField]
	Transform player;
	[SerializeField]
	Text compassDirectionText;

	Dictionary<int, string> compassValues = new Dictionary<int, string>()
    {
		{0, "N" },
		{45, "NE" },
		{90, "E" },
		{130, "SE" },
		{180, "S" },
		{225, "SW" },
		{270, "W" },
		{315, "NW" },
		{360, "N" },
    };

    public void Update()
	{
		compassImage.uvRect = new Rect(player.localEulerAngles.y / 360, 0, 1, 1);

		Vector3 forward = player.transform.forward;
		forward.y = 0;

		float headingAngle = Quaternion.LookRotation(forward).eulerAngles.y;
		headingAngle = Mathf.RoundToInt(headingAngle);

		int displayangle = Mathf.RoundToInt(headingAngle);

		if (compassValues.TryGetValue(displayangle, out string direction))
		{
			compassDirectionText.text = direction;
		}
        else
        {
			compassDirectionText.text = headingAngle.ToString() + "°";
        }
	}
}