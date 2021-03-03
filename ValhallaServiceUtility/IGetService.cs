using System.Threading.Tasks;

namespace Valhalla.Services
{
	public interface IGetService<TQuery, TResult>
	{
		ValueTask<TResult> GetAsync(TQuery query);
	}
}
