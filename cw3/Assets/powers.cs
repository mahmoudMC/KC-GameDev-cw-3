using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powers : MonoBehaviour
{
    string Heroname = "mahmoud";
    int heroPower = 10;
    string Villainname = "Python";
    int villainPower = 8;

    float playerSpeed = 1;
    void Start()
    {
        if (heroPower > villainPower)
        {
            print(Heroname + " won");
        }
        else if (heroPower < villainPower)
        {
            print(Heroname + " lost");
        }
        else
        {
            print("it's a draw");
        }

        setSpeed(playerSpeed, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setSpeed(float oldspeed, float newadd)
    {
        playerSpeed = newadd;
        print("old speed is " + oldspeed + " and the new speed is " + playerSpeed);
        CompareSpeed(oldspeed, playerSpeed);
    }

    void CompareSpeed(float Oldspeed, float Newspeed)
    {
        if (Oldspeed > Newspeed)
        {
            print(Oldspeed);
        }
        else if (Oldspeed < Newspeed)
        {
            print(Newspeed);
        }
        else
        {
            print(Newspeed + " and old speed is " + Oldspeed);
        }
    }
}
