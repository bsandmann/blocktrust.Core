namespace Blocktrust.Common.Tests;

using System.Text.Json;
using FluentAssertions;
using Models.DidDoc;
using Models.Secrets;

public class SerializationTests
{
    [Fact]
    public void SerializingAndDeserializingOfSecretWorks()
    {
        var secret = new Secret("mykid", VerificationMethodType.Ed25519VerificationKey2018, new VerificationMaterial()
        {
            Value = "myValue",
            Format = VerificationMaterialFormat.Jwk
        });
        
        var serialized = JsonSerializer.Serialize(secret);
        
        var deserialized = JsonSerializer.Deserialize<Secret>(serialized);
        
        deserialized.Kid.Should().Be(secret.Kid);
        deserialized.Type.Should().Be(secret.Type);
        deserialized.VerificationMaterial.Format.Should().Be(secret.VerificationMaterial.Format);
        deserialized.VerificationMaterial.Value.Should().Be(secret.VerificationMaterial.Value);
    }
    
    [Fact]
    public void SerializingAndDeserializingOfSecretWorksWithOtherValue()
    {
        var secret = new Secret("mykid", VerificationMethodType.X25519KeyAgreementKey2019, new VerificationMaterial()
        {
            Value = "myValue",
            Format = VerificationMaterialFormat.Multibase
        });
        
        var serialized = JsonSerializer.Serialize(secret);
        
        var deserialized = JsonSerializer.Deserialize<Secret>(serialized);
        
        deserialized.Kid.Should().Be(secret.Kid);
        deserialized.Type.Should().Be(secret.Type);
        deserialized.VerificationMaterial.Format.Should().Be(secret.VerificationMaterial.Format);
        deserialized.VerificationMaterial.Value.Should().Be(secret.VerificationMaterial.Value);
    }
}