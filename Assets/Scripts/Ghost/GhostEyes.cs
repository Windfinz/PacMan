using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEyes : MonoBehaviour
{
    public SpriteRenderer sprite { get; private set; }
    public Movement movement { get; private set; }

    public Sprite up;
    public Sprite down;
    public Sprite left;
    public Sprite right;

    private void Awake()
    {
        this.sprite = GetComponent<SpriteRenderer>();
        this.movement = GetComponentInParent<Movement>();
    }

    private void Update()
    {
        if(this.movement.direction == Vector2.up)
        {
            this.sprite.sprite = this.up;
        }
        if (this.movement.direction == Vector2.down)
        {
            this.sprite.sprite = this.down;
        }
        if (this.movement.direction == Vector2.left)
        {
            this.sprite.sprite = this.left;
        }
        if (this.movement.direction == Vector2.right)
        {
            this.sprite.sprite = this.right;
        }


    }

}
