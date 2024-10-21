using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAge : MonoBehaviour
{
    public void IncreaseAge(int Age)
    {
        Age++;
        Debug.Log("Age after 1 year: " + Age);
    }

    public void IncreaseAge(int Age, int years)
    {
        Age += years;
        Debug.Log("Age after " + years + " years: " + Age);
    }

    void Start()
    {
        int age = 25;

        Debug.Log("Age: " + age);
        IncreaseAge(age);  

        int yearsToAdd = 5;
        IncreaseAge(age, yearsToAdd);  

        yearsToAdd = 10;
        IncreaseAge(age, yearsToAdd);
    }
}

