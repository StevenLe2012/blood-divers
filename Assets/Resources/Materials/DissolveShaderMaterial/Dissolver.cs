using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolver : MonoBehaviour
{
    // animate the game object from 1 to 0 and back
    public float minimum = 0.0F; // off
    public float maximum =  1.0F; // on
    private Material dissolve;

    // starting value for the Lerp
    float t = 1.0f;
    public bool spawn = true;
    
    public float dissolveSpeed = 0.5f;

    private void Start()
    {
        dissolve = Instantiate(GetComponent<MeshRenderer>().sharedMaterial);
        spawn = true;
        dissolve.SetFloat("_Effect", 1f); // start at invisible
        GetComponent<MeshRenderer>().material = dissolve;
    }
    // private void Awake()
    // {
    //     dissolve = Instantiate(GetComponent<MeshRenderer>().sharedMaterial);
    //     spawn = true;
    //     dissolve.SetFloat("_Effect", 1f); // start at invisible

    // }

    private void Update()
    {
        // animate the spawning...
        dissolve.SetFloat("_Effect", Mathf.Lerp(minimum, maximum, t));

        if (spawn) {            
            if (t > 0.0f) {
                t -= dissolveSpeed * Time.deltaTime;
            } else {
                 // Debug.Log("t reached 0f");
            }
        }

        if (!spawn)
        {
            if (t < 1.0f) {
                t += dissolveSpeed * Time.deltaTime;
            } else {
                 // Debug.Log("t reached 1f");
            }
        }
     }

     private void OnDestroy() {
        if(dissolve != null) {
            Destroy(dissolve);
        }
     }
    

    // void update() {
        
    //     if (despawn) {
    //         Debug.Log("despawn");
    //         dissolve.SetFloat("_Effect", Mathf.MoveTowards(dissolve.GetFloat("_Effect"), 0f, dissolveSpeed*Time.deltaTime));
    //     } else {
    //         Debug.Log(dissolve.GetFloat("_Effect"));
    //         dissolve.SetFloat("_Effect", Mathf.MoveTowards(dissolve.GetFloat("_Effect"), 1.25f, dissolveSpeed*Time.deltaTime));
    //     }
        
    // }

    // public void Spawn(){
    //     dissolve.SetFloat("_Effect", Mathf.MoveTowards(dissolve.GetFloat("_Effect"), 0f, dissolveSpeed*Time.deltaTime));
        
    // }
    // public void Despawn(){
    //     Debug.Log(dissolve.GetFloat("_Effect"));
    //     dissolve.SetFloat("_Effect", Mathf.MoveTowards(dissolve.GetFloat("_Effect"), 1.25f, dissolveSpeed*Time.deltaTime));
        
    // }
}
