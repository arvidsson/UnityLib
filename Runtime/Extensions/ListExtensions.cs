﻿using System.Collections.Generic;

namespace UnityEngine
{
    public static class ListExtensions
    {
        /// <summary>
        /// Shuffles a list randomly.
        /// </summary>
        public static void Shuffle<T>(this IList<T> list)
        {
            var n = list.Count;
            var rng = new System.Random();

            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}