using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrewMate_Manager : MonoBehaviour
{
    public GameObject test;
    public List<string> CrewMates;
    public List<string> CrewMatesHobbies;
    public List<string> AlienHobbies;
    public bool IsAlien;
    public string CrewHire;
    public string CrewHobbies;
    public string AlienHobbie;
 
/// sets all strings when the prebaf is made
    void Awake()
    {
        // Gets a random number and has a max from the list
        int RandomCrew = Random.Range(0,(CrewMates.Count));
        int RandomCrewHobbie = Random.Range(0,(CrewMatesHobbies.Count));
        int RandomAlienHobbie = Random.Range(0,(AlienHobbies.Count));

        // sets a random number from the list
        CrewHire = CrewMates[RandomCrew];
        CrewHobbies = CrewMatesHobbies[RandomCrewHobbie];
        AlienHobbie = AlienHobbies[RandomAlienHobbie];
        if(Random.Range(1,4) >=3)
        {
            IsAlien = true;
        }
    }

    // sends a string too anything that calls GetAnnouncement
    public string GetAnnouncement()
    {
        if (IsAlien)
        {
            return "My Name is "+CrewHire+" and My Hobbie is "+AlienHobbie;
        }else
        {
        return "My Name is "+CrewHire+" and My Hobbie is "+CrewHobbies;
        }

    }
    // sends a bool when it is called 
    public bool ifAlien()
       {
        return IsAlien;
       }  

}
    
