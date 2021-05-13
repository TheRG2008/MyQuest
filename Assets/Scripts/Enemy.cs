
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
   
    private NavMeshAgent _navMesh;
    private int _CurrentWaypointIndex;
    private Animator _anim;
    void Awake()
    {
        _navMesh = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
    }

    void Start()
    {
           
        _anim.SetBool("walk", true);
        _navMesh.SetDestination(_waypoints[0].position);

    }

    void Update()
    {
        if (_navMesh.remainingDistance <= _navMesh.stoppingDistance + 1)
        {
            _CurrentWaypointIndex = (_CurrentWaypointIndex + 1) % _waypoints.Length;
            _navMesh.SetDestination(_waypoints[_CurrentWaypointIndex].position);
        }
    }
}
