using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Assigment5 : ProcessingLite.GP21
{
    int numberOfBalls = 10;
    Ball[] balls;

    Player player1 = new Player();
    void Start()
    {
        balls = new Ball[numberOfBalls];

        for (int i = 0; i < balls.Length; i++)
        {
            balls[i] = new Ball(Width / 2, Height / 2);
        }
    }
    void Update()
    {
        Background(0);
        player1.InputBehaviour();
        player1.MovementPlayers();
        player1.Frame();
        player1.MaxSpeed();
        player1.DrawPlayer();


        //Tell each ball to update it's position
        for (int i = 0; i < balls.Length; i++)
        {
            balls[i].UpdatePos();
            balls[i].BouncesEdgeOfScreen();
            balls[i].Draw();
        }
    }
}
