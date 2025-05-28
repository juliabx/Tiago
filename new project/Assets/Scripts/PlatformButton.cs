using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public string buttonID;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log($"Botão {buttonID} foi pressionado!");
            EventChannels.ButtonPressed(buttonID);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
