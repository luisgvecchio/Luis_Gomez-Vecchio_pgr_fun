using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Assigment5 : ProcessingLite.GP21
{
    int numberOfBalls = 10; //Move to ball manager
    Ball[] balls;           //Move to ball manager

    bool hit;
    bool gameOver = false;

    Player player1 = new Player();
    void Start()
    {
        Background(0);
        player1.positionPlayer1.x = 1;
        player1.positionPlayer1.y = 5;

        balls = new Ball[numberOfBalls];

        for (int i = 0; i < balls.Length; i++)
        {
            balls[i] = new Ball(Width / 2, Height / 2);
        }
    }
    void Update()
    {
        Background(0);
        player1.DrawPlayer();
        player1.InputBehaviour();
        player1.MovementPlayers();
        player1.Frame();
        player1.MaxSpeed();

        for (int i = 0; i < balls.Length; i++)      //Move to ball manager, Make it a Methid
        {
            balls[i].UpdatePos();
            balls[i].BouncesEdgeOfScreen();
            balls[i].Draw();
            hit = CollisionCheck(player1.positionPlayer1.x, player1.positionPlayer1.y, player1.diameter1 / 2,
                balls[i].position.x, balls[i].position.y, balls[i].ballSize / 2);
            if (hit)
            {
                gameOver = true;
            }
        }
        GameOverSign();
        RestartGame();

    }
    bool CollisionCheck(float x1, float y1, float size1, float x2, float y2, float size2)
    {
        float maxDistance = size1 + size2;
        if (Mathf.Abs(x1 - x2) > maxDistance || Mathf.Abs(y1 - y2) > maxDistance)
        {
            return false;
        }
        else if (Vector2.Distance(new Vector2(x1, y1), new Vector2(x2, y2)) > maxDistance)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    void GameOverSign()
    {
        if (gameOver)
        {
            Stroke(255);
            StrokeWeight(2);
            Line(0, 0, Width, Height);
            Line(Width, Height, 0, 0);
        }

    }
    void RestartGame()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Start();
            gameOver = false;
        }
    }

}
