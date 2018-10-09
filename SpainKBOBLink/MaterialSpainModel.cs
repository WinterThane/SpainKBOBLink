namespace SpainKBOBLink
{
    public class MaterialSpainModel
    {
        public int IdMaterial { get; set; }
        public string MaterialGroup { get; set; }
        public string ShortDescription { get; set; }
        public float CO2 { get; set; }
        public float EnergyConsumption { get; set; }
        public float RawMaterial { get; set; }
        public float PostRecycling { get; set; }
        public float PreRecycling { get; set; }
    }
}
