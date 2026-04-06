using UnityEngine.InputSystem;
using UnityEngine;

public class controller : MonoBehaviour
{
    public int strength;
    public Rigidbody2D rb;
    public GameObject player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) == true) // if spacebar or up
        {
            print("key pressed!");

            Vector2 origin = player.transform.position;
            Vector2 direction = Vector2.down;
            float distance = 0.1f;
            origin.y -= 0.41f;
            // 2. Cast the ray
            RaycastHit2D hit = Physics2D.Raycast(origin, direction, distance);
            if (hit.collider != null)
            {
                Debug.Log("Hit: " + hit.collider.name);
                if (hit.collider.name != null)
                {
                    rb.AddForce(transform.up * strength);
                }
            }

        }
        float leftValue = InputSystem.actions.FindAction("RotateLeft").ReadValue<float>();
        transform.Rotate(0, 0, leftValue * Time.deltaTime * 60.0f);

        float rightValue = InputSystem.actions.FindAction("RotateRight").ReadValue<float>();
        transform.Rotate(0, 0, -rightValue * Time.deltaTime * 60.0f);
    }
    
}
