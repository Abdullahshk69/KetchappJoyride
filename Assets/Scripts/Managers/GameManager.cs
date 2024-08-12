using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [field: SerializeField] public float MoveSpeed { get; private set; }
    [field: SerializeField] public Transform PlayerPosition {  get; private set; }

    [SerializeField] TextMeshProUGUI scoretxt;
    [SerializeField] GameObject gameOverPanel;

    public bool isPaused = true;
    public bool gameOver = false;

    private float score = 0.0f;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        Debug.Log(Time.timeScale);
        if(!isPaused && !gameOver)
        {
            MoveSpeed = Mathf.Clamp(MoveSpeed + Time.deltaTime * 0.01f, 0.5f, 1.5f);
            Time.timeScale = 1;
            score += Time.deltaTime * MoveSpeed * 10;
            scoretxt.text = "Score: " + string.Format("{0:0}", score);
        }
        else if(isPaused || gameOver)
        {
            Time.timeScale = 0;
        }

        if(gameOver)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
