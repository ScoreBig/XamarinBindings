using Foundation;

namespace KissMetrics.iOS
{
//   @interface KISSmetricsAPI : NSObject
  [BaseType(typeof(NSObject))]
  interface KISSmetricsAPI
  {
    // +(KISSmetricsAPI *)sharedAPIWithKey:(NSString *)apiKey;
    [Static]
    [Export("sharedAPIWithKey:")]
    KISSmetricsAPI SharedAPIWithKey(string apiKey);

    // +(KISSmetricsAPI *)sharedAPI;
    [Static]
    [Export("sharedAPI")]
//    [Verify(MethodToProperty)]
    KISSmetricsAPI SharedAPI { get; }

    // -(void)identify:(NSString *)identity;
    [Export("identify:")]
    void Identify(string identity);

    // -(NSString *)identity;
    [Export("identity")]
//    [Verify(MethodToProperty)]
    string Identity { get; }

    // -(void)clearIdentity;
    [Export("clearIdentity")]
    void ClearIdentity();

    // -(void)alias:(NSString *)firstIdentity withIdentity:(NSString *)secondIdentity;
    [Export("alias:withIdentity:")]
    void Alias(string firstIdentity, string secondIdentity);

    // -(void)record:(NSString *)eventName withProperties:(NSDictionary *)properties;
    [Export("record:withProperties:")]
    void Record(string eventName, NSDictionary properties);

    // -(void)record:(NSString *)eventName;
    [Export("record:")]
    void Record(string eventName);

    // -(void)recordEvent:(NSString *)eventName withProperties:(NSDictionary *)properties __attribute__((deprecated("use method record:withProperties: instead")));
    [Export("recordEvent:withProperties:")]
    void RecordEvent(string eventName, NSDictionary properties);

    // -(void)record:(NSString *)eventName withProperties:(NSDictionary *)properties onCondition:(KMARecordCondition)condition;
    [Export("record:withProperties:onCondition:")]
    void Record(string eventName, NSDictionary properties, KMARecordCondition condition);

    // -(void)record:(NSString *)eventName onCondition:(KMARecordCondition)condition;
    [Export("record:onCondition:")]
    void Record(string eventName, KMARecordCondition condition);

    // -(void)recordOnce:(NSString *)eventName __attribute__((deprecated("use method record:onCondition: instead")));
    [Export("recordOnce:")]
    void RecordOnce(string eventName);

    // -(void)set:(NSDictionary *)properties;
    [Export("set:")]
    void Set(NSDictionary properties);

    // -(void)setProperties:(NSDictionary *)properties __attribute__((deprecated("use method set: instead")));
    [Export("setProperties:")]
    void SetProperties(NSDictionary properties);

    // -(void)setDistinct:(NSObject *)propertyValue forKey:(NSString *)propertyKey;
    [Export("setDistinct:forKey:")]
    void SetDistinct(NSObject propertyValue, string propertyKey);

    // -(void)autoRecordAppLifecycle;
    [Export("autoRecordAppLifecycle")]
    void AutoRecordAppLifecycle();

    // -(void)autoRecordInstalls;
    [Export("autoRecordInstalls")]
    void AutoRecordInstalls();

    // -(void)autoSetHardwareProperties;
    [Export("autoSetHardwareProperties")]
    void AutoSetHardwareProperties();

    // -(void)autoSetAppProperties;
    [Export("autoSetAppProperties")]
    void AutoSetAppProperties();
  }
}