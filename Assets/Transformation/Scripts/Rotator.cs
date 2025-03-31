using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * _speed, Space.Self);
    }
}
