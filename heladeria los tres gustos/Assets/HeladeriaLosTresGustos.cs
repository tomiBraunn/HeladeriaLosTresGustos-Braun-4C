using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaLosTresGustos : MonoBehaviour
{
    public string gustoDeHelado;
    public int cantidadDeHelado;

    private float precioPorKilo = 500f;
    private float costoFinal;

    void Start()
    {
        if ((gustoDeHelado != "CHO" && gustoDeHelado != "FRU" && gustoDeHelado != "DDL") || 
            (cantidadDeHelado < 250 || cantidadDeHelado > 3000))
        {
            Debug.Log("Por favor ingresa un gusto válido o una cantidad válida.");
            return;
        }

        float precioFinalPorKilo = precioPorKilo;

        if (gustoDeHelado == "FRU")
        {
            precioFinalPorKilo *= 0.9f; 
        }

        costoFinal = (cantidadDeHelado / 1000f) * precioFinalPorKilo;

        Debug.Log("El costo del pedido es: $" + costoFinal);
    }

    void Update()
    {

    }
}
