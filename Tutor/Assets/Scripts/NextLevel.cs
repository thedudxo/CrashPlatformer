using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] string nextLevelName;

    public void LoadNextLevel()
    {

        SceneManager.LoadScene(nextLevelName);
    }
}
