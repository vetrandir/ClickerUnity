using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumberRes : MonoBehaviour
{
    static int copperN;
    static int enCrN;
    static int quarzN;
    static int cauchukN;
    static int ironN;
    public string[] ResNames = new string[] { "Quarz", "Iron", "EnergyCrystals", "Copper", "Cauchuk" };
    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUpAsButton() {
        RandomNumberRes rnd = new RandomNumberRes();
        rnd.count();
    }
    public void count() {
        //for (int x = 0; x < ResNames.Length; x++) {
            int rndNr = Random.Range(0, 4);
            switch (ResNames[rndNr]) {
                case "Quarz":
                    quarzN++;
                    Debug.Log("quarz: "+quarzN);
                PlayerPrefs.SetInt("quarz", quarzN);
                PlayerPrefs.Save();
                break;
                case "Iron":
                    ironN++;
                    Debug.Log("iron: "+ironN);
                PlayerPrefs.SetInt("iron", ironN);
                PlayerPrefs.Save();
                break;
                case "EnergyCrystals":
                    enCrN++;
                    Debug.Log("enCr: "+enCrN);
                PlayerPrefs.SetInt("enCrn", enCrN);
                PlayerPrefs.Save();
                break;
                case "Copper":
                    copperN++;
                    Debug.Log("copper: "+copperN);
                PlayerPrefs.SetInt("copper", copperN);
                PlayerPrefs.Save();
                break;
                case "Cauchuk":
                    cauchukN++;
                    Debug.Log("cauchuk: "+cauchukN);
                PlayerPrefs.SetInt("cauchuk", cauchukN);
                PlayerPrefs.Save();
                break;
            }
        //}
    }
}
