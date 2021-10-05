using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents 
{
    public delegate void GameEvent();
    public delegate void GameIntEvent(int i);
    
    public static event GameEvent GAME_BEGIN; 
    public static event GameEvent GO_HOME; 
    public static event GameEvent CHUNK_CLEARED; 
    public static event GameEvent HIT_TREE; 
    public static event GameIntEvent GAME_END; 
    public static event GameIntEvent SCORE_POINTS; 

    public static void GameBegin()
    {
        if (GAME_BEGIN!=null)
        {
            Debug.Log("Game Begin");
            GAME_BEGIN();
        }
    }

    public static void ChunkCleared()
    {
        if (CHUNK_CLEARED!=null)
        {
            Debug.Log("Chunk Cleared");
            CHUNK_CLEARED();
        }
    }

    public static void GoHome()
    {
        if (GO_HOME!=null)
        {
            Debug.Log("Go Home");
            GO_HOME();
        }
    }

    public static void HitTree()
    {
        if (HIT_TREE!=null)
        {
            Debug.Log("Hit Tree");
            HIT_TREE();
        }
    }

    public static void GameEnd(int score)
    {
        if (GAME_END!=null)
        {
            Debug.Log("Game Ended - final score: " + score);
            GAME_END(score);
        }
    }

    public static void ScorePoints(int score)
    {
        if (SCORE_POINTS!=null)
        {
            Debug.Log("points scored: " + score);
            SCORE_POINTS(score);
        }
    }

}
