namespace Blocktrust.Common.Models.DidDoc;

public struct VerificationMaterial
{
    public VerificationMaterial(VerificationMaterialFormat format, string value)
    {
        this.format = format;
        this.value = value;
    }
    
    public VerificationMaterialFormat format;
    public string value; 
}