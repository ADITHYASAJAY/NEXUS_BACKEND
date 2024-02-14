using AutoMapper;
using NexusBackEndAPI;
using NexusUserBackend.DTO;
using NexusUserBackend.Entities;


namespace NexusUserBackend.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly ContextClass _context;
        private IMapper _mapper;

        public UserRepository(ContextClass context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

  

        public bool  Add(UserDto userModel)
        {
            try
            {
                if (userModel.Role == "Student") 
                {
                    var StudentPresent = _context.Students.Find(userModel.PersonalId);
                    var IsUserPresent = _context.Users.SingleOrDefault(x => x.PersonalId == userModel.PersonalId);
                    if (StudentPresent != null && IsUserPresent == null) 
                    {
                        var u = _mapper.Map<User>(userModel);
                        _context.Users.Add(u);
                        _context.SaveChanges();
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                    
                }
                else if(userModel.Role=="Teacher")
                {
                    var TeacherPresent = _context.Teachers.Find(userModel.PersonalId);
                    var IsUserPresent = _context.Users.SingleOrDefault(x=>x.PersonalId==userModel.PersonalId);
                    if (TeacherPresent != null && IsUserPresent == null) 
                    {
                        var u = _mapper.Map<User>(userModel);
                        _context.Users.Add(u);
                        _context.SaveChanges();
                        return true;
                    }
                    else 
                    {
                        return false;
                    }

                }
                else { return false; }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
        public User Validate(LoginUser loginUser)
        {
            return _context.Users.SingleOrDefault(u => u.Email == loginUser.Email && u.Password == loginUser.Password);
        }
    }
}
