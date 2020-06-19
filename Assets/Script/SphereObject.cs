using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObject : MonoBehaviour
{
    void Update()
    {
        Transform sphereTransform = this.transform;

        sphereTransform.Rotate(1.0f, 1.0f, 1.0f, Space.World);
    }
}
