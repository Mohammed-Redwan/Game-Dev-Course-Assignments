using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingGame : MonoBehaviour
{
    public RaceState raceState;
    public void SimulateRace()
    {
        switch (raceState)
        {
            case RaceState.Start:
                Debug.Log("Race is begin!");
                break;
            case RaceState.Accelerate:
                Debug.Log("You press the gas pedal. The car speeds up!");
                break;
            case RaceState.Turn:
                Debug.Log("You approach a sharp turn. Be carful not to crash!");
                break;
            case RaceState.Crash:
                Debug.Log("You hit a barrier. The race is over.");
                break;
            case RaceState.Finish:
                Debug.Log("You crossed the finish line. Well done!!");
                break;
            default:
                Debug.Log("This state is not defined. Something is worng.");
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SimulateRace();
    }
}
