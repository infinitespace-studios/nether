// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace AnalyticsTestClient
{
    public class MainMenu : ConsoleMenu
    {
        private BatchAnalyticsClient _client;

        public MainMenu(BatchAnalyticsClient client)
        {
            _client = client;

            Title = "Nether Analytics Test Client - Main Menu";

            MenuItems.Add('1', new ConsoleMenuItem("Send Typed Game Messages ...", () => { new SendTypedGameEventMenu(_client).Show(); }));
            MenuItems.Add('2', new ConsoleMenuItem("Send Custom Game Message", SendCustomGameEvent));
            MenuItems.Add('3', new ConsoleMenuItem("Simulate moving game client ...", () => { new SimulateMovementMenu(_client).Show(); }));
            MenuItems.Add('4', new ConsoleMenuItem("USQL Script ...", () => new USQLJobMenu().Show()));
            MenuItems.Add('5', new ConsoleMenuItem("Results API Consumer ...", () => { new ResultsApiConsumerMenu().Show(); }));
        }

        private void SendCustomGameEvent()
        {
            var msg = (string)EditProperty("Custom Message", $"This is a custom msg at {DateTime.UtcNow}", typeof(string));

            _client.SendMessageAsync(msg).Wait();
        }
    }
}