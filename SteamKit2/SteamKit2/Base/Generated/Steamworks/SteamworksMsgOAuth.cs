//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_oauth.steamworkssdk.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamworkssdk.proto
namespace SteamKit2.Steamworks
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COAuthToken_ImplicitGrantNoPrompt_Request")]
  public partial class COAuthToken_ImplicitGrantNoPrompt_Request : global::ProtoBuf.IExtensible
  {
    public COAuthToken_ImplicitGrantNoPrompt_Request() {}
    

    private string _clientid = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"clientid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clientid
    {
      get { return _clientid; }
      set { _clientid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"COAuthToken_ImplicitGrantNoPrompt_Response")]
  public partial class COAuthToken_ImplicitGrantNoPrompt_Response : global::ProtoBuf.IExtensible
  {
    public COAuthToken_ImplicitGrantNoPrompt_Response() {}
    

    private string _access_token = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"access_token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string access_token
    {
      get { return _access_token; }
      set { _access_token = value; }
    }

    private string _redirect_uri = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"redirect_uri", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string redirect_uri
    {
      get { return _redirect_uri; }
      set { _redirect_uri = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IOAuthToken
    {
      COAuthToken_ImplicitGrantNoPrompt_Response ImplicitGrantNoPrompt(COAuthToken_ImplicitGrantNoPrompt_Request request);
    
    }
    
    
}
#pragma warning restore 1591
