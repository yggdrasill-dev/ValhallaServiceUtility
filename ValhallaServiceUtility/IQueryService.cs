using System.Collections.Generic;

namespace Valhalla.Services
{
	public interface IQueryService<TQuery, TResult>
	{
		IAsyncEnumerable<TResult> QueryAsync(TQuery query);
	}
}
