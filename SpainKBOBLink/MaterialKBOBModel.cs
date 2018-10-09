namespace SpainKBOBLink
{
    public class MaterialKBOBModel
    {
        public int IdKBOB { get; set; }
        public string KBOB { get; set; }
        public string NameGerman { get; set; }
        public string SurfaceMass { get; set; }
        public string SurfaceMassUnit { get; set; }
        public float Ubp13Manufacture { get; set; }
        public float Ubp13Disposal { get; set; }
        public float TotalProduction { get; set; }
        public float TotalDisposal { get; set; }
        public float RenewableProduction { get; set; }
        public float RenewableDisposal { get; set; }
        public float NonRenewableProduction { get; set; }
        public float NonRenewableDisposal { get; set; }
        public float GreenhouseGasEmissionsProduction { get; set; }
        public float GreenhouseGasEmissionsDisposal { get; set; }
    }
}
