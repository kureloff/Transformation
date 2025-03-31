using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class MoverToWaypoints : Mover
{
    [SerializeField] private List<Transform> _waypoints;
    private int _currentWaypoint = 0;
    private float _speed = 0.1f;

    protected override void Move()
    {
        if (transform.position == _waypoints[_currentWaypoint].position)
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Count;

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed);
    }

    public List<Transform> GetWaypoints() => 
        _waypoints.ToList();
}