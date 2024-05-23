using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Store the current collectible in front of the player
    Collectible currentCollectible;

    public void UpdateCollectible(Collectible newCollectible)
    {
        currentCollectible = newCollectible;
    }

    void OnInteract()
    {
        if(currentCollectible != null)
        {
            currentCollectible.collected(this);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
