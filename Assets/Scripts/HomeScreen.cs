using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    public GameObject container;

    private void Awake()
    {
        GameEvents.GAME_BEGIN += HandleGameBegin;
        GameEvents.GO_HOME += HandleGoHome;
    }

    private void OnDestroy()
    {
        GameEvents.GAME_BEGIN -= HandleGameBegin;
        GameEvents.GO_HOME -= HandleGoHome;
    }

    private void HandleGameBegin()
    {
        container.SetActive(false);
    }
    private void HandleGoHome()
    {
        container.SetActive(true);
    }
}
