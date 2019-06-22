using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleFabric : MonoBehaviour
{
    public GameObject capsulePrefab;
    public int capsulesNumber;
    public Vector2 minMaxX;
    public Vector2 minMaxZ;

    public Vector3 RandomPosition
    {
        get
        {
            var v = Vector3.one;
            v.x = Random.Range(minMaxX.x, minMaxZ.y);
            v.z = Random.Range(minMaxX.x, minMaxZ.y);
            return v;
        }
    }

    void Start()
    {
        for (int i = 0; i < capsulesNumber; i++)
        {
            InstanceCapsule();
        }
    }

    void InstanceCapsule()
    {
        Instantiate(capsulePrefab,RandomPosition,Random.rotation);
    }
}
