using Exiled.API.Features;
using Exiled.API.Enums;
using Exiled;
using System;
using PluginAPI.Core;


namespace PeanutGoesBoom_exiled
{
    public class PeanutGoesBoom : Plugin<Config>
    {
        public override string Name { get; } = "Peanut Goes Boom";
        public override string Author { get; } = "Lilin";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 8, 0);
        public override string Prefix { get; } = "PeanutGoesBoom";
        public override PluginPriority Priority { get; } = PluginPriority.Default;

        public static PeanutGoesBoom Instance { get; } = new PeanutGoesBoom();
        private PeanutGoesBoom() { }
        public EventHandlers EventHandlers;

        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers();

            Exiled.Events.Handlers.Player.Dying += EventHandlers.OnPlayerDying;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            EventHandlers = null;

            Exiled.Events.Handlers.Player.Dying -= EventHandlers.OnPlayerDying;

            base.OnDisabled();
        }
    }
}
