/*
Create a game similar to Hangman in which a player guesses letters to try to replicate a hidden word.
Store at least eight words in an array and randomly select one to be the hidden word.
Initially, display the hidden word using asterisks to represent each letter.
Allow the user to guess letters to replace the asterisks in the hidden word until the user completes the entire word.
If the user guesses a letter that is not in the hidden word, display an appropriate message.
If the user guesses a letter that appears multiple times in the hidden word, make sure that each correct letter is placed.

HINT
You will need to know about strings internal array
strings Contains method
strings Remove method
strings Insert method
strings Length method

*/

string[] words = new string[] {"dance","blood","music","movie","skating","basketball","laptop","engineer"};
Random random = new Random();

