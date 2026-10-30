using System;

public class ConfigurationManager
{
    private static ConfigurationManager? _instance;

    private ConfigurationManager()
    {
        // constructor privat: nu se poate face "new ConfigurationManager()" din afară
    }

    public static ConfigurationManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ConfigurationManager();
        }
        return _instance;
    }
}