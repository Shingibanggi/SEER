using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour {

    private GameObject button;
    private new string name;

    public void SelectLevel()
    {
        //read button name & open selected Scene
        button = EventSystem.current.currentSelectedGameObject;
        name = button.GetComponentInChildren<Text>().text;
        SceneManager.LoadScene(name);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
