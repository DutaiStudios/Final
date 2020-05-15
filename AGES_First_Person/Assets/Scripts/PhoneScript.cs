using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PhoneScript : MonoBehaviour
{

    [SerializeField] GameObject glow;
    [SerializeField] GameManager gm;
    [SerializeField] Animation glowstrobe;
    public bool oncurcall = false;
    public bool choi1 = false;
    public bool choi2 = false;
    public bool choi3 = false;
    bool needschoice = false;
    public int curconv = 1;
    private int poschoice;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (oncurcall == true)
        {
            call();
        }
    }

    void call()
    {
        if (curconv == 1)
        {
            Conv1();
        }
        if (curconv == 2)
        {

        }
        if (curconv == 3)
        {

        }
        if (curconv == 4)
        {

        }
    }

    public void ChooseA()
    {
        choi1 = true;
    }


    public void ChooseB()
    {
        choi2 = true;
    }


    public void ChooseC()
    {
        choi3 = true;
    }

    void ChoiceReset()
    {

    }

    void Conv1()
    {

    }

}
