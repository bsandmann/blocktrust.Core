namespace Blocktrust.Common.Resolver;

using Models.DidDoc;

public interface IDidDocResolver {
    DidDoc? Resolve(string did);
}