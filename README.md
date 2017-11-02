# NetatmoCore
.NET Core SDK for NetAtmo products

.NET Core class library which helps interaction with Netatmo products.

Basic station data reading is simply done by calling few methods:

```C#
var auth = new NetatmoAuth();
var token = auth.Login(clientId, clientSecret, username, password, new[] { NetatmoAuth.READ_STATION});

var netatmo = new NetAtmoClient(token.access_token);

var result = await netatmo.Getthermostatsdata(device_id);
```