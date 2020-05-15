using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Phonecall3 : MonoBehaviour
{

    [SerializeField] Text maintext;
    [SerializeField] Text firstchoice;
    [SerializeField] Text secondchoice;
    [SerializeField] Text thirdchoice;
    [SerializeField] Phonecall1 pc1;
    [SerializeField] bool ChooseA = false;
    [SerializeField] bool ChooseB = false;
    [SerializeField] bool ChooseC = false;
    public string choiceID = "0";
    public int callstart;

    [SerializeField] GameObject PhoneRinger;
    [SerializeField] GameObject ComputerSetup;
    // Start is called before the first frame update
    void Start()
    {

        callstart = 1;
            //= Phonecall1.convoneoutcome;
    }

    // Update is called once per frame
    void Update()
    {
        if (callstart == 1)
        {
            maintext.text = "Can we go outside yet?";
            firstchoice.text = "Yes";
            secondchoice.text = "No";
            thirdchoice.text = "Maybe";
        }

        if (callstart == 2)
        {
            Endcall();
        }
    }


    public void ChoiceA()
    {

        callstart = 2;

    }

    public void ChoiceB()
    {

        callstart = 2;

    }

    public void ChoiceC()
    {

        callstart = 2;
    }

    void Endcall()
    {

        Application.Quit();
    }
}
