using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOGIC
{
   public static void main()
    {

    }
}

public class Enemy
{
    public int Health;
    public float type;

    public Enemy(float Type, int health)
    {
        type = Type;
        Health = health;
    }
}

public class Player
{
    public int ForceOfHit;
    public int speed;

    public Player(int speed, int ForceOfHit)
    {
        this.speed = speed;
        this.ForceOfHit = ForceOfHit;
    }
}

public class Asteroids
{
    public int speed;

    public Asteroids (int Speed)
    {
        speed = Speed;
    }
}