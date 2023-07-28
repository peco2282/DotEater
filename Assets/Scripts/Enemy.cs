using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
  public GameObject target;

  private NavMeshAgent _agent;

  private Animator _animator;

  private static readonly int Speed = Animator.StringToHash("Speed");

  // Start is called before the first frame update
  void Start()
  {
    _agent    = GetComponent<NavMeshAgent>();
    _animator = GetComponentInChildren<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
    _agent.destination = target.transform.position;
    _animator.SetFloat(Speed, _agent.velocity.magnitude);
  }
}