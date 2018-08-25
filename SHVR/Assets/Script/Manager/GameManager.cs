using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager{
    private static int time;
    private static int score;

    public static int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    public static int Time
    {
        get
        {
            return time;
        }

        set
        {
            time = value;
        }
    }
}
