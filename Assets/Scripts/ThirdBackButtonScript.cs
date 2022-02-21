using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdBackButtonScript : MonoBehaviour
{
    public Button backButtonThree;
    public string mainScene;

    // Start is called before the first frame update
    private void Start()
    {
        backButtonThree.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Back to main Scene");
        SceneManager.LoadScene(mainScene);
    }
}
