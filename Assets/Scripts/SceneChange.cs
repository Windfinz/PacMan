using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void SceneChanged(string name)
    {
        SceneManager.LoadScene(name);
        Time.timeScale = 1;
    }

}
