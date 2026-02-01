using System.Threading;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer =0;
    public float heightOffSet = 10;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float heighestPoint = transform.position.y + heightOffSet;
        Instantiate(pipe , new Vector3(transform.position.x , Random.Range(lowestPoint , heighestPoint) , 0) , transform.rotation);
    }
}
