using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 45f;

    public string inputID;          // "1" or "2"
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        // Axis setup (based on player number)
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // Move the vehicle forward/back
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate the vehicle left/right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Switch cameras
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
