using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHighlight : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Material originalMaterial;
    public Material hightLightMaterial;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;
        // on récupére le matériel de base pour le stocker dans l'original afin de pouvoir switcher avec le HLMaterial
    }

    private void OnMouseOver() 
    {
        meshRenderer.material = hightLightMaterial;    
    }

    private void OnMouseExit()
    {
        
        meshRenderer.material = originalMaterial;   
    }
}
