using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetweenCases : MonoBehaviour
{
    string sceneName;

    void OnMouseUpAsButton()
    {
        sceneName = SceneManager.GetActiveScene().name;
        Debug.Log(sceneName);
        string objName = gameObject.name;
        Debug.Log(objName);
        if (objName == "strelkaRight")
        {
            switch (sceneName)
            {
                case "case3":
                    SceneManager.LoadScene("case2");
                    break;
                case "case2":
                    SceneManager.LoadScene("case1");
                    break;
            }
        }
        if (objName == "strelkaLeft")
        {
            switch (sceneName)
            {
                case "case1":
                    SceneManager.LoadScene("case2");
                    break;
                case "case2":
                    SceneManager.LoadScene("case3");
                    break;
            }
        }       
    }

}
