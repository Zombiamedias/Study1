using UnityEngine;


public enum ManagerState
{
    Offline, Initializing, Completed
}
public interface IManager
{
    ManagerState currentState { get; }
    void BootSequence();
}