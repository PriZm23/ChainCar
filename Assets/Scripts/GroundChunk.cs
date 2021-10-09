using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChunk : MonoBehaviour
{
    public GameData data;
    public Transform container;
    public Transform bounds;

    private void OnEnable()
    {
        DistributeTrees();
    }

    [ContextMenu("Distribute Trees")]
    private void DistributeTrees()
    {
        for (int i=container.childCount-1; i>=0; i--)
        {
            Destroy(container.GetChild(i).gameObject);
        }

        float radius = data.GetCurrentPlacementRadius();
        List<Vector2> points = PoissonDiscSampling.GeneratePoints(radius, new Vector2(bounds.lossyScale.x, bounds.lossyScale.z));

        for (int i=0; i<points.Count; i++)
        {
            float x = 0.5f-(points[i].x / bounds.lossyScale.x);
            float z = 0.5f - (points[i].y / bounds.lossyScale.z);
            Vector3 position = bounds.TransformPoint(new Vector3(x, .5f, z));
            GameObject go = Instantiate(data.treePrefabs.GetRandom(), position, Quaternion.identity);
            Vector3 lookRot = new Vector3(Random.insideUnitCircle.x, 0f, Random.insideUnitCircle.y);
            go.transform.rotation = Quaternion.LookRotation(lookRot, Vector3.up);
            go.transform.localScale = Vector3.one * data.treeScale + Vector3.one * Random.Range(-data.treeScaleModifier, data.treeScaleModifier);
            go.transform.SetParent(container);
        }
    }
}
