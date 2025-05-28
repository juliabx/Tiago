using UnityEngine;

public class ICommand : MonoBehaviour
{
    public interface IdCommand
    {
        void Do()
        {
            player.moedas++;
            coin.SetActive(false);
        }

        void Undo()
        {
            player.moedas--;
            coin.SetActive(true);
            //Lembrar de executar a função Undo mais uma vez
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
