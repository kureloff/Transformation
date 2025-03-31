using UnityEngine;

public class MoverToForward : Mover
{
    private float _speed = 0.5f;
    protected override void Move()
    {
        transform.Translate(Vector3.forward * _speed, Space.Self);
    }
}