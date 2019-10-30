using System.Linq;
using System.Threading.Tasks;
using NetCoreApiTemplate.Extensions;
using NetCoreApiTemplate.Extensions.Pagination;
using NetCoreApiTemplate.Forms;
using NetCoreApiTemplate.Services.Shared;
using NetCoreApiTemplate.ViewModels;

namespace NetCoreApiTemplate.Services
{
    public class HomeService
    {
        private static int _numTimesCalled = 0;
        
        public ServiceOperationResult GetHome()
        {
            ++_numTimesCalled;

            if (_numTimesCalled > 3)
            {
                return ServiceOperationResult.BadRequest("Dude. Really.");
            }
            if (_numTimesCalled > 1)
            {
                return ServiceOperationResult.Conflict("I already told you we're up!");
            }
            
            return ServiceOperationResult.Ok("Up and running!");
        }

        public async Task<ServiceOperationResult<PaginationViewModel<int>>> GetNumbersAsync(NumbersForm form)
        {
            var list = Enumerable.Range(0, form.Number);
            
            return ServiceOperationResult.Ok(
                await list.AsQueryable()
                    .PaginateAsync(
                        new PaginationParams
                        {
                            Page = 0,
                            PageSize = 5
                        },
                        map: x => x
                    )
            );
        }
    }
}