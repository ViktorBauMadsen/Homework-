using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_1 : MonoBehaviour
{
    void Start()
    {
        string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        foreach (string day in weekDays)
        {
            switch (day)
            {
                case "Monday":
                    Debug.Log("Monday: Read PBL book.");
                    break;
                case "Tuesday":
                    Debug.Log("Tuesday: Work on P1 project.");
                    break;
                case "Wednesday":
                    Debug.Log("Wednesday: Read book on c#.");
                    break;
                case "Thursday":
                    Debug.Log("Thursday: Group meeting.");
                    break;
                case "Friday":
                    Debug.Log("Friday: Go to Fredagsbar at AAU.");
                    break;
                case "Saturday":
                    Debug.Log("Saturday: Rest.");
                    break;
                case "Sunday":
                    Debug.Log("Sunday: Rest.");
                    break;
            }
        }
    }
}
