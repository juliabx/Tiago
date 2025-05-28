using UnityEngine;

    public interface ICommand2
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Execute();
        void Undo();
    }