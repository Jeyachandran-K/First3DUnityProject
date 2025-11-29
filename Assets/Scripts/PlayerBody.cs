using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBody : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidBody;
    [SerializeField] private float forceAmount;
    [SerializeField] private float lateralForceAmount;
    [SerializeField] private float jumpForceAmount;

    void Start()
    {
        
    }


    void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            //transform.position += new Vector3(0, 0, 1);
            //rigidbody.AddForce(Vector3.forward * forceAmount);
            playerRigidBody.linearVelocity = new Vector3(0, 0, 1) * forceAmount*Time.fixedDeltaTime;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            //transform.position += new Vector3(0, 0, -1);
            playerRigidBody.linearVelocity = new Vector3(0, 0, -1) * forceAmount * Time.fixedDeltaTime;
        }
        if (Keyboard.current.spaceKey.isPressed)
        {
            //transform.position += new Vector3(0, 1, 0);
            playerRigidBody.linearVelocity = new Vector3(0, 1, 0) * jumpForceAmount * Time.fixedDeltaTime;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            //transform.position += new Vector3(1, 0, 0);
            playerRigidBody.linearVelocity = new Vector3(1, 0, 0) * lateralForceAmount * Time.fixedDeltaTime;
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            //transform.position += new Vector3(-1, 0, 0);
            playerRigidBody.linearVelocity = new Vector3(-1, 0, 0) * lateralForceAmount * Time.fixedDeltaTime;
        }
    }
}
