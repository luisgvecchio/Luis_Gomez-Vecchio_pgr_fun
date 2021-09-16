using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigment3 : ProcessingLite.GP21
{
    Vector2 circlePosition = new Vector2();
    Vector2 circleDirection = new Vector2();
    Vector2 circleSpeed = new Vector2();

    Vector3 mousePosition = new Vector3();
    Vector2 betweenCircleAndMouse = new Vector2();


    public float diameter = 0.02f;

    void Start()
    {
        Background(0);
        Stroke(255);
        StrokeWeight(0.2f);
        circlePosition.x = 5;
        circlePosition.y = 5;
    }

    void Update()
    {
        Background(0);

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Circle(circlePosition.x, circlePosition.y, diameter);

        LineWhilePressingMouse();
        TransportCircleToMouse();
        VectorInBetweenCalculator();
        //CircleDirection();

    }
    public void LineWhilePressingMouse()
    {
        if (Input.GetMouseButton(0))
        {
            Stroke(255);
            StrokeWeight(0.2f);
            Line(circlePosition.x, circlePosition.y, mousePosition.x, mousePosition.y);
        }
    }
    public void TransportCircleToMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            circlePosition.x = mousePosition.x;
            circlePosition.y = mousePosition.y;
            Stroke(255);
            StrokeWeight(0.2f);
            Circle(circlePosition.x, circlePosition.y, diameter);
        }
    }


    public void VectorInBetweenCalculator()
    {
        if (mousePosition.x > circlePosition.x)
        {
            betweenCircleAndMouse.x = mousePosition.x - circlePosition.x;
        }
        if (mousePosition.x < circlePosition.x)
        {
            betweenCircleAndMouse.x = circlePosition.x - mousePosition.x;
        }
        if (mousePosition.y > circlePosition.y)
        {
            betweenCircleAndMouse.y = mousePosition.y - circlePosition.y;
        }
        if (mousePosition.y < circlePosition.y)
        {
            betweenCircleAndMouse.y = circlePosition.y - mousePosition.y;
        }
    }
    public void CircleDirection()
    {
        circleDirection = betweenCircleAndMouse.normalized;

        

    }


}
