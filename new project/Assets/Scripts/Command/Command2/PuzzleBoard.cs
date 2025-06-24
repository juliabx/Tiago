using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class PuzzleBoard : MonoBehaviour
{
    public Piece[,] pieces;
    public int width, height;

    void Start()
    {
        Shuffle();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SwapPieces(Vector2Int a, Vector2Int b)
    {
        var temp = pieces [a.x, a.y];
        pieces [a.x, a.y] = pieces [b.x, b.y];
        pieces [b.x, b.y] = temp;
        
        pieces[a.x, a.y].UpdatePosition(a);
        pieces[b.x, b.y].UpdatePosition(b);
    }

    public bool IsSolved()
    {
        foreach (var piece in pieces)
        {
            if (!piece.IsInCorrectPosition()) return false;
        }

        return true;
    }
    
    // Update is called once per frame
    public void Shuffle()
    {
        Debug.Log("Shuffled puzzle");
        
        List<Piece> flat = pieces.Cast<Piece>().ToList();
        System.Random rng = new System.Random();

        int n = flat.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            (flat[n], flat[k]) = (flat[k], flat[n]);
        }

        int index = 0;
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                pieces[x,y] = flat[index];
                pieces[x,y].UpdatePosition(new Vector2Int(x, y));
                index++;
            }
        }
    }
}
