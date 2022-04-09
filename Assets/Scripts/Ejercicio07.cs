using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio07 : MonoBehaviour
{
    public static int num1, num2, num3;
    public int[] nums = new int[] { num1, num2, num3 };
    // Start is called before the first frame update
    void Start()
    {
        int largest = nums[0];
        for (int big = 1; big < nums.Length; big++)
        {
            if (largest < nums[big])
            {
                largest = nums[big];
            }
        }

        Debug.Log(largest);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
