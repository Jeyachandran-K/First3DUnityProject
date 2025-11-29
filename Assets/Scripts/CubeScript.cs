using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float timeElapsed = Time.time;
        transform.position += Vector3.forward*Time.deltaTime;
        Debug.Log("Distance moved :"+transform.position.z+ "Time taken :"+timeElapsed);

    }
}
