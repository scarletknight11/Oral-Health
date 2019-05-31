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
    public GameObject sad;
    public GameObject happy;

    public int ChoiceMade;

    void Start()
    {
        Choice1.SetActive(false);
        Choice2.SetActive(false);
        Choice3.SetActive(false);
    }


    public void Smoking()
    {
        Choice1.SetActive(true);
        Choice2.SetActive(true);
        Choice3.SetActive(true);
        happy.SetActive(true);
        SceneManager.LoadScene("Question 3");
    }

    public void Eating()
    {
        Choice1.SetActive(true);
        Choice2.SetActive(true);
        Choice3.SetActive(true);
        sad.SetActive(true);
        SceneManager.LoadScene("Question 3");
    }

    public void Sleeping()
    {
        Choice1.SetActive(true);
        Choice2.SetActive(true);
        Choice3.SetActive(true);
        sad.SetActive(true);
        SceneManager.LoadScene("Question 3");
    }

}
