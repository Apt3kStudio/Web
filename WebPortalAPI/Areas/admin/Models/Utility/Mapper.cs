using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Data;
using WebPortalAPI.Areas.admin.Models;
using WebPortalAPI.Models;

namespace WebPortalAPI.Areas.Admin.Models.Utility
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<FirebaseSetting, FirebaseSettingVM>().ReverseMap();
            CreateMap<FirebaseSetting, FirebaseSupportService>().ReverseMap();
            CreateMap<FileUpload, FileUploadVM>().ReverseMap();
            CreateMap<LandingPage, Areas.admin.Models.LandingPageVM>().ReverseMap();
            CreateMap<LandingPage, WebPortalAPI.Models.LandingPageVM>().ReverseMap();
        }
    }
}
