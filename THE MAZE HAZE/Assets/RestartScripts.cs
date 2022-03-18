using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class RestartScripts : MonoBehaviour
{
    public void OnClickRestart()
    {
         SceneManager.LoadScene(sceneBuildIndex:0);
    }
}
