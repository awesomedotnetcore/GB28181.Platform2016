// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gb28181config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Manage {

  /// <summary>Holder for reflection information generated from gb28181config.proto</summary>
  public static partial class Gb28181ConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for gb28181config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Gb28181ConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNnYjI4MTgxY29uZmlnLnByb3RvEgZtYW5hZ2UiGwoZUXVlcnlHYjI4MTgx",
            "Q29uZmlnUmVxdWVzdCJBChdRdWVyeUdiMjgxODFDb25maWdSZXBseRImCgpz",
            "aXBhY2NvdW50GAEgAygLMhIubWFuYWdlLlNJUEFjY291bnQi4QIKClNJUEFj",
            "Y291bnQSCgoCSWQYASABKAkSDAoETmFtZRgCIAEoCRIRCglHYlZlcnNpb24Y",
            "AyABKAkSDwoHTG9jYWxJRBgEIAEoCRIPCgdMb2NhbElQGAUgASgJEhEKCUxv",
            "Y2FsUG9ydBgGIAEoCRISCgpSZW1vdGVQb3J0GAcgASgJEhYKDkF1dGhlbnRp",
            "Y2F0aW9uGAggASgJEhMKC1NJUFVzZXJuYW1lGAkgASgJEhMKC1NJUFBhc3N3",
            "b3JkGAogASgJEhMKC01zZ1Byb3RvY29sGAsgASgJEhYKDlN0cmVhbVByb3Rv",
            "Y29sGAwgASgJEg8KB1RjcE1vZGUYDSABKAkSEQoJTXNnRW5jb2RlGA4gASgJ",
            "EhYKDlBhY2tldE91dE9yZGVyGA8gASgJEhkKEUtlZXBhbGl2ZUludGVydmFs",
            "GBAgASgJEhcKD0tlZXBhbGl2ZU51bWJlchgRIAEoCTJyCg9NYW5hZ2VHYlNl",
            "cnZpY2USXwoXR2V0R2IyODE4MVNlcnZpY2VDb25maWcSIS5tYW5hZ2UuUXVl",
            "cnlHYjI4MTgxQ29uZmlnUmVxdWVzdBofLm1hbmFnZS5RdWVyeUdiMjgxODFD",
            "b25maWdSZXBseSIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Manage.QueryGb28181ConfigRequest), global::Manage.QueryGb28181ConfigRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Manage.QueryGb28181ConfigReply), global::Manage.QueryGb28181ConfigReply.Parser, new[]{ "Sipaccount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Manage.SIPAccount), global::Manage.SIPAccount.Parser, new[]{ "Id", "Name", "GbVersion", "LocalID", "LocalIP", "LocalPort", "RemotePort", "Authentication", "SIPUsername", "SIPPassword", "MsgProtocol", "StreamProtocol", "TcpMode", "MsgEncode", "PacketOutOrder", "KeepaliveInterval", "KeepaliveNumber" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message.
  /// </summary>
  public sealed partial class QueryGb28181ConfigRequest : pb::IMessage<QueryGb28181ConfigRequest> {
    private static readonly pb::MessageParser<QueryGb28181ConfigRequest> _parser = new pb::MessageParser<QueryGb28181ConfigRequest>(() => new QueryGb28181ConfigRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueryGb28181ConfigRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Manage.Gb28181ConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryGb28181ConfigRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryGb28181ConfigRequest(QueryGb28181ConfigRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryGb28181ConfigRequest Clone() {
      return new QueryGb28181ConfigRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueryGb28181ConfigRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueryGb28181ConfigRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueryGb28181ConfigRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  /// <summary>
  /// The response message.
  /// </summary>
  public sealed partial class QueryGb28181ConfigReply : pb::IMessage<QueryGb28181ConfigReply> {
    private static readonly pb::MessageParser<QueryGb28181ConfigReply> _parser = new pb::MessageParser<QueryGb28181ConfigReply>(() => new QueryGb28181ConfigReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueryGb28181ConfigReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Manage.Gb28181ConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryGb28181ConfigReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryGb28181ConfigReply(QueryGb28181ConfigReply other) : this() {
      sipaccount_ = other.sipaccount_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryGb28181ConfigReply Clone() {
      return new QueryGb28181ConfigReply(this);
    }

    /// <summary>Field number for the "sipaccount" field.</summary>
    public const int SipaccountFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Manage.SIPAccount> _repeated_sipaccount_codec
        = pb::FieldCodec.ForMessage(10, global::Manage.SIPAccount.Parser);
    private readonly pbc::RepeatedField<global::Manage.SIPAccount> sipaccount_ = new pbc::RepeatedField<global::Manage.SIPAccount>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Manage.SIPAccount> Sipaccount {
      get { return sipaccount_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueryGb28181ConfigReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueryGb28181ConfigReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sipaccount_.Equals(other.sipaccount_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sipaccount_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      sipaccount_.WriteTo(output, _repeated_sipaccount_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sipaccount_.CalculateSize(_repeated_sipaccount_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueryGb28181ConfigReply other) {
      if (other == null) {
        return;
      }
      sipaccount_.Add(other.sipaccount_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            sipaccount_.AddEntriesFrom(input, _repeated_sipaccount_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///SIPAccount ..
  /// </summary>
  public sealed partial class SIPAccount : pb::IMessage<SIPAccount> {
    private static readonly pb::MessageParser<SIPAccount> _parser = new pb::MessageParser<SIPAccount>(() => new SIPAccount());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SIPAccount> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Manage.Gb28181ConfigReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SIPAccount() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SIPAccount(SIPAccount other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      gbVersion_ = other.gbVersion_;
      localID_ = other.localID_;
      localIP_ = other.localIP_;
      localPort_ = other.localPort_;
      remotePort_ = other.remotePort_;
      authentication_ = other.authentication_;
      sIPUsername_ = other.sIPUsername_;
      sIPPassword_ = other.sIPPassword_;
      msgProtocol_ = other.msgProtocol_;
      streamProtocol_ = other.streamProtocol_;
      tcpMode_ = other.tcpMode_;
      msgEncode_ = other.msgEncode_;
      packetOutOrder_ = other.packetOutOrder_;
      keepaliveInterval_ = other.keepaliveInterval_;
      keepaliveNumber_ = other.keepaliveNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SIPAccount Clone() {
      return new SIPAccount(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "GbVersion" field.</summary>
    public const int GbVersionFieldNumber = 3;
    private string gbVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GbVersion {
      get { return gbVersion_; }
      set {
        gbVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LocalID" field.</summary>
    public const int LocalIDFieldNumber = 4;
    private string localID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LocalID {
      get { return localID_; }
      set {
        localID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LocalIP" field.</summary>
    public const int LocalIPFieldNumber = 5;
    private string localIP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LocalIP {
      get { return localIP_; }
      set {
        localIP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LocalPort" field.</summary>
    public const int LocalPortFieldNumber = 6;
    private string localPort_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LocalPort {
      get { return localPort_; }
      set {
        localPort_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "RemotePort" field.</summary>
    public const int RemotePortFieldNumber = 7;
    private string remotePort_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RemotePort {
      get { return remotePort_; }
      set {
        remotePort_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Authentication" field.</summary>
    public const int AuthenticationFieldNumber = 8;
    private string authentication_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Authentication {
      get { return authentication_; }
      set {
        authentication_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "SIPUsername" field.</summary>
    public const int SIPUsernameFieldNumber = 9;
    private string sIPUsername_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SIPUsername {
      get { return sIPUsername_; }
      set {
        sIPUsername_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "SIPPassword" field.</summary>
    public const int SIPPasswordFieldNumber = 10;
    private string sIPPassword_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SIPPassword {
      get { return sIPPassword_; }
      set {
        sIPPassword_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MsgProtocol" field.</summary>
    public const int MsgProtocolFieldNumber = 11;
    private string msgProtocol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MsgProtocol {
      get { return msgProtocol_; }
      set {
        msgProtocol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "StreamProtocol" field.</summary>
    public const int StreamProtocolFieldNumber = 12;
    private string streamProtocol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StreamProtocol {
      get { return streamProtocol_; }
      set {
        streamProtocol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "TcpMode" field.</summary>
    public const int TcpModeFieldNumber = 13;
    private string tcpMode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TcpMode {
      get { return tcpMode_; }
      set {
        tcpMode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MsgEncode" field.</summary>
    public const int MsgEncodeFieldNumber = 14;
    private string msgEncode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MsgEncode {
      get { return msgEncode_; }
      set {
        msgEncode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "PacketOutOrder" field.</summary>
    public const int PacketOutOrderFieldNumber = 15;
    private string packetOutOrder_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PacketOutOrder {
      get { return packetOutOrder_; }
      set {
        packetOutOrder_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "KeepaliveInterval" field.</summary>
    public const int KeepaliveIntervalFieldNumber = 16;
    private string keepaliveInterval_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeepaliveInterval {
      get { return keepaliveInterval_; }
      set {
        keepaliveInterval_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "KeepaliveNumber" field.</summary>
    public const int KeepaliveNumberFieldNumber = 17;
    private string keepaliveNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeepaliveNumber {
      get { return keepaliveNumber_; }
      set {
        keepaliveNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SIPAccount);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SIPAccount other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (GbVersion != other.GbVersion) return false;
      if (LocalID != other.LocalID) return false;
      if (LocalIP != other.LocalIP) return false;
      if (LocalPort != other.LocalPort) return false;
      if (RemotePort != other.RemotePort) return false;
      if (Authentication != other.Authentication) return false;
      if (SIPUsername != other.SIPUsername) return false;
      if (SIPPassword != other.SIPPassword) return false;
      if (MsgProtocol != other.MsgProtocol) return false;
      if (StreamProtocol != other.StreamProtocol) return false;
      if (TcpMode != other.TcpMode) return false;
      if (MsgEncode != other.MsgEncode) return false;
      if (PacketOutOrder != other.PacketOutOrder) return false;
      if (KeepaliveInterval != other.KeepaliveInterval) return false;
      if (KeepaliveNumber != other.KeepaliveNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (GbVersion.Length != 0) hash ^= GbVersion.GetHashCode();
      if (LocalID.Length != 0) hash ^= LocalID.GetHashCode();
      if (LocalIP.Length != 0) hash ^= LocalIP.GetHashCode();
      if (LocalPort.Length != 0) hash ^= LocalPort.GetHashCode();
      if (RemotePort.Length != 0) hash ^= RemotePort.GetHashCode();
      if (Authentication.Length != 0) hash ^= Authentication.GetHashCode();
      if (SIPUsername.Length != 0) hash ^= SIPUsername.GetHashCode();
      if (SIPPassword.Length != 0) hash ^= SIPPassword.GetHashCode();
      if (MsgProtocol.Length != 0) hash ^= MsgProtocol.GetHashCode();
      if (StreamProtocol.Length != 0) hash ^= StreamProtocol.GetHashCode();
      if (TcpMode.Length != 0) hash ^= TcpMode.GetHashCode();
      if (MsgEncode.Length != 0) hash ^= MsgEncode.GetHashCode();
      if (PacketOutOrder.Length != 0) hash ^= PacketOutOrder.GetHashCode();
      if (KeepaliveInterval.Length != 0) hash ^= KeepaliveInterval.GetHashCode();
      if (KeepaliveNumber.Length != 0) hash ^= KeepaliveNumber.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (GbVersion.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GbVersion);
      }
      if (LocalID.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LocalID);
      }
      if (LocalIP.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(LocalIP);
      }
      if (LocalPort.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(LocalPort);
      }
      if (RemotePort.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(RemotePort);
      }
      if (Authentication.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Authentication);
      }
      if (SIPUsername.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(SIPUsername);
      }
      if (SIPPassword.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(SIPPassword);
      }
      if (MsgProtocol.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(MsgProtocol);
      }
      if (StreamProtocol.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(StreamProtocol);
      }
      if (TcpMode.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(TcpMode);
      }
      if (MsgEncode.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(MsgEncode);
      }
      if (PacketOutOrder.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(PacketOutOrder);
      }
      if (KeepaliveInterval.Length != 0) {
        output.WriteRawTag(130, 1);
        output.WriteString(KeepaliveInterval);
      }
      if (KeepaliveNumber.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(KeepaliveNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (GbVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GbVersion);
      }
      if (LocalID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LocalID);
      }
      if (LocalIP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LocalIP);
      }
      if (LocalPort.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LocalPort);
      }
      if (RemotePort.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemotePort);
      }
      if (Authentication.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Authentication);
      }
      if (SIPUsername.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SIPUsername);
      }
      if (SIPPassword.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SIPPassword);
      }
      if (MsgProtocol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MsgProtocol);
      }
      if (StreamProtocol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StreamProtocol);
      }
      if (TcpMode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TcpMode);
      }
      if (MsgEncode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MsgEncode);
      }
      if (PacketOutOrder.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PacketOutOrder);
      }
      if (KeepaliveInterval.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(KeepaliveInterval);
      }
      if (KeepaliveNumber.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(KeepaliveNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SIPAccount other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.GbVersion.Length != 0) {
        GbVersion = other.GbVersion;
      }
      if (other.LocalID.Length != 0) {
        LocalID = other.LocalID;
      }
      if (other.LocalIP.Length != 0) {
        LocalIP = other.LocalIP;
      }
      if (other.LocalPort.Length != 0) {
        LocalPort = other.LocalPort;
      }
      if (other.RemotePort.Length != 0) {
        RemotePort = other.RemotePort;
      }
      if (other.Authentication.Length != 0) {
        Authentication = other.Authentication;
      }
      if (other.SIPUsername.Length != 0) {
        SIPUsername = other.SIPUsername;
      }
      if (other.SIPPassword.Length != 0) {
        SIPPassword = other.SIPPassword;
      }
      if (other.MsgProtocol.Length != 0) {
        MsgProtocol = other.MsgProtocol;
      }
      if (other.StreamProtocol.Length != 0) {
        StreamProtocol = other.StreamProtocol;
      }
      if (other.TcpMode.Length != 0) {
        TcpMode = other.TcpMode;
      }
      if (other.MsgEncode.Length != 0) {
        MsgEncode = other.MsgEncode;
      }
      if (other.PacketOutOrder.Length != 0) {
        PacketOutOrder = other.PacketOutOrder;
      }
      if (other.KeepaliveInterval.Length != 0) {
        KeepaliveInterval = other.KeepaliveInterval;
      }
      if (other.KeepaliveNumber.Length != 0) {
        KeepaliveNumber = other.KeepaliveNumber;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            GbVersion = input.ReadString();
            break;
          }
          case 34: {
            LocalID = input.ReadString();
            break;
          }
          case 42: {
            LocalIP = input.ReadString();
            break;
          }
          case 50: {
            LocalPort = input.ReadString();
            break;
          }
          case 58: {
            RemotePort = input.ReadString();
            break;
          }
          case 66: {
            Authentication = input.ReadString();
            break;
          }
          case 74: {
            SIPUsername = input.ReadString();
            break;
          }
          case 82: {
            SIPPassword = input.ReadString();
            break;
          }
          case 90: {
            MsgProtocol = input.ReadString();
            break;
          }
          case 98: {
            StreamProtocol = input.ReadString();
            break;
          }
          case 106: {
            TcpMode = input.ReadString();
            break;
          }
          case 114: {
            MsgEncode = input.ReadString();
            break;
          }
          case 122: {
            PacketOutOrder = input.ReadString();
            break;
          }
          case 130: {
            KeepaliveInterval = input.ReadString();
            break;
          }
          case 138: {
            KeepaliveNumber = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
