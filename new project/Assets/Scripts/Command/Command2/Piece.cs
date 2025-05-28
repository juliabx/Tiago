using UnityEngine;

public class Piece : MonoBehaviour
{
    public Vector2Int CorrectPosition { get; private set; }
    public Vector2Int CurrentPosition { get; private set; }

    public void SetCorrectPosition(Vector2Int pos)
    {
        CorrectPosition = pos;
    }

    public void UpdatePosition(Vector2Int pos)
    {
        CurrentPosition = pos;
        // Mover peça visualmente na UI ou no mundo
        transform.localPosition = new Vector3(pos.x, pos.y, 0);
    }

    public bool IsInCorrectPosition()
    {
        return CurrentPosition == CorrectPosition;
    }

    public void Highlight(bool on)
    {
        // Ex: mudar cor da peça
    }

    private void OnMouseDown()
    {
        FindObjectOfType<PuzzleManager>().OnPieceClicked(this);
    }
}
