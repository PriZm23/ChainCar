using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData data;

    private void Awake()
    {
        GameEvents.GAME_BEGIN += HandleGameBegin;
        GameEvents.GAME_END += HandleGameEnd;
    }

    private void OnDestroy()
    {
        GameEvents.GAME_BEGIN -= HandleGameBegin;
        GameEvents.GAME_END -= HandleGameEnd;
    }

    private void HandleGameEnd(int points)
    {
        data.isPlaying = false;
        data.timer = 0f;
    }

    private void HandleGameBegin()
    {
        data.isPlaying = true;
        data.timer = 0f;
    }

    private void Update()
    {
        data.timer += Time.deltaTime;
    }
}
