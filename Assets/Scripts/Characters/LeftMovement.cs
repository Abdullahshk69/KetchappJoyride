using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x - (GameManager.Instance.TimeMultiplier * GameManager.Instance.moveSpeed), transform.position.y);
    }
}
