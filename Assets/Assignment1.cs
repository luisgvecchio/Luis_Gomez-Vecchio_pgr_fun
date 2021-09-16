using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Assignment1 : ProcessingLite.GP21
{
    int redLetterColor = 0;
    int greenLetterColor = 0;
    int blueLetterColor = 30;


    void Start()
    {

    }

    public void LinesBackground()
    {
        Stroke(68);
        StrokeWeight(1);

        BeginShape();
        Vertex(0, 0);
        Vertex(11.35f, 10);
        EndShape();

        BeginShape();
        Vertex(23, 0);
        Vertex(11.35f, 10);
        EndShape();
        //2
        BeginShape();
        Vertex(0, 5);
        Vertex(8, 10);
        EndShape();

        BeginShape();
        Vertex(23, 7.5f);
        Vertex(8, 10);
        EndShape();
        //3
        BeginShape();
        Vertex(0, 6.4f);
        Vertex(4, 10);
        EndShape();

        BeginShape();
        Vertex(23, 3.5f);
        Vertex(4, 10);
        EndShape();
        //4
        BeginShape();
        Vertex(23, 5f);
        Vertex(14.75f, 10);
        EndShape();

        BeginShape();
        Vertex(0, 7.5f);
        Vertex(14.75f, 10);
        EndShape();
        //5
        BeginShape();
        Vertex(18, 10);
        Vertex(23, 6.4f);
        EndShape();

        BeginShape();
        Vertex(0, 3.5f);
        Vertex(18, 10);
        EndShape();

        //   V
        Stroke(169);
        BeginShape();
        Vertex(23, 10);
        Vertex(11.35f, 0);
        EndShape();

        BeginShape();
        Vertex(0, 10);
        Vertex(11.35f, 0);
        EndShape();
        //2
        BeginShape();
        Vertex(23, 3.5f);
        Vertex(8, 0);
        EndShape();

        BeginShape();
        Vertex(0, 6.4f);
        Vertex(8, 0);
        EndShape();
        //3
        BeginShape();
        Vertex(23, 7.5f);
        Vertex(4, 0);
        EndShape();

        BeginShape();
        Vertex(0, 5);
        Vertex(4, 0);
        EndShape();
        //4
        BeginShape();
        Vertex(23, 5);
        Vertex(18, 0);
        EndShape();

        BeginShape();
        Vertex(0, 7.5f);
        Vertex(18, 0);
        EndShape();
        //5
        BeginShape();
        Vertex(23, 6.4f);
        Vertex(14.75f, 0);
        EndShape();

        BeginShape();
        Vertex(0, 3.5f);
        Vertex(14.75f, 0);
        EndShape();
    }


    public void LetterL()
    {
        StrokeWeight(7);
        Stroke(redLetterColor, greenLetterColor, blueLetterColor);
        Line(5.5f, 7, 5.5f, 3);
        Line(5.5f, 3, 7.5f, 3);
    }
    private void LetterU()
    {
        Stroke(redLetterColor, greenLetterColor, blueLetterColor);
        Line(9, 7, 9, 3);
        Line(11, 7, 11, 3);
        Line(9, 3, 11, 3);
    }
    private void LetterI()
    {
        Stroke(redLetterColor, greenLetterColor, blueLetterColor);
        StrokeWeight(7);
        Line(13, 6, 13, 2.7f);
        Fill(redLetterColor, greenLetterColor, blueLetterColor);
        StrokeWeight(2);
        Circle(13, 6.85f, 0.45f);
    }

    private void LetterS()
    {
        Stroke(redLetterColor, greenLetterColor, blueLetterColor);
        StrokeWeight(7);
        Line(15, 3, 17, 3);
        Line(15, 7, 17, 7);
        Line(15, 5, 17, 5);
        Line(15, 7, 15, 5);
        Line(17, 3, 17, 5);
    }

    private void ShadeL()
    {
        Stroke(90);
        StrokeWeight(7);
        Line(5.8f, 6.7f, 5.8f, 2.7f);
        Line(5.8f, 2.7f, 7.8f, 2.7f);
    }
    private void ShadeU()
    {
        Stroke(90);
        Line(9.3f, 6.7f, 9.3f, 2.7f);
        Line(11.3f, 6.7f, 11.3f, 2.7f);
        Line(9.3f, 2.7f, 11.3f, 2.7f);
    }
    private void ShadeI()
    {
        Stroke(90);
        Line(13.3f, 5.7f, 13.3f, 2.4f);
        Fill(80);
        StrokeWeight(2);
        Circle(13.3f, 6.55f, 0.45f);
    }
    private void ShadeS()
    {
        Stroke(90);
        StrokeWeight(7);
        Line(15.3f, 2.7f, 17.3f, 2.7f);
        Line(15.3f, 6.7f, 17.3f, 6.7f);
        Line(15.3f, 4.7f, 17.3f, 4.7f);
        Line(15.3f, 6.7f, 15.3f, 4.7f);
        Line(17.3f, 2.7f, 17.3f, 4.7f);
    }

    public void Background()
    {
        Background(0);
    }


    // Update is called once per frame
    void Update()
    {
        redLetterColor += 1;
        greenLetterColor += 1;

        if (redLetterColor == 255)
        {
            redLetterColor = 0;
            greenLetterColor = 0;

        }


        Background();
        LinesBackground();

        ShadeL();
        LetterL();

        ShadeU();
        LetterU();

        ShadeI();
        LetterI();

        ShadeS();
        LetterS();
    }
}
