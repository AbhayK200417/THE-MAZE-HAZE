using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class restartScript : MonoBehaviour
{
    public void OnClickRestart()
    {
         SceneManager.LoadScene(0);
    }
}
