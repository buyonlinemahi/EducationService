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
    public class CollegeService : ICollegeService
    {
        private readonly ICollege _college;
        private readonly IFaculty _faculty;
        public CollegeService(ICollege college, IFaculty faculty)
        {
            _college = college;
            _faculty = faculty;
        }

        public int AddCollege(DTO.College college)
        {
            return _college.AddCollege(Mapper.Map<DTO.College, HCRGUniversity.Core.BL.Model.College>(college));
        }

        public int UpdateCollege(DTO.College college)
        {
            return _college.UpdateCollege(Mapper.Map<DTO.College, HCRGUniversity.Core.BL.Model.College>(college));
        }

        public void DeleteCollege(int collegeID, bool IsActive)
        {
            _college.DeleteCollege(collegeID, IsActive);
        }

        public IEnumerable<College> getAllCollege(int clientID)
        {
            return Mapper.Map<IEnumerable<College>>(_college.getAllCollege(clientID));
        }

        public IEnumerable<College> getAllCollegeActive(int clientID)
        {
            return Mapper.Map<IEnumerable<College>>(_college.getAllCollegeActive(clientID));
        }

        public IEnumerable<College> GetAllCollegeWeb(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<College>>(_college.GetAllCollegeWeb(OrganizationID));
        }

        public IEnumerable<College> GetAllCollegeActiveWeb(int OrganizationID)
        {
            return Mapper.Map<IEnumerable<College>>(_college.GetAllCollegeActiveWeb(OrganizationID));
        }

        public College GetCollegeByID(int collegeID)
        {
            return Mapper.Map<College>(_college.GetCollageByID(collegeID));
        }

        public DTO.Paged.PagedCollege GetAllPagedCollege(int skip, int take, int clientID)
        {
            return Mapper.Map<DTO.Paged.PagedCollege>(_college.GetAllPagedCollege(skip, take, clientID));
        }
        
        //faculty..hp
        public int AddFaculty(DTO.Faculty _facul)
        {
            return _faculty.AddFaculty(Mapper.Map<DTO.Faculty, HCRGUniversity.Core.Data.Model.Faculty>(_facul));
        }

        public int UpdateFaculty(DTO.Faculty _facul)
        {
            return _faculty.UpdateFaculty(Mapper.Map<DTO.Faculty, HCRGUniversity.Core.Data.Model.Faculty>(_facul));
        }

        public DTO.Paged.PagedFaculty GetAllPagedFaculty(int skip, int take, int organizationID, int ClientID)
        {
            return Mapper.Map<DTO.Paged.PagedFaculty>(_faculty.GetAllFaculties(skip, take, organizationID, ClientID));
        }

        public DTO.Faculty GetFacultyById(int id)
        {
            return Mapper.Map<DTO.Faculty>(_faculty.GetFacultyById(id));
        }

        public IEnumerable<College> GetAllCollegeByOrganizationID(int _organizationID)
        {
            return Mapper.Map<IEnumerable<College>>(_college.GetAllCollegeByOrganizationID(_organizationID));
        }
    }
}