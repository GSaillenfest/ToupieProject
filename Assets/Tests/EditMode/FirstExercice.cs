/*
 * Pour tester votre code ouvrir la fenetre Test Runner d'Unity
 * Pour l'ouvrir aller dans Window > General > Test Runner
 * 
 * Pour lancer les tests cliquer sur le bouton "Run All" pour faire l'ensemble des tests
 * Sinon cliquer sur le nom de l'exercice que vous etes entrain de faire et
 * cliquer sur le Bouton "Run Selected"
 * 
 * Vous devez cliquer sur "Run All" ou "Run Selected" a chaque que vous voulez
 * tester votre reponse.
 * 
 * Vous pourrez trouver des indices dans ce document. 
 * Si vous êtes avec Visual Studio, en maintenant la touche CTRL du clavier
 * et en cliquant sur un des liens vous allez l'ouvrir directement dans votre
 * navigateur !
 */

public static class FirstExercice
{
    //Pour commencer, vous devez creer une propriete publique et statique m_name qui contient votre pseudo
    //m_name = "Le nom du joueur";
    public static string m_name = "Gaëtan";

    //La propriete m_value doit avoir la valeur 16
    public static int m_value = 16;

    /* La methode AddValue doit retourner l'addition du
     * parametre nb a la propriete m_value
     */
    public static int AddValue( int nb )
    {
        return nb + m_value;
    }

    /*
     * La methode Multiply doit retourner le resultat
     * de a multiplier par b
     */
    #region Indice
    /*
     * Vous devez utiliser l'opérateur arithmétique de multiplication
     * https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/operators/arithmetic-operators
     * 
     */
    #endregion
    public static int Multiply(int a, int b )
    {
        return a * b;
    }

    /*
     * La méthode Divide prend en parametre 2 float et dois retourner
     * le résultat de a diviser par b.
     * 
     */
    #region Indice
    /*
     * Vous devez utiliser l'opérateur arithmétique de division
     * https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/operators/arithmetic-operators
     */
    #endregion
    public static float Divide( float a, float b )
    {
        if (b != 0) return a / b;
        else return 0f;
    }

    /*
     * La methode AddZ doit retourner la concatenation
     * du parametre word avec "Z"
     */
    #region Indice
    /*
     * Vous devez faire une concaténation pour réussir l'exercice
     * https://docs.microsoft.com/fr-fr/dotnet/csharp/how-to/concatenate-multiple-strings
     * 
     */
    #endregion
    public static string AddZ( string word )
    {
        return word + "Z";
    }

    /*
     * La methode Sandwich prend en parametre 2 strings start et end.
     * Elle doit retourner une string contenant le mot -BURGER- entre start et end.
     * 
     * Exemple :
     * start = Pain
     * end = Fromage
     * 
     * Résultat = Pain-BURGER-Fromage
     * 
     */
    #region Indice
    /*
        * Vous devez faire une concaténation pour réussir l'exercice
        * https://docs.microsoft.com/fr-fr/dotnet/csharp/how-to/concatenate-multiple-strings
        * 
        */
    #endregion
    public static string Sandwich( string start, string end )
    {
        return start + "-BURGER-" + end;
    }

    /*
     * La méthode IsEvent prend en paramètre un entier number
     * et doit retourner un booléen.
     * Si number est pair IsEven doit retourner TRUE sinon FALSE
     * 
     * Exemple :
     * number = 156
     * 
     * Résultat = true
     */
    #region Indice
    /*
     * Vous devez utiliser l'opération arithmétique de reste %
     * https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/operators/arithmetic-operators
     */
    #endregion
    public static bool IsEven( int number )
    {
        if ( number%2 != 0) return false;
        else return true;
    }


    /*
     * La methode Biggest doit retourner le plus grand nombre
     * entre a et b. Si les 2 nombres sont egaux il doit retourner
     * l'un des deux
     */
    #region Indice
    /*
     * Vous devez faire une condition if/else
     * https://www.w3schools.com/cs/cs_conditions.php
     */
    #endregion
    public static int Biggest(int a, int b)
    {
        if (a <= b) return b;
        else return a;
    }

