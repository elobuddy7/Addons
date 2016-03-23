using System;
using System.Drawing;

using EloBuddy;

namespace How_many_times_do_i_click
{
    internal static class Program
    {
        private static int Clicks;

        private static void Main(string[] args)
        {
            Player.OnIssueOrder += Player_OnIssueOrder;
            Drawing.OnDraw += Drawing_OnDraw;
        }

        private static void Player_OnIssueOrder(Obj_AI_Base sender, PlayerIssueOrderEventArgs args)
        {
            if (sender.IsMe && (args.Order.HasFlag(GameObjectOrder.MoveTo) || args.Order.HasFlag(GameObjectOrder.AttackTo)))
            {
                Clicks++;
            }
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            Drawing.DrawText(Drawing.Height * 0.1f, Drawing.Width * 0.1f, Color.GreenYellow, $"Clicks: {Clicks}");
        }
    }
}
