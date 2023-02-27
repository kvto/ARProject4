using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
//needed to use button functions
public class Button3Script : MonoBehaviour{    
    public static Button3Script current;
  public GameObject screen1, screen2, screen3, button1, button2, button3;
  public Material blueMaterial, greenMaterial;
  public bool on;
    public GameObject definedButton;    
    public UnityEvent OnClick = new UnityEvent();    
    // Use this for initialization    
    private void Awake(){
    current = this;
  }
    void Start () 
    {
         definedButton = this.gameObject;      
         screen1.SetActive(false);
         screen2.SetActive(false);       
         screen3.SetActive(false); 
         on = false;     
         }          
         // Update is called once per frame     
void Update () {        
    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);       
    RaycastHit Hit;        
    if (Input.GetMouseButtonDown(0))        
    {          
           if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)    
           {               
            if(on == false){
              screen1.SetActive(false);
             screen2.SetActive(false);       
             screen3.SetActive(true);

             button1.GetComponent<MeshRenderer>().material = blueMaterial;
             button2.GetComponent<MeshRenderer>().material = blueMaterial;
             button3.GetComponent<MeshRenderer>().material = greenMaterial;   
            on = true;
            
             Button1Script.current.on = false;
             Button2Script.current.on = false;
             }
             else{
              button3.GetComponent<MeshRenderer>().material = blueMaterial;
              screen3.SetActive(false);
              on = false;
             }
             //  Debug.Log("Button Clicked");     
                           
            }        
     }        
}     
      
}