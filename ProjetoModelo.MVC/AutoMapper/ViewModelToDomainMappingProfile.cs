using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoModelo.MVC.ViewModels;

namespace ProjetoModelo.MVC.AutoMapper {
    public class ViewModelToDomainMappingProfile : Profile {

        public override string ProfileName {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure ( ) {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}