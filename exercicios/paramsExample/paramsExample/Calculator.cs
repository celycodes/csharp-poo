namespace paramsExample {
    class Calculator {
        public static int Sum(params int[] numbers) {
            int sum = 0; // variavel auxiliar soma 
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
