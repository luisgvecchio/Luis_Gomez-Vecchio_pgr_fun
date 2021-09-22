using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : ProcessingLite.GP21
{
    Vector2 positionPlayer1 = new Vector2(5, 5);
    float diameter1 = 1;
    float initialSpeedP1 = 4f;
    float changingSpeedP1;
    float maxSpeed = 35;
    float acceleration = 8f;
    float deceleration = 22f;

    float velocityInputX;
    float velocityInputY;

    public void InputBehaviour()
    {
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            velocityInputX = 1;
            if (changingSpeedP1 < initialSpeedP1)
            {
                changingSpeedP1 = initialSpeedP1;
            }
            changingSpeedP1 = changingSpeedP1 + acceleration * Time.deltaTime;
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
            if (Input.GetAxisRaw("Horizontal") == 0)
            {
                velocityInputX = 0;
            }
        }
        if (Input.GetAxisRaw("Vertical") == 0 && Input.GetAxisRaw("Horizontal") == 0 && changingSpeedP1 > 0)
        {
            changingSpeedP1 = changingSpeedP1 - deceleration * Time.deltaTime;

        }
    }
    public void MovementPlayers()
    {
        positionPlayer1.x = positionPlayer1.x + velocityInputX * Time.deltaTime * changingSpeedP1;// accelerating, yellow
        positionPlayer1.y = positionPlayer1.y + velocityInputY * Time.deltaTime * changingSpeedP1;

        float horizontalNormalize = Input.GetAxis("Horizontal");
        float verticalNormalize = Input.GetAxis("Vertical");
        Vector2 normalizeDiagonal = new Vector2(horizontalNormalize, verticalNormalize);
        normalizeDiagonal.Normalize();
    }
    public void MaxSpeed()
    {
        if (changingSpeedP1 > maxSpeed)
        {
            changingSpeedP1 = maxSpeed;
        }
    }
    public void DrawPlayer()
    {
        Stroke(255, 255, 0);
        Fill(255, 255, 0);
        Circle(positionPlayer1.x, positionPlayer1.y, diameter1);
    }
    
    
}
