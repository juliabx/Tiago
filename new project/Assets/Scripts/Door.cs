using UnityEngine;

public class Door : MonoBehaviour
{
    public string buttonID;

    private bool isOpen = false;
    private Collider2D doorCollider;
    private SpriteRenderer sr;
   
    private void Awake()
    {
        doorCollider = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        EventChannels.OnButtonPressed += OpenIfMatches;
    }

    private void OnDisable()
    {
        EventChannels.OnButtonPressed -= OpenIfMatches;
    }

    private void OpenIfMatches(string pressedID)
    {
        if (pressedID == buttonID)
        {
            Debug.Log($"Porta {buttonID} foi aberta!");
            isOpen = true;
            doorCollider.enabled = false; // desativa a colisão da porta
            sr.color = Color.green; // visualmente mostra que abriu
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
