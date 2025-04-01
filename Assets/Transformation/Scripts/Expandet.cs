using UnityEngine;

public class Expandet : MonoBehaviour
{
    private float _scaleIncrement = 0.01f;

    private void Update()
    {
        transform.localScale += Vector3.one * _scaleIncrement * Time.deltaTime;
    }
}
