public class FactoryMachine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        willCheckTier(int Tier);
    }

    func willCheckTier(int Tier)
    {
        switch (Tier)
        {
            case 1:
                NormalSale = 1; // Sanjijiksong
                break;
            case 2:
                NormalSale = 1;
                Freezing = 1; // Naengdong
                Drying = 1; // Malligi
                break;
            case 3:
                NormalSale = 1;
                Freezing = 1;
                Drying = 1;
                Pickle = 1; // Jutgal
                break;
            case 4:
                NormalSale = 1;
                Freezing = 1;
                Drying = 1;
                Pickle = 1;
                FishCake = 1; // Eomuk
                break;
            case 5:
                NormalSale = 1;
                Freezing = 1;
                Drying = 1;
                Pickle = 1;
                FishCake = 1;
                Can = 1; // Tongjorim
                break;
        }
    }
}
