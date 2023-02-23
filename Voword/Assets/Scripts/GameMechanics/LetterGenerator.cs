using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterGenerator : MonoBehaviour
{
    public Button generateButton;
    public Text[] letterTiles;

    private string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

    // Start is called before the first frame update
    void Start()
    {
        // Generate random letters on the tiles
        GenerateLetters();

        // Add listener to generate button
        generateButton.onClick.AddListener(GenerateLetters);
    }

    // Function to generate random letters on the tiles
    void GenerateLetters()
    {
        // Loop through each letter tile
        for (int i = 0; i < letterTiles.Length; i++)
        {
            // Get a random letter from the letters array
            string randomLetter = letters[Random.Range(0, letters.Length)];

            // Set the text of the current letter tile to the random letter
            letterTiles[i].text = randomLetter;
        }
    }
}

