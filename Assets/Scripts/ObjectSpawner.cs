using System.Threading;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]private GameObject Obstacle;
    private Vector3 spawnPosition;
    private Quaternion spawnRotation=Quaternion.identity;
    private float zValue = 10f;
    private float timer = 0f;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            SpawnObstacles();
            timer = 0;
        }
    }
    private void SpawnObstacles()
    {
        spawnPosition= new Vector3(Random.Range(-10, 10), 1.5f, zValue);
        Instantiate(Obstacle,spawnPosition,spawnRotation);
        zValue += 10;
    }
}
