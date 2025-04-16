using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Slime slimeA = new Slime(10);
        Slime slimeB = new Slime(15);

        Debug.Log("Slime A tiene " + slimeA.vida + " de vida ");
        Debug.Log("Slime B tiene " + slimeB.vida + " de vida ");

        Slime slimeCombinado = slimeA + slimeB;

    }

}
