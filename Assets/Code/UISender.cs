using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UISender : MonoBehaviour
{
   private string CrewName;
   private string CrewRemove;
   private string SavingName;
   public List<string> Name;
   [SerializeField] TextMeshProUGUI Name1;
   [SerializeField] TextMeshProUGUI Name2;
   [SerializeField] TextMeshProUGUI Name3;
   [SerializeField] TextMeshProUGUI Name4;
   [SerializeField] TextMeshProUGUI Name5;
   [SerializeField] TextMeshProUGUI Name6;
   [SerializeField] TextMeshProUGUI Name7;
   [SerializeField] TextMeshProUGUI Name8;
   [SerializeField] TextMeshProUGUI Name9;
   [SerializeField] TextMeshProUGUI Name10;
   [SerializeField] TextMeshProUGUI hasDied;
   [SerializeField] TextMeshProUGUI hasDied2;

   
    public void UIhasDied(string Dead,string Dead2)
    { 
        if (Dead != "")
        {
           
            hasDied.text = Dead;
            
           

        }
        if(Dead2 != "")
        {
            hasDied2.text = Dead2;
           
        }
    }
    
    
    
   
     public void SetName()
    {
        //SetVar();
        
        if(Name1.text =="")
        {
            Name1.text = CrewName; 
              

        }else if(Name2.text =="")
        {
            Name2.text = CrewName;
        }else if(Name3.text =="")
        {
            Name3.text = CrewName;
        }else if(Name4.text =="")
        {
            Name4.text = CrewName;
        }else if(Name5.text =="")
        {
            Name5.text = CrewName;
        }else if(Name6.text =="")
        {
            Name6.text = CrewName;
        }else if(Name7.text =="")
        {
            Name7.text = CrewName;
        }else if(Name8.text =="")
        {
            Name8.text = CrewName;
        }else if(Name9.text =="")
        {
            Name9.text = CrewName;
        }else if(Name10.text =="")
        {
            Name10.text = CrewName;
        }
      

    }

    // Update is called once per frame
    public void SaveName(string Save)
    {
        SavingName = Save;
        Name.Add(SavingName);
    }


    public void Recivename(string Name)
    {
        CrewName = Name;
        
        
    }
    public void RemoveName(string Crew)
    {
         

        if(Name1.text ==Crew)
        {
            Name1.text = ""; 
              

        }else if(Name2.text ==Crew)
        {
            Name2.text = "";
        }else if(Name3.text ==Crew)
        {
            Name3.text = "";
        }else if(Name4.text ==Crew)
        {
            Name4.text = "";
        }else if(Name5.text ==Crew)
        {
            Name5.text = "";
        }else if(Name6.text ==Crew)
        {
            Name6.text = "";
        }else if(Name7.text ==Crew)
        {
            Name7.text = "";
        }else if(Name8.text ==Crew)
        {
            Name8.text = "";
        }else if(Name9.text ==Crew)
        {
            Name9.text = "";
        }else if(Name10.text ==Crew)
        {
            Name10.text = "";
        }


        

    }

    public void EndGame()
    {

        
        Name1.text = "";
        Name2.text = "";
        Name3.text = "";
        Name4.text = "";
        Name5.text = "";
        Name6.text = "";
        Name7.text = "";
        Name8.text = "";
        Name9.text = "";
        Name10.text = "";
    }

   
    

       


}
