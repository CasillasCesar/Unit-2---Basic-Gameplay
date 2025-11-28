using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private const float speed = 10.0f;
    private const int limit = -10;

    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < limit)
        {
            transform.position = new Vector3(limit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > -limit)
        {
            transform.position = new Vector3(-limit, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
