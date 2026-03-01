using Valour.Sdk.Client;
using DotNetEnv;

Env.Load();

var token = Environment.GetEnvironmentVariable("TOKEN");
if (string.IsNullOrWhiteSpace(token))
{
    Console.WriteLine("TOKEN is not set in the .env - Make sure its labeled .env and not something.env");
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









long planetId = 00000000000000000; //Put your planet id here. (Copy Id gives the id wrong, if you add +1 it should work. ex: 42439954653511680 -> 42439954653511681)
string inviteCode = ""; //Place the invite code here (just the end part). (If planet is Discoverable, this is not required.)



try
{
    var joinResult = string.IsNullOrWhiteSpace(inviteCode)
    ? await client.PlanetService.JoinPlanetAsync(planetId)
    : await client.PlanetService.JoinPlanetAsync(planetId, inviteCode);

    if (!joinResult.Success)
    {
        Console.WriteLine($"Failed to join planet: {joinResult.Message}");
        return;
    }

    Console.WriteLine($"Successfullly joined Planet.");
} catch (Exception ex)
{
    Console.WriteLine($"Error while joining planet: {ex.Message}");
}