using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : IRandomWalker
{
    bool left = false;
    bool right = false;
    bool up = false;
    bool down = false;

    // Start is called before the first frame update
    public string GetName()
    {
        return "Sonic";
    }

    // Update is called once per frame
    public Vector2 GetStartPosition (int areaWidthPosition, int areaHeightPosition)
    {
        float x = areaWidthPosition ;
        float y = areaHeightPosition ;

        return new Vector2(x, y);
    }
    public Vector2 Movement()
    {
        
        
        
        switch (Random.Range(0, 4))
        {
            case 0:
                left = true;
                right = false;
                down = false;
                up = false;
                return new Vector2(-1, 0);
            case 1:
                right = true;
                left = false;
                down = false;
                up = false;
                return new Vector2(1, 0);
            case 2:  
                up = true;
                down = false;
                left = false;
                right = false;
                return new Vector2(0, 1);
            default:
                down = true;
                up = false;
                left = false;
                right = false;
                return new Vector2(0, -1);
        }
    }
}
