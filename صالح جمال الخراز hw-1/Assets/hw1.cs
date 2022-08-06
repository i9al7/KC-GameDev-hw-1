using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hw1 : MonoBehaviour
{
    string hero = "9al7";
    int health = 100;
    int damagedHealth;
    int boostHealth;

    // Start is called before the first frame update
    void Start()
    {
        damagedHealth = damaged();
        print("Damaged health = " + health);
        boostHealth = boost();
        print("Boost health = " + health);
        print(boostHealth + " is less than " + damagedHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int damaged()
    {
        return health -= 20;

    }
    int boost()
    {
        return health += 10;
    }
}
