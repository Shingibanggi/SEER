using System.Collections;
using System.Collections.Generic;
using Firebase;
using Firebase.Auth;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AuthManager : MonoBehaviour {

    AuthUI authUI;

    FirebaseAuth auth;

	// Use this for initialization
	void Start () {
        authUI = GetComponent<AuthUI>();

        InitializeFirebase();
	}

    void InitializeFirebase()
    {
        auth = FirebaseAuth.DefaultInstance;
    }


    public void OnLoginButtonClick(){
        TryLoginWithFirebaseAuth(authUI.SigninEmail.text, authUI.SigninPassword.text);
    }

    public void OnCreateaccountButtonClick()
    {
        TrySignUpWithFirebaseAuth(authUI.SigninEmail.text, authUI.SigninPassword.text, authUI.SigninConfirmPassword.text);
    }

    public void OnSignoutButtonClick()
    {
        auth.SignOut();
        SceneManager.LoadScene("Log_In");
    }

    private void TryLoginWithFirebaseAuth(string email, string password){
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(obj => {

            authUI.ShowLoggedinPanel();
        });
    }

    //check validity of pw and email
    private void TrySignUpWithFirebaseAuth(string email, string password,string confirmpassword){
        
        if(password != confirmpassword){
            Debug.Log("pw not matched");
            return;
        }

        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(obj => {

            authUI.ShowLoginPanel();
        });
    }
}
