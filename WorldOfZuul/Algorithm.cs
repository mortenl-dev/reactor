public static class Algorithm {
    public static int Evaluate(Character character, Prompt Question, int responseNumber) {
        int outputEval = character.factor;
        //CHECK GENDER, THEN INCREMENT EVALUATING BASED ON THE GENDER SPECIFIC RESPONSE VALUE
        if (character.Gender == true) {
            outputEval += Question.reaction_Female[responseNumber];
        }
        else {
            outputEval += Question.reaction_Male[responseNumber];
        }
        
        return outputEval;
    }
}