using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_2 : MonoBehaviour
{
    void Start()
    {
        string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        foreach (string day in weekDays)
        {
            if (day == "Monday")
            {
                Debug.Log("Monday: Read PBL book.");
            }
            else if (day == "Tuesday")
            {
                Debug.Log("Tuesday: Work on P1 project.");
            }
            else if (day == "Wednesday")
            {
                Debug.Log("Wednesday: Read book on c#.");
            }
            else if (day == "Thursday")
            {
                Debug.Log("Thursday: Group meeting.");
            }
            else if (day == "Friday")
            {
                Debug.Log("Friday: Go to Fredagsbar at AAU.");
            }
            else if (day == "Saturday")
            {
                Debug.Log("Saturday: Rest.");
            }
            else if (day == "Sunday")
            {
                Debug.Log("Sunday: Rest.");
            }
        }
    }
}