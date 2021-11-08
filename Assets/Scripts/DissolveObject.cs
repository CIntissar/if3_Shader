using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject : MonoBehaviour
{
    // METHODE AVEC TIMER:
    private MeshRenderer render;
    public float duration = 2f;  
    private float timer = 0f;
    private bool running = false;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
	void Update()
	{	
        if(running && timer < duration)
        {
            timer += Time.deltaTime;
            float newValue = timer / duration; // pour qu'il soit de 0 à 1
            render.material.SetFloat("_Dissolution", newValue);
        }
	}
	void OnMouseDown() 
	{
        running = true;
	}

    /* METHODE AVEC COROUTINE:

    private MeshRenderer render;
    public float duration = 2f;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
	void Update()
	{	
 
	}
	void OnMouseDown() 
	{
        StartCoroutine(Dissolve());
	}

    private IEnumerator Dissolve()
    {
        float startTime = Time.time; //nbre de secondes depuis le début du jeu
        //le début où la coroutine a commencé à l'heure!

        while( Time.time - startTime < duration) 
        // 13h53 - 13h52 = donc le résultat < durée qu'on veut
        {
            float newValue = (Time.time - startTime) / duration; // pour qu'il soit de 0 à 1
            render.material.SetFloat("_Dissolution", newValue); 
            yield return true; // s'arrête jusqu'à la frame suivante
        }
    }

    */

    // ----------------------------------------------------------

    /* METHODE AVEC LERP:

    private MeshRenderer render;
    private float finalValue = 0f;


    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
	void Update()
	{	
		float currentValue = render.material.GetFloat("_Dissolution");
		float newValue = Mathf.Lerp(currentValue, finalValue, Time.deltaTime);
		render.material.SetFloat("_Dissolution", newValue);    
	}
	void OnMouseDown() 
	{
		finalValue = 1f;    
	}
    */
}
