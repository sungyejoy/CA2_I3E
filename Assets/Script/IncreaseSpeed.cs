using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class IncreaseSpeed : Collectible
{
    float increasePlayerSpeed = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void collected(Player player)
    {
        base.collected(player);
        player.GetComponent<FirstPersonController>().MoveSpeed += increasePlayerSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
