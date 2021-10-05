using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChunk : MonoBehaviour
{
    public GameData data;
    public Transform container;
    public Transform bounds;

    private void Awake()
    {

    }

    [ContextMenu("Distribute Trees")]
    private void DistributeTrees()
    {
        for (int i=container.childCount-1; i>=0; i--)
        {
            Destroy(container.GetChild(i.gameObject);
        }

        float radius = data.GetCurrentPlacementRadius();
        List<Vector2> points = PoissonDiscSampling.GeneratePoints(radius, new Vector2(bounds.lossyScale.x, bounds.lossyScale.z));

        for (int i=0; i<points.Count; i++)
        {
            float x = 0.5f-(points[i].x / bounds.lossyScale.x);
            float z = 0.5f - (points[i].y / bounds.lossyScale.z);
            Vector3 position = container.TransformPoint(new Vector3(x, .5f, z));
            GameObject go = Instantiate(data.treePrefabs.GetRandom(), position, Quaternion.identity);
            go.transform.SetParent(container);
        }
    }
}
