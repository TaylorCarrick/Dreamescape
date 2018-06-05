using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneChange : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
            SceneManager.LoadScene("TestLevel");
    }
}
   
    


