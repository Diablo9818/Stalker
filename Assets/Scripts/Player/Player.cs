using UnityEngine;

[RequireComponent(typeof(CharacterController)), RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private CharacterController _characterController;
    private PlayerInput _input;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (_characterController.isGrounded)
        {
            _characterController.Move((_input.GetInput() * _speed) + Physics.gravity);
        }
        else
        {
            _characterController.Move(_characterController.velocity + Physics.gravity * Time.deltaTime);
        }
    }
}
