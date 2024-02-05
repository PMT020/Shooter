using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int health;

    void Start()
    {
        health = 25;
    }

    public void Hurt(int damage)
    {
        health -= damage;

        Debug.Log($"Health : {health}");
    }

    public void Heal(int Hdamage)
    {
        health += Hdamage;

        Debug.Log($"Health : {health}");
    }

    private void Update()
    {
        if (health < 1)
        {
            Debug.Log("Player has died");
            Destroy(this.gameObject);


        }
            

    }
}
