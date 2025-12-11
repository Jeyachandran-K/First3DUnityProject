using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        transform.LookAt(target);
    }
}
