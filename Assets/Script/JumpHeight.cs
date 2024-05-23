using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class JumpHeight : Collectible
{
    float increaseJumpHeight = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void collected(Player player)
    {
        base.collected(player);
        player.GetComponent<FirstPersonController>().JumpHeight += increaseJumpHeight;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
