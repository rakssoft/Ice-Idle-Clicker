using UnityEngine;

public class DataSave : MonoBehaviour
{
    [SerializeField] private float _initialPriceHous;
    [SerializeField] private float _initialPriceFeeder;
    [SerializeField] private float _initialPriceFence;
    [SerializeField] private float _initialPriceMaraStatue;
    [SerializeField] private float _initialPriceGoose;

    private void Awake()
    {
       // PlayerPrefs.DeleteAll();

        if (!PlayerPrefs.HasKey("hous"))
        {
            PlayerPrefs.SetInt("hous", 0);
        }
        if (!PlayerPrefs.HasKey("profitHous"))
        {
            PlayerPrefs.SetFloat("profitHous", 1);
        } 
        if (!PlayerPrefs.HasKey("priceHous"))
        {
            PlayerPrefs.SetFloat("priceHous", _initialPriceHous);
        }


        if (!PlayerPrefs.HasKey("feeder"))
        {
            PlayerPrefs.SetInt("feeder", 0);
        }

        if (!PlayerPrefs.HasKey("priceFeeder"))
        {
            PlayerPrefs.SetFloat("priceFeeder", _initialPriceFeeder);
        } 
        if (!PlayerPrefs.HasKey("profitFeeder"))
        {
            PlayerPrefs.SetFloat("profitFeeder", 0);
        }

        if (!PlayerPrefs.HasKey("fence"))
        {
            PlayerPrefs.SetInt("fence", 0);
        }

        if (!PlayerPrefs.HasKey("priceFence"))
        {
            PlayerPrefs.SetFloat("priceFence", _initialPriceFence);
        } 
        if (!PlayerPrefs.HasKey("profitFence"))
        {
            PlayerPrefs.SetFloat("profitFence", 0);
        }


        if (!PlayerPrefs.HasKey("maraStatue"))
        {
            PlayerPrefs.SetInt("maraStatue", 0);
        }

        if (!PlayerPrefs.HasKey("priceMaraStatue"))
        {
            PlayerPrefs.SetFloat("priceMaraStatue", _initialPriceMaraStatue);
        } 
        if (!PlayerPrefs.HasKey("profitMaraStatue"))
        {
            PlayerPrefs.SetFloat("profitMaraStatue", 1);
        }



        if (!PlayerPrefs.HasKey("goose"))
        {
            PlayerPrefs.SetInt("goose", 1);
        }

        if (!PlayerPrefs.HasKey("priceGoose"))
        {
            PlayerPrefs.SetFloat("priceGoose", _initialPriceGoose);
        }


      

        if (!PlayerPrefs.HasKey("egg"))
        {
            PlayerPrefs.SetFloat("egg", 0);
        } 
        if (!PlayerPrefs.HasKey("fragmentswinter"))
        {
            PlayerPrefs.SetFloat("fragmentswinter", 0);
        } 
        if (!PlayerPrefs.HasKey("learn"))
        {
            PlayerPrefs.SetInt("learn", 0);
        }
 
 
        if (!PlayerPrefs.HasKey("autoclick"))
        {
            PlayerPrefs.SetFloat("autoclick", 0);
        }
        if (!PlayerPrefs.HasKey("quest"))
        {
            PlayerPrefs.SetFloat("quest", 0);
        }
        if (!PlayerPrefs.HasKey("questHome"))
        {
            PlayerPrefs.SetInt("questHome", 0);
        } 
        if (!PlayerPrefs.HasKey("questFeeder"))
        {
            PlayerPrefs.SetInt("questFeeder", 0);
        } 
        if (!PlayerPrefs.HasKey("questFence"))
        {
            PlayerPrefs.SetInt("questFence", 0);
        }  
        if (!PlayerPrefs.HasKey("questGoose"))
        {
            PlayerPrefs.SetInt("questGoose", 0);
        }
        if (!PlayerPrefs.HasKey("questMorana"))
        {
            PlayerPrefs.SetInt("questMorana", 0);
        }
        
        if (!PlayerPrefs.HasKey("beads"))
        {
            PlayerPrefs.SetInt("beads", 0);
        }
        if (!PlayerPrefs.HasKey("caftan"))
        {
            PlayerPrefs.SetInt("caftan", 0);
        }
        if (!PlayerPrefs.HasKey("profitCaftan"))
        {
            PlayerPrefs.SetFloat("profitCaftan", 0);
        } 
        if (!PlayerPrefs.HasKey("kokoshnik"))
        {
            PlayerPrefs.SetInt("kokoshnik", 0);
        }
        if (!PlayerPrefs.HasKey("profitkokoshnik"))
        {
            PlayerPrefs.SetFloat("profitkokoshnik", 0);
        }
        if (!PlayerPrefs.HasKey("gooseCap"))
        {
            PlayerPrefs.SetInt("gooseCap", 0);
        }
        if (!PlayerPrefs.HasKey("profitGooseCap"))
        {
            PlayerPrefs.SetFloat("profitGooseCap", 0);
        }



    }


    public void DellKeys()
    {
        PlayerPrefs.DeleteAll();
    }

    public void SaveDate()
    {
        PlayerPrefs.SetFloat("egg", PlayerPrefs.GetFloat("egg"));
    }
}
