using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EscenaJuego()
    {
        SceneManager.LoadScene("MainGame");
        Time.timeScale = 1f;
    }

    public void Salir()
    {
        Application.Quit();
    }
    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }
}
