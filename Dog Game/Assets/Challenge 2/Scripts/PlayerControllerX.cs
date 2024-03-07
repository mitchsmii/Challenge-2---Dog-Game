using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer = 1f;
    public bool onCooldown;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && onCooldown == false)
        {
            spawnDog();
            Invoke("cooldown", timer);
            onCooldown = true;
        }
    }

    public void spawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

    public void cooldown()
    {
        onCooldown = false;
    }
}
