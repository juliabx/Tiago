using UnityEngine;

public class PlayerCommand : MonoBehaviour
{
    public class Moveup : ICommand
    {
        private Transform playerTransform;

        public MoveUp(Transform transform)
        {
            playerTransform = transform;
        }

        public void Do()
        {
            playerTransform.position += Vector3.up;
        }

        public class MoveRight : ICommand
    }
        public class GetCoin : ICommand
        {
            private SimplePlayer player;
            private GameObject coin;
            
            public void Do()
            {
                playerTransform.position += Vector3.right;
            }

            public void Undo()
            {
                player.moedas--;
                coin.SetActive(true);
                //lembrar de executar a função Undo mais uma vez
                player.UndoLastCommand();
            }

            public class GetCoin : ICommand
            {
                private SimplePlayer player;
                public GameObject coin;

                public GetCoin(SimplePlayer player, GameObject coin)
                {
                    this.player = player;
                    this.coin = coin;
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
}