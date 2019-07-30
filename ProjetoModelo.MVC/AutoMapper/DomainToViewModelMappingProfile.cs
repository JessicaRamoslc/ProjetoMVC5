using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoModelo.MVC.ViewModels;

namespace ProjetoModelo.MVC.AutoMapper {
    public class DomainToViewModelMappingProfile : Profile {

        public override string ProfileName {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure () {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}