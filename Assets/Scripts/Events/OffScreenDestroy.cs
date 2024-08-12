using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreenDestroy : MonoBehaviour
{
    private void Update()
    {
        if(MathF.Abs(transform.position.x - GameManager.Instance.PlayerPosition.position.x) > 20
            && transform.position.x < GameManager.Instance.PlayerPosition.position.x)
        {
            Destroy(gameObject);
        }
    }
}
