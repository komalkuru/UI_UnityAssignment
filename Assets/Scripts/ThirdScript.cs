using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdScript : MonoBehaviour
{
    public Button buttonThree;
    public string newSceneThree;

    // Start is called before the first frame update
    private void Start()
    {
        buttonThree.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("Third button clicked");
        SceneManager.LoadScene(newSceneThree);
    }
}
