using AutoMapper;
using HG.BE.External.Fourth.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HG.BE.External.Fourth
{
    public class FourthMapperProfile : Profile
    {
        public FourthMapperProfile()
        {
            CreateMap<TransactionDiscItemDto, FourthDatasetRow>();
            CreateMap<TransactionMainsAwayDto, FourthDatasetRow>();
            CreateMap<TransactionModifierItemDto, FourthDatasetRow>();
            CreateMap<TransactionPrintCheckDto, FourthDatasetRow>();
            CreateMap<TransactionSalesItemDto, FourthDatasetRow>();
            CreateMap<TransactionServiceChargeDto, FourthDatasetRow>();
            CreateMap<TransactionTabCloseDto, FourthDatasetRow>();
            CreateMap<TransactionTabOpenDto, FourthDatasetRow>();
            CreateMap<TransactionTenderDto, FourthDatasetRow>();
            CreateMap<TransactionVoidErrorDto, FourthDatasetRow>();
            CreateMap<TransactionVoidItemDto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste10Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste11Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste2Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste3Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste4Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste5Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste6Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste7Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste8Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWaste9Dto, FourthDatasetRow>();
            CreateMap<TransactionVoidWasteDto, FourthDatasetRow>();
        }

    }
}
