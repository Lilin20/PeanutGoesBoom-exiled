using Exiled.Events.EventArgs.Player;
using Exiled;
using UnityEngine;
using Exiled.API.Features.Items;
using Exiled.API.Features;

namespace PeanutGoesBoom_exiled
{
    public class EventHandlers
    {   
        public void OnPlayerDying(DyingEventArgs ev)
        {
            if (ev.Player.Role != PlayerRoles.RoleTypeId.Scp173)
            {
                return;
            }
            ExplosiveGrenade grenade = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
            grenade.FuseTime = PeanutGoesBoom.Instance.Config.FuseTime;
            grenade.SpawnActive(ev.Player.Position);
            grenade.ConcussDuration = 5f;
            grenade.BurnDuration = 5f;
        }
    }
}
