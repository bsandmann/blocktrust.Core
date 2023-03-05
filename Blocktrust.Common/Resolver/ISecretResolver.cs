namespace Blocktrust.Common.Resolver;

using Models.Secrets;

public interface ISecretResolver
{
    Secret? FindKey(string kid);
    HashSet<string> FindKeys(List<string> kids);
    public void AddKey(string kid, Secret secret);
}