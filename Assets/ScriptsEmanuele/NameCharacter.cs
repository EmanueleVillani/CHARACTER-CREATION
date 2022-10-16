using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SG
{

    public class NameCharacter : MonoBehaviour
    {

        public CharacterStatsManager character;
       // public GameObject inputField;

        public TextMeshProUGUI nameButtonText;
        public TMP_InputField fieldInput;

        public void NameMyCharacter()
        {
            //character.charactername = inputField.GetComponent<Text>().text;
            character.charactername = fieldInput.GetComponent<TMP_InputField>().text;

            if (character.charactername == "")
            {
                character.charactername = "NameLess";
            }

            nameButtonText.text = character.charactername;
        }

    }

}