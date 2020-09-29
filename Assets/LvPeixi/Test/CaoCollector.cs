using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaoCollector : MonoBehaviour,IInteractableResourceCollector
{
    public int resourceAccount = 15;
    public string resourceType = "FoodMaterial";
    public string interactObjectType = "ResourceCollector";
    public int ResourceAccount { get => resourceAccount; }
    public string ResourceType { get => resourceType; }
    public string InteractObjectType { get => interactObjectType; }
    public void EndInteractWithPlayer()
    {
        GameEvents.Sigton.onInteractEnd();
    }

    public void OnResourceCollectEnd()
    {
        resourceAccount = 0;
    }

    public void OnResourceCollectStart()
    {
        
    }

    public void StartInteractWithPlayer()
    {
        if (resourceAccount > 0)
        {
            Mediator.Sigton.StartResourceCollect(this);
        }
    }
}
