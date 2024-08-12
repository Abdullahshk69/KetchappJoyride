using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
    [SerializeField] GameObject rocket;
    [SerializeField] Camera cam;
    [SerializeField] Transform ceiling;
    [SerializeField] Transform ground;
    private float x;
    private float timer;
    float halfHeight;
    float halfWidth;
    private void Start()
    {
        halfHeight = cam.orthographicSize;
        halfWidth = cam.aspect * halfHeight;
        x = halfWidth * 2;
        timer = 0.0f;
    }

    private void Update()
    {
        
        if (GameManager.Instance.isPaused || GameManager.Instance.gameOver)
        {

        }
        else
        {
            timer += Time.deltaTime;
            Debug.Log("Spawn ");
            if (timer > 1.0f)
            {
                timer = 0.0f;
                if (Random.Range(0, 100) < 50)
                {
                    int randAmount = Random.Range(0, 4);
                    for(int  i = 0; i < randAmount; i++)
                    {
                        Instantiate(rocket, new Vector2(x, Random.Range(ground.position.y + 1, ceiling.position.y - 1)), Quaternion.identity);
                    }
                }
            }
        }
    }

    private void SpawnRockets()
    {
        StopAllCoroutines();

        
    }
}
