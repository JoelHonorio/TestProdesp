#region Usings

using AutoMapper;
using Prodesp.Negocios.Models;
using Prodesp.ViewModels;

#endregion

namespace Prodesp.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fabricante, FabricanteViewModel>().ReverseMap();
            CreateMap<Imunobiologico, ImunobiologicoViewModel>().ReverseMap();
        }
    }
}