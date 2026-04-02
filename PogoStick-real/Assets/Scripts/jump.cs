using System.Diagnostics;
using UnityEngine;

public class jumpbumpy : MonoBehaviour
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
            bool grounded = Physics.Raycast(player.transform.position, Vector3.down, 1f, LayerMask.NameToLayer("Ground")); // raycast down to look for ground is not detecting ground? only works if allowing jump when grounded = false; // return "Ground" layer as layer
            if (grounded == true)
            {
                print("grounded!");
                jump();
            }
        }
    }
    void jump()
    {
        rb.AddForce(transform.up * strength * Time.deltaTime);
        UnityEngine.Debug.Log("please");
        
            
        
    }
}
