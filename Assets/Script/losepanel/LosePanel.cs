using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    public HeroMovementController movement;
    private void Start()
    {

    }
    public void RestartLevel1()
    {
        SceneManager.LoadScene(1);
        movement.enabled = true;
        //Time.timeScale = 1;
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
