using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timerScript : MonoBehaviour
{
    public float resetTime = 0;
    public Text timerText;
    public Text savedTimeText;
    public float savedTiming;
    public float timing;
    public GameObject ObjectifManager;
    public GameObject GameShapes;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            savedTiming = timing;
            timing = resetTime;
            savedTimeText.text = ("Bravo tu as fini en " + savedTiming + " secondes");
            ObjectifManager.GetComponent<ChooseShape>().ResetShapeFunction();
            ObjectifManager.GetComponent<ChooseShape>().selectedShape.GetComponent<ChooseColor>().ChooseColorShape();
            //GameShapes.GetComponent<ChooseShape>().ResetShapeFunction();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ObjectifManager.GetComponent<ChooseShape>().ResetShapeFunction();
            ObjectifManager.GetComponent<ChooseShape>().selectedShape.GetComponent<ChooseColor>().ChooseColorShape();

        }

        Timing();
    }

    private void Timing()
    {
        timing += Time.deltaTime;
        timerText.text = (timing + "secondes");
    }
}
