using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    //variables
    private static int health = 10;
    private static int maxHealth = 10;
    private static float moveSpeed = 5;
    private static float fireRate = 0.5f;

    public static int Health {get => health; set => health = value;}
    public static int MaxHealth { get => maxHealth; set => maxHealth = value;}
    public static float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }
    public static float FireRate { get => fireRate; set => fireRate = value; }

    public Text healthText;

    //start
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        print("private health: " + health);
        print("public health: " + Health);
    }

    //update
    void Update()
    {
        healthText.text = "Health: " + health;   
    }


    //functions
    public static void DamagePlayer(int damage)
    {
        health -= damage;

        print("private health: " + health);
        print("public health: " + Health);

        if (health <= 0)
        {
            KillPlayer();
        }
    }


    public static void HealPlayer(int healAmount)
    {
        health = Mathf.Min(maxHealth, health + healAmount);
    }

    public static void KillPlayer()
    {
        print("Player is Dead");
    }
}
