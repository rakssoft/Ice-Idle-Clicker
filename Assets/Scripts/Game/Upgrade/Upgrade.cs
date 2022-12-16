using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private Button _gooseCapButton;
    [SerializeField] private Button _beadsButton;
    [SerializeField] private Button _kokoshnikButton;
    [SerializeField] private Button _caftanButton;

    public void ViewUpgradePanel()
    {
        if(PlayerPrefs.GetInt("gooseCap") == 0)
        {
            _gooseCapButton.interactable = true;
        }
        else
        {
            _gooseCapButton.interactable = false;
        }
        if(PlayerPrefs.GetInt("caftan") == 0)
        {
            _caftanButton.interactable = true;
        }
        else
        {
            _caftanButton.interactable = false;
        } 
        if(PlayerPrefs.GetInt("beads") == 0)
        {
            _beadsButton.interactable = true;
        }
        else
        {
            _beadsButton.interactable = false;
        }
        if(PlayerPrefs.GetInt("kokoshnik") == 0)
        {
            _kokoshnikButton.interactable = true;
        }
        else
        {
            _kokoshnikButton.interactable = false;
        }





    }

    public void BuyGooseCap()
    {
        if (PlayerPrefs.GetFloat("fragmentswinter") >= 200)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") - 200);
            if (PlayerPrefs.GetInt("caftan") == 0)
            {
                PlayerPrefs.SetInt("gooseCap", 1);
                PlayerPrefs.SetFloat("profitGooseCap", 0.3f);
                Events.GooseSkin?.Invoke("hat");
                _gooseCapButton.interactable = false;
            }
            else if (PlayerPrefs.GetInt("caftan") == 1)
            {
                PlayerPrefs.SetInt("gooseCap", 1);
                Events.GooseSkin?.Invoke("hat_coat");
                _gooseCapButton.interactable = false;
            }
        }
    } 
    public void BuyCaftan()
    {
        if (PlayerPrefs.GetFloat("fragmentswinter") >= 100)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") - 100);
            if (PlayerPrefs.GetInt("gooseCap") == 0)
            {
                PlayerPrefs.SetInt("caftan", 1);
                PlayerPrefs.SetFloat("profitCaftan", 0.3f);
                Events.GooseSkin?.Invoke("coat");
                _caftanButton.interactable = false;
            }
            else if (PlayerPrefs.GetInt("gooseCap") == 1)
            {
                PlayerPrefs.SetInt("caftan", 1);
                Events.GooseSkin?.Invoke("hat_coat");
                _caftanButton.interactable = false;
            }
        }
    }

    public void BuyBeads()
    {
        if (PlayerPrefs.GetFloat("fragmentswinter") >= 50)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") - 50);
            if (PlayerPrefs.GetInt("kokoshnik") == 0)
            {
                PlayerPrefs.SetInt("beads", 1);
                Events.GooseMadamSkin?.Invoke("goose_beads");
                _beadsButton.interactable = false;
            }
            else if (PlayerPrefs.GetInt("kokoshnik") == 1)
            {
                PlayerPrefs.SetInt("beads", 1);
                Events.GooseMadamSkin?.Invoke("kokoshnik_and_ beads");
                _beadsButton.interactable = false;
            }
        }
    }
    public void BuyKokoshnik()
    {
        if (PlayerPrefs.GetFloat("fragmentswinter") >= 150)
        {
            PlayerPrefs.SetFloat("fragmentswinter", PlayerPrefs.GetFloat("fragmentswinter") - 150);
            if (PlayerPrefs.GetInt("beads") == 0)
            {
                PlayerPrefs.SetInt("kokoshnik", 1);
                PlayerPrefs.SetFloat("profitkokoshnik", 0.3f);
                Events.GooseMadamSkin?.Invoke("goose_kokoshnik");
                _kokoshnikButton.interactable = false;
            }
            else if (PlayerPrefs.GetInt("beads") == 1)
            {
                PlayerPrefs.SetInt("kokoshnik", 1);
                Events.GooseMadamSkin?.Invoke("kokoshnik_and_ beads");
                _kokoshnikButton.interactable = false;
            }
        }
    }


}

