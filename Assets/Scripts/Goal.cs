using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Scoreboard scoreboard;
    public bool isForP1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            if (isForP1)
            {
                scoreboard.SendMessage("IncrementP1");
            }
            else
            {
                scoreboard.SendMessage("IncrementP2");
            }
        }
    }
}
