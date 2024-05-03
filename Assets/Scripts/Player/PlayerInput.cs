using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;

    public Vector3 GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        return new Vector3(_horizontalInput, 0, _verticalInput) * Time.deltaTime;
    }
}
