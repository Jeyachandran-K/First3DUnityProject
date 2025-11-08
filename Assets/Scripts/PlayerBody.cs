using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBody : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
   
    void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            rigidbody.transform.position += new Vector3(0, 0, 1);
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            rigidbody.transform.position += new Vector3(0, 0, -1);
        }
        if (Keyboard.current.spaceKey.isPressed)
        {
            rigidbody.transform.position += new Vector3(0, 1, 0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            rigidbody.transform.position += new Vector3(1, 0, 0);
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            rigidbody.transform.position += new Vector3(-1, 0, 0);
        }
    }
}
