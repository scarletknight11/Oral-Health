using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour {

	public void Slider_Changed()
    {
        SceneManager.LoadScene("Question 1");
    }


}
