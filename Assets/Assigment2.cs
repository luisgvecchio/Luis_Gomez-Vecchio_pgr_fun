using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigment2 : ProcessingLite.GP21
{
    // Start is called before the first frame update
    void Start()
    {
        Background(255, 158, 0);


    }

    // Update is called once per frame
    void Update()
    {
        float x = 1f;
        float y = 10;
        int numberOfLines = 20;

        for (int i = 0; i < numberOfLines; i++)
        {
            if (i % 3 == 0)
            {
                Stroke(0);                
            }
            else
            {
                Stroke(158);
            }

            Line(0, y, x, 0);

            if (y > 0)
            {
                x += 1f;
                y -= 0.5f;
            }           
        }
    }
}
