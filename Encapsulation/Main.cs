using System;

class Automobile
{
    // Variabili private, accessibili solo all'interno della classe
    private string marca;
    private string modello;
    private int anno;

    public string GetMarca()
    {
        return marca;
    }

    // Proprietà pubbliche per accedere e modificare le variabili private
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modello
    {
        get { return modello; }
        set { modello = value; }
    }

    public int Anno
    {
        get { return anno; }
        set
        {
            // Esempio di controllo sull'anno (es. non deve essere nel futuro)
            if (value <= DateTime.Now.Year)
                anno = value;
            else
                Console.WriteLine("L'anno inserito non è valido.");
        }
    }

    // Metodo pubblico per visualizzare le informazioni dell'automobile
    public void MostraInformazioni()
    {
        Console.WriteLine($"Marca: {Marca}, Modello: {Modello}, Anno: {Anno}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creazione di un oggetto Automobile
        Automobile auto = new Automobile();

        // Accesso alle proprietà per impostare i valori
        auto.Marca = "Fiat";
        auto.Modello = "500";
        auto.Anno = 2020;

        // Accesso al metodo per visualizzare le informazioni
        auto.MostraInformazioni();
    }
}
