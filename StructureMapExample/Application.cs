namespace StructureMapExample
{
    public class Application
    {
        private readonly ICalculator _calculator;
        private readonly ILogger _logger;

        public Application(
            ICalculator calculator,
            ILogger logger
            )
        {
            _calculator = calculator;
            _logger = logger;
        }

        public void Run()
        {
            _logger.WriteInfo($"{nameof(Application)} starting!");
            _calculator.Add(1, 2);
            _calculator.Add(2, 3);
            _calculator.Add(3, 5);
            _logger.WriteInfo($"{nameof(Application)} ending!");
        }
    }
}
