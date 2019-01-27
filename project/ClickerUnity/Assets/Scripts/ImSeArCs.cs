using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ImSeArCs : MonoBehaviour
{
    static int quarzAmount;
    static int ironAmount;
    static int energyCrystalsAmount;
    static int copper;
    static int kauchuk;
    static int x;
    public string[] ImageNames = new string[] { "Quarz", "Iron", "EnergyCrystals", "Copper", "Cauchuk" };
    public GameObject Img;
    public GameObject TxtResourceName;
    public GameObject TxtResourceAmount;
    

    void Awake()
    {
        if (x == 0)
        {
            
            int resourceNumber = Random.Range(0, ImageNames.Length);
            int resourceAmount = Random.Range(0, 101);
            Debug.Log("Hello. ISAC started.");
            x++;
            string name = ImageNames[resourceNumber];
            Img = GameObject.Find("ResourcePic");
            Img.GetComponent<Image>().sprite = Resources.Load<Sprite>(name);
            TxtResourceName = GameObject.Find("ResourceName");
            TxtResourceName.GetComponent<Text>().text = name;
            TxtResourceAmount = GameObject.Find("ResourceAmount");
            TxtResourceAmount.GetComponent<Text>().text = resourceAmount.ToString();
        }
    }



   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}