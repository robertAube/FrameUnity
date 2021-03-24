using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    public void LoadScene(string name) {
        Debug.Log("Scene : " + name);
        SceneManager.LoadScene(name);
    }
}
