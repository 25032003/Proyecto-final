using MauiApp1.Clases;


namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private bool Informacion_Sedan = false;
    private bool Informacion_Pickup = false;
    private bool Informacion_Camioneta = false;
    private bool Informacion_Jeep = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            //Propiedades del Vehiculo sedan

            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Tipo_Auto = "Mazda";
            sedan.Modelo_Auto = "Mazda CX-50";
            sedan.Color_Auto = "Negro";
            sedan.Año_Auto = 2020;
            sedan.Identificacion_Auto = "JJA11";
            sedan.Marca_Auto = "Sedán";

            //Atributos del auto sedan
            sedan.Start();
            sedan.Pedal_Acelerar(30);
            sedan.Pito();
            sedan.Estacionar();
            sedan.Apagar_Vehiculo();
        

            //Propiedades del vehiculo
            string sedanInfo = $"Marca: {sedan.Tipo_Auto}" +
                $"\nModelo: {sedan.Modelo_Auto}" +
                $"\nColor: {sedan.Color_Auto}" +
                $"\nAño: {sedan.Año_Auto}" +
                $"\nPlaca: {sedan.Identificacion_Auto}" +
                $"\nTipo: {sedan.Marca_Auto}";
            sedanLabel.Text = sedanInfo; 
            
            // Metodos del Vehiculo
            string sedanMethod = $"\nBocina: {sedan.Pito()}";
            //sedanMethod += $"\nApagado: {sedan.Apagar_Vehiculo()}";
            //sedanMethod += $"\nEl carro esta encendido: {sedan.Start()}";
            //sedanMethod += $"\nEl carro esta acelerando a: {sedan.Pedal_Acelerar(30)} kilometros/s";
            //sedanMethod += $"\nFrenando: de  {sedan.Pedal_Freno(10)} Kilometros/s";
            sedanLabel.Text += sedanMethod;

            Informacion_Sedan = true;
        }
    }
    private void OnCounterClicked4(object sender, EventArgs e)
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Start();
            string sedanMethod = $"El carro esta:{ sedan.Start()} ";
            sedanLabel.Text += sedanMethod;
            Informacion_Sedan = true;

        }
        }
    private void OnCounterClicked9(object sender, EventArgs e)
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Start();
            string sedanMethod = sedanMethod = $"{sedan.Pito()}";
            sedanLabel.Text += sedanMethod;
            Informacion_Sedan = true;
        }
    }

    private void OnCounterClicked5(object sender, EventArgs e)
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Apagar_Vehiculo();
            string sedanMethod = $"\nEl carro esta : {sedan.Apagar_Vehiculo()}";
            sedanLabel.Text += sedanMethod;
            Informacion_Sedan = true;

        }
    }
    private void OnCounterClicked6(object sender, EventArgs e)
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Pedal_Acelerar(30);
            string sedanMethod = $"\nEl carro esta acelerando a: {sedan.Pedal_Acelerar(30)} kilometros/s";
            sedanLabel.Text += sedanMethod;
            Informacion_Sedan = true;

        }
    }
    private void OnCounterClicked7(object sender, EventArgs e)
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Start();
            string sedanMethod = $"\nFrenando el vehiculo a {sedan.Pedal_Freno(10)} Kilometros/s";
            sedanLabel.Text += sedanMethod;
            Informacion_Sedan = true;
        }
        }

        private void OnCounterClicked1(object sender, EventArgs e)
    {
        if (Informacion_Pickup)
        {
            Informacion_Pickup = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            PickUp pickUp = new PickUp();
            pickUp.Tipo_Auto = "Toyota";
            pickUp.Modelo_Auto = "22R";
            pickUp.Color_Auto = "Rojo";
            pickUp.Año_Auto = 2004;
            pickUp.Identificacion_Auto = "JGL10";
            pickUp.Marca_Auto = "PickUp";
            pickUp.Start();
            pickUp.Pedal_Acelerar(80);
            pickUp.Pito();
            pickUp.Cargar();
            pickUp.Apagar_Vehiculo();

            string pickUpInfo = $"Marca: {pickUp.Tipo_Auto}" +
                $"\nModelo: {pickUp.Modelo_Auto}" +
                $"\nColor: {pickUp.Color_Auto}" +
                $"\nAño: {pickUp.Año_Auto}" +
                $"\nPlaca: {pickUp.Identificacion_Auto}" +
                $"\nTipo: {pickUp.Marca_Auto}";
            pickUpLabel.Text = pickUpInfo; // Muestra la información
            string pickupMethod = $"\nBocina: {pickUp.Pito()}";
            /*pickupMethod += $"\nApagado: {pickUp.Apagar_Vehiculo()}"*/;
            pickupMethod += $"\nEl carro esta: {pickUp.Start()}";
            pickupMethod += $"\nEl vehiculo esta acelerando a: {pickUp.Pedal_Acelerar(30)} Kilometro/s";
            pickupMethod += $"\nEl vehiculo se esta frenando a: {pickUp.Pedal_Freno(10)} kilometros/s";
            pickUpLabel.Text += pickupMethod;
            Informacion_Pickup = true;
        }

    }
    private void OnCounterClicked8(object sender, EventArgs e)
    {
        if (Informacion_Pickup)
        {
            Informacion_Pickup = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            PickUp pickUp = new PickUp();
            pickUp.Start();
            string pickupMethod = $"\nEl carro esta: {pickUp.Start()}";
            pickUpLabel.Text += pickupMethod;
            Informacion_Pickup = true;
        }
    }





        private void OnCounterClicked2(object sender, EventArgs e)
    {
        if (Informacion_Camioneta)
        {
            Informacion_Camioneta = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Camioneta Camioneta = new Camioneta();
            Camioneta.Tipo_Auto = "Land Cruiser";
            Camioneta.Modelo_Auto = "Prado";
            Camioneta.Color_Auto = "Negro";
            Camioneta.Año_Auto = 2022;
            Camioneta.Identificacion_Auto = "BOSS44";
            Camioneta.Marca_Auto = "SUV";
            Camioneta.Start();
            Camioneta.Pedal_Acelerar(100);
            Camioneta.Pito();
            Camioneta.ActivarTraccion4x4();
            Camioneta.Apagar_Vehiculo();

            string Camioneta_Info = $"Marca: {Camioneta.Tipo_Auto}" +
                $"\nModelo: {Camioneta.Modelo_Auto}" +
                $"\nColor: {Camioneta.Color_Auto}" +
                $"\nAño: {Camioneta.Año_Auto}" +
                $"\nPlaca: {Camioneta.Identificacion_Auto}" +
                $"\nTipo: {Camioneta.Marca_Auto}";
            suvLabel.Text = Camioneta_Info; // Muestra la información
            string CamionetaMethod = $"\nBocina: {Camioneta.Pito()}";
            //CamionetaMethod += $"\nApagado: {Camioneta.Apagar_Vehiculo()}";
            CamionetaMethod += $"\nLa camioneta esta: {Camioneta.Start()}";
            CamionetaMethod += $"\nAcelerando en: {Camioneta.Pedal_Acelerar(25)} Kilometros/s";
            CamionetaMethod += $"\nFrenando: de a {Camioneta.Pedal_Freno(10)} Kilometros/s";
            suvLabel.Text += CamionetaMethod;
            Informacion_Camioneta = true;
        }
    }
    private void OnCounterClicked3(object sender, EventArgs e)
    {
        if (Informacion_Jeep)
        {
            Informacion_Jeep = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Jeep Jeep = new Jeep();
            Jeep.Tipo_Auto = "Land Rover";
            Jeep.Modelo_Auto = "Defender";
            Jeep.Color_Auto = "Verde";
            Jeep.Año_Auto = 2022;
            Jeep.Identificacion_Auto = "JKL012";
            Jeep.Marca_Auto = "4x4";
            Jeep.Start();
            Jeep.Pedal_Acelerar(50);
            Jeep.Pito();
            Jeep.ConducirTerrenosDificiles();
            Jeep.Apagar_Vehiculo();

            string Jeep_Informacion = $"Marca: {Jeep.Tipo_Auto}" +
                $"\nModelo: {Jeep.Modelo_Auto}" +
                $"\nColor: {Jeep.Color_Auto}" +
                $"\nAño: {Jeep.Año_Auto}" +
                $"\nPlaca: {Jeep.Identificacion_Auto}" +
                $"\nTipo: {Jeep.Marca_Auto}";
            cuatroPorCuatroLabel.Text = Jeep_Informacion; // Muestra la información
            string JeepMethod = $"\nBocina: {Jeep.Pito()}";
            //JeepMethod += $"\nApagado: {Jeep.Apagar_Vehiculo()}";
            JeepMethod += $"\nEl carro esta: {Jeep.Start()}";
            JeepMethod += $"\nAcelerando en: {Jeep.Pedal_Acelerar(36)} kilometros/s";
            JeepMethod += $"\nFrenando: de a {Jeep.Pedal_Freno(14)}kilometros/s";
            suvLabel.Text += JeepMethod;
            Informacion_Jeep = true;
        }

    }

}

