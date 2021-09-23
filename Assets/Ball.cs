using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ball : ProcessingLite.GP21
{
    internal Vector2 position;
    Vector2 velocity;
    internal float ballSize;
    int red, blue, green;

    public Ball(float x, float y)
    {
        position = new Vector2(x, y);

        velocity = new Vector2();
        velocity.x = Random.Range(0, 21) - 10;
        velocity.y = Random.Range(0, 21) - 10;
        float randomBallSize = Random.Range(0, 1.5F);
        int randomRed = Random.Range(0, 255);
        int randomGreen = Random.Range(0, 255);
        int randomBlue = Random.Range(0, 255);
        red = randomRed;
        green = randomGreen;
        blue = randomBlue;
        ballSize = randomBallSize;
    }

    public void BouncesEdgeOfScreen()
    {
        if (position.x > Width || position.x < 0)
        {
            velocity.x *= -1;
        }
        if (position.y > Height || position.y < 0)
        {
            velocity.y *= -1;
        }
    }
    public void Draw()
    {

        Stroke(red, green, blue);
        Fill(red, green, blue);
        Circle(position.x, position.y, ballSize);
    }
    public void UpdatePos()
    {
        position += velocity * Time.deltaTime;
    }
}
