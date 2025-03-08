using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    int radius = 5;
    public GameObject ObjectToSpawn;

    void Start()
    {
        Debug.Log(ObjectToSpawn.name);
        //if(ObjectToSpawn.equals())
        LootAngle myLootAngle = new LootAngle(45);
    
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        
    }

    void SpawnPotion(int angle){
       
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

public class LootAngle{
    int angle; 
    int step;
    public LootAngle(int increment){
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

