﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TF2Items
{
    public class ToolTips
    {
        public static string[] m_arrItemToolTips = {
                                        "Decreases the weapon's damage by a percentage.",
                                        "Increases the weapon's damage by a percentage.",
                                        "Decreases the cap size of the clip (which carries ammunition to fire with) by a percentage. Only applies to guns.",
                                        "Increases the cap size of the clip (which carries ammunition to fire with) by a percentage. Only applies to guns. Currently an unused ability.",
                                        "Decreases the attack speed by a percentage.",
                                        "Increases the attack speed by a percentage.",
                                        "Decreases the healing speed by a percentage. Only applies to Mediguns. Currently an unused ability.",
                                        "Increases the healing speed by a percentage. Only applies to Mediguns. Currently an unused ability.",
                                        "Decreases the Ubercharge build-up speed. Only applies to Mediguns. Currently an unused ability.",
                                        "Increases the Ubercharge build-up speed.",
                                        "Increases the maximum overheal by a percentage. Only applies to Mediguns. Currently an unused ability.",
                                        "Decreases the overheal time by a percentage. Only applies to Mediguns. Currently an unused ability.",
                                        "Increases the overheal time by a percentage. Only applies to Mediguns. Currently an unused ability.",
                                        "Causes the overheal not to decay. Only applies to Mediguns. Currently an unused ability, and doesn't work.",
                                        "Disables random critical hits. Only special critical hits work.",
                                        "Each hit on an opponent gives you health by units (i.e. 50 value means 50 health per hit).",
                                        "Each hit on an opponent gives you Ubercharge by percentage. Only applies to Medics.",
                                        "Causes the Ubercharge to grant 100% crits instead of invurenability. Only applies to Mediguns.",
                                        "Hitting an opponent will grant you a damage buff by a percentage. Lasts for ?? seconds. Currently an unused ability.",
                                        "Hitting a burning opponent will always crit.",
                                        "Hitting a nonburning opponent will deal less damage by a percentage.",
                                        "Hitting a nonburning opponent will never crit.",
                                        "Disables compression blast. Only applies to Flamethrowers.",
                                        "Attacking an opponent from behind (rougly 90 degrees wide behind where the opponent is facing) will always crit. Only applies to Flamethrowers.",
                                        "Decreases the secondary max ammo (the backup ammunition to fill your clip), but doesn't tell you in the game. Despite what it says on the description string, it's actually only used by the Flare Gun.",
                                        "Increases the player's max health by units.",
                                        "What it name says, it disables the Alt-Fire button. Currently an unused ability, and doesn't work. However, there is a developer weapon called the Rare Bonesaw, which has this ability, but the weapon is not in the file.",
                                        "Disables random critical hits, but doesn't tell you in the game. Only special critical hits work.",
                                        "When I saw the beta Natascha, I knew what this does. When using alt-fire, it functions the same as the regular fire button. However, here's the catch: It heals you on hit, but it does -25% damage in the process. I don't know if this still works or not, so to be tested. Currently a scrapped ability.",
                                        "On kill, the player and nearby teammates will gain 50 health and +10% crit chance for a limited time. But in actually using it, now, it doesn't work at all. Only applies to Fists. Currently a scrapped ability.",
                                        "Killing an opponent will grant the player 100% critical hits for a certain amount of time. Each unit value is a second.",
                                        "Hitting an opponet will cause him to slow down for a second on a percentage chance. Best used on rapidfire weapons.",
                                        "Causes the cloak only to activate by a nonlethal hit while out. Can't attack while holding it out or cloaking. Only applies to Cloaks.",
                                        "Increases the consume rate of the cloak. Only applies to Cloaks.",
                                        "Increases the regneration rate of the cloak while not using the cloak, or when standing still with the Cloak & Dagger, by a percentage. Only applies to Cloaks.",
                                        "Increases the spread by a percentage. Only applies to weapons with 0.01 spread or more.",
                                        "Decreases the secondary max ammo (the backup ammunition to fill your clip) by a percentage, but doesn't tell you in the game. I did find out why it was called Primary Max Ammo. That means it increases the secondary ammo for the primary weapon.",
                                        "Allows the use of stun balls. Only applies to the Sandman, but do NOT remove the ability from the Sandman, or the game will glitch up.",
                                        "Hitting a nonstunned opponent will deal less damage by a certain percentage. This ability was scrapped from the Sandman.",
                                        "Disables the slowdown for when you zoom in. Only applies to Sniper Rifles. But right now, it doesn't work. Currently an unused ability.",
                                        "Reduces the charge rate of the Sniper Rifle per second by a percentage. Only applies to, well, Sniper Rifles. Currently an unused ability.",
                                        "Disables the ability to headshot. Applies to Sniper Rifles and Huntsmen, but unconfirmed for a reflected arrow. Currently an unused ability.",
                                        "Causes the scattergun to reload two bullets at once. This only works with the Force-a-Nature, but what it ACTUALLY does is reload the entire clip in one go.",
                                        "Greatly increases the knockback of the Scattergun, to the point where you can even use it as a third jump!",
                                        "Or pellets, if you want to call them that. Increases the amount of pellets per shot by a percentage. Only applies to guns with pellets.",
                                        "Decreases the zoom from the Sniper Rifle. Guess what this only applies to? Currently an unused ability.",
                                        "Disables charging, which means you can't do powerful shots (unless it's a headshot). Currently an unused ability.",
                                        "Sets the Cloak to be movement-based. Standing still will recharge it, and moving will drain it. Used on the Cloak & Dagger. Only applies to Cloaks.",
                                        "Disables double jumping. Only applies to Scouts. This was a scrapped ability from the Sandman.",
                                        "While cloaked, the cloak will absorb 90% of the damage done to you. Even though on attribute_class it says it wasn't implemented, the Dead Ringer does this, but it doesn't even show it has it on the script. Apparently currently as an unused ability.",
                                        "Enables headshots for the Revolver.",
                                        "Prevents one backstab, and can only be regenerated by the Resupply Cabinet. Unconfirmed if this only works on the Razorback.",
                                        "Prevents afterburn. Doesn't work anymore, but it was going to be used on the Fire-proof Suit. Sadly, it was scrapped.",
                                        "Decreases your movement speed by a percentage.",
                                        "Unknown. Does nothing. Currently an unused ability.",
                                        "Simply tells you what the Jarate does.",
                                        "Regenerates health (by units) per second.",
                                        "Increases the knockback (by a percentage) from rocket-/sticky-jumps. Currently an unused ability.",
                                        "Decreases the knockback (by a percentage) from rocket-/sticky-jumps. Currently an unused ability.",
                                        "Reduces the damage you take from fire on a percentage.",
                                        "Increases the damage you take from fire on a percentage.",
                                        "Reduces the damage you take from critical hits on a percentage. Unconfirmed if having 100% critical-proof will prevent backstabs. If so, I can see why this is a currently unused ability.",
                                        "Increases the damage you take from critical hits on a percentage. Beware the critical Pistols. Currently an unused ability.",
                                        "Reduces the damage you take from explosions on a percentage.",
                                        "Increases the damage you take from explosions on a percentage. Currently an unused ability.",
                                        "Reduces the damage you take from bullets on a percentage. Currently an unused ability to prevent the possibility of outsmarting boolets.",
                                        "Increases the damage you take from bullets on a percentage.",
                                        "Increases the capture value on Control Points and Carts by units.",
                                        "Decreases the amount of health you get from Medics by a percentage. Currently an unused ability.",
                                        "Increases the amount of health you get from Medics by a percentage. Currently an unused ability.",
                                        "Increases the damage that your fire does by a percentage. Given that only Pyro has fire damage, I'll say that it only applies to Pyros. Currently an unused ability.",
                                        "Decreases the damage that your fire does by a percentage. Technically only applies to Pyros. Currently an unused ability.",
                                        "Increases the afterburn time on the opponents you inflicted on by a percentage. Technically only applies to Pyros. Currently an unused ability.",
                                        "Decreases the afterburn time on the opponents you inflicted on by a percentage. Technically only applies to Pyros. Currently an unused ability.",
                                        "Decreases the slowdown speed on certain aiming points, such as when scoping with a Sniper Rifle or spinning the Minigun. Currently an unused ability.",
                                        "Increases the primary's secondary ammunition by a percentage. Currently an unused ability.",
                                        "Decreases the primary's secondary ammunition by a percentage. Currently an unused ability.",
                                        "Increases the secondary ammunition by a percentage.",
                                        "Decreases the secondary ammunition by a percentage. Currently an unused ability.",
                                        "Increases the maximum metal that you can hold onto by a percentage. Can only go up to 999 before it restarts (therefore, the maximum value should be 4.99) by a percentage. Unused.",
                                        "Decreases the maximum metal that you can hold onto by a percentage. Unused.",
                                        "Increases the cloak consume rate by a percentage. Only applies to Cloaks. I thought this was already made?",
                                        "Decreases the cloak consume rate by a percentage. Only applies to Cloaks.",
                                        "Increases the cloak regeneration rate by a percentage. Only applies to Cloaks.",
                                        "Decreases the cloak regeneration rate by a percentage. Only applies to Cloaks.",
                                        "Increases the spin-up time for the Minigun by a percentage. Only applies to Miniguns. Unused.",
                                        "Decreases the spin-up time for the Minigun by a percentage. Only applies to Miniguns. Unused.",
                                        "Increases the amount of Sticky Bombs you can have out. Only applies to Stickybomb Launchers.",
                                        "Decreases the amount of Sticky Bombs you can have out. Only applies to Stickybomb Launchers. Unused.",
                                        "Increases the Sniper Rifle charge rate. Only applies to Sniper Rifles. Currently an unused ability.",
                                        "Decreases the Sniper Rifle charge rate. Only applies to Sniper Rifles. Unused.",
                                        "Increases the construction rate of the Wrench by percentage. Only applies to Wrenches. Unused.",
                                        "Decreases the construction rate of the Wrench by percentage. Only applies to Wrenches. Unused.",
                                        "Increases the repair rate of the Wrench by percentage. Only applies to Wrenches. Unused.",
                                        "Decreases the repair rate of the Wrench by percentage. Only applies to Wrenches. Unused.",
                                        "Increases the reload time. Only applies to guns. Unused.",
                                        "Decreases the reload time. Only applies to guns. Unused.",
                                        "Hitting an opponent will get you hurt (by units). Unused, and probably for a good reason.",
                                        "Increases the radius of explosions by a percentage. Only applies to explosions. Unused.",
                                        "Decreases the radius of explosions by a percentage. Only applies to explosions.",
                                        "Increases the range of projectiles by a percentage. Although, why? Unused, and for a good reason.",
                                        "Decreases the range of projectiles by a percentage. Unused.",
                                        "Increases the projectile speed by a percentage. Only seems to apply to the rockets.",
                                        "Decreases the projectile speed by a percentage. Only seems to apply to the rockets. Unused.",
                                        "Decreases the max overheal by a percentage. Only applies to Mediguns. Unused.",
                                        "Reduces the spread by a percentage. Only applies to guns. Unused.",
                                        "Increases your speed by a percentage. Currently an unused ability. The max is the Scout, but if you have 500% on the Heavy, he will have no slowdown while spinning his Minigun! The following chart is the minimum necessary percentage to be as fast as the Scout:",
                                        "Increases the amount of health you get from health packs by a percentage. Unused.",
                                        "Decreases the amount of health you get from health packs by a percentage. Unused.",
                                        "See 'heal on hit for rapidfire', except this is unused.",
                                        "See 'selfdmg on hit for slowfire'.",
                                        "Every 5 seconds, a percent of your ammunition gets recovered (i.e. if the value is set to 0.1, you recover 20 ammo every 5 seconds with the Minigun). Unused",
                                        "See ammo regen, but instead of ammo, it's Metal. Unused.",
                                        "Any rocket that hits an airborne enemy pushed back by your rocket will cause a mini-crit. Only applies to the Direct Hit.",
                                        "The further you take damage, the more damage you can do and move faster, but only when active. Only applies to the Equalizer and Soldier.",
                                        "Buff Banner effect.",
                                        "Increases the damage falloff by a percentage, which means the longer the projectile goes, the less damage. Only applies to rockets. Unused, and doesn't work.",
                                        "Decreases the damage falloff by a percentage. Only applies to rockets. Unused, and doesn't work.",
                                        "Makes it that you activate the stickies near or on your crosshair. Currently a used attribute.",
                                        "Increases the sticky arm time by units.",
                                        "Makes the stickies able to destroy the enemies' stickies.",
                                        "It does ABSOLUTELY NOTHING. Currently an unused attribute.",
                                        "Increases your speed by a percentage, only when active. Currently an unused attribute.",
                                        "Disables the ability to upgrade buildings. Currently an unused attribute, since the weapon that has this (P.D.Q.) is scrapped.",
                                        "Decreases your max health by a percentage. Currently an unused attribute.",
                                        "Reduces the sticky arm time by units. Currently an unused attribute.",
                                        "The stickybombs burst when it touches ANYTHING. However, it doesn't work. Currently an unused attribute.",
                                        "Makes it so that ALL the attributes the weapon provides only be used when the said weapon is active.",
                                        "For each second, you lose health (based on the value, which is in units).",
                                        "Increases the Medic's regeneration power by a percentage. Only applies to Civilians...er, Medics. Currently an unused attribute.",
                                        "Decreases the Medic's regeneration power by a percentage. Currently an unused attribute.",
                                        "Just adds the Community description.",
                                        "Just adds the description from the Medal, when you were one of the first 1,111 visitors.",
                                        "Attaches a particle effect. 1 to 3 (heh) are flames, 4 is the Community Sparkle, and 5 is the Cheater's Lament Particle.",
                                        "Reduces the damage you take from self damage (not just rocket jumping!) at a percentage.",
                                        "When using the weapon with the ability, for each kill the Sentry gets, you get 2 guaranteed crit shots, and for each assist, you get 1 guaranteed crit shot. The crit shots only apply once the Sentry is destroyed. Only applies to the Engineer.",
                                        "The weapon deals more damage to enemy buildables at a percentage.",
                                        "The weapon deals less damage to opponents at a percentage.",
                                        "Gives you an additional 50 HP for 30 seconds. Only applies to the Dalokohs Bar.",
                                        "It just boosts your max health, but without telling you so.",
                                        "Just adds the Selfmade description. No, you can't edit it, it's not what you think it is.",
                                        "The description of the Bronze, Silver, Gold, and Platinum badges. It is based on when you joined the game. ",
                                        "Gives you the ability to give and take Mini-Crit damage. Only applies to the Crit-a-Cola and Pepsi.",
                                        "Gives the weapon the ability to be able to remove sappers based on your damage.",
                                        "The number of the Golden Wrench obtained. Only applies to Golden Wrenches",
                                        "Reduces the cost of buildings",
                                        "Makes the opponent bleed on hit. The duration is based on the value, on units.",
                                        "Turns any victim that is killed by the weapon turn into a gold statue. Only applies to the Wrenches.",
                                     };

    }
}
