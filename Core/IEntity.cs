namespace Ats.CLEANARCH.CSM.ClientApi.Core
{
  public interface IEntity
  { }

  public interface IEntity<TKey> : IEntity
  {
    TKey UserId { get; set; }
  }
}
