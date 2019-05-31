using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Question1 : MonoBehaviour {

    public GameObject Togglebar;
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject Choice3;
    public int ChoiceMade;

    public void Apple()
    {
       
    }

    public void Orange()
    {
     
        SceneManager.LoadScene("Question 2");
    }

    public void Pineapple()
    {
        
    }

    void Update()
    {
       
    }

}
