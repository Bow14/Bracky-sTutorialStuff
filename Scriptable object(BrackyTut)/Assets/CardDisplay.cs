using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    
    //https://www.youtube.com/watch?v=aPXvoWVabPY
    // Start is called before the first frame update
    
    
    public Card card;

    public Text nameText;
    public Text descriptitonText;

    public Image artworkImage;

    public Text manaText;
    public Text attackText;
    public Text healthText;
    void Start()
    {
        nameText.text = card.name;
        descriptitonText.text = card.description;

        artworkImage.sprite = card.artwork;

        manaText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();


    }

 
}
