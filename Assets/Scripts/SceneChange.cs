using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("TestLevel");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
}