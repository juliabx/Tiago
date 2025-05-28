using UnityEngine;

public class MoveCommand : ICommand2
{
    private PuzzleBoard board;

    private Vector2Int pos1, pos2;

    public MoveCommand(PuzzleBoard board, Vector2Int pos1, Vector2Int pos2)
    {
        this.board = board;
        this.pos1 = pos1;
        this.pos2 = pos2;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Execute()
    {
        board.SwapPieces(pos1, pos2);
    }

    // Update is called once per frame
    public void Undo()
    {
        board.SwapPieces(pos1, pos2);
    }
}
