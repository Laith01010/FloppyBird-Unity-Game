using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public int moveSpeed = 5;
    public float deadZone = -8.8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);
    }
}
