using System;
using NUnit.Framework;

public class Tests
{
    [Test]
    public void Exo01_Test_de_la_propriete_Name()
    {
        Assert.AreEqual( FirstExercice.m_name != default, true, "La variable m_name n'a pas de valeur" );
        Assert.AreEqual( FirstExercice.m_name.Length > 0 , true, "Vous n'avez rien écrit dans m_name :'(" );
    }

    [Test]
    public void Exo02_Test_de_la_propriete_Value()
    {
        Assert.AreEqual( FirstExercice.m_value != default, true, "La variable m_value n'a pas de valeur." );
        Assert.AreEqual( FirstExercice.m_value, 16, "La variable m_value a bien une valeur.\nMais ce n'est pas la bonne." );
    }

    [Test]
    public void Exo03_Test_de_la_methode_AddValue()
    {
        TestContext.Out.WriteLine( "Test 1 : m_value + 10 = 26" );
        Assert.AreEqual( FirstExercice.AddValue( 10 ), 26 );
        TestContext.Out.WriteLine( "Test 2 : m_value + 16 = 32" );
        Assert.AreEqual( FirstExercice.AddValue( 16 ), 32 );
        TestContext.Out.WriteLine( "Test 3 : m_value + 50 = 66" );
        Assert.AreEqual( FirstExercice.AddValue( 50 ), 66 );
        TestContext.Out.WriteLine( "All tests passed !" );
    }

    [Test]
    public void Exo04_Test_de_la_methode_Multiply()
    {
        Assert.AreEqual( FirstExercice.Multiply(5,3), 15 );
        Assert.AreEqual( FirstExercice.Multiply(10,40), 400 );
        Assert.AreEqual( FirstExercice.Multiply(12,12), 144 );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo05_Test_de_la_methode_Divide()
    {
        Assert.AreEqual( FirstExercice.Divide( 9f, 3f ), 3f );
        Assert.AreEqual( FirstExercice.Divide( 40f, 10f ), 4f );
        Assert.AreEqual( FirstExercice.Divide( 6f, 12f ), 0.5f );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo06_Test_de_la_methode_AddZ()
    {
        Assert.AreEqual( FirstExercice.AddZ( "Mario" ), "MarioZ" );
        Assert.AreEqual( FirstExercice.AddZ( "Unity" ), "UnityZ" );
        Assert.AreEqual( FirstExercice.AddZ( "Hyperqualifragilistique" ), "HyperqualifragilistiqueZ" );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo07_Test_de_la_methode_Sandwich()
    {
        Assert.AreEqual( FirstExercice.Sandwich( "Pain", "Fromage" ), "Pain-BURGER-Fromage" );
        Assert.AreEqual( FirstExercice.Sandwich( "Ketchup", "Salade" ), "Ketchup-BURGER-Salade" );
        Assert.AreEqual( FirstExercice.Sandwich( "Mayonnaise", "Pain" ), "Mayonnaise-BURGER-Pain" );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo08_Test_de_la_methode_IsEven()
    {
        Assert.AreEqual( FirstExercice.IsEven( 5 ), false );
        Assert.AreEqual( FirstExercice.IsEven( 12 ), true );
        Assert.AreEqual( FirstExercice.IsEven( 6 ), true );
        Assert.AreEqual( FirstExercice.IsEven( 1568 ), true );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo09_Test_de_la_methode_Biggest()
    {
        Assert.AreEqual( FirstExercice.Biggest(15, 20), 20 );
        Assert.AreEqual( FirstExercice.Biggest(20, 15), 20 );
        Assert.AreEqual( FirstExercice.Biggest(20, 20), 20 );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo10_Test_de_la_methode_BigWord()
    {
        Assert.AreEqual( FirstExercice.BigWord( "chaise", "table" ), "chaise" );
        Assert.AreEqual( FirstExercice.BigWord( "big", "small" ), "small" );
        Assert.AreEqual( FirstExercice.BigWord( "bilbon", "frodon" ), "bilbon" );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo11_Test_de_la_methode_Bonus()
    {
        Assert.AreEqual( FirstExercice.Bonus( 1000, false ), "$1000" );
        TestContext.Out.WriteLine( "Test 1 - Salaire = 1000, Prime = false, Résultat = $1000" );
        Assert.AreEqual( FirstExercice.Bonus( 250, true ), "$2500" );
        TestContext.Out.WriteLine( "Test 2 - Salaire = 250, Prime = true, Résultat = $2500" );
        Assert.AreEqual( FirstExercice.Bonus( 1500, false ), "$1500" );
        TestContext.Out.WriteLine( "Test 3 - Salaire = 1500, Prime = false, Résultat = $1500" );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo12_Test_de_la_mehtode_Populate()
    {
        Assert.AreEqual( FirstExercice.Populate( 5 ), new int[] { 0, 1, 2, 3, 4 } );
        Assert.AreEqual( FirstExercice.Populate( 2 ), new int[] { 0, 1 } );
        Assert.AreEqual( FirstExercice.Populate( 10 ), new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 } );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo13_Test_de_la_methode_Even()
    {
        Assert.AreEqual( FirstExercice.Even( new int[] { 0, 1, 2, 3, 4 } ), 3 );
        Assert.AreEqual( FirstExercice.Even( new int[] { 12 } ), 1 );
        Assert.AreEqual( FirstExercice.Even( new int[] { 1 } ), 0 );
        Assert.AreEqual( FirstExercice.Even( new int[] { 10,26,54,123,6548,62,1 } ), 5 );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo14_Test_de_la_methode_FirstLetter()
    {
        Assert.AreEqual( FirstExercice.FirstLetter( "zelda" ), "Z" );
        Assert.AreEqual( FirstExercice.FirstLetter( "mario"), "M" );
        Assert.AreEqual( FirstExercice.FirstLetter( "samus"), "S" );
        TestContext.Out.WriteLine( "This is Good !" );
    }

    [Test]
    public void Exo15_Test_de_la_methode_Average()
    {
        Assert.AreEqual( FirstExercice.Average( new int[] { 0, 1, 2, 3, 4 } ), 2.0f );
        Assert.AreEqual( FirstExercice.Average( new int[] { 10, 15, 30 } ), 18.0f );
        Assert.AreEqual( FirstExercice.Average( new int[] { 12, 600, 35, 24, 900 } ), 314.0f );
        TestContext.Out.WriteLine( "This is Good !" );
    }
}
