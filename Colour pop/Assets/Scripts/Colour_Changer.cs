using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Colour_Changer : MonoBehaviour
{

    public Material[] materials;
    public Renderer Rend;

    private int index = 1;

    
    void Start()
    {
        Rend = GetComponent<Renderer>();//Gives functionality for the renderer
        Rend.enabled = true;
    }

    void OnMouseDown()
    {

        if (materials.Length == 0)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            index += 1;//When mouse is pressed down we increment up to the next index location

            if (index == materials.Length + 1)//When it reaches the end of the materials it starts over.
                index = 1;

            print(index);

            Rend.sharedMaterial = materials[index - 1]; 
        }
    }
}
