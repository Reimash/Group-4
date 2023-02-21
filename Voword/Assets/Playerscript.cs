using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;
    public healthbarscript healthbar;
    void Start()
    {
        currenthealth = maxhealth;
        healthbar.SetMaxHealth(maxhealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) 
        {
            TakeDamage(20);
        }
    }
    void TakeDamage(int damage)
    { currenthealth -= damage;
    healthbar.SetHealth(currenthealth);
    }
}
