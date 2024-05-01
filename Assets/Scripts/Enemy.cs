using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _stoppingDistance;
    [SerializeField] private Transform _target;

    private Rigidbody _rigidbody;
    private float _gravity = -9.8f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 direction = _target.position - transform.position;
        direction.y = _gravity;

        if (direction.magnitude > _stoppingDistance)
        {
            _rigidbody.velocity = direction.normalized * _speed;
        }
        else
        {
            _rigidbody.velocity = Vector3.zero;
        }

        transform.LookAt(_target);
    }
}
