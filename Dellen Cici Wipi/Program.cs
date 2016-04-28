using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;


namespace DellenCiciWipi
{
    class Program
    {
        private static Menu Menu, Hotkeys;
        public static bool duramk = false;
        public static float gameTime1 = 0;

        private static void Addzoo(string name, string displayName, bool value = true)
        {
            Menu.Add(name, new CheckBox(displayName, value));
        }

        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnGameLoad;
        }

        public static void StringList(Menu menu, string uniqueId, string displayName, string[] values, int defaultValue)
        {
            var mode = menu.Add(uniqueId, new Slider(displayName, defaultValue, 0, values.Length - 1));
            mode.DisplayName = displayName + ": " + values[mode.CurrentValue];
            mode.OnValueChange +=
                delegate(ValueBase<int> sender, ValueBase<int>.ValueChangeArgs args)
                {
                    sender.DisplayName = displayName + ": " + values[args.NewValue];
                };
        }

        private static void OnGameLoad(EventArgs args)
        {
            Loading.OnLoadingComplete += delegate
            {
                Chat.Print(
                    "<font color = \"#ff052b\">Dellen's cici wipi</font>  <font color = \"#fcdfff\">Yuklendi  </font> ");

                Menu = MainMenu.AddMenu("Dellen", "Dellen");
                Hotkeys = Menu.AddSubMenu("Hotkeys", "Hotkeys");
                Hotkeys.AddGroupLabel("Hotkey Settings");
                var press1 = Hotkeys.Add("GGyaz",
                    new KeyBind("GGYAZ", false, KeyBind.BindTypes.HoldActive, "{Right}".ToCharArray()[0]));
                var press2 = Hotkeys.Add("WPyaz",
                    new KeyBind("WPyaz", false, KeyBind.BindTypes.HoldActive, "{Left}".ToCharArray()[0]));
                var press3 = Hotkeys.Add("ORT",
                    new KeyBind("ORT", false, KeyBind.BindTypes.HoldActive, "{Up}".ToCharArray()[0]));


                Game.OnUpdate += delegate
                {
                    if (press1.CurrentValue)
                    {
                        if (duramk == false)
                        {
                            Chat.Say("/all                          ");
                            Chat.Say("/all   ######        ######   ");
                            Chat.Say("/all  ##                  ##       ");
                            Chat.Say("/all  ##                  ##       ");
                            Chat.Say("/all  ##   ####     ##   ####");
                            Chat.Say("/all  ##        ##     ##       ##");
                            Chat.Say("/all  ##        ##     ##       ##");
                            Chat.Say("/all   ######        ######  ");

                            duramk = true;
                            gameTime1 = Game.Time + 1;
                        }
                        if (Game.Time > gameTime1)
                        {
                            duramk = false;
                        }
                    };

                    if (press2.CurrentValue)
                    {                      
                        if (duramk == false)
                        {
                            Chat.Say("/all                           ");
                            Chat.Say("/all  ##         ##   ####### ");
                            Chat.Say("/all  ##  ##  ##   ##      ##");
                            Chat.Say("/all  ##  ##  ##   ##      ##");
                            Chat.Say("/all  ##  ##  ##   ####### ");
                            Chat.Say("/all  ##  ##  ##   ##       ");
                            Chat.Say("/all  ##  ##  ##   ##       ");
                            Chat.Say("/all   ###  ###    ##      ");

                            duramk = true;
                            gameTime1 = Game.Time + 1;
                        }
                        if (Game.Time > gameTime1)
                        {
                            duramk = false;
                        }
                    }
                    if (press3.CurrentValue)
                    {
                        if (duramk == false)
                        {
                            Chat.Say("/all                       /´¯/)");
                            Chat.Say("/all                     ,/¯  / ");
                            Chat.Say("/all                    /    / ");
                            Chat.Say("/all              /´¯/'   '/´¯¯`·¸ ");
                            Chat.Say("/all           /'/   /    /       /¨¯\\ ");
                            Chat.Say("/all         ('(   ´   ´     ¯~/'   ') ");
                            Chat.Say("/all          |\\                 '     / ");
                            Chat.Say("/all           ''   \\           _ ·´ ");

                            duramk = true;
                            gameTime1 = Game.Time + 1;
                        }
                        if (Game.Time > gameTime1)
                        {
                            duramk = false;
                        }
                    }
                };

            };
        }
    }
}

        
        
    
    

