using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    //Variables
    private string shipName;
    private float shipSpeed;
    private int healthCount, shieldCount, livesCount;

    //set the my variables to the value of num
    public void setShipName(string name) => shipName = name;
    public void setSpeed(float num) => shipSpeed = num;
    public void setHealth(int num) => healthCount = num;
    public void setShield(int num) => shieldCount = num;
    public void setLives(int num) => livesCount = num;

    //Get the value of each method/function
    public string getShipName() { return shipName; }
    public float getSpeed() { return shipSpeed; }
    public int getHealth() { return healthCount; }
    public int getShield() { return shieldCount; }
    public int getLives() { return livesCount; }
}
