using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 0.5f;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _speed, Space.Self);
    }
}