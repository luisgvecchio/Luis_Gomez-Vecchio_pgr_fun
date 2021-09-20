using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigment4 : ProcessingLite.GP21
{
    Vector2 positionPlayer1 = new Vector2();
    Vector2 positionPlayer2 = new Vector2();
    
    float diameter1 = 2;
    float diameter2 = 2;

    float initialSpeedP1 = 4f;
    float changingSpeedP1;
    float initialSpeedP2 = 10f;
    float changingSpeedP2;
    float maxSpeed = 35;
    float acceleration = 8f;
    float deceleration = 22f;

    int velocityInputX;
    int velocityInputY;

    void Start()
    {
        positionPlayer1.x = Width / 2;
        positionPlayer1.y = Height / 10;

        positionPlayer2.x = Width / 4;
        positionPlayer2.y = Height / 10;
    }

    void Update()
    {
        Background(50, 166, 240);

        MaxSpeed();
        InputBehaviour();
        MovementPlayers();
        HorizontalFrame();
        VerticalFrame();

        Stroke(255, 255, 0);
        Fill(255, 255, 0);
        Circle(positionPlayer1.x, positionPlayer1.y, diameter1); //1st character

        Stroke(0, 255, 0);
        Fill(0, 255, 0);
        Circle(positionPlayer2.x, positionPlayer2.y, diameter2); //2nd character

    }

    private void VerticalFrame()
    {
        if (positionPlayer1.y < 0 + diameter1 / 2)
        {
            positionPlayer1.y = 0 + diameter1 / 2;
        }
        if (positionPlayer1.y > Height - diameter1 / 2)
        {
            positionPlayer1.y = Height - diameter1 / 2;
        }
        if (positionPlayer2.y < 0 + diameter2 / 2)
        {
            positionPlayer2.y = 0 + diameter2 / 2;
        }
        if (positionPlayer2.y > Height - diameter2 / 2)
        {
            positionPlayer2.y = Height - diameter2 / 2;
        }
    }
    private void HorizontalFrame()
    {
        if (positionPlayer1.x > Width - diameter1 / 2)
        {
            positionPlayer1.x = 0 + diameter1 / 2;
        }
        if (positionPlayer1.x < 0 + diameter1 / 2)
        {
            positionPlayer1.x = Width - diameter1 / 2;
        }
        if (positionPlayer2.x > Width - diameter2 / 2)
        {
            positionPlayer2.x = 0 + diameter2 / 2;
        }
        if (positionPlayer2.x < 0 + diameter1 / 2)
        {
            positionPlayer2.x = Width - diameter1 / 2;
        }
    }
    private void InputBehaviour()
    {
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            velocityInputX = 1;
            if (changingSpeedP1 < initialSpeedP1)
            {
                changingSpeedP1 = initialSpeedP1;
            }
            changingSpeedP1 = changingSpeedP1 + acceleration * Time.deltaTime;
            changingSpeedP2 = initialSpeedP2;
            if (Input.GetAxis("Vertical") == 0)
            {
                velocityInputY = 0;
            }
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            velocityInputX = -1;
            if (changingSpeedP1 < initialSpeedP1)
            {
                changingSpeedP1 = initialSpeedP1;
            }
            changingSpeedP1 = changingSpeedP1 + acceleration * Time.deltaTime;
            changingSpeedP2 = initialSpeedP2;
            if (Input.GetAxisRaw("Vertical") == 0)
            {
                velocityInputY = 0;
            }
        }
        if (Input.GetAxisRaw("Vertical") == 1)
        {
            velocityInputY = 1;
            if (changingSpeedP1 < initialSpeedP1)
            {
                changingSpeedP1 = initialSpeedP1;
            }
            changingSpeedP1 = changingSpeedP1 + acceleration * Time.deltaTime;
            changingSpeedP2 = initialSpeedP2;
            if (Input.GetAxisRaw("Horizontal") == 0)
            {
                velocityInputX = 0;
            }
        }
        else if (Input.GetAxisRaw("Vertical") == -1)
        {
            velocityInputY = -1;
            if (changingSpeedP1 < initialSpeedP1)
            {
                changingSpeedP1 = initialSpeedP1;
            }
            changingSpeedP1 = changingSpeedP1 + acceleration * Time.deltaTime;
            changingSpeedP2 = initialSpeedP2;
            if (Input.GetAxisRaw("Horizontal") == 0)
            {
                velocityInputX = 0;
            }
        }
        if (Input.GetAxisRaw("Vertical") == 0 && Input.GetAxisRaw("Horizontal") == 0 && changingSpeedP1 > 0)
        {
            changingSpeedP1 = changingSpeedP1 - deceleration * Time.deltaTime;

        }
        if (Input.GetAxisRaw("Vertical") == 0 && Input.GetAxisRaw("Horizontal") == 0 && changingSpeedP2 > 0)
        {
            changingSpeedP2 = changingSpeedP2 - deceleration * Time.deltaTime;

        }
    }
    private void MovementPlayers()
    {
        positionPlayer1.x = positionPlayer1.x + velocityInputX * Time.deltaTime * changingSpeedP1;// accelerating, yellow
        positionPlayer1.y = positionPlayer1.y + velocityInputY * Time.deltaTime * changingSpeedP1;

        positionPlayer2.x = positionPlayer2.x + velocityInputX * Time.deltaTime * changingSpeedP2;//constant speed, green
        positionPlayer2.y = positionPlayer2.y + velocityInputY * Time.deltaTime * changingSpeedP2;
    }
    private void MaxSpeed()
    {
        if (changingSpeedP1 > maxSpeed)
        {
            changingSpeedP1 = maxSpeed;
        }
    }
}
