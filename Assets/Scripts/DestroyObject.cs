using System.Threading;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private float topBound = 190;
    private float lowerBound = -15;
    private Timer timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }

        Destroy(gameObject, 20);

        
    }
}
