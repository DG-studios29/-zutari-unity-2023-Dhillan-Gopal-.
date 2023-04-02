using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class WeatherApp : MonoBehaviour
{
    public TextMeshProUGUI cityNameText;
    public TextMeshProUGUI temperatureText;
    public TextMeshProUGUI descriptionText;

    private string[] cityNames = { "Johannesburg", "Cape Town", "Pretoria", "Durban", "Port Elizabeth", "Bloemfontein", "Nelspruit", "Polokwane", "Mahikeng", "Kimberley" };

    private string[] provinceNames = { "Gauteng", "Western Cape", "Gauteng", "KwaZulu-Natal", "Eastern Cape", "Free State", "Mpumalanga", "Limpopo", "North West", "Northern Cape" };

    private string apiEndpoint = "http://api.openweathermap.org/data/2.5/weather";
    private string apiKey = "52ac3d0dbc318c3fedca9599ba387072";

    void Start()
    {
        StartCoroutine(GetWeather());
    }

    IEnumerator GetWeather()
    {
        for (int i = 0; i < cityNames.Length; i++)
        {
            //method extract the city and province names for the current iteration of the loop, and construct the API endpoint URL with the city name and API key.
            string city = cityNames[i];
            string province = provinceNames[i];
            string url = apiEndpoint + "?q=" + city + "&appid=" + apiKey;

            //A UnityWebRequest object is then created with the URL, and the request is sent with the SendWebRequest() method.
            UnityWebRequest request = UnityWebRequest.Get(url);
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Error retrieving weather data for " + city + ": " + request.error);
            }
            else
            {
                string json = request.downloadHandler.text;
                WeatherData weatherData = JsonUtility.FromJson<WeatherData>(json);

                // Output
                cityNameText.text += city + ", " + province + "\n"+"\n";
                temperatureText.text += ((int)(weatherData.main.temp - 273.15f)).ToString() + "°C\n\n";
                descriptionText.text += weatherData.weather[0].description.ToUpper() + "\n\n";
            }
        }
    }
}

[System.Serializable]
public class WeatherData
{
    //This class is used to parse the main temperature data and the weather description data from the JSON response.
    public MainData main;
    public Weather[] weather;
}

[System.Serializable]
public class MainData
{
    //This class is used to parse the weather description data from the JSON response.
    public float temp;
}

[System.Serializable]
public class Weather
{
    //They are used in the GetWeather() coroutine method in the WeatherApp scene to parse the JSON response from the OpenWeather API.
    public string description;
}


