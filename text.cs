// Create conditions for each win and tie scenario
// write a method that takes 2 inputs XX
// write a method that determines winner
// write a method that determines player
// create a class?? that holds win values of each 'Play'

//Rock v. Scissors = Rock wins
//Rock v. Paper = Paper wins
//Paper v. Scissors = Scissors wins

You are correct. The current implementation of the UserInputOption method only considers the two player cases, but it doesn't handle the case where the computer wins. To fix this issue, you can modify the code in the UserInputOption method to check if the input2 parameter is empty, and if it is, compare the user's input (input1) with the computer's input (input3). Here is the modified code

With this modification, the UserInputOption method should correctly handle all three cases (two human players, one human player and the computer, and two computer players) and return the correct winner.