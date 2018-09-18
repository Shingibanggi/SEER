using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour {

    public void BackLevel()
    {
        SceneManager.LoadScene("Main_menu_2");
    }
}
