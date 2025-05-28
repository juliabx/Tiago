using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
      rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            movement.y += 1;
        if (Keyboard.current.sKey.isPressed)
            movement.y -= 1;
        if (Keyboard.current.aKey.isPressed)
            movement.x -= 1;
        if (Keyboard.current.dKey.isPressed)
            movement.x += 1;
        
        Debug.Log("Input: " + movement);
    }
    
    

    void FixedUpdate()
    {
        rb.AddForce(rb.position + movement * speed * Time.fixedDeltaTime);
    }
    
    
}