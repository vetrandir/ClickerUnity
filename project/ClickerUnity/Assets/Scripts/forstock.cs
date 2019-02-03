using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class forstock : MonoBehaviour 

    

{
    public Text text;
    public int copper;
    public int iron;
    public int cauchuk;
    public int enCrn;
    public int quarz;
    public GameObject TxtResourceAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("copper"))
        {

        }
        else copper = 0;
        copper = PlayerPrefs.GetInt("copper");
        if (PlayerPrefs.HasKey("copper"))
        {

        }
        else copper = 0;
        
        if (PlayerPrefs.HasKey("iron"))
        {
            iron = PlayerPrefs.GetInt("iron");
        }
        else iron = 0;
        
        if (PlayerPrefs.HasKey("quarz"))
        {
            quarz = PlayerPrefs.GetInt("quarz");
        }
        else quarz = 0;
        
        if (PlayerPrefs.HasKey("enCrn"))
        {
            enCrn = PlayerPrefs.GetInt("enCrn");
        }
        else enCrn = 0;
        
        if (PlayerPrefs.HasKey("cauchuk"))
        {
            cauchuk = PlayerPrefs.GetInt("cauchuk");
        }
        else cauchuk = 0;
        TxtResourceAmount = GameObject.Find("cauchuk");
        TxtResourceAmount.GetComponent<Text>().text = cauchuk.ToString();
        TxtResourceAmount = GameObject.Find("copper");
        TxtResourceAmount.GetComponent<Text>().text = copper.ToString();
        TxtResourceAmount = GameObject.Find("quarz");
        TxtResourceAmount.GetComponent<Text>().text = quarz.ToString();
        TxtResourceAmount = GameObject.Find("iron");
        TxtResourceAmount.GetComponent<Text>().text = iron.ToString();
        TxtResourceAmount = GameObject.Find("enCrn");
        TxtResourceAmount.GetComponent<Text>().text = enCrn.ToString();
    }
}
