using UnityEngine;
using Utilities.Inspector;
using UnityEngine.SceneManagement;

public class NextSceneLoader
{
    public void LoadNextScene(int val)
    {
        SceneManager.LoadScene(val);
    }
}