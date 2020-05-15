using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Prologue : MonoBehaviour
{

    [SerializeField] Text maintext;
    [SerializeField] Text ButtonA;
    [SerializeField] Text ButtonB;
    [SerializeField] Text DayText;

    private bool ChoiceResetNeed = false;
    public int choicepick;
    private bool opset = false;
    public bool ChoiceAPick;
    public bool ChoiceBPick;
    private int Day;

    void Start()
    {
        Day = 0;
    }

    void Update()
    {
        DayText.text = "Day " + Day;
        if (Day == 0)
        {
            PrologueText();
        }
        if (Day == 1)
        {
            Day1();
        }
        if (Day == 7)
        {
            Day2();
        }

        if (Day == 19)
        {
            Day3();
        }

        if (Day == 26)
        {
            Day4();
        }

        if (Day == 30)
        {
            SceneManager.LoadScene("Apartment1");
        }

    }

    void PrologueText()
    {
        if (opset == false)
        {
            maintext.text = "You wake up cold. You were dreaming about something, the memory, flickering like an ember, is quickly snuffed by the chill. What were you dreaming about? Something inside of you thinks fondly towards the fleeted fantasy, but your conscious mind has entirely deserted it.\n\nYou shiver. The blankets above you are thin, but there are many of them. The bed beneath you is rigid, but it’s softer than the floor.";
            ButtonA.text = "Check the time.";
            ButtonB.text = "Fall back asleep.";
        }


        if (ChoiceAPick == true && choicepick == 1)
        {
            maintext.text = "	Your trembling fingers fumble beneath your pillow; blankets shift as your palm brushes against a frigid item. The screen light is blinding, your eyes reflexively squint, an iota of moisture forms behind your lids as they adjust to the illumination. It’s barely 1 AM.";
            ButtonA.text = "Check your messages.";
            ButtonB.text = "Fall back asleep.";
            opset = true;

        }

        else if (ChoiceBPick == true)
        {
            ChoiceResetNeed = true;
            Day = 1;
        }

        if (opset == true && ChoiceAPick == true && choicepick == 2)
        {

            maintext.text = "There is one unread message. Your heartbeat shudders as fingers run against the cold screen.\n\nCOUPON\nCITY GROCER: BUY ONE GET ONE FREE\nALL MARKED ITEMS\n\nThis aside, you have no messages.";
            ButtonA.text = "Fall back asleep";
            ButtonB.text = "Fall back asleep.";
        }

        if (choicepick == 3)
        {
            ChoiceResetNeed = true;
            Day = 1;
        }


    }
    public void ChoiceA()
    {
        ChoiceAPick = true;
        choicepick += 1;
    }

    public void ChoiceB()
    {
        ChoiceBPick = true;
        choicepick += 1;
    }

    void ChoiceReset()
    {
        if (ChoiceResetNeed == true)
        {
            ChoiceBPick = false;
            ChoiceAPick = false;
            choicepick = 0;
            ChoiceResetNeed = false;
        }
        else
        {

        }

    }

    void Day1()
    {
        ChoiceReset();
        Day = 1;
        maintext.text = "There is a siren outside. It waxes and wanes throughout the day; moments of silence are scarce. The daytime sun has done nothing to stave the winter chill, the thermostat, a beige box on an empty wall, hung precariously. You don't dare touch it.";
        ButtonA.text = "Call a family member.";
        ButtonB.text = "Call a friend.";

        if (ChoiceAPick == true && choicepick == 1)
        {
            maintext.text = "The dial tone is loud in your ear. In the background, the sirens loom. It rings, again and again, the harsh tone broken by brief respites of silence. The ringing stops. No human voice emerges from the receiver.\n\n “We’re sorry.” The phone says. “The number you are trying to reach has a voicemail box that-”\n\nYou lower your phone, and the call terminates.\n\nOutside, the city yells.";
            ButtonA.text = "Check the news.";
            ButtonB.text = "Take a nap.";
            ChoiceBPick = false;
        }

        if (ChoiceBPick == true && choicepick == 1)
        {
            maintext.text = "The dial tone is loud in your ear. In the background, the sirens loom. It rings, again and again, the harsh tone broken by brief respites of silence. The ringing stops. No human voice emerges from the receiver.\n\n “We’re sorry.” The phone says. “The number you are trying to reach has a voicemail box that-”\n\nYou lower your phone, and the call terminates.\n\nOutside, the city yells.";
            ButtonA.text = "Check the news.";
            ButtonB.text = "Take a nap.";
            ChoiceAPick = false;
        }

        if (ChoiceAPick == true && choicepick == 2)
        {
            maintext.text = "Two faces, hardly dissimilar, sit a length apart. Their suits are dark, but their expressions cheery. Their cheeks curve upwards into some strange imitation of a smile.\n\n				“The new guidelines set in place by the city are expected to last at least until the end of the month. In the meantime, residents are encouraged to-”\n\nYour connection falters; the faces freeze, trapped within their false grins before resuming, monotonous tone unchanged.";
            ButtonA.text = "Take a nap";
            ButtonB.text = "Take a nap.";
            ChoiceBPick = false;
        }

        if (ChoiceBPick == true && choicepick == 2)
        {
            Day = 7;
            ChoiceResetNeed = true;
        }

        if (ChoiceBPick == true && choicepick == 3)
        {
            Day = 7;
            ChoiceResetNeed = true;
        }

        if (ChoiceAPick == true && choicepick == 3)
        {
            Day = 7;
            ChoiceResetNeed = true;
        }
    }

    void Day2()
    {
        ChoiceReset();
        Day = 7;
        maintext.text = "The sirens continue, unabated. Long, harsh wails have become the characteristic atmosphere of the outside. The cold lifted somewhat the day prior but now returned with a vengeance, transforming your breath into brief, wispy clouds against the barren scape of your home. The light was waning from the windows as night swiftly fell. You, however, had only recently awakened.";
        ButtonA.text = "Eat.";
        ButtonB.text = "Exercise.";

        if (ChoiceAPick == true && choicepick == 1)
        {
            maintext.text = "The food is cold and rubbery. You have no fridge, so instead, you place your items against the open window. The pipes groan at night, some mornings they rattle, but you preserve hope that they won’t burst. You wash down your meal with water, lukewarm, from the sink. It feels slimy in your mouth and makes your innards feel unclean.";
            ButtonA.text = "Exercise";
            ButtonB.text = "Lie Down";
            ChoiceBPick = false;

            if (ChoiceAPick == true)
            {
                maintext.text = "You stand. Your vision feels off-kilter as your legs bend beneath you. Your arms stretch back to compensate, then swing forward as your calves burn and your head elevates once more. You repeat this plodding task for some time until the thick beads of sweat begin to roll down your second chin and the base of your head is utterly moistened. Your stomach churns, unsettled. The bottom of your throat feels like burning tar.";
                ButtonA.text = "Lie Down.";
                ButtonB.text = "Lie Down.";
                ChoiceAPick = false;
            }
        }

        if (ChoiceBPick == true && choicepick == 1)
        {
            maintext.text = "You stand. Your vision feels off-kilter as your legs bend beneath you. Your arms stretch back to compensate, then swing forward as your calves burn and your head elevates once more. You repeat this plodding task for some time until the thick beads of sweat begin to roll down your second chin and the base of your head is utterly moistened. Your stomach feels both empty and unsettled.";
            ButtonA.text = "Eat.";
            ButtonB.text = "Lie Down.";
            ChoiceAPick = false;

            if (ChoiceAPick == true)
            {
                maintext.text = "The food is cold and rubbery. You have no fridge, so instead, you place your items against the open window. The pipes groan at night, some mornings they rattle, but you preserve hope that they won’t burst. You wash down your meal with more than a few gulps of water, lukewarm, from the sink. It feels slimy in your mouth and makes your innards feel unclean. In spite of this, you drink a fair amount. Your fingers run gingerly over your stomach, you feel bloated.";
                ButtonA.text = "Lie Down.";
                ButtonB.text = "Lie Down.";
                ChoiceAPick = false;
            }
        }

        if (ChoiceAPick == true && choicepick == 2)
        {
            maintext.text = "The food is cold and rubbery. You have no fridge, so instead, you place your items against the open window. The pipes groan at night, some mornings they rattle, but you preserve hope that they won’t burst. You wash down your meal with water, lukewarm, from the sink. It feels slimy in your mouth and makes your innards feel unclean.";
            ButtonA.text = "Lie Down.";
            ButtonB.text = "Lie Down.";
            ChoiceBPick = false;
        }

        if (ChoiceBPick == true && choicepick == 2)
        {
            maintext.text = "The ceiling is dull, there is no pattern, nor is there any appealing dose of the disorder. It is a simple, grey slate, utterly untouched and unmanaged. A breeze rolls in from the city outside, your skin becomes clammy as the sweat accrued from your workout transforms into another bitter chill. You reach for a blanket, thin as they may all be, but find yourself more uncomfortable beneath it.";        
            ButtonA.text = "Close your eyes.";
            ButtonB.text = "Close your eyes.";
            ChoiceAPick = false;
        }

        if (choicepick == 3)
        {
            
            maintext.text = "The ceiling is dull, there is no pattern, nor is there any appealing dose of the disorder. It is a simple, grey slate, utterly untouched and unmanaged. A breeze rolls in from the city outside, your skin becomes clammy as the sweat accrued from your workout transforms into another bitter chill. You reach for a blanket, thin as they may all be, but find yourself more uncomfortable beneath it.";
            ButtonA.text = "Close your eyes.";
            ButtonB.text = "Close your eyes.";
        }

        if (choicepick == 4)
        {
            ChoiceResetNeed = true;
            Day = 19;
        }
    }

    void Day3()
    {
        ChoiceReset();
        maintext.text = "There is no alarm. The sirens are silent, the grey exterior, once a bustling city, is still and lifeless. Buildings are darkened, any windows with some semblance of occupation are lethargic. Silhouettes are a rare sighting, a passerby on the street is rarer still. You wake when your body wakes, and when the urge arises, you sleep. The days are silent.";
        ButtonA.text = "Wait.";
        ButtonB.text = "Wait.";

        if (choicepick == 1)
        {
            Day = 26;
            ChoiceResetNeed = true;
        }
    }

    void Day4()
    {
        ChoiceReset();
        maintext.text = "	You hear your own voice. A part of you shudders, it’s been some time since you’ve spoken. A tiny part of your mind, the world therein as grey and faded as the city streets, forgets for a faint second that you can speak. You open your mouth as if to respond to the words of another, but suddenly recall that you are alone. You look towards the window; the sun is rising.\n\nAnd you lay calmly back to sleep.";
        ButtonA.text = "Sleep.";
        ButtonB.text = "Sleep.";

        if (choicepick == 1)
        {
            Day = 30;
        }
    }
}
