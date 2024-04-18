using System;

namespace ChanceEditor
{
    public static class PercentagesExtension
    {
        /// <param name="value">
        /// A value from 0 to 1 is required.
        /// </param>
        /// <returns>
        /// Returns probability from percentages.
        /// </returns>
        public static int ToPercentages(this float value) => (int)Math.Clamp(value * 100, 0, 100);

        /// <param name="value">
        /// An integer value from 0 to 1 is required.
        /// </param>
        /// <returns>
        /// Returns percentages from probability.
        /// </returns>
        public static float ToProbability(this int value) => Math.Clamp(value / 100f, 0, 1);
    }
}
