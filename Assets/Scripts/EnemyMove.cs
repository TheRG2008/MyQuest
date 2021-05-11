using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _speed;    
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private Transform _player;
    [SerializeField] private int _agrDistance = 3;
    private Animator _anim;
    private NavMeshAgent _navMeshAgent;
    int _CurrentWaypointIndex;

    private void Awake() 
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
    }
    
   
    void Start()
    {
        _navMeshAgent.SetDestination(_waypoints[0].position);
        _anim.SetBool("walk", true);
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, _player.position) < _agrDistance)
        {
            _navMeshAgent.SetDestination(_player.position);
        }

        if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            _CurrentWaypointIndex = (_CurrentWaypointIndex + 1) % _waypoints.Length;
            _navMeshAgent.SetDestination(_waypoints[_CurrentWaypointIndex].position);
        }
    }


}
