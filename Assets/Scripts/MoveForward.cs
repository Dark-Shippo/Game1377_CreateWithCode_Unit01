using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(10.0f, 40.0f);

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
