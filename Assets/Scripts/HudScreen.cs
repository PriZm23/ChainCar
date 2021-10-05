using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudScreen : MonoBehaviour
{
    public ScorePointsVFX pointsPrefab;
    public GameObject container;
    public RectTransform pointsContainer;

    private void Awake()
    {
        GameEvents.GAME_BEGIN += HandleGameBegin;
        GameEvents.SCORE_POINTS+=HandleScorePoints;
    }
    private void OnDestroy()
    {
        GameEvents.GAME_BEGIN -= HandleGameBegin;
        GameEvents.SCORE_POINTS-=HandleScorePoints;
    }

    private void HandleGameBegin()
    {
        container.SetActive(true);
    }

    private void HandleScorePoints(int points)
    {
        ScorePointsVFX pointsVFX = Instantiate(pointsPrefab, pointsContainer);
        pointsVFX.Configure(points);
    }
}
