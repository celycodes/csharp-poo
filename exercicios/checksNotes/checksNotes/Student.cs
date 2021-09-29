namespace checksNotes {
    class Student {
        public string Name;
        public double T1, T2, T3;

        public double FinalScore() {
            return T1 + T2 + T3; // nota final
        }

        public bool Check() { // checando se o aluno está aprovado
            if (FinalScore() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double remainingNote() { // nota restante
            if (Check()) {
                return 0.0;
            }
            else {
                return 60.0 - FinalScore();
            }
        }
    }
}