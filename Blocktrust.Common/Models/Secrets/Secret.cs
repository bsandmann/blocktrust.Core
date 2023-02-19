namespace Blocktrust.Common.Models.Secrets;

using Blocktrust.Common.Models.DidDoc;

public class Secret {
    public string Kid;
    public VerificationMethodType Type;
    public VerificationMaterial VerificationMaterial;

    public Secret(string kid, VerificationMethodType type, VerificationMaterial verificationMaterial) {
        this.Kid = kid;
        this.Type = type;
        this.VerificationMaterial = verificationMaterial;
    }
}