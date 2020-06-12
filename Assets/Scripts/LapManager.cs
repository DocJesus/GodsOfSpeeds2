using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapManager : MonoBehaviour
{
    public UnityStandardAssets.Vehicles.Car.CarController[] cars;

    [SerializeField]
    private float countDownCap = 3f;
    [SerializeField]
    private float adder = 1f;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = countDownCap;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            /*
            for (int i = 0; i < cars.Length; i++)
            {
            }
            */
            timeLeft = countDownCap;
        }
    }
}
