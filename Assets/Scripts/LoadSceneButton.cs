using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    public string sceneName;

    public void LoadScene() 
    {
        SceneManager.LoadScene(sceneName);
    }
}
