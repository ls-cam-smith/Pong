using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private int p1Score = 0;
    private int p2Score = 0;
    public TextMeshPro p1Scoreboard;
    public TextMeshPro p2Scoreboard;

    public void Reset()
    {
        p1Score = 0;
        p2Score = 0;
        p1Scoreboard.text = "00";
        p2Scoreboard.text = "00";
    }

    public void IncrementP1()
    {
        p1Score += 1;
        p1Scoreboard.text = String.Format("{0, 0:D2}", p1Score);
    }

    public void IncrementP2()
    {
        p2Score += 1;
        p2Scoreboard.text = String.Format("{0, 0:D2}", p2Score);
    }
}
