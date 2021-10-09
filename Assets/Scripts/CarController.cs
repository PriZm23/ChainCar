using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameData data;

    public Rigidbody carRB;

    private Vector3 oldForward;

    public float lerpModifier;
    public float driveSpeed;

    private void Start()
    {
        InvokeRepeating("NewForward", 0f, lerpModifier);
    }

    private void NewForward()
    {
        StartCoroutine(Slide());
    }

    private IEnumerator Slide()
    {
        float timer = 0f;

        while (timer < lerpModifier)
        {
            timer+=Time.deltaTime;
            yield return null;
        }

        oldForward = transform.forward;
    }


    private void Update()
    {
        carRB.AddForce(transform.forward * driveSpeed * Time.deltaTime);
    }
}
