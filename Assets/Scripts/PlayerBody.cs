using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerBody : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidBody;
    [SerializeField] private float forceAmount;
    [SerializeField] private float lateralForceAmount;
    [SerializeField] private float jumpForceAmount;
    //[SerializeField] private GameObject Obstacle;

    void Start()
    {
        
    }


    void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            playerRigidBody.linearVelocity = new Vector3(0, 0, 1) * forceAmount*Time.fixedDeltaTime;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            
            playerRigidBody.linearVelocity = new Vector3(0, 0, -1) * forceAmount * Time.fixedDeltaTime;
        }
        if (Keyboard.current.spaceKey.isPressed)
        {
            
            playerRigidBody.linearVelocity = new Vector3(0, 1, 0) * jumpForceAmount * Time.fixedDeltaTime;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            
            playerRigidBody.linearVelocity = new Vector3(1, 0, 0) * lateralForceAmount * Time.fixedDeltaTime;
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            
            playerRigidBody.linearVelocity = new Vector3(-1, 0, 0) * lateralForceAmount * Time.fixedDeltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)

    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.TryGetComponent<SpawnedObject>(out SpawnedObject obstacle))
        {
            Debug.Log(collision.gameObject.name);
            SceneManager.LoadScene(0);
        }
    }
}
