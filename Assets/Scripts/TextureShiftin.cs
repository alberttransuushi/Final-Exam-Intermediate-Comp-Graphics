using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TextureShiftin : MonoBehaviour
{
   
    Material material;
    float timer;
    [SerializeField] float cycleTime = 1;
    [SerializeField] string texName;
    [SerializeField] bool x;
    [SerializeField] bool y;
    void Start()
    {
        //Fetch the Material from the Renderer of the GameObject
        material = GetComponent<Renderer>().material;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > cycleTime)
        {
            timer -= cycleTime;
        }
        Vector2 shift = Vector2.zero;
        if (x)
        {
            shift.x = timer / cycleTime;
        }
        if (y)
        {
            shift.y = timer / cycleTime;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            cycleTime = 20;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            cycleTime = 1;
        }
        material.SetTextureOffset(texName, shift);
       
            

    }
}
