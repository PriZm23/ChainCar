using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public GameObject container;

    private void Awake()
    {
        GameEvents.GAME_END += HandleGameEnd;
        GameEvents.GAME_BEGIN += HandleGameBegin;
        GameEvents.GO_HOME += HandleGoHome;
    }

    private void OnDestroy()
    {
        GameEvents.GAME_END -= HandleGameEnd;
        GameEvents.GAME_BEGIN -= HandleGameBegin;
        GameEvents.GO_HOME -= HandleGoHome;
    }

    private void HandleGameBegin()
    {
        container.SetActive(false);
    }
    
    private void HandleGoHome()
    {
        container.SetActive(false);
    }

    private void HandleGameEnd(int score)
    {
        container.SetActive(true);
        //if score > highscore
        // turn on highscore widget
    }
}
