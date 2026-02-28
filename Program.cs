using Valour.Sdk.Client;

var token = Environment.GetEnvironmentVariable("TOKEN");
if (string.IsNullOrWhiteSpace(token))
{
    Console.WriteLine("TOKEN is not set in the environment variables");
    return;
}

var client = new ValourClient("https://api.valour.gg");
client.SetupHttpClient();

var loginResult = await client.InitializeUser(token);
if (!loginResult.Success)
{
    Console.WriteLine($"Login Failed: {loginResult.Message}");
    return;
}
Console.WriteLine($"Logged in as {client.Me.Name} (ID: {client.Me.Id})");









long planetId = 000000000000000; //Put your planet id here
string inviteCode = ""; //Put an invite code here.

try
{

    var joinResult = await client.PlanetService.JoinPlanetAsync(planetId, inviteCode);
    if (!joinResult.Success)
    {
        Console.WriteLine($"Failed to join planet: {joinResult.Message}");
    }

    Console.WriteLine($"Successfullly joined Planet.");
} catch (Exception ex)
{
    Console.WriteLine($"Error while joining planet: {ex.Message}");
}