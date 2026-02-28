<!DOCTYPE html>
<html lang="en">
<body>

<h1>Valour Bot Planet Joiner</h1>

<p>
Valour Bot Planet Joiner is a minimal .NET 8 application that authenticates with the
Valour.gg API using a <strong>bot token</strong> and joins a specified planet automatically.
</p>

<p>
Environment variables are loaded using <code>DotNetEnv</code>, allowing secure
configuration via a <code>.env</code> file.
</p>

<hr>

<h2>Features</h2>
<ul>
    <li>Bot authentication via token</li>
    <li>Planet join via Planet ID</li>
    <li>Optional invite code support</li>
    <li>Graceful error handling</li>
    <li>Async .NET implementation</li>
</ul>

<hr>

<h2>How It Works</h2>

<ol>
    <li>Loads environment variables from a <code>.env</code> file</li>
    <li>Reads the <code>TOKEN</code> bot token</li>
    <li>Initializes <code>ValourClient</code> with <code>https://api.valour.gg</code></li>
    <li>Authenticates the bot</li>
    <li>Attempts to join the specified planet</li>
    <li>Outputs result to the console</li>
</ol>

<hr>

<h2>Requirements</h2>
<ul>
    <li>.NET 8+</li>
    <li>Valid Valour bot token</li>
    <li>Planet ID</li>
</ul>

<hr>

<h2>Installation</h2>

<pre><code>git clone https://github.com/YOUR_USERNAME/ValourPlanetJoinerBot.git
cd ValourPlanetJoinerBot
dotnet restore
</code></pre>

<hr>

<h2>Configuration</h2>

<p>Create a <code>.env</code> file in the project root:</p>

<pre><code>TOKEN=your-valour-bot-token
</code></pre>

<p>
Then edit the following values in <code>Program.cs</code>:
</p>

<pre><code>long planetId = 123456789012345; // Your Planet ID
string inviteCode = "";          // Optional invite code
</code></pre>

<p>
Do not commit your <code>.env</code> file to version control.
</p>

<hr>

<h2>Running the Bot</h2>

<pre><code>dotnet run
</code></pre>

<p>
If authentication succeeds, the console will display the bot identity and
the planet join result.
</p>

<hr>

<h2>Error Handling</h2>

<ul>
    <li>Missing TOKEN environment variable</li>
    <li>Authentication failure</li>
    <li>Planet join failure</li>
    <li>Unhandled exceptions</li>
</ul>

<hr>

<h2>License</h2>

<p>
This project is licensed under the
<strong>GNU Affero General Public License v3.0 (AGPL-3.0)</strong>.
</p>

<p>
See the LICENSE file for details.
</p>

<p>
If you modify and deploy this project publicly (including as a hosted service),
you must make your source code available under the same AGPL-3.0 license.
</p>

</body>
</html>