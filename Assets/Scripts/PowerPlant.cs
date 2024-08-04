using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowPowerPlantInfo()
    }

    func ShowPowerPlantInfo() // check thermal, wind, tidal power plant
    {
        ThermalPowerPlant;
        WindPowerPlant;
        TidalPowerPlant;
    }

    // Thermal power plant
    class ThermalPowerPlant
    {
        private var isOpening: Bool // check if thermal power plant is open
        
        private func willCheckPower()
        {
            if FishFarmGrade >= 1 {
                isOpening = 1;
            } else isOpening = 0; // basic fish farm grade = 1, so this is basic power plant

            if isOpening == 0 {
                StopPowerPlant();
            }

            if PowerPlantEvent == 1 {
                StopPowerPlant();
            } // if power plant event occurs, stop power plant

            if Machine < 5 {
                DecreasePower();
            } // if machine point is less than 5, decrease power

            if FishFarm < 10 {
                DecreasePower();
            } // if fish farm point is less than 10, decrease power
        }
    }

    // wind power plant
    class WindPowerPlant
    {
        private var isOpening: Bool // check if wind power plant is open

        private func willCheckPower()
        {
            if FishFarmGrade >= 2 {
                isOpening = 1;
            }
            else isOpening = 0; // need one upgrade to use wind power plant

            if isOpening == 0 {
                StopPowerPlant();
            }

            if PowerPlantEvent == 1 {
                StopPowerPlant();
            } // if power plant event occurs, stop power plant

            if Machine < 5 {
                DecreasePower();
            } // if machine point is less than 5, decrease power

            if FishFarm < 10 {
                DecreasePower();
            } // if fish farm point is less than 10, decrease power
        }
    }

    // Tidal power station
    class TidalPowerPlant
    {
        private var isOpening: Bool // check if tidal power plant is open

        private func willCheckPower()
        {
            if FishFarmGrade >= 3 {
                isOpening = 1;
            }
            else isOpening = 0; // need two upgrade to use tidal power plant

            if isOpening == 0 {
                StopPowerPlant();
            }

            if PowerPlantEvent == 1 {
                StopPowerPlant();
            } // if power plant event occurs, stop power plant

            if Machine < 5 {
                DecreasePower();
            } // if machine point is less than 5, decrease power

            if FishFarm < 10 {
                DecreasePower();
            } // if fish farm point is less than 10, decrease power
        }
    }

}
