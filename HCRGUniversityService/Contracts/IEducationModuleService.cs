using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;

namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IEducationModuleService
    {
        [OperationContract]
        int AddEducationModule(EducationModule educationModule);
        [OperationContract]
        int UpdateEducationModule(EducationModule educationModule);
        [OperationContract]
        int UpdateEducationModuleTime(EducationModule educationModule);
        [OperationContract]
        void DeleteEducationModule(int educationModuleID);
        [OperationContract]
        EducationModule GetEducationModuleByID(int educationModuleID);
        [OperationContract]
        IEnumerable<EducationModule> GetAllEducationModule();
        [OperationContract]
        IEnumerable<EducationModule> GetAllEducationModuleByEducationID(int educationID);
        [OperationContract]
        Client GetOrganizationClientByEducationModuleID(int educationModuleID);
        //Filetype
        [OperationContract]
        IEnumerable<FileType> GetAllFileType();

        //EducationModuleFile
        [OperationContract]
        int AddEducationModuleFile(EducationModuleFile educationModuleFile);
        [OperationContract]
        int UpdateEducationModuleFile(EducationModuleFile educationModuleFile);
        [OperationContract]
        void DeleteEducationModuleFile(int educationModuleFileID);
        [OperationContract]
        EducationModuleFile GetEducationModuleFileByID(int educationModuleFileID);
        [OperationContract]
        IEnumerable<EducationModuleFile> GetAllEducationModuleFile();
        [OperationContract]
        EducationModuleFile GetEducationModuleFileByModuleID(int educationModuleID);
        [OperationContract]
        void DeleteEducationModuleFileByEducationModuleFileID(int EducationModuleFileID, int FileTypeID);

     
        [OperationContract]
        PagedEducationModule GetAllPagedEducationModuleByEid(int educationID, int skip, int take);
        [OperationContract]
        IEnumerable<DTO.EducationModuleFile> GetMyEducationModulesDetailsByMEID_FileTypeID(int emID, int FileTypeID);
    }

}
