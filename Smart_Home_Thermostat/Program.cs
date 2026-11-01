using Smart_Home_Thermostat;

var myThermostat = new Thermostat();
myThermostat.AddTemperature(68.5);
myThermostat.AddTemperature(70.2);
myThermostat.AddTemperature(69);

myThermostat.DisplayTemperatureReadings();