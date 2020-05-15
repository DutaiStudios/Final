using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Phonecall1 : MonoBehaviour
{
    [SerializeField] Text maintext;
    [SerializeField] Text firstchoice;
    [SerializeField] Text secondchoice;
    [SerializeField] Text thirdchoice;
    public bool startext = true;
    public bool callended = false;
    [SerializeField] bool ChooseA = false;
    [SerializeField] bool ChooseB = false;
    [SerializeField] bool ChooseC = false;
    public string choiceID = "0";
    public static int convoneoutcome;
    private bool textlock = false;
    // 1 = friendly. 2 = awkward. 3 = faux professional. 4 = inflammatory. 
    public int convnum = 0;

    [SerializeField] GameObject PhoneRinger;
    [SerializeField] GameObject ComputerSetup;

    void Start()
    {
        maintext.text = "...";
        firstchoice.text = "Hello?";
        secondchoice.text = "Hi. Who is this?";
        thirdchoice.text = "[...]";
    }

    void Update()
    {
        TextDistr();
    }



    public void ChoiceA()
    {
        startext = false;
        ChooseA = true;
        ChooseB = false;
        ChooseC = false;
        choiceID = choiceID +"a";
        convnum++;
    }

    public void ChoiceB()
    {
        ChooseA = false;
        ChooseB = true;
        ChooseC = false;
        startext = false;
        choiceID = choiceID + "b";
        convnum++;
    }

    public void ChoiceC()
    {
        ChooseA = false;
        ChooseB = false;
        ChooseC = true;
        startext = false;
        choiceID = choiceID + "c";
        convnum++;
    }


    void TextDistr()
    {

        if (startext == false && textlock == false)
        {
            maintext.text = "“Hi. I’m calling about my delivery? I got a grocery dropoff earlier today, but I think you mispacked. I wasn’t given a receipt, but I was supposed to receive two more boxes of the non-perishables, I got charged for a triple load but I definitely didn’t get the amount that was advertised. Is there a second delivery being made today, or can I get the remaining tomorrow? I can provide my name and address-”";
            firstchoice.text = "I think you have the wrong number.";
            secondchoice.text = "This is an apartment. We don't deliver.";
            thirdchoice.text = "Do you have your receipt?";
            choiceID = "0";
            textlock = true;
            startext = true;
        }

        if (choiceID == "0a" || choiceID == "0b")
        {
            choiceID = "0a";
            maintext.text = "Hmm? No I’m, I’m pretty sure I dialed the right number… God is that a seven or a one? And am I- I’m sorry, you’re right, I must’ve misread my own handwriting.";
            firstchoice.text = "It happens to the best of us, I guess.";
            secondchoice.text = "Isn't reading one's own handwriting supposed to be easy?";
            thirdchoice.text = "Sounds like you ordered a lot of food.";

        }

        if (choiceID == "0ac")
        {
            maintext.text = "Oh. Yeah, I guess. I'm not panic buying if that's what you're implying. My grandparents live with me, I need to be able to feed them both. Being the breadwinner is hard work.";
            firstchoice.text = "They must have quite the appetite!";
            secondchoice.text = "Makes sense. [HANGUP]";
            thirdchoice.text = "Well, hopefully your delivery comes soon.";
        }

        if (choiceID == "0aca")
        {
            maintext.text = "I don't have to explain myself to you. I don't have to explain myself to anyone, that's why I got food delivered instead of just going to the store.";
            firstchoice.text = "So the stores being closed had nothing to do with it?";
            secondchoice.text = "Jeeze, touchy. I was only joking.";
            thirdchoice.text = "Well I hope they enjoy their boxes and boxes of food. [HANGUP]";
        }

        if (choiceID == "0acaa" || choiceID == "0acab")
        {
            choiceID = "0acaa";
            maintext.text = "Yeah let's not jump down this rabbit hole. I get that you're probably bored, locked inside and all that, but so am I and I'm managing to not taunt random strangers on the line.";
            firstchoice.text = "Hey, it's not like I called you. [HANGUP]";
            secondchoice.text = "Fair point. But if you didn't want to talk, why are you still on the line? You know this is the wrong number. [HANGUP]";
            thirdchoice.text = "Gotta stay occupied in quarantine somehow. But if you're not batting, I won't pitch. [HANGUP]";
        }

        if (choiceID == "0acaaa" || choiceID == "0acaab" || choiceID == "0acaac")
        {
            Endcall();
            convoneoutcome = 1;
        }

        if (choiceID == "0acac")
        {
            Endcall();
            convoneoutcome = 2;
        }
        if (choiceID == "")

        if (choiceID == "0acb")
        {
            Endcall();
            convoneoutcome = 2;
        }

        if (choiceID == "0aa" || choiceID == "0ab")
        {
            choiceID = "0aa";
            maintext.text = "Haha. I suppose you're right. Sorry for bothering you.";
            firstchoice.text = "Don't worry about it. Enjoy your day. [HANGUP]";
            secondchoice.text = "No harm no foul. And, if I'm being honest, I'd take any sort of distraction I can get these days.";
            thirdchoice.text = "No problem, just work on that handwriting, okay? Consider it your newest at-home assignment.";
        }

        if (choiceID == "0aac")
        {
            maintext.text = "I'm sorry professor, but I just- I feel I need to drop your class. It's not you, it's me. I just- I don't really have the time for this kind of committment right now.";
            firstchoice.text = "Good riddance! [HANGUP]";
            secondchoice.text = "There's always time for schoolwork! I'll be seeing you in detention! [HANGUP]";
            thirdchoice.text = "What, is my class not interesting to you?";
        }

        if (choiceID == "0aaca" || choiceID == "0aacb")
        {
            Endcall();
            convoneoutcome = 1;
        }

        if (choiceID == "0aacc")
        {
            maintext.text = "I'm sorry professor, but it's best you hear it from me...I'm wildly in love with your rival teacher. It was love at first sight, she totally captivated me. She's my Romeo. I'm dropping out of your class to join hers.";
            firstchoice.text = "You're leaving me...for her? Oh no, this is just like my kids all over again...";
            secondchoice.text = "I will never forgive you. [HANGUP]";
            thirdchoice.text = "I eagerly await hearing about your double suicide on the local news. Farewell, my dear Juliet. [HANGUP]";
        }

        if (choiceID == "0aacca")
        {
            maintext.text = "I'm sorry professor, but it's best you hear it from me...I'm wildly in love with your rival teacher. It was love at first sight, she totally captivated me. She's my Romeo. I'm dropping out of your class to join hers.";
            firstchoice.text = "You're leaving me...for her? Oh no, this is just like my kids all over again...";
            secondchoice.text = "I will never forgive you. [HANGUP]";
            thirdchoice.text = "I eagerly await hearing about your double suicide on the local news. Farewell, my dear Juliet. [HANGUP]";
        }

        if (choiceID == "0aaccaa")
        {
            maintext.text = "Yes, I'm aware, I'll be moving in with your children. We're already on first name basis. Face it, I'm replacing you.";
            firstchoice.text = "If you do replace me, do I get your delivery? [HANGUP]";
            secondchoice.text = "This really is the endtimes. Tell my kids I hate them. [HANGUP]";
            thirdchoice.text = "Jokes on you, if you take over my life, all you get is a studio apartment and crippling student debt. [HANGUP]";
        }

        if (choiceID == "0aaccaaa" || choiceID == "0aaccaab" || choiceID == "0aaccaac")
        {
            Endcall();
            convoneoutcome = 1;
        }

        if (choiceID == "0aaccb" || choiceID == "0aaccc")
        {
            Endcall();
            convoneoutcome = 2;
        }

        if (choiceID == "0aaa")
        {
            Endcall();
            convoneoutcome = 2;
        }

        if (choiceID == "0aab" || choiceID == "0aab")
        {
            maintext.text = "Right? Quarantine is killing me. The reason I didn't realize the delivery guy forgot more than half my stuff is because I was so starved for conversation. Suffice to say not only was he not very talkative, he wasn't very observant either.";
            firstchoice.text = "I mean, he probably thought you were hitting on him.";
            secondchoice.text = "I've started talking to the furniture myself. Of course, don't tell the ceiling fan, he tends to...spin...tall tales. If you catch my drift.";
            thirdchoice.text = "Of course, essential workers are only a step or so away from being actual zombies. My neighbor's kid is grocery store cashier, I don't think he's slept since lockdown started.";
        }

        if (choiceID == "0aaba")
        {
            maintext.text = "Naturally. I was especially attracted to his missing fingers, it's a real turn on for me. His right hand looked like a snail with an extra...are those antennae?";
            firstchoice.text = "I'm actually missing my left thumb myself.";
            secondchoice.text = "As a Malacologist, I can inform you with a degree of relative certainty that they are tentacles with eyes at the end. Although antennae is not technically innaccurate.";
            thirdchoice.text = "I hate snails.";
        }

        if (choiceID == "0aabaa")
        {
            maintext.text = "You're joking.";
            firstchoice.text = "I'm missing a mouth too.";
            secondchoice.text = "It was a tiger attack.";
            thirdchoice.text = "I'm sorry to inform you that I don't have any discernable sense of humor.";
        }

        if (choiceID == "0aabab")
        {
            maintext.text = "You're joking.";
            firstchoice.text = "I'm missing a mouth too.";
            secondchoice.text = "It was a tiger attack.";
            thirdchoice.text = "I'm sorry to inform you that I don't have any discernable sense of humor.";
        }

        if (choiceID == "0aabaaa" || choiceID == "0aabaab" || choiceID == "0aabaac")
        {
            choiceID = "0aabaaa";
            maintext.text = "Very funny. I, personally, am a petrapeligic.";
            firstchoice.text = "Well I'm not real. I'm just a figment of your mind, conjured to distract from how bored you are.";
            secondchoice.text = "Well I'm dead. You have to let me go, the crash wasn't your fault.";
            thirdchoice.text = "That's a lot of -legic's. What was it, tiger attack?";
        }

        if (choiceID == "0aabaaaa" || choiceID == "0aabaaab" || choiceID == "0aabaaac")
        {

            maintext.text = "Maybe. Let's not dwell on the topic, lest the whole plot come crashing down.";
            firstchoice.text = "Then you should tell your service monkey to hang up, and dial the right number this time. [HANGUP]";
            secondchoice.text = "Well, then I wish you a fond afternoon and hope that your remaining shipment arrives in a timely enough manner. [HANGUP]";
            thirdchoice.text = "Best of luck in that case. And don't accidentally hit on the delivery guy this time. [HANGUP]";
        }

        if (choiceID == "0aabaaaaa" || choiceID == "0aabaaabb" || choiceID == "0aabaaacc")
        {
            Endcall();
            convoneoutcome = 3;
        }

        if (choiceID == "0c")
        {
            maintext.text = "Like I said, I wasn’t given a receipt. I was told it’d be in the delivery box, but I’m missing more than half of them. Can’t you look up my order in the system? I can- I can give my name, and I think I have the name of the gentleman who made the delivery earlier. You know, I just- I paid for my order, I don’t wanna cause any trouble, I only want what I’ve already been charged for.";
            firstchoice.text = "I'm sorry, the system is down right now. If you don't have a receipt-";
            secondchoice.text = "That's no concern of mine. What did you think was gonna happen without a receipt?";
            thirdchoice.text = "I'm sorry, this was a bit cruel, I'll admit. Honestly, this is an apartment, you've got the wrong number. Sorry for...That was a mean joke.";
        }

        if (choiceID == "0ca")
        {
            maintext.text = "Well, who do I talk to then? It’s not like your service is cheap, you marked me up- thirty percent? Fourty? That’s a pretty hefty cost for some soup cans and rice bags. Is there a manager you can transfer me to? What about the delivery driver? Give me his number, the receipt has got to be in one of my undelivered boxes.";
            firstchoice.text = "I'm afraid I'm not authorized to give out the personal information of our employees. If what you say is true, we can confirm it when he arrives at the warehouse later today.";
            secondchoice.text = "Of course. Would you mind if I put you on hold while I find his information? [HANGUP]";
            thirdchoice.text = "I'm sorry, I'm afraid our delivery truck was in an accident earlier this afternoon, the driver is currently at the hospital...";
        }

        if (choiceID == "0cab")
        {
            Endcall();
            convoneoutcome = 4;
        }

        if (choiceID == "0cac")
        {
            maintext.text = "A car accident? Sure, yeah, he probably ran right into all those invisible commuters. The roads are dead. If you're gonna lie to me, at least try a little harder, asshole.";
            firstchoice.text = "Fine, I'll come clean. You called the wrong number.";
            secondchoice.text = "Heh. N-No, it's, umm, it's true. The accident. It was horrible. He may never recover. He is also my brother. And my lover. I'm really very torn up about the whole affair. I am carrying his child, after all. [HANGUP]";
            thirdchoice.text = "Look, if you don't want to believe me that's fine. I'm telling you though, the accident was really terrible, he's in really bad shape, last I heard.";
        }

        if (choiceID == "0caca")
        {
            choiceID = "0a";
        }

        if (choiceID == "0cacb")
        {
            Endcall();
            convoneoutcome = 4;
        }

        if (choiceID == "0cacc")
        {
            maintext.text = "Oh, really then? If you don't mind me asking, what was his name again?";
            firstchoice.text = "It was. Um. Michael. Michael McDoesn'tExist. [HANGUP]";
            secondchoice.text = "Why, he was Abe Froman of course! He was wearing a leatherjacket, white t-shirt- devastatingly handsome, that man. [HANGUP]";
            thirdchoice.text = "How dare you question my honor! I demand a duel, pistols at dawn, six feet apart, as is socially responsible. [HANGUP]";
        }

        if (choiceID == "0cacca" || choiceID == "0caccb" || choiceID == "0caccc")
        {
            Endcall();
            convoneoutcome = 4;

        }
        if (choiceID == "0caa")
        {
            maintext.text = "That's- reasonable. I suppose in your shoes, I wouldn't want my number out to a bunch of strangers either. The delivery trucks rounds are probably finishing up in a few hours, right? I'll call back and see if I can't catch it at the warehouse so you can contact the driver directly.";
            firstchoice.text = "I'm sorry I can't do more to assist you. I hope you enjoy the rest of your day. [HANGUP]";
            secondchoice.text = "Don't worry, we'll call you. I hope you enjoy the remainder of your afternoon. [HANGUP]";
            thirdchoice.text = "Listen, I should come clean. This is a residential number, I have no idea what you're talking about...";
        }

        if (choiceID == "0caaa" || choiceID == "0caab")
        {
            Endcall();
            convoneoutcome = 3;
        }

        if (choiceID == "0caac" || choiceID == "0cc")
        {
            choiceID = "0a";
        }

        if (choiceID == "0cb")
        {
            maintext.text = "I- I'm sorry, I must have misheard you. Would you care to repeat yourself?";
            firstchoice.text = "Of course, your majesty. Would you care for me to kiss your boots while I do?";
            secondchoice.text = "Oh I think you heard me clear enough.";
            thirdchoice.text = "I'm sorry, that was rude of me. Let me make it up to you this way- [HANGUP]";
        }

        if (choiceID == "0cba" || choiceID == "0cbb")
        {
            choiceID = "ocba";
            maintext.text = "You know what? I think I'll call back later when someone more...suited to customer service is working the lines. Have a nice day, douche.";
            firstchoice.text = "Please enjoy your day! [HANGUP]";
            secondchoice.text = "I'll be sure to enjoy your lost shipment in the meantime. [HANGUP]";
            thirdchoice.text = "Wait, would you be willing to fill out a customer survey regarding my service? [HANGUP]";
        }

        if (choiceID == "0cbc" || choiceID == "0cbaa" || choiceID == "0cbab" || choiceID == "0cbac" || choiceID == "0cbba" || choiceID == "0cbbb" || choiceID == "0cbbc")
        {
            Endcall();
            convoneoutcome = 4;
        }

    }


    void Endcall()
    {
        ComputerSetup.SetActive(true);
        PhoneRinger.SetActive(false);
        choiceID = "";
        SceneManager.LoadScene("GoToPlay");

    }
}
