<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<body>

<h1>Privacy Policy</h1>
<p><strong>Effective Date:</strong> February 28, 2026</p>
<p>
This Privacy Policy describes how the Valour Bot Planet Joiner handles information
when operating within a Valour planet.
</p>
<hr>

<h2>1. Information Collected</h2>
<p>
The Bot is designed to collect and store the minimum data necessary to perform its function
of joining a planet using a bot token.
</p>

<h3>Information Stored:</h3>
<ol>
  <li>No persistent data storage</li>
  <li>Bot token loaded from environment variables (.env)</li>
  <li>Planet ID configured in source code</li>
  <li>Optional invite code configured in source code</li>
</ol>

<h3>Information Not Stored:</h3>
<ol>
  <li>User message content</li>
  <li>Direct Messages (“DMs”)</li>
  <li>User account information</li>
  <li>Email addresses</li>
  <li>Authentication credentials beyond runtime memory</li>
  <li>Analytics or tracking data</li>
</ol>

<hr>

<h2>2. Purpose of Data Usage</h2>
<p>The limited runtime information is used exclusively to:</p>
<ol>
  <li>Authenticate the Bot with the Valour API</li>
  <li>Join a specified planet</li>
  <li>Display authentication and join status in the console</li>
</ol>
<p>
The Bot does not perform profiling, analytics, advertising, or tracking.
</p>

<hr>

<h2>3. Data Storage and Security</h2>
<p>
The Bot does not persistently store user or planet data.
All sensitive configuration values (including the bot token) are loaded from
environment variables and exist only in application memory during runtime.
</p>
<p>
It is the responsibility of the operator to secure the hosting environment,
protect environment variables, and prevent unauthorized access.
</p>

<hr>

<h2>4. Data Retention</h2>
<p>
No data is retained after the application stops running.
All runtime data is cleared when the process exits.
</p>

<hr>

<h2>5. Changes to This Policy</h2>
<p>
If functionality is expanded in the future to include additional logging,
storage, or data handling practices, this Privacy Policy will be updated
prior to deployment of those changes.
</p>
<p>
Continued use of the Bot after policy updates constitutes acceptance of
the revised Privacy Policy.
</p>

<hr>

<h2>6. Contact Information</h2>
<p>For privacy-related inquiries, requests, or concerns, please contact:</p>
<p><strong>Email:</strong> contact@skyjoshua.xyz</p>

</body>
</html>