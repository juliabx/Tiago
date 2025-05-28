using UnityEngine;
using UnityEngine.InputSystem;

public class SimplePlayer : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.uKey.wasPressedThisFrame)
        {
            UndoLastCommand();
        }
        
        if (Keyboard.current.upArrowKey.wasPressedThisFrame || Keyboard.current.wKey.wasPressedThisFrame)
        {
            //transform.position += Vector3.up;
            myCommandManager.AddCommand(new Moveup(transform));
        }
        
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame || Keyboard.current.dKey.wasPressedThisFrame)
        {
            transform.position += Vector3.right;
        }
    
    public int moedas; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            /*moedas++;
            Destroy(other.gameObject);*/
            myCommandManager.AddCommand(new GetCoin(this, other.gameObject));
        }

        public void UndoLastCommand()
        {
            myCommandManager.UndoCommand();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    }
}
