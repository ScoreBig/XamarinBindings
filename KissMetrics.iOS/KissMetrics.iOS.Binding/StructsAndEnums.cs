using ObjCRuntime;

namespace KissMetrics.iOS
{
  [Native]
  public enum KMARecordCondition : long
  {
    Always,
    OncePerInstall,
    OncePerIdentity
  }
}