using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstBackButtonScript : MonoBehaviour
{
    public Button backButtonOne;
    public string mainScene;

    // Start is called before the first frame update
    private void Start()
    {
        backButtonOne.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Back to main Scene");
        SceneManager.LoadScene(mainScene);
    }
}
