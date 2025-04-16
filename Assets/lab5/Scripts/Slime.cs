using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime 
{
    public int vida;

   
    public Slime(int vida)
    {
        this.vida = vida;
    }

    public static Slime operator +(Slime A, Slime B)
    {
        int NuevaVida = A.vida + B.vida;
        Debug.Log("Se ha creado un slime combinando slime A con slime B y se creó un slime con " + NuevaVida + " de vida ");
        return new Slime (NuevaVida);
    }
}
