using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugEvents : MonoBehaviour
{

    [ContextMenu("GameOver")]
    public void GameOver()
    {
        GameEvents.GameEnd(10);
    }
    [ContextMenu("ChunkCleared")]
    public void ChunkCleared()
    {
        GameEvents.ChunkCleared();
    }

    [ContextMenu("GameStart")]
    public void GameStart()
    {
        GameEvents.GameBegin();
    }

    [ContextMenu("BackToHome")]
    public void BackToHome()
    {
        GameEvents.GoHome();
    }

    [ContextMenu("PointsScored")]
    public void PointsScored()
    {
        GameEvents.ScorePoints(10);
    }

    [ContextMenu("HitTree")]
    public void HitTree()
    {
        GameEvents.HitTree();
    }
}


