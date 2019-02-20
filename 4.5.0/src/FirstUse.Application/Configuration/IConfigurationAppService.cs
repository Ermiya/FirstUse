using System.Threading.Tasks;
using FirstUse.Configuration.Dto;

namespace FirstUse.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
