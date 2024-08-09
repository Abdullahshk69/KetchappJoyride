using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float TimeMultiplier { get; private set; }

    public float moveSpeed;

    private void Start()
    {
        Instance = this;
        TimeMultiplier = 1.0f;
    }

    private void Update()
    {
        TimeMultiplier = Mathf.Clamp(TimeMultiplier + Time.deltaTime * 0.1f, 1.0f, 2.0f);
    }
}
