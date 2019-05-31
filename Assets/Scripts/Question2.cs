using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Question2 : MonoBehaviour {

    public GameObject Togglebar;
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject Choice3;
    public int ChoiceMade;

    public void Smoking()
    {
       
        SceneManager.LoadScene("Question 3");
    }

    public void Eating()
    {

    }

    public void Sleeping()
    {

    }

}
