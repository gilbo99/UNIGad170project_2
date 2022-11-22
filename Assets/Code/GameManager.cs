using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{

    public GameObject TempCrew;
    public GameObject UI;
    public List<GameObject> Templist;
    public List<GameObject> ShipList;
    public List<string> SavedNames;
    int CrewNumber = 0;
    bool TempAlien;
    public TextMeshProUGUI Announce;
    public string Name;
    bool has = true;
    public int Crew1;
    public int Crew2;
    public string RemoveNameAT;
    public string RemoveNameAT2;
    

    
    // just the win state and clears everything so you automatically play again
    void Update()
    {
        if(ShipList.Count == 10)
        {   
            System.Threading.Thread.Sleep(3000);
            ShipList.Clear();
            SavedNames.Clear();
            UI.GetComponent<UISender>().EndGame();
            Announce.text = "you win, click Next in like to start again!!!";

        }
    }
    // call a new perfab and asked what its name, if alien and gets the GetAnnouncement to print to the UI
    public void NewCrew()
    {
        if (has)
        {
        GameObject Hirecrew = Instantiate(TempCrew, new Vector3(0, 0, 0), Quaternion.identity);
        Templist.Add(Hirecrew);
        Name = Hirecrew.GetComponent<CrewMate_Manager>().CrewHire;
        TempAlien = Hirecrew.GetComponent<CrewMate_Manager>().ifAlien();
        Announce.text = Hirecrew.GetComponent<CrewMate_Manager>().GetAnnouncement();
        
        has = false;     
       
        }
        
       
    }
    // saves the perfab too a list and saves it for the ui and sends it
    public void HireCrewMember()
    {
        
        
        if(TempAlien == false && has == false)
        {
        CrewNumber++;
        ShipList.Add(TempCrew);
        SavedNames.Add(Name);
        UI.GetComponent<UISender>().SaveName(Name);
        UI.GetComponent<UISender>().Recivename(Name);
        UI.GetComponent<UISender>().SetName();
        Templist.RemoveAt(0);
        has = true;
        
        }
        // It removes a random crew member from the saved list if there 2 it removes 2. sends who died to the UI as well
        if (TempAlien)
        {
            Templist.RemoveAt(0);
            if (ShipList.Count >= 1&& has == false)
            {
            Crew1 = Random.Range(0,ShipList.Count); 
            RemoveNameAT = SavedNames[Crew1];
            //hasDied.text = RemoveNameAT;
            SavedNames.RemoveAt(Crew1);
            ShipList.RemoveAt(Crew1);
            UI.GetComponent<UISender>().RemoveName(RemoveNameAT , Crew1);
            if(ShipList.Count >= 1) 
            {
                Crew2 = Random.Range(0,ShipList.Count);
                RemoveNameAT2 = SavedNames[Crew2];
                SavedNames.RemoveAt(Crew2);
                ShipList.RemoveAt(Crew2);
                UI.GetComponent<UISender>().RemoveName(RemoveNameAT2, Crew2);

            }
            }
            UI.GetComponent<UISender>().UIhasDied(RemoveNameAT, RemoveNameAT2);
            TempAlien = false;
            has = true;
        }        
    }
    // all this does is remove the gameobject from the temp list
    public void RejectCrewMember()
    {
        
        if(has == false)
        {
       Templist.RemoveAt(0);
       has = true;
        }
    }
    
    
  


    
}
