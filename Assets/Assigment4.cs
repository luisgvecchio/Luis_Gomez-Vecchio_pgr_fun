using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigment4 : ProcessingLite.GP21
{
    float posX1;
    float posY1;

    float posX2;
    float posY2;

    float diameter1 = 2;
    float diameter2 = 2;

    float speed =5f;
    float maxSpeed =30f;
    float acceleration = 5f;
    float deacceleration = -1f;

    void Start()
    {
        posX1 = Width / 2;
        posY1 = Height / 10;

        posX2 = Width / 4;
        posY2 = Height / 10;


    }

    void Update()
    {
        Background(50, 166, 240);
        speed = speed + acceleration * Time.deltaTime;

        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }

        posY1 = posY1 + Input.GetAxis("Vertical") * Time.deltaTime * speed;
        posX1 = posX1 + Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        //if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.R))
        //{
        //    speed = speed + deacceleration * Time.deltaTime;
        //    posY1 = posY1 + Input.GetAxis("Vertical") * Time.deltaTime * speed;
        //    posX1 = posX1 + Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //}

        posX2 = posX2 + Input.GetAxis("Horizontal") * Time.deltaTime * acceleration;
        posY2 = posY2 + Input.GetAxis("Vertical") * Time.deltaTime * acceleration;


        Circle(posX1, posY1, diameter1); //1st character
        Circle(posX2, posY2, diameter2); //2nd character


        if (posX1> Width - diameter1 / 2)
        {
            posX1 = Width - diameter1;
        }
        if (posX1 < 0 + diameter1 / 2)
        {
            posX1 = 0 + diameter1;
        }
        if (posX2 > Width - diameter2 / 2)
        {
            posX2 = Width - diameter2;
        }
        if (posX2 < 0 + diameter1 / 2)
        {
            posX2 = 0 + diameter1;
        }

    }
}
