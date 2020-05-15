using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Phonecall2 : MonoBehaviour
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
            maintext.text = "H-Hello. I just. I was calling to say thank you. Oh gosh I'm being awkward aren't I. Look. Don't let this be weird, please? It's been so crazy lately, I. I'm just glad to have had the chance to have a normal conversation. So yeah. Thanks.";
            firstchoice.text = "Don't worry about it.";
            secondchoice.text = "Happy I could help.";
            thirdchoice.text = "I felt the same.";
        }

        if (choiceID != "0")
        {
            SceneManager.LoadScene("GameChoose2");
        }
        
    }


    public void ChoiceA()
    {

        ChooseA = true;
        ChooseB = false;
        ChooseC = false;
        choiceID = choiceID + "a";

    }

    public void ChoiceB()
    {
        ChooseA = false;
        ChooseB = true;
        ChooseC = false;
       choiceID = choiceID + "b";

    }

    public void ChoiceC()
    {
        ChooseA = false;
        ChooseB = false;
        ChooseC = true;
        choiceID = choiceID + "c";
    }

    void Endcall()
    {
        ComputerSetup.SetActive(true);
        PhoneRinger.SetActive(false);
        choiceID = "";
        SceneManager.LoadScene("LoadFinal");
    }
}
