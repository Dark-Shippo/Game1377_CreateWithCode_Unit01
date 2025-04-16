using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] vehiclePrefabsLeft;
    public GameObject[] vehiclePrefabsRight;
    private float spawnRangeX = 47;
    private float spawnPosZLeft = 181;
    private float spawnPosZRight = -10;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomVehicleRight", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomVehicleLeft", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomVehicleRight()
    {
        int vehicleIndex = Random.Range(0, vehiclePrefabsRight.Length);

        Vector3 spawnPos = new Vector3(Random.Range(10, spawnRangeX), 0, spawnPosZRight);

        Instantiate(vehiclePrefabsRight[vehicleIndex], spawnPos, vehiclePrefabsRight[vehicleIndex].transform.rotation);
    }

    void SpawnRandomVehicleLeft()
    {
        int vehicleIndex = Random.Range(0, vehiclePrefabsLeft.Length);

        Vector3 spawnPos = new Vector3(Random.Range(10, spawnRangeX), 0, spawnPosZLeft);

        Instantiate(vehiclePrefabsLeft[vehicleIndex], spawnPos, vehiclePrefabsLeft[vehicleIndex].transform.rotation);
    }
}
