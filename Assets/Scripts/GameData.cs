using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    public AnimationCurve acceleration;
    public AnimationCurve densityMap;
    public float infiniteAccelerationScale = 2f;
    public float treeScaleModifier;
    public float treeScale;

    public float playerSpeed;

    public GameObject[] treePrefabs;

    public float timer = 0f;
    public bool isPlaying = false;

    public float GetCurrentPlacementRadius()
    {
        return densityMap.Evaluate(timer);
    }
}
