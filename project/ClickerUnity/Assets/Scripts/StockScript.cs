using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StockScript : MonoBehaviour
{
    public string[] ResPicsNames = new string[] { "Iron", "Copper", "Quarz", "Graok", "Grafen", "VtoipBar", "CopperWires", "IronPlate", "Unknown"/*"SiliconBased"*/,
                                                  "VtoipPlate", "Unknown"/*"OpticalFiber"*/, "Unknown"/*"Plastic"*/,"Unknown", "Screw", "Antenna", "Pipe", "Body", "Tank", "Screen", "Chip",
                                                  "Unknown"/*"DroneBody"*/, "Wires", "Nozzle","Unknown" /*"SetOfSensors"*/, "CPU", "Battery", "Turbine", "Pump", "SolarPanel",
                                                  "SatelliteDish", "Transponder", "Cowl", "Skin", "Computer", "CellPhone", "Unknown"/*"Scanner"*/, "LSS", "ResidentialModule",
                                                  "RocketBooster", "OnBoardComputer", "ElecticMotor", "Unknown"/*"Gyroscope"*/, "Unknown"/*"DroneBrain"*/, "Server", "Unknown"/*"Drone"*/, "FlyingCar",
                                                  "Unknown"/*"Tricoder"*/, "Satellite","Unknown"/*"Rover"*/,"ThirdRStage","SecondRStage","FirstRStage","Rocket","Unknown"/*"IS"*/,"Unknown"/*"StationModule"*/,"Badlock"};//
    public string[] ResObjectsNames = new string[] { "Iron", "Copper", "Quarz", "Graok", "Grafen", "VtoipBar", "CopperWires", "IronPlate", "SiliconBased",
                                                  "VtoipPlate", "OpticalFiber", "Plastic","Unknown", "Screw", "Antenna", "Pipe", "Body", "Tank", "Screen", "Chip",
                                                  "DroneBody", "Wires", "Nozzle", "SetOfSensors", "CPU", "Battery", "Turbine", "Pump", "SolarPanel",
                                                  "SatelliteDish", "Transponder", "Cowl", "Skin", "Computer", "CellPhone", "Scanner", "LSS", "ResidentialModule",
                                                  "RocketBooster", "OnBoardComputer", "ElecticMotor", "Gyroscope", "DroneBrain", "Server", "Drone", "FlyingCar",
                                                  "Tricoder", "Satellite","Rover","ThirdRStage","SecondRStage","FirstRStage","Rocket","IS","StationModule","Badlock"};//55 position = Badlock
    public GameObject ImgBtn;
    static int StageNr = 5;
    static int finishResNumber;

    // Start is called before the first frame update
    void Start()
    {
        switch (StageNr) {
            case 1:
                finishResNumber = 14;
                break;
            case 2:
                finishResNumber = 24;
                break;
            case 3:
                finishResNumber = 34;
                break;
            case 4:
                finishResNumber = 44;
                break;
            case 5:
                finishResNumber = 56;
                break;
        }
        StockScript sc = new StockScript();
        sc.Count(finishResNumber);
    }
    void Count(int finishResNumber) {
        int x = 0;
        while (x<finishResNumber) {
            ImgBtn = GameObject.Find(ResObjectsNames[x]);
            if (ImgBtn != null) {
                ImgBtn.GetComponent<Image>().sprite = Resources.Load<Sprite>("Tablets/" + ResPicsNames[x]);
                x++;
            } else {
                x++;
            }
        }
        while(x < ResPicsNames.Length - 1) {
            ImgBtn = GameObject.Find(ResPicsNames[x]);
            ImgBtn.GetComponent<Image>().sprite = Resources.Load<Sprite>("Tablets/" + ResPicsNames[55]);
            x++;
        }
    }

}
