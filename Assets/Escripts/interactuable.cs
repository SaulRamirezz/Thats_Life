using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Interactibletype
{
    puerta, escritorio, librero, cama, escritorioremake
}

public class interactuable : MonoBehaviour
{

    public Interactibletype type;
    public string descripcion;

    public void use()
    {
        ui.instance.showButton(descripcion, type);

    }
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
