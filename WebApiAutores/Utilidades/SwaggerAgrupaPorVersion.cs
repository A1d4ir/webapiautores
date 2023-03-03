using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WebApiAutores.Utilidades
{
    public class SwaggerAgrupaPorVersion : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var namespaceControlador = controller.ControllerType.Namespace; // retorna el namespace del controlador
            var versionAPI =  namespaceControlador.Split('.').Last().ToLower(); // v1
            controller.ApiExplorer.GroupName = versionAPI;
        }
    }
}
