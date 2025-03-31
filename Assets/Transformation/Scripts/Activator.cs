using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField] private MoverToWaypoints _moverToWaypoints;
    [SerializeField] private GameObject[] _objects;
    private int objectNumber = 0;

    private void Update()
    {
        Activate();
    }

    private void Activate()
    {
        if(_moverToWaypoints.transform.position == _moverToWaypoints.GetWaypoints()[objectNumber].position)
        {
            _objects[objectNumber].SetActive(true);
            objectNumber = (objectNumber + 1) % _moverToWaypoints.GetWaypoints().Count;
        }
    }
}
