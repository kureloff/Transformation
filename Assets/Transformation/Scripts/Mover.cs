using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 0.5f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime, Space.Self);
    }
}