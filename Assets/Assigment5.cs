using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigment5 : ProcessingLite.GP21
{
    Player player1 = new Player();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Background(100, 0, 150);
        player1.InputBehaviour();
        player1.MovementPlayers();
        player1.MaxSpeed();
        player1.DrawPlayer();
    }
}
