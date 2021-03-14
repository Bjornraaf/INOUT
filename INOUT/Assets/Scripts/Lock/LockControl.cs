using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    private int[] result, correctCombination;

    // Start is called before the first frame update
    void Start()
    {
        result = new int[] { 5, 5, 5 };
        correctCombination = new int[] { 6, 6, 6 };
        Rotate.Rotated += CheckResults;
    }
    
    private void CheckResults(string wheelname, int number)
    {
        switch (wheelname)
        {
            case "wheel1":
                result[0] = number;
                break;

            case "wheel2":
                result[1] = number;
                break;

            case "wheel3":
                result[2] = number;
                break;
        }
        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
        {
            Debug.Log("Opened!");
        }
    }
    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    } 

}
