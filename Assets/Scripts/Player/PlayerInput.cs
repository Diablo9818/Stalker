using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private const string HorizontalInputName = "Horizontal";
    private const string VerticalInputName = "Vertical";

    public Vector3 GetInput()
    {
        float horizontalInput = Input.GetAxis(HorizontalInputName);
        float verticalInput = Input.GetAxis(VerticalInputName);

        return new Vector3(horizontalInput, 0, verticalInput) * Time.deltaTime;
    }
}
