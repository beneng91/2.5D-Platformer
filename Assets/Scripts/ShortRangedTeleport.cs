//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortRangedTeleport : MonoBehaviour
{
    public Transform playerPos;
    public bool shortOnCooldown;
    private float baseCooldown;
    public float shortCooldown = 3f;
    public float shortTeleport = 7.5f;

    
    void Start()
    {
        shortOnCooldown = false;

    }
    void Update()
    {
        ShortTeleport();
    }
    void ShortTeleport()
    {
        if (Input.GetKey(KeyCode.Mouse1) && shortOnCooldown == false) // Activates Short-Ranged Teleportation
        {
            playerPos.transform.position += Vector3.right * shortTeleport; // Teleport
            Debug.Log("Right clicked");
            //Sound
            shortOnCooldown = true;
            
            baseCooldown = shortCooldown; // Cooldown reset
        }
         else if (shortOnCooldown == true) // Cooldown calculations
        {
            baseCooldown -= Time.deltaTime;
            if (baseCooldown <= 0)
            {
                shortOnCooldown = false;

            }
            else
            {
                if (Input.GetKey(KeyCode.Mouse1))
                {
                    
                }
                // Play audio for teleport cooldown currently active here
            }
        }
    }
}
