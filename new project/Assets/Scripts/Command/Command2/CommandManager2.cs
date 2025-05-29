using System.Collections.Generic;
using UnityEngine;

public class CommandManager2
{
    private Stack<ICommand2> commandHistory = new Stack<ICommand2>();
    private List<ICommand2> replayList = new List<ICommand2>();
    private int replayIndex = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ExecuteCommand(ICommand2 command)
    {
        command.Execute();
        commandHistory.Push(command);
        replayList.Add(command);
    }

    // Update is called once per frame
    public void Undo()
    {
        if (commandHistory.Count > 0)
        {
            var command = commandHistory.Pop();
            command.Undo();
        }
    }

    public void ResetReplay()
    {
        replayIndex = 0;
    }

    public bool ReplayNextStep()
    {
        if (replayIndex < replayList.Count)
        {
            replayList[replayIndex].Execute();
            replayIndex++;
            return true;
        }
        return false;
    }

    public void FastForwardReplay()
    {
        while (ReplayNextStep())
        {
            
        }
    }
}
