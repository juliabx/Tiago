using UnityEngine;
using System.Collections;

public class PuzzleManager : MonoBehaviour
{
    public PuzzleBoard board;
    public CommandManager2 commandManager = new CommandManager2();

    private Piece selectedPiece = null;
    private bool isReplaying = false;

    public void OnPieceClicked(Piece clicledPiece)
    {
        if (isReplaying) return;

        if (selectedPiece == null)
        {
            selectedPiece = clicledPiece;
            selectedPiece.Highlight(true);
        }
        else
        {
            {
                var pos1 = selectedPiece.CurrentPosition;
                var pos2 = clicledPiece.CurrentPosition;

                var move = new MoveCommand(board, pos1, pos2);
                commandManager.ExecuteCommand(move);

                selectedPiece.Highlight(false);
                selectedPiece = null;

                if (board.IsSolved())
                    ShowVictoryUI();
            }
        }

        public void OnUndoClicked()
        {
            if (selectedPiece == null && !isReplaying)
            {
                commandManager.Undo();
            }
        }

        public void OnRestartClicked()
        {
            board.Shuffle();
            commandManager = new CommandManager2();
            selectedPiece = null;
        }

        public void OnReplayClicked()
        {
            isReplaying = true;
            commandManager.ResetReplay();
            StartCoroutine(PlayReplay());
        }

        private IEnumerator PlayReplay()
        {
            while (commandManager.ReplayNextStep())
            {
                yield return new WaitForSeconds(1f);
            }

            isReplaying = false;
            ShowVictoryUI();
        }

        public void OnCancelReplayClicked()
        {
            StopAllCoroutines();
            commandManager.FastForwardReplay();
            isReplaying = false;
            ShowVictoryUI();
        }

        private void ShowVictoryUI()
        {
            Debug.Log("Parabéns! Você venceu!");
            // Exibir painel com botões: Jogar novamente / Ver Replay
        }

    }
}