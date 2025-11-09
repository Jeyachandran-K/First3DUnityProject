using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBody : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float forceAmount;
    [SerializeField] private float lateralForceAmount;
   
    void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            //transform.position += new Vector3(0, 0, 1);
            //rigidbody.AddForce(Vector3.forward * forceAmount);
            rigidbody.linearVelocity = new Vector3(0, 0, 1) * forceAmount;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            //transform.position += new Vector3(0, 0, -1);
            rigidbody.linearVelocity = new Vector3(0, 0, -1) * forceAmount;
        }
        if (Keyboard.current.spaceKey.isPressed)
        {
            //transform.position += new Vector3(0, 1, 0);
            rigidbody.linearVelocity = new Vector3(0, 1, 0) * forceAmount;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            //transform.position += new Vector3(1, 0, 0);
            rigidbody.linearVelocity = new Vector3(1, 0, 0) * lateralForceAmount;
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            //transform.position += new Vector3(-1, 0, 0);
            rigidbody.linearVelocity = new Vector3(-1, 0, 0) * lateralForceAmount;
        }
    }
}
