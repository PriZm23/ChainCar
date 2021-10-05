using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePointsVFX : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float timeToDie;

    public void Configure(int points)
    {
        text.text = points.ToString();
        if (timeToDie > 0f)
        {
            Invoke("Die", timeToDie);
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

    
}
