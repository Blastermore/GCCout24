using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    private CharacterController controller;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get WASD input
        float moveX = Input.GetAxis("Horizontal"); // A/D keys
        float moveZ = Input.GetAxis("Vertical");   // W/S keys

        // Calculate movement direction relative to player's facing direction
        moveDirection = transform.right * moveX + transform.forward * moveZ;
        moveDirection *= moveSpeed;

        // Apply movement using CharacterController
        controller.Move(moveDirection * Time.deltaTime);

        // Rotate the player based on mouse movement (horizontal rotation)
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, mouseX, 0);
    }
}