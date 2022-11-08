using System;
using FireSharp;
using FireSharp.Config;

namespace BowlingGame.Infrastructure
{
    public static class Firebase
    {
        private static FirebaseConfig BuildConfig()
        {
            const string Url = "https://bowling-2cd83-default-rtdb.firebaseio.com/";
            const string Realm = "bowling";
            var dateKey = DateTime.Now.Date.ToString("yyyyMMdd");

            var config = new FirebaseConfig
            {
                BasePath = $"{Url}/{Realm}/{dateKey}"
            };
            return config;
        }

        public static FirebaseClient CreateClient()
        {
            return new FirebaseClient(BuildConfig());
        }
    }
}