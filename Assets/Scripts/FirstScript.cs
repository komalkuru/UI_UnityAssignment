using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstScript : MonoBehaviour
{
    public Button buttonOne;
    public string newSceneOne;

    // Start is called before the first frame update
    private void Start()
    {
        buttonOne.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("First button clicked");
        SceneManager.LoadScene(newSceneOne);
    }
}
