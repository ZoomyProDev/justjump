using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlSelStarSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject oneButton, twoButton, threeButton, fourButton, fiveButton, sixButton, sevenButton, eightButton, nineButton, tenButton, elevenButton, twelveButton, thirteenButton, fourteenButton, fifteenButton, sixteenButton, seventeenButton, eighteenButton, nineteenButton, twentyButton;

    private Vector3 TempPos;



    private void Awake()
    {
        oneButton.transform.GetChild(0).gameObject.SetActive(false);
        oneButton.transform.GetChild(1).gameObject.SetActive(false);
        oneButton.transform.GetChild(2).gameObject.SetActive(false);

        twoButton.transform.GetChild(0).gameObject.SetActive(false);
        twoButton.transform.GetChild(1).gameObject.SetActive(false);
        twoButton.transform.GetChild(2).gameObject.SetActive(false);

        threeButton.transform.GetChild(0).gameObject.SetActive(false);
        threeButton.transform.GetChild(1).gameObject.SetActive(false);
        threeButton.transform.GetChild(2).gameObject.SetActive(false);

        fourButton.transform.GetChild(0).gameObject.SetActive(false);
        fourButton.transform.GetChild(1).gameObject.SetActive(false);
        fourButton.transform.GetChild(2).gameObject.SetActive(false);

        fiveButton.transform.GetChild(0).gameObject.SetActive(false);
        fiveButton.transform.GetChild(1).gameObject.SetActive(false);
        fiveButton.transform.GetChild(2).gameObject.SetActive(false);

        sixButton.transform.GetChild(0).gameObject.SetActive(false);
        sixButton.transform.GetChild(1).gameObject.SetActive(false);
        sixButton.transform.GetChild(2).gameObject.SetActive(false);

        sevenButton.transform.GetChild(0).gameObject.SetActive(false);
        sevenButton.transform.GetChild(1).gameObject.SetActive(false);
        sevenButton.transform.GetChild(2).gameObject.SetActive(false);

        eightButton.transform.GetChild(0).gameObject.SetActive(false);
        eightButton.transform.GetChild(1).gameObject.SetActive(false);
        eightButton.transform.GetChild(2).gameObject.SetActive(false);

        nineButton.transform.GetChild(0).gameObject.SetActive(false);
        nineButton.transform.GetChild(1).gameObject.SetActive(false);
        nineButton.transform.GetChild(2).gameObject.SetActive(false);

        tenButton.transform.GetChild(0).gameObject.SetActive(false);
        tenButton.transform.GetChild(1).gameObject.SetActive(false);
        tenButton.transform.GetChild(2).gameObject.SetActive(false);

        elevenButton.transform.GetChild(0).gameObject.SetActive(false);
        elevenButton.transform.GetChild(1).gameObject.SetActive(false);
        elevenButton.transform.GetChild(2).gameObject.SetActive(false);

        twelveButton.transform.GetChild(0).gameObject.SetActive(false);
        twelveButton.transform.GetChild(1).gameObject.SetActive(false);
        twelveButton.transform.GetChild(2).gameObject.SetActive(false);

        thirteenButton.transform.GetChild(0).gameObject.SetActive(false);
        thirteenButton.transform.GetChild(1).gameObject.SetActive(false);
        thirteenButton.transform.GetChild(2).gameObject.SetActive(false);

        fourteenButton.transform.GetChild(0).gameObject.SetActive(false);
        fourteenButton.transform.GetChild(1).gameObject.SetActive(false);
        fourteenButton.transform.GetChild(2).gameObject.SetActive(false);

        fifteenButton.transform.GetChild(0).gameObject.SetActive(false);
        fifteenButton.transform.GetChild(1).gameObject.SetActive(false);
        fifteenButton.transform.GetChild(2).gameObject.SetActive(false);

        sixteenButton.transform.GetChild(0).gameObject.SetActive(false);
        sixteenButton.transform.GetChild(1).gameObject.SetActive(false);
        sixteenButton.transform.GetChild(2).gameObject.SetActive(false);

        seventeenButton.transform.GetChild(0).gameObject.SetActive(false);
        seventeenButton.transform.GetChild(1).gameObject.SetActive(false);
        seventeenButton.transform.GetChild(2).gameObject.SetActive(false);

        eighteenButton.transform.GetChild(0).gameObject.SetActive(false);
        eighteenButton.transform.GetChild(1).gameObject.SetActive(false);
        eighteenButton.transform.GetChild(2).gameObject.SetActive(false);

        nineteenButton.transform.GetChild(0).gameObject.SetActive(false);
        nineteenButton.transform.GetChild(1).gameObject.SetActive(false);
        nineteenButton.transform.GetChild(2).gameObject.SetActive(false);

        twentyButton.transform.GetChild(0).gameObject.SetActive(false);
        twentyButton.transform.GetChild(1).gameObject.SetActive(false);
        twentyButton.transform.GetChild(2).gameObject.SetActive(false);
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("Speedrun", 0) == 1)
        {

        }
        else
        {
            if (PlayerPrefs.GetInt("Level1Stars", 0) == 1)
            {
                oneButton.transform.GetChild(0).gameObject.SetActive(true);

            }
            else if (PlayerPrefs.GetInt("Level1Stars") == 2)
            {
                oneButton.transform.GetChild(1).gameObject.SetActive(true);

            }
            else if (PlayerPrefs.GetInt("Level1Stars") == 3)
            {

                oneButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level2Stars", 0) == 1)
            {
                twoButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level2Stars") == 2)
            {
                twoButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level2Stars") == 3)
            {
                twoButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level3Stars", 0) == 1)
            {
                threeButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level3Stars") == 2)
            {
                threeButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level3Stars") == 3)
            {
                threeButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level4Stars", 0) == 1)
            {
                fourButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level4Stars") == 2)
            {
                fourButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level4Stars") == 3)
            {
                fourButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level5Stars", 0) == 1)
            {
                fiveButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level5Stars") == 2)
            {
                fiveButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level5Stars") == 3)
            {
                fiveButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level6Stars", 0) == 1)
            {
                sixButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level6Stars") == 2)
            {
                sixButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level6Stars") == 3)
            {
                sixButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level7Stars", 0) == 1)
            {
                sevenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level7Stars") == 2)
            {
                sevenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level7Stars") == 3)
            {
                sevenButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level8Stars", 0) == 1)
            {
                eightButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level8Stars") == 2)
            {
                eightButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level8Stars") == 3)
            {
                eightButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level9Stars", 0) == 1)
            {
                nineButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level9Stars") == 2)
            {
                nineButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level9Stars") == 3)
            {
                nineButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level10Stars", 0) == 1)
            {
                tenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level10Stars") == 2)
            {
                tenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level10Stars") == 3)
            {
                tenButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level11Stars", 0) == 1)
            {
                elevenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level11Stars") == 2)
            {
                elevenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level11Stars") == 3)
            {
                elevenButton.transform.GetChild(2).gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Level12Stars", 0) == 1)
            {
                twelveButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level12Stars") == 2)
            {
                twelveButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level12Stars") == 3)
            {
                twelveButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level13Stars", 0) == 1)
            {
                thirteenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level13Stars") == 2)
            {
                thirteenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level13Stars") == 3)
            {
                thirteenButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level14Stars", 0) == 1)
            {
                fourteenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level14Stars") == 2)
            {
                fourteenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level14Stars") == 3)
            {
                fourteenButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level15Stars", 0) == 1)
            {
                fifteenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level15Stars") == 2)
            {
                fifteenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level15Stars") == 3)
            {
                fifteenButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level16Stars", 0) == 1)
            {
                sixteenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level16Stars") == 2)
            {
                sixteenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level16Stars") == 3)
            {
                sixteenButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level17Stars", 0) == 1)
            {
                seventeenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level17Stars") == 2)
            {
                seventeenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level17Stars") == 3)
            {
                seventeenButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level18Stars", 0) == 1)
            {
                eighteenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level18Stars") == 2)
            {
                eighteenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level18Stars") == 3)
            {
                eighteenButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level19Stars", 0) == 1)
            {
                nineteenButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level19Stars") == 2)
            {
                nineteenButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level19Stars") == 3)
            {
                nineteenButton.transform.GetChild(2).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("Level20Stars", 0) == 1)
            {
                twentyButton.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level20Stars") == 2)
            {
                twentyButton.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("Level20Stars") == 3)
            {
                twentyButton.transform.GetChild(2).gameObject.SetActive(true);
            }
        }

        

    }


}
