using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigment3 : ProcessingLite.GP21
{
    Vector2 circlePosition = new Vector2();
    Vector2 circleDirection = new Vector2();
    Vector2 circleSpeed = new Vector2();
    Vector2 zeroCorrection = new Vector2(0.0000001f, 0.0000001f);

    float diameter = 1f;
    float speed = 0.01f;

    void Start()
    {        
        StrokeWeight(0.2f);
        circlePosition.x = Width / 2;
        circlePosition.y = Height / 2;
    }

    void Update()
    {
        Background(0);
        StrokeWeight(1f);
        Circle(circlePosition.x, circlePosition.y, diameter);

        LineWhilePressingMouse();
        TransportCircleToMouse();
        DirectionCalculator();
        ThrowBall();
        LimitOnEdges();
    }
    public void TransportCircleToMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            circlePosition.x = MouseX + zeroCorrection.x;
            circlePosition.y = MouseY + zeroCorrection.y;
            Stroke(255);
            StrokeWeight(2f);
            Circle(circlePosition.x, circlePosition.y, diameter);
            circleDirection = Vector2.zero + zeroCorrection;
        }
    }
    public void LineWhilePressingMouse()
    {
        if (Input.GetMouseButton(0))
        {
            Stroke(255);
            StrokeWeight(0.2f);
            Line(circlePosition.x, circlePosition.y, MouseX, MouseY);
        }
    }
    public void DirectionCalculator()
    {
        if (Input.GetMouseButtonUp(0))
        {
            circleDirection.x = MouseX - circlePosition.x + zeroCorrection.x;
            circleDirection.y = MouseY - circlePosition.y + zeroCorrection.y;
        }
    }
    public void ThrowBall()
    {
        circleSpeed.x = circleDirection.x * speed;
        circleSpeed.y = circleDirection.y * speed;

        float acceleration = circleDirection.magnitude / 10;

        if (Input.GetMouseButtonUp(0))
        {
            circleSpeed.x = circleSpeed.x + (acceleration * Time.deltaTime);
            circleSpeed.y = circleSpeed.y + (acceleration * Time.deltaTime);            
        }
        circlePosition = circlePosition + circleSpeed;
    }
    public void LimitOnEdges()
    {
        if (circlePosition.x > Width - diameter / 2 || circlePosition.x < 0 + diameter / 2)
        {
            circleDirection.x *= -1;
        }
        if (circlePosition.y > Height - diameter / 2 || circlePosition.y < 0 + diameter / 2)
        {
            circleDirection.y *= -1;
        }
    }

}
