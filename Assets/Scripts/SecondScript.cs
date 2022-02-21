using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondScript : MonoBehaviour
{
    public Button buttonTwo;
    public string newSceneTwo;

    // Start is called before the first frame update
    private void Start()
    {
        buttonTwo.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Second button clicked");
        SceneManager.LoadScene(newSceneTwo);
    }
}
