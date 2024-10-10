using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject pausa;
    public bool IsPaused;
    // Start is called before the first frame update
    void Start()
    {
        pausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    void PauseGame()
    {
        pausa.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    void ResumeGame()
    {
        pausa.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
}
