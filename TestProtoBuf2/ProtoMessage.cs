//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: friend.proto
// Note: requires additional types generated from: Person.proto
namespace Xsjm.Logic.Protocols
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2S_GetFriendList_message")]
  public partial class C2S_GetFriendList_message : global::ProtoBuf.IExtensible
  {
    public C2S_GetFriendList_message() {}
    
    private int? _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result?? default(int); }
      set { _result = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool resultSpecified
    {
      get { return this._result != null; }
      set { if (value == (this._result== null)) this._result = value ? this.result : (int?)null; }
    }
    private bool ShouldSerializeresult() { return resultSpecified; }
    private void Resetresult() { resultSpecified = false; }
    
    private Xsjm.Logic.Protocols.Person _p = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"p", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Xsjm.Logic.Protocols.Person p
    {
      get { return _p; }
      set { _p = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
// Generated from: Person.proto
namespace Xsjm.Logic.Protocols
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Person")]
  public partial class Person : global::ProtoBuf.IExtensible
  {
    public Person() {}
    
    private int? _value;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int value
    {
      get { return _value?? default(int); }
      set { _value = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool valueSpecified
    {
      get { return this._value != null; }
      set { if (value == (this._value== null)) this._value = value ? this.value : (int?)null; }
    }
    private bool ShouldSerializevalue() { return valueSpecified; }
    private void Resetvalue() { valueSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
// Generated from: Student.proto
// Note: requires additional types generated from: Person.proto
namespace Xsjm.Logic.Protocols
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2S_GetStudentInfo")]
  public partial class C2S_GetStudentInfo : global::ProtoBuf.IExtensible
  {
    public C2S_GetStudentInfo() {}
    
    private int? _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id?? default(int); }
      set { _id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool idSpecified
    {
      get { return this._id != null; }
      set { if (value == (this._id== null)) this._id = value ? this.id : (int?)null; }
    }
    private bool ShouldSerializeid() { return idSpecified; }
    private void Resetid() { idSpecified = false; }
    
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name?? ""; }
      set { _name = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool nameSpecified
    {
      get { return this._name != null; }
      set { if (value == (this._name== null)) this._name = value ? this.name : (string)null; }
    }
    private bool ShouldSerializename() { return nameSpecified; }
    private void Resetname() { nameSpecified = false; }
    
    private int? _age;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"age", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int age
    {
      get { return _age?? default(int); }
      set { _age = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool ageSpecified
    {
      get { return this._age != null; }
      set { if (value == (this._age== null)) this._age = value ? this.age : (int?)null; }
    }
    private bool ShouldSerializeage() { return ageSpecified; }
    private void Resetage() { ageSpecified = false; }
    
    private readonly global::System.Collections.Generic.List<Xsjm.Logic.Protocols.Person> _person = new global::System.Collections.Generic.List<Xsjm.Logic.Protocols.Person>();
    [global::ProtoBuf.ProtoMember(4, Name=@"person", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Xsjm.Logic.Protocols.Person> person
    {
      get { return _person; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2S_Login")]
  public partial class C2S_Login : global::ProtoBuf.IExtensible
  {
    public C2S_Login() {}
    
    private int? _PID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PID
    {
      get { return _PID?? (int)1; }
      set { _PID = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool PIDSpecified
    {
      get { return this._PID != null; }
      set { if (value == (this._PID== null)) this._PID = value ? this.PID : (int?)null; }
    }
    private bool ShouldSerializePID() { return PIDSpecified; }
    private void ResetPID() { PIDSpecified = false; }
    
    private string _AuthInfo;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"AuthInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AuthInfo
    {
      get { return _AuthInfo?? ""; }
      set { _AuthInfo = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool AuthInfoSpecified
    {
      get { return this._AuthInfo != null; }
      set { if (value == (this._AuthInfo== null)) this._AuthInfo = value ? this.AuthInfo : (string)null; }
    }
    private bool ShouldSerializeAuthInfo() { return AuthInfoSpecified; }
    private void ResetAuthInfo() { AuthInfoSpecified = false; }
    
    private string _Platform;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Platform", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Platform
    {
      get { return _Platform?? ""; }
      set { _Platform = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool PlatformSpecified
    {
      get { return this._Platform != null; }
      set { if (value == (this._Platform== null)) this._Platform = value ? this.Platform : (string)null; }
    }
    private bool ShouldSerializePlatform() { return PlatformSpecified; }
    private void ResetPlatform() { PlatformSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}