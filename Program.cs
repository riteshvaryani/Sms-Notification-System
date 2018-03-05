// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using System.Configuration;
using System.Net.Http;

using Newtonsoft.Json;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using TwlioSupport;

class Example
{
    static void Main(string[] args)
    {
        GetQuotes();
        //SendMessage();
        
    }

    private static void SendMessage()
    {
        // Find your Account Sid and Auth Token at twilio.com/console
        string accountSid = ConfigurationManager.AppSettings["AccountSid"];
        string authToken = ConfigurationManager.AppSettings["AuthToken"];
        TwilioClient.Init(accountSid, authToken);

        var to = new PhoneNumber(ConfigurationManager.AppSettings["ToPhoneNumber"]);
        var message = MessageResource.Create(
            to,
            from: new PhoneNumber(ConfigurationManager.AppSettings["FromPhoneNumber"]),
            body: "This is the ship that made the Kessel Run in fourteen parsecs?");

        Console.WriteLine(message.Sid);
    }

    private static void GetQuotes()
    {
        using (var client = new HttpClient())
        {
            var result = client.GetAsync("https://api.coinmarketcap.com/v1/ticker/");
            var resultAsJson = result.Result.Content.ReadAsStringAsync().Result;
            var deserializedObject = JsonConvert.DeserializeObject<CoinDetail[]>(resultAsJson);
            Console.WriteLine(JsonConvert.SerializeObject(deserializedObject[0]));
        }
        //var xhr = new XMLHttpRequest();
        //xhr.open("GET", "https://api.coinmarketcap.com/v1/ticker/", false);
        //xhr.send();
    }
}