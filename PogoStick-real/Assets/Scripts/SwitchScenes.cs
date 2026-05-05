using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SwitchScenes : MonoBehaviour
{
    public string sceneName;
    public Button myButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         myButton.onClick.AddListener(WhenClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void WhenClick()
    {
        SceneManager.LoadScene(sceneName);
        UnityEngine.Debug.Log("ahh");
    }
}
