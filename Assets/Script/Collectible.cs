using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdatePlayerInteractable(Player player)
    {
        player.UpdateCollectible(this);
    }

    public void RemovePlayerInteractable(Player player)
    {
        player.UpdateCollectible(null);
    }

    public virtual void collected(Player player)
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            UpdatePlayerInteractable(collision.gameObject.GetComponent<Player>());
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            RemovePlayerInteractable(collision.gameObject.GetComponent<Player>());
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
