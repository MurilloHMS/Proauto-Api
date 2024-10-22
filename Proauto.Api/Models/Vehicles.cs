namespace Api_Proauto.Models
{
    public class Vehicles
    {        
        public int Id { get; set; } // Identificador único do veículo
        public string Name { get; set; } // Nome do veículo
        public string Brand { get; set; } // Marca do veículo
        public string Model { get; set; } // Modelo do veículo
        public string Plate { get; set; } // Placa do veículo
        public string VehicleCategory { get; set; } // Categoria do veículo
        public double UrbanAlcoholConsumption { get; set; } // Consumo urbano de álcool
        public double RoadAlcoholConsumption { get; set; } // Consumo rodoviário de álcool
        public double UrbanGasolineConsumption { get; set; } // Consumo urbano de gasolina
        public double RoadGasolineConsumption { get; set; } // Consumo rodoviário de gasolina
        public bool Status { get; set; } // Status do veículo (ativo/inativo)
    }
}
