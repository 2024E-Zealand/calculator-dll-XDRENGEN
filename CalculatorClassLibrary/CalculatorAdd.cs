namespace CalculatorClassLibrary
{
    /// <summary>
    /// Metode til at starte programmet.
    /// Metoden bruges til en meget simpel regnemaskine,
    /// som kan udføre +, -, * og / baseret på hvad brugeren vælger.
    /// </summary>
    public class CalculatorAdd
    {
        /// <summary>
        /// Lægger to tal sammen 
        /// </summary>
        /// <param name="a">Det første tal som skal lægges sammen</param>
        /// <param name="b">Det andet tal som skal lægges sammen</param>
        /// <returns>Returnere summen af de to tal som er lagt sammen</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
