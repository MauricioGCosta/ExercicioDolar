namespace ExercicioDolar {
    class ConversorDeMoedas {
        public double Conversao(double valorDolar, double qtdeDolar) {
            return valorDolar * qtdeDolar + (valorDolar * qtdeDolar * 0.06);
        }
    }
}
