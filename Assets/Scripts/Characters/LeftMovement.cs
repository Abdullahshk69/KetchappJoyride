using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    private void FixedUpdate()
    {
        if(!GameManager.Instance.isPaused)
        {
            Vector2 newPos = transform.position;
            newPos.x -= GameManager.Instance.MoveSpeed;
            transform.position = newPos;
        }
    }
}
