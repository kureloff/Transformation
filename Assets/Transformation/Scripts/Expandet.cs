using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expandet : MonoBehaviour
{
    private float _scaleIncrement = 0.01f;

    private void Update()
    {
        Expand();
    }

    private void Expand()
    {
        transform.localScale += Vector3.one * _scaleIncrement;
    }
}
