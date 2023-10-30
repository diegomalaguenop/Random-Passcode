using System;

public class RandomCodeGenerator
{
    private static readonly Random random = new Random();

    public static string GenerateRandomCode()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(
            Enumerable.Repeat(chars, 14)
            .Select(s => s[random.Next(s.Length)])
            .ToArray()
        );
    }
}
