using System.Net.Http;
using System.Net.Http.Headers;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Write code to to make requests to Jira server using Personal Access Tokens authentication

//Refactor the code to decouple setting of the token from generating and sending the request

//Refactor to use a design pattern that fits here
// Create a new HttpClient object and set the base address to the Jira server URL 
        HttpClient client = new HttpClient(); 
        client.BaseAddress = new Uri("https://jira.example.com/");

        // Set the authentication header with the personal access token as a bearer token 
        string personalAccessToken = "YOUR_PERSONAL_ACCESS_TOKEN"; 

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", personalAccessToken);

        // Make a request to the Jira server and get the response back 
        HttpResponseMessage response = client.GetAsync("/rest/api/2/issue").Result;

        // Check if the request was successful and print out the response content if it was successful 
        if (response.IsSuccessStatusCode) { 

            string responseContent = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(responseContent);

        } else {

            Console.WriteLine($"Request failed with status code: {response.StatusCode}");

        }  										  
