using Firebase.Auth;

var username = "firebase user";
var password = "firebase password";
var apiKey = "firebase api key";

var config = new FirebaseConfig(apiKey);

var authProvider = new FirebaseAuthProvider(config);
var result = await authProvider.SignInWithEmailAndPasswordAsync(username, password);
var token = result.FirebaseToken;

Console.WriteLine("Bearer " + token);
Console.WriteLine(" ");