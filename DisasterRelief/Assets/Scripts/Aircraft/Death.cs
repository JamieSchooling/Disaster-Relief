using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool isDed = false;

    [SerializeField]
    GameObject deathScreen;

    public void PlayerDeath()
    {
        Time.timeScale = 0f;
        isDed = true;
        deathScreen.SetActive(true);
    }
}
