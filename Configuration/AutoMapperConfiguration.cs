using AutoMapper;
using Projeto_Desafio_API_Usuario.Entities;
using Projeto_Desafio_API_Usuario.Models;

namespace Projeto_Desafio_API_Usuario.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {

            CreateMap<Deputado, GetDeputadoViewModel>();

            CreateMap<Governador, GetGovernadorViewModel>();

            CreateMap<Ministro, GetMinistroViewModel>();

            CreateMap<Presidente, GetPresidenteViewModel>();

            CreateMap<Prefeito, GetPrefeitoViewModel>();

            CreateMap<Senador, GetSenadorViewModel>();

            CreateMap<Vereador, GetVereadorViewModel>();
        }
    }
}