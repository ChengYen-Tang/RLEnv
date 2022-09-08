﻿namespace BaseRLEnv.Utils;

internal static class Seeding
{
    /// <summary>
    /// Generates a random number generator from the seed and returns the Generator and seed.
    /// </summary>
    /// <param name="seed"> The seed used to create the generator </param>
    /// <returns> The generator and resulting seed </returns>
    /// <exception cref="Error"> Seed must be a non-negative integer or omitted </exception>
    public static (random npRandom, uint seed) NpRandom(uint? seed = null)
    {
        if (seed.HasValue && seed < 0)
            throw new Error("Seed must be a non-negative integer or omitted");

        seed ??= Convert.ToUInt32(Math.Abs(Guid.NewGuid().GetHashCode()));
        random npRandom = new();
        npRandom.seed(seed);

        return (npRandom, seed.Value);
    }
}
