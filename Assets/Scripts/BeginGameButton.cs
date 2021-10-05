using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginGameButton : MonoBehaviour
{
    public Button button;

    private void OnEnable()
    {
        button.interactable = true;

        button.onClick.AddListener(HandleClick);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(HandleClick);
    }

    private void HandleClick()
    {
        GameEvents.GameBegin();
        button.interactable = false;
    }
}
