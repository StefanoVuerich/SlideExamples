// See https://aka.ms/new-console-template for more information
using LampadinaOOP;

internal class Lampadina
{
    private int numeroAccensioni;
    private StatoLampadina stato;

    public Lampadina(int maxClick)
    {
        this.numeroAccensioni = maxClick;
        stato = StatoLampadina.Spenta;
    }

    public void Click()
    {
        if(numeroAccensioni == 0)
        {
            stato = StatoLampadina.Rotta;
            Console.WriteLine("Rotta");
            return;
        }

        if(stato == StatoLampadina.Accesa)
        {
            stato = StatoLampadina.Spenta;
            Console.WriteLine("Spenta");

        }
        else if(stato == StatoLampadina.Spenta)
        {
            stato = StatoLampadina.Accesa;
            Console.WriteLine("Accesa");
        }

        numeroAccensioni--;
    }

    public string Stato()
    {
        return this.stato.ToString();
    }
}