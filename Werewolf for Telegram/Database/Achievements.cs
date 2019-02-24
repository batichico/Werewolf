﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public enum Achievements
    {
        [Display(Name = "None"), Description("You haven't played a game yet!")]
        None = 0,
        [Display(Name = "Welcome to Hell"), Description("Play a game")]
        WelcomeToHell = 1,
        [Display(Name = "Welcome to the Asylum"), Description("Play a chaos game")]
        WelcomeToAsylum = 2,
        [Display(Name = "Alzheimer's Patient"), Description("Play a game with an amnesia language pack")]
        AlzheimerPatient = 3,
        [Display(Name = "O HAI DER!"), Description("Play a game with Para's secret account (not @para949)")]
        OHAIDER = 4,
        [Display(Name = "Spy vs Spy"), Description("Play a game in secret mode (no role reveal)")]
        SpyVsSpy = 5,
        [Display(Name = "Explorer"), Description("Play at least 2 games each in 10 different groups")]
        Explorer = 6,
        [Display(Name = "Linguist"), Description("Play at least 2 games each in 10 different language packs")]
        Linguist = 7,
        [Display(Name = "I Have No Idea What I'm Doing"), Description("Play a game in secret amnesia mode")]
        NoIdeaWhat = 8,
        [Display(Name = "Enochlophobia"), Description("Play a 35 player game")]
        Enochlophobia = 9,
        [Display(Name = "Introvert"), Description("Play a 5 player game")]
        Introvert = 10,
        [Display(Name = "Naughty!"), Description("Play a game using any NSFW language pack")]
        Naughty = 11,
        [Display(Name = "Dedicated"), Description("Play 100 games")]
        Dedicated = 12,
        [Display(Name = "Obsessed"), Description("Play 1000 games")]
        Obsessed = 13,
        [Display(Name = "Here's Johnny!"), Description("Get 50 kills as the serial killer")]
        HereJohnny = 14,
        [Display(Name = "I've Got Your Back"), Description("Save 50 people as the Guardian Angel")]
        GotYourBack = 15,
        [Display(Name = "Masochist"), Description("Win a game as the Tanner")]
        Masochist = 16,
        [Display(Name = "Wobble Wobble"), Description("Survive a game as the drunk (at least 10 players)")]
        Wobble = 17,
        [Display(Name = "Inconspicuous"), Description("In a game of 20 or more people, do not get a single lynch vote against you (and survive)")]
        Inconspicuous = 18,
        [Display(Name = "Survivalist"), Description("Survive 100 games")]
        Survivalist = 19,
        [Display(Name = "Black Sheep"), Description("Get lynched first 3 games in a row")]
        BlackSheep = 20,
        [Display(Name = "Promiscuous"), Description("As the harlot, survive a 5+ night game without staying home or visiting the same person more than once")]
        Promiscuous = 21,
        [Display(Name = "Mason Brother"), Description("Be one of at least two surviving masons in a game")]
        MasonBrother = 22,
        [Display(Name = "Double Shifter"), Description("Change roles twice in one game (cult conversion does not count)")]
        DoubleShifter = 23,
        [Display(Name = "Hey Man, Nice Shot"), Description("As the hunter, use your dying shot to kill a wolf or serial killer")]
        HeyManNiceShot = 24,
        [Display(Name = "That's Why You Don't Stay Home"), Description("As a wolf or cultist, kill or convert a harlot that stayed home")]
        DontStayHome = 25,
        [Display(Name = "Double Vision"), Description("Be one of two seers at the same time")]
        DoubleVision = 26,
        [Display(Name = "Double Kill"), Description("Be part of the Serial Killer / Hunter ending")]
        DoubleKill = 27,
        [Display(Name = "Should Have Known"), Description("As the Seer, reveal the Beholder")]
        ShouldHaveKnown = 28,
        [Display(Name = "I See a Lack of Trust"), Description("As the Seer, get lynched on the first day")]
        LackOfTrust = 29,
        [Display(Name = "Sunday Bloody Sunday"), Description("Be one of at least 4 victims to die in a single night")]
        BloodyNight = 30,
        [Display(Name = "Change Sides Works"), Description("Change roles in a game, and win")]
        ChangingSides = 31,
        [Display(Name = "Forbidden Love"), Description("Win as a wolf / villager couple (villager, not village team)")]
        ForbiddenLove = 32,
        [Display(Name = "Developer"), Description("Have a pull request merged into the repo")]
        Developer = 33,
        [Display(Name = "The First Stone"), Description("Be the first to cast a lynch vote 5 times in a single game")]
        FirstStone = 34,
        [Display(Name = "Smart Gunner"), Description("As the Gunner, both of your bullets hit a wolf, serial killer, or cultist")]
        SmartGunner = 35,
        [Display(Name = "Streetwise"), Description("Find a different wolf, serial killer, or cultist 4 nights in a row as the detective")]
        Streetwise = 36,
        [Display(Name = "Speed Dating"), Description("Have the bot select you as a lover (cupid failed to choose)")]
        OnlineDating = 37,
        [Display(Name = "Even a Stopped Clock is Right Twice a Day"), Description("As the Fool, have at least two of your visions be correct by the end of the game")]
        BrokenClock = 38,
        [Display(Name = "So Close!"), Description("As the Tanner, be tied for the most lynch votes")]
        SoClose = 39,
        [Display(Name = "Cultist Convention"), Description("Be one of 10 or more cultists alive at the end of a game")]
        CultCon = 40,
        [Display(Name = "Self Loving"), Description("As cupid, pick yourself as one of the lovers")]
        SelfLoving = 41,
        [Display(Name = "Should've Said Something"), Description("As a wolf, your pack eats your lover (first night does not count)")]
        ShouldveMentioned = 42,
        [Display(Name = "Tanner Overkill"), Description("As the Tanner, have everyone (but yourself) vote to lynch you")]
        TannerOverkill = 43,
        [Display(Name = "Serial Samaritan"), Description("As the Serial Killer, kill at least 3 wolves in single game")]
        SerialSamaritan = 44,
        [Display(Name = "Cultist Fodder"), Description("Be the cultist that is sent to attempt to convert the Cult Hunter")]
        CultFodder = 45,
        [Display(Name = "Lone Wolf"), Description("In a chaos game of 10 or more people, be the only wolf - and win")]
        LoneWolf = 46,
        [Display(Name = "Pack Hunter"), Description("Be one of 7 living wolves at one time")]
        PackHunter = 47,
        [Display(Name = "Saved by the Bull(et)"), Description("As a villager, the wolves match the number of villagers, but the game does not end because the gunner has a bullet")]
        GunnerSaves = 48,
        [Display(Name = "In for the Long Haul"), Description("Survive for at least an hour in a single game")]
        LongHaul = 49,
        [Display(Name = "OH SHI-"), Description("Kill your lover on the first night")]
        OhShi = 50,
        [Display(Name = "Veteran"), Description("Play 500 games.  You can now join @werewolfvets")]
        Veteran = 51,
        [Display(Name = "No Sorcery!"), Description("As a wolf, kill your sorcerer")]
        NoSorcery = 52,
        [Display(Name = "Cultist Tracker"), Description("As the cultist hunter, kill at least 3 cultists in one game")]
        CultistTracker = 53,
        [Display(Name = "I'M NOT DRUN-- *BURPPP*"), Description("As the clumsy guy, have at least 3 correct lynches by the end of the game")]
        ImNotDrunk = 54,
        [Display(Name = "Wuffie-Cult"), Description("As the alpha wolf, successfully convert at least 3 victims into wolves")]
        WuffieCult = 55,
        [Display(Name = "Did you guard yourself?"), Description("As the guardian angel, survive after 3 tries guarding an unattacked wolf")]
        DidYouGuardYourself = 56,
        [Display(Name = "Spoiled Rich Brat"), Description("As the prince, still gets lynched even after revealing your identity")]
        SpoiledRichBrat = 57,
        [Display(Name = "Three Little Wolves and a Big Bad Pig"), Description("As the sorcerer, survive a game with three or more alive wolves")]
        ThreeLittleWolves = 58,
        [Display(Name = "President"), Description("As the mayor, successfully cast 3 lynch votes after revealing")]
        President = 59,
        [Display(Name = "I Helped!"), Description("As a wolf cub, the alive pack has 2 successful eat attempts after you die")]
        IHelped = 60,
        [Display(Name = "It Was a Busy Night!"), Description("During the same night, got visited by 3 or more different visiting roles")]
        ItWasABusyNight = 61,
    } // MAX VALUE: 9223372036854775807
      //            

    public static partial class Extensions
    {
        public static string GetDescription(this Achievements value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        public static string GetName(this Achievements value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var descriptionAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (descriptionAttributes == null) return string.Empty;
            return (descriptionAttributes.Length > 0) ? descriptionAttributes[0].Name : value.ToString();
        }

        public static byte[] ToByteArray(this BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }


        public static IEnumerable<Achievements> GetUniqueFlags(this BitArray flags)
        {
            for (var i = 0; i < flags.Length; i++)
            {
                if (flags.Get(i))
                {
                    yield return (Achievements)i;
                }
            }
        }

        public static bool HasFlag(this BitArray array, Achievements achv)
        {
            return array[(int)achv];
        }

        public static BitArray Set(this BitArray array, Achievements achv)
        {
            array[(int)achv] = true;
            return array;
        }

        public static BitArray Unset(this BitArray array, Achievements achv)
        {
            array[(int)achv] = false;
            return array;
        }
    }
}
