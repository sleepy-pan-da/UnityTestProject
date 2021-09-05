using NUnit.Framework;


public class damage_calculator
{
    [Test]
    public void calculates_2_damage_from_10_with_80_percent_mitigation()
    {
        // ACT
        int calculatedDamage = DamageCalculator.CalculateDamage(10, 0.8f);

        // ASSERT
        Assert.AreEqual(2, calculatedDamage);
    }
}