    /*
     * La methode BigWord prend en parametre 2 string
     * et doit retourner la plus longue. Si les deux
     * mots ont la meme longueur le premier doit etre
     * retourner.
     */
    #region Indice
    /*
     * Pour connaitre la longueur d'une string vous devez utiliser
     * la propriété String.Length
     * 
     * https://docs.microsoft.com/fr-fr/dotnet/api/system.string.length?view=net-6.0
     */
    #endregion
    public static string BigWord( string a, string b )
    {
        if (a.Length >= b.Length) return a;
        else return b;
    }

    /*
     * La methode Bonus prend en parametre un entier et 
     * un booleen. Si le booleen prime est TRUE le salaire
     * est multiplier par 10.
     * La fonction doit retourner une string contenant 
     * le salaire, avec le calcul du bonus si il doit 
     * s'appliquer, prefixe du signe $.
     * 
     * Exemple : 
     * Salaire = 100
     * Prime = true
     * Resultat : $1000
     */
    #region Indice
    /*
     * Vous devez utiliser une condition et une concaténation.
     */
    #endregion
    public static string Bonus( int salaire, bool prime )
    {
        if (prime) salaire *= 10;
        return "$"+salaire;
    }

    /*
     * La methode Populate prend en parametre un entier quantity.
     * Elle doit retourner un tableau d'entier contenant
     * un entier par entree allant de 0 jusque quantity.
     * 
     * Exemple 1 : 
     * quantity = 5
     * Resultat = [0, 1, 2, 3, 4]
     * 
     * * Exemple 2 : 
     * quantity = 3
     * Resultat = [0, 1, 2]
     */
    #region Indice
    /*
     * Vous devez utiliser une boucle pour remplir ce tableau
     * https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/statements/iteration-statements
     */
    #endregion
    public static int[] Populate( int quantity )
    {
        //Déclaration de la variable, elle n'a pas de valeur
        int[] resultat = new int[quantity];

        for (int i = 0; i < quantity; i++)
        {
            resultat[i] = i;
        }
        return resultat;
    }

    /*
     * La methode Even prend en parametre un tableau d'entier numbers.
     * Elle doit retourner la quantite de nombres pairs presents
     * dans ce tableau.
     * Vous devez utiliser l'operateur modulo % pour reussir l'exercice.
     * 0 est compte comme etant un nombre pair.
     * 
     * Exemple : 
     * numbers = [1,2,3,4]
     * Resultat = 2
     * 
     * Bonus : Vous pouvez utiliser la méthode IsEvent que vous avez
     * déjà crée
     */
    #region Indice
    /*
     * Vous devez utiliser une boucle, une condition et
     * utiliser un modulo.
     */
    #endregion
    public static int Even( int[] numbers )
    {
        int nbentiers = 0;
        foreach (int number in numbers)
        {
            if (IsEven(number)) nbentiers++ ;  
        }
        return nbentiers;
    }

    /*
     * La methode FirstLetter prend en parametre une string username.
     * Elle doit renvoyer la premiere lettre du parametre username
     * en majuscule.
     * 
     * Exemple : 
     * username = zelda
     * Resultat = Z
     */
    #region Indice
    /*
     * Quand vous récupérer le premier élément d'une string, il change de type
     * celui-ci n'est plus une string mais un char.
     * 
     * Pour mettre un char en majuscule il existe la méthoded Char.ToUpper()
     * https://docs.microsoft.com/fr-fr/dotnet/api/system.char.toupper?view=net-6.0
     * 
     */
    #endregion
    public static string FirstLetter( string username )
    {
        
        return username.ToUpper()[0].ToString();
    }

    /*
     * La methode Average prend en parametre un tableau d'entier datas.
     * Elle doit retourner un float qui est la moyenne des entiers
     * de ce tableau.
     * 
     * Exemple :
     * datas = [1,2,3]
     * 
     * résultat = 2
     */
    #region Indice
    /*
     * Vous devez faire la moyenne du tableau, dans un premier
     * temps vous devez additioner tous les éléments du tableau.
     */
    #endregion
    public static float Average( int[] datas )
    {
        int sum = 0;
        foreach( int data in datas )
        {
            sum += data;
        }
        return sum / datas.Length;
    }
}