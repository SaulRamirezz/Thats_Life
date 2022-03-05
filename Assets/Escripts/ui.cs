using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{
    public static ui instance;
    public Slider Gordura;
    public Slider SexAppeal;
    public Slider Cansancio;
    public Slider Inteligencia;
    public Slider SocialSkills;
    public Slider Musculatura;
    public Slider Progreso;
    public Interactibletype currentInteractible;
    public Text descriptionText;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public GameObject window;

    public void showButton(string texto, Interactibletype type)
    {
        window.SetActive(true);
        currentInteractible = type;
        descriptionText.text = texto;
    }

    public void hideButton()
    {
        window.SetActive(false);
    }

    public void clickButton()
    {
        switch (currentInteractible)
        {
            case Interactibletype.puerta:
                SocialSkills.value += 3;
                Cansancio.value += 2;
                SexAppeal.value += 2;
                Progreso.value += 1;
                if(SexAppeal.value >= 10)
                {
                    SceneManager.LoadScene("pantallaDeVictoria");
                }
                break;
            case Interactibletype.escritorio:
                Musculatura.value += 1;
                SexAppeal.value += 2;
                Cansancio.value += 2;
                break;
            case Interactibletype.librero:
                Inteligencia.value += 2;
                Cansancio.value += 2;
                Progreso.value += 1;
                break;
            case Interactibletype.cama:
                Cansancio.value -= 2;
                Progreso.value += 1;
                break;
            case Interactibletype.escritorioremake:
                Gordura.value += 4;
                SexAppeal.value -= 4;
                Cansancio.value += 2;
                SocialSkills.value -= 2;
                Progreso.value += 1;
                break;
            default:
                break;
        }
        if (Cansancio.value >= 10 || Progreso.value > 8)
        {
            SceneManager.LoadScene("perdiste");
        }

        hideButton();
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