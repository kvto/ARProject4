using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
//needed to use button functions
public class Button1Script : MonoBehaviour{    
  public static Button1Script current;
  public GameObject screen1, screen2, screen3, button1, button2, button3;
  public Material blueMaterial, greenMaterial;
  public bool on;

  public GameObject definedButton;    
  public UnityEvent OnClick = new UnityEvent();    

  private void Awake(){
    current = this;
  }
    // Use this for initialization    
  void Start () 
  {
         screen1.SetActive(false);
         screen2.SetActive(false);       
         screen3.SetActive(false); 
         on = false;
         definedButton = this.gameObject;          
  }          
         // Update is called once per frame     
  void Update () 
  {        
    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);       
    RaycastHit Hit;        
    if (Input.GetMouseButtonDown(0))        
    {          
           if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)    
           {               

            if(on == false){
             screen1.SetActive(true);
             screen2.SetActive(false);       
             screen3.SetActive(false);         

             button1.GetComponent<MeshRenderer>().material = greenMaterial;
             button2.GetComponent<MeshRenderer>().material = blueMaterial;
             button3.GetComponent<MeshRenderer>().material = blueMaterial;

             on = true;
             Button2Script.current.on = false;
             Button3Script.current.on = false;
             }         
             else{
              button1.GetComponent<MeshRenderer>().material = blueMaterial;
              screen1.SetActive(false);
              on = false;
             }
            }
             //  Debug.Log("Button Clicked");     
             
     }        
      }     
      
      }