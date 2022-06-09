using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RaycastCollision))]
public class Death : MonoBehaviour
{
    public bool isDed = false;

    [SerializeField]
    GameObject deathScreen;

    RaycastCollision collision;

    private void Start()
    {
        collision = GetComponent<RaycastCollision>();
        collision.OnRaycastCollision += OnRaycastCollision;
    }

    void OnRaycastCollision(RaycastHit hit)
    {
        if (hit.transform.tag == "Terrain")
        {
            PlayerDeath();
        }
    }

    public void PlayerDeath()
    {
        Time.timeScale = 0f;
        isDed = true;
        deathScreen.SetActive(true);
    }
}
