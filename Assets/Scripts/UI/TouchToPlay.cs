using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToPlay : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.isPaused = true;
    }
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        GameManager.Instance.isPaused = false;
    }
}
