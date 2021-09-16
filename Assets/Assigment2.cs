using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigment2 : ProcessingLite.GP21
{
    float xParabol1 = 0.5f;
    float yParabol1 = 10;
    int linesAmountParabol1 = 20;

       void Start()
    {
        Background(255, 158, 0);
    }

    // Update is called once per frame
    void Update()
    {
        ParabolicCurves parabolicCurve1 = new ParabolicCurves(xParabol1, yParabol1, linesAmountParabol1);
    }
}

public class ParabolicCurves : ProcessingLite.GP21
{
    float axis1;
    float axis2;
    float numberOfLines;

    public ParabolicCurves(float axis1, float axis2, float numberOfLines)
    {
        this.axis1 = axis1;
        this.axis2 = axis2;
        this.numberOfLines = numberOfLines;

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

            StrokeWeight(0.5f);
            Line(0, axis2, axis1, 0);

            if (axis1 > 0)
            {
                axis1 += 1f;
                axis2 -= 0.5f;
            }
        }
    }
}