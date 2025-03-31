using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    private void FixedUpdate()
    {
        Move();
    }

    protected abstract void Move();
}