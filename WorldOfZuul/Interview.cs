using static System.Console;
using Spectre.Console;

//INTERVIEW ORDER
//
//INTRODUCTION
//
//LOOP-->
//1. ASK QUESTION
//2. WAIT FOR RESPONSE
//3. EVALUATE RESPONSE BASED ON VARIABLES
//4. PRESENT NEW QUESTION (CONSTANT FOR NOW, VARIABLE LATER)

public class Interview {
    public required List<Prompt> Questions;
    public static readonly string[] ResponseOptions = {"Formal","Casual","Assertive","Passive"}; // SHOULD BE 0123 THEORETICALLY BUT LEFT IT LIKE THIS FOR READABILITY

    public void Start (Character character) {
        //INIT FIRST QUESTION
        int currentQuestion = 0;

        //SET VARIABLE FOR GENDER
        if (character.Gender == false) {
            character.factor = 60;
        }
        else {
            character.factor = 40;
        }

        //START INTERVIEW LOOP
        while (currentQuestion < Questions.Count) {
            WriteLine(Questions[currentQuestion]);
            var response = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select how you wish to respond.")
                    .PageSize(10)
                    .AddChoices(ResponseOptions));

            int responseNumber = -1;
            // Show response to response, then loop
            switch(response) {
                case "Formal":
                    AnsiConsole.WriteLine(Questions[currentQuestion].Answers[0]);
                    responseNumber = 0;

                    break;
                case "Casual":
                    AnsiConsole.WriteLine(Questions[currentQuestion].Answers[1]);
                    responseNumber = 1;

                    break;
                case "Assertive":
                    AnsiConsole.WriteLine(Questions[currentQuestion].Answers[2]);
                    responseNumber = 2;

                    break;
                case "Passive":
                    AnsiConsole.WriteLine(Questions[currentQuestion].Answers[3]);
                    responseNumber = 3;

                    break;
            }
            
            character.factor = Algorithm.Evaluate(character, Questions[currentQuestion], responseNumber);
            
            currentQuestion++;
        }
        Console.WriteLine("The likeliness of your character to pass this interview is "+character.factor);
        
    }
}