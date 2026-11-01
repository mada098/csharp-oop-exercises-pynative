namespace Smart_Home_Thermostat;

public class Thermostat
{
    private double[] _historyTemperature = new double[10];
    private int _counter = 0;

    public void AddTemperature(double temperature)
    {
        if (_counter < _historyTemperature.Length)
        {
            _historyTemperature[_counter] = temperature;
            _counter++;
        }
    }

    public void Reset()
    {
        _counter = 0;
        _historyTemperature = new double[10];
    }

    public void DisplayTemperatureReadings()
    {
        foreach (double temperature in _historyTemperature)
        {
            Console.Write(temperature + ", ");
        }
    }

}