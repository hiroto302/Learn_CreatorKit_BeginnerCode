using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public int radius = 4;

    void Start()
    {
        // int angle = 15;
        // Vector3 spawnPosition = transform.position;

        // Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // spawnPosition = transform.position + direction * radius;
        // Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        // angle = 55;
        // direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // spawnPosition = transform.position + direction * radius;
        // Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        // angle = 95;
        // direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // spawnPosition = transform.position + direction * radius;
        // Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        // angle = 135;
        // direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        // spawnPosition = transform.position + direction * radius;
        // Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        // int angleToSpawn = 15;
        // for(int i = 0; i < 4; i++)
        // {
        //     SpawnPotion(angleToSpawn);
        //     angleToSpawn += 40;
        // }

        LootAngle myLootAngle = new LootAngle(45);
        for(int i = 0; i < 4; i++)
        {
            SpawnPotion(myLootAngle.NextAngle());
        }
    }

    void SpawnPotion(int angle)
    {
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

public class LootAngle
{
    int angle;
    int step;

    public LootAngle(int increment)
    {
        step = increment;
        angle = 0;
    }

    public int NextAngle()
    {
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);
        return currentAngle;
    }
}

