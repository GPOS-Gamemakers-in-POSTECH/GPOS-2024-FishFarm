public class SampleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if PlayerdoCheckPowerPlantInfo == 1 {
            ShowPowerPlantInfo()
        }
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
        private var isOpening: bool // check if thermal power plant is open
        private var Power: int
        private func willCheckPower()
        {
            if FishFarmGrade >= 1 {
                isOpening = 1;
                Power = 10; // generate basic power 10
            }
            else isOpening = 0; // basic fish farm grade = 1, so this is basic power plant

            if isOpening == 0 {
                StopPowerPlant();
                Power = 0;
            }

            if PowerPlantEvent == 1 {
                StopPowerPlant();
                Power = 0;
            } // if power plant event occurs, stop power plant

            if Machine < 5 {
                Power = Power - 5;
            } // if machine point is less than 5, decrease power

            if FishFarm < 10 {
                Power = Power - 5;
            } // if fish farm point is less than 10, decrease power
        }
    }

    // wind power plant
    class WindPowerPlant
    {
        private var isOpening: bool // check if wind power plant is open
        private var Power: int
        private func willCheckPower()
        {
            if FishFarmGrade >= 2 {
                isOpening = 1;
                Power = 15; // generate basic power 15
            }
            else isOpening = 0; // need one upgrade to use wind power plant

            if isOpening == 0 {
                StopPowerPlant();
                Power = 0;
            }

            if PowerPlantEvent == 1 {
                StopPowerPlant();
                Power = 0;
            } // if power plant event occurs, stop power plant

            if Machine < 5 {
                Power = Power - 5;
            } // if machine point is less than 5, decrease power

            if FishFarm < 10 {
                Power = Power - 5;
            } // if fish farm point is less than 10, decrease power
        }
    }

    // Tidal power station
    class TidalPowerPlant
    {
        private var isOpening: bool // check if tidal power plant is open
        private var Power: int
        private func willCheckPower()
        {
            if FishFarmGrade >= 3 {
                isOpening = 1;
                Power = 30; // generate basic power 30
            }
            else isOpening = 0; // need two upgrade to use tidal power plant

            if isOpening == 0 {
                StopPowerPlant();
                Power = 0;
            }

            if PowerPlantEvent == 1 {
                StopPowerPlant();
                Power = 0;
            } // if power plant event occurs, stop power plant

            if Machine < 5 {
                Power = Power - 5;
            } // if machine point is less than 5, decrease power

            if FishFarm < 10 {
                Power = Power - 5;
            } // if fish farm point is less than 10, decrease power
        }
    }

}
