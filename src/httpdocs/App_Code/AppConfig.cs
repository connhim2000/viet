using System;
using System.Configuration;
using System.Net.Configuration;

/// <summary>
/// Summary description for AppConfig
/// </summary>
public static class AppConfig
{
    //Caches the connection string
    private readonly static string dbConnectionString;
    //Caches the data provider name
    private readonly static string dbProviderName;
    private readonly static String passPhrase;
    private readonly static String saltValue;
    private readonly static String hashAlgorithm;
    private readonly static int passwordIterations;
    private readonly static String initVector;
    private readonly static int keySize;
    private readonly static String mailUsername;
	static AppConfig()
	{
        //
        // TODO: Add constructor logic here
        //
        dbConnectionString = ConfigurationManager.ConnectionStrings["GTSdbConnStrMySQL"].ConnectionString;
        dbProviderName = ConfigurationManager.ConnectionStrings["GTSdbConnStrMySQL"].ProviderName;
        passPhrase = ConfigurationManager.AppSettings["passPhrase"];
        saltValue = ConfigurationManager.AppSettings["saltValue"];
        hashAlgorithm = ConfigurationManager.AppSettings["hashAlgorithm"];
        passwordIterations = Int32.Parse(ConfigurationManager.AppSettings["passwordIterations"]);
        initVector = ConfigurationManager.AppSettings["initVector"];
        keySize = Int32.Parse(ConfigurationManager.AppSettings["keySize"]);
        SmtpSection cfg = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
        mailUsername = cfg.Network.UserName;
	}

    //Returns the connection string for the GTSVN database
    public static string DbConnectionString
    {
        get
        {
            return dbConnectionString;
        }
    }

    //Returns the provider name for the GTSVN database
    public static string DbProviderName
    {
        get
        {
            return dbProviderName;
        }
    }

    public static String PassPhrase
    {
        get
        {
            return passPhrase;
        }
    }

    public static String SaltValue
    {
        get
        {
            return saltValue;
        }
    }

    public static String HashAlgorithm
    {
        get
        {
            return hashAlgorithm;
        }
    }

    public static int PasswordIterations
    {
        get
        {
            return passwordIterations;
        }
    }

    public static String InitVector
    {
        get
        {
            return initVector;
        }
    }

    public static int KeySize
    {
        get
        {
            return keySize;
        }
    }

    public static String MailUsername
    {
        get
        {
            return mailUsername;
        }
    }
}

