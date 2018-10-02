using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class AuthUI : MonoBehaviour {

    public GameObject LoginPanel;
    public GameObject SignupPanel;
    public GameObject LoggedinPanel;

    public InputField loginEmail;
    public InputField loginPassword;

    public InputField SigninEmail;
    public InputField SigninPassword;
    public InputField SigninConfirmPassword;


	// Use this for initialization
	void Start () {
        
        ShowLoginPanel();
	}
	
    public void ShowLoginPanel()
    {
        ShowPanel(LoginPanel);
    }
    public void ShowSignupPanel()
    {
        ShowPanel(SignupPanel);

    }
    public void ShowLoggedinPanel()
    {
        SceneManager.LoadScene("Main_menu_1");
    }

    public void ShowPanel(GameObject panel)
    {
        LoginPanel.SetActive(false);
        SignupPanel.SetActive(false);

        panel.SetActive(true);
    }
}
