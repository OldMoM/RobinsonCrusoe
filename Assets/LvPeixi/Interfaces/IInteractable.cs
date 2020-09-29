
public interface IInteractable 
{
    string InteractObjectType { get; }
    void StartInteractWithPlayer();
    void EndInteractWithPlayer();
}

