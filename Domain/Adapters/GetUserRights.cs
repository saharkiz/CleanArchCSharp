using System;
using System.Collections.Generic;
using System.Linq;
using Ats.CLEANARCH.CSM.ClientApi.Core.Entities;
using Ats.CLEANARCH.CSM.ClientApi.Domain.Abstraction;
using Ats.CLEANARCH.CSM.ClientApi.Extension.ErrorMessages;
using Ats.CLEANARCH.CSM.ClientApi.Extension.Guards;
using Ats.CLEANARCH.CSM.ClientApi.Extension.Helper;

namespace Ats.CLEANARCH.CSM.ClientApi.Domain.Adapters
{
  internal class GetUserRights
  {
    private readonly IRepository _repository;

    public GetUserRights(IRepository repository)
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public List<Rights> Handle(Guid UserKey, Guid ResourceKey)
    {
      Guard.Against.NotImplemented(
                  _repository,
                  nameof(_repository),
                  EnumExtension.GetDescription(CsmErrorMessage.RepoNotImplemented)
                  );

      var repoResult = _repository.GetResult(UserKey, ResourceKey);
      return repoResult.Select(x => new Rights()
      {
        Resource = x.resourceKey,
        UserId = x.efmUserGuid
      }).ToList();
    }
  }
}
