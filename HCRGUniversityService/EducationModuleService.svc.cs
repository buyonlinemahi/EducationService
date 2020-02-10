using System.ServiceModel;
using AutoMapper;
using HCRGUniversity.Core.BL;
using HCRGUniversityService.Contracts;
using HCRGUniversityService.CustomServiceBehaviors;
using System.Collections.Generic;
using HCRGUniversityService.DTO;

namespace HCRGUniversityService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AutoMapperServiceBehavior]
    public class EducationModuleService : IEducationModuleService
    {
        private readonly IEducationModule _educationModule;
        private readonly IEducationModuleFile _educationModuleFile;
        private readonly IFileType _fileType;


        public EducationModuleService(IEducationModule educationModule, IEducationModuleFile educationModuleFile, IFileType fileType)
        {
            _educationModule = educationModule;
            _educationModuleFile = educationModuleFile;
            _fileType = fileType;

        }

        public int AddEducationModule(DTO.EducationModule educationModule)
        {
            return _educationModule.AddEducationModule(Mapper.Map<DTO.EducationModule, HCRGUniversity.Core.Data.Model.EducationModule>(educationModule));
        }

        public int UpdateEducationModule(DTO.EducationModule educationModule)
        {
            return _educationModule.UpdateEducationModule(Mapper.Map<DTO.EducationModule, HCRGUniversity.Core.Data.Model.EducationModule>(educationModule));
        }

        public int UpdateEducationModuleTime(DTO.EducationModule educationModule)
        {
            return _educationModule.UpdateEducationModuleTime(Mapper.Map<DTO.EducationModule, HCRGUniversity.Core.Data.Model.EducationModule>(educationModule));
        }

        public void DeleteEducationModule(int educationModuleID)
        {
            _educationModule.DeleteEducationModule(educationModuleID);
        }

        public EducationModule GetEducationModuleByID(int educationModuleID)
        {
            return Mapper.Map<EducationModule>(_educationModule.GetEducationModuleByID(educationModuleID));
        }

        public IEnumerable<EducationModule> GetAllEducationModule()
        {
            return Mapper.Map<IEnumerable<EducationModule>>(_educationModule.GetAllEducationModule());
        }

        public IEnumerable<EducationModule> GetAllEducationModuleByEducationID(int educationID)
        {
            return Mapper.Map<IEnumerable<EducationModule>>(_educationModule.GetAllEducationModuleByEducationID(educationID));
        }

        public Client GetOrganizationClientByEducationModuleID(int educationModuleID)
        {
            return Mapper.Map<Client>(_educationModule.GetOrganizationClientByEducationModuleID(educationModuleID));
        }

        //FileType

        public IEnumerable<FileType> GetAllFileType()
        {
            return Mapper.Map<IEnumerable<FileType>>(_fileType.GetAllFileType());
        }

        //EducationModuleFile

        public int AddEducationModuleFile(DTO.EducationModuleFile educationModuleFile)
        {
            return _educationModuleFile.AddEducationModuleFile(Mapper.Map<DTO.EducationModuleFile, HCRGUniversity.Core.Data.Model.EducationModuleFile>(educationModuleFile));
        }

        public int UpdateEducationModuleFile(DTO.EducationModuleFile educationModuleFile)
        {
            return _educationModuleFile.UpdateEducationModuleFile(Mapper.Map<DTO.EducationModuleFile, HCRGUniversity.Core.Data.Model.EducationModuleFile>(educationModuleFile));
        }

        public void DeleteEducationModuleFile(int educationModuleFileID)
        {
            _educationModuleFile.DeleteEducationModuleFile(educationModuleFileID);
        }


        public void DeleteEducationModuleFileByEducationModuleFileID(int EducationModuleFileID, int FileTypeID)
        {
            _educationModuleFile.DeleteEducationModuleFileByEducationModuleFileID(EducationModuleFileID, FileTypeID);
        }

        public EducationModuleFile GetEducationModuleFileByID(int educationModuleFileID)
        {
            return Mapper.Map<EducationModuleFile>(_educationModuleFile.GetEducationModuleFileByID(educationModuleFileID));
        }

        public IEnumerable<EducationModuleFile> GetAllEducationModuleFile()
        {
            return Mapper.Map<IEnumerable<EducationModuleFile>>(_educationModuleFile.GetAllEducationModuleFile());
        }

        public EducationModuleFile GetEducationModuleFileByModuleID(int educationModuleID)
        {
            return Mapper.Map<EducationModuleFile>(_educationModuleFile.GetEducationModuleFileByModuleID(educationModuleID));
        }


       

        //LAzy Binding
        public DTO.Paged.PagedEducationModule GetAllPagedEducationModuleByEid(int educationid, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedEducationModule>(_educationModule.GetAllPagedEducationModuleByEid(educationid, skip, take));
        }

        public IEnumerable<DTO.EducationModuleFile> GetMyEducationModulesDetailsByMEID_FileTypeID(int emID, int FileTypeID)
        {
            return Mapper.Map<IEnumerable<EducationModuleFile>>(_educationModuleFile.GetMyEducationModulesDetailsByMEID_FileTypeID(emID, FileTypeID));
        }



    }
}
