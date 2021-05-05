using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{

    //public TextMeshProUGUI myTextField;
    public Image DiceArea_1;
    public Image DiceArea_2;
    public Image DiceArea_3;
    public Image Button1;

    public void BtnAction()
    {

        //Loop the 3 Dice Areas
        for (int i = 1; i < 4; i++)
        {
            // If Dice Are Is NOT locked then change the face

            switch (i)
            {
                case 1:
                    DiceArea_1.sprite = Resources.Load<Sprite>("Sprites/1-" + PickRandomNumber());
                    break;
                case 2:
                    DiceArea_2.sprite = Resources.Load<Sprite>("Sprites/1-" + PickRandomNumber());
                    break;
                case 3:
                    DiceArea_3.sprite = Resources.Load<Sprite>("Sprites/1-" + PickRandomNumber());
                    break;
                default:
                    //Default..Do Nothing
                    break;
            }
            
        }


    }

    private string PickRandomNumber()
    {
 
        int randomNum = Random.Range(1, 3);
        //myTextField.text = "1-" + randomNum.ToString();
        return randomNum.ToString();

    }

}
