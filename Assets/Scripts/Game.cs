using UnityEngine;
using System.Collections;

public static class Game
{
    private static GameState state;

    public static GameState State
    {
        get
        {
            return state;
        }

        set
        {
            state = value;
        }
    }
}