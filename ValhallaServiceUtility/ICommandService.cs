using System.Threading.Tasks;

namespace Valhalla.Services
{
	public interface ICommandService<TCommand>
	{
		ValueTask ExecuteAsync(TCommand command);
	}
}
