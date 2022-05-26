using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class Compass : MonoBehaviour
{
	[SerializeField]
	RawImage compassImage;
	[SerializeField]
	Transform player;

    public void Update()
	{
		compassImage.uvRect = new Rect(player.localEulerAngles.y / 360f, 0f, 1f, 1f);
	}
}