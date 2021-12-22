// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/feedreader.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcServiceK8s {

  /// <summary>Holder for reflection information generated from Protos/feedreader.proto</summary>
  public static partial class FeedreaderReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/feedreader.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedreaderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90b3MvZmVlZHJlYWRlci5wcm90bxILbWFpbnNlcnZpY2UaG2dvb2ds",
            "ZS9wcm90b2J1Zi9lbXB0eS5wcm90byI5CgxGZWVkUmVzcG9uY2USKQoJRmVl",
            "ZEl0ZW1zGAEgAygLMhYubWFpbnNlcnZpY2UuRmVlZE1vZGVsIk4KCUZlZWRN",
            "b2RlbBINCgV0aXRsZRgBIAEoCRIPCgdzdW1tYXJ5GAIgASgJEgwKBGxpbmsY",
            "AyABKAkSEwoLcHVibGlzaERhdGUYBCABKAkySwoLRmVlZFNlcnZpY2USPAoH",
            "R2V0RmVlZBIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRoZLm1haW5zZXJ2aWNl",
            "LkZlZWRSZXNwb25jZUIRqgIOR3JwY1NlcnZpY2VLOHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceK8s.FeedResponce), global::GrpcServiceK8s.FeedResponce.Parser, new[]{ "FeedItems" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceK8s.FeedModel), global::GrpcServiceK8s.FeedModel.Parser, new[]{ "Title", "Summary", "Link", "PublishDate" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The response message containing list of items.
  /// </summary>
  public sealed partial class FeedResponce : pb::IMessage<FeedResponce>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedResponce> _parser = new pb::MessageParser<FeedResponce>(() => new FeedResponce());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedResponce> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceK8s.FeedreaderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedResponce() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedResponce(FeedResponce other) : this() {
      feedItems_ = other.feedItems_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedResponce Clone() {
      return new FeedResponce(this);
    }

    /// <summary>Field number for the "FeedItems" field.</summary>
    public const int FeedItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GrpcServiceK8s.FeedModel> _repeated_feedItems_codec
        = pb::FieldCodec.ForMessage(10, global::GrpcServiceK8s.FeedModel.Parser);
    private readonly pbc::RepeatedField<global::GrpcServiceK8s.FeedModel> feedItems_ = new pbc::RepeatedField<global::GrpcServiceK8s.FeedModel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcServiceK8s.FeedModel> FeedItems {
      get { return feedItems_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedResponce);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedResponce other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!feedItems_.Equals(other.feedItems_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= feedItems_.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      feedItems_.WriteTo(output, _repeated_feedItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      feedItems_.WriteTo(ref output, _repeated_feedItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += feedItems_.CalculateSize(_repeated_feedItems_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FeedResponce other) {
      if (other == null) {
        return;
      }
      feedItems_.Add(other.feedItems_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            feedItems_.AddEntriesFrom(input, _repeated_feedItems_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            feedItems_.AddEntriesFrom(ref input, _repeated_feedItems_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The response message containing the feed.
  /// </summary>
  public sealed partial class FeedModel : pb::IMessage<FeedModel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedModel> _parser = new pb::MessageParser<FeedModel>(() => new FeedModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceK8s.FeedreaderReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedModel(FeedModel other) : this() {
      title_ = other.title_;
      summary_ = other.summary_;
      link_ = other.link_;
      publishDate_ = other.publishDate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedModel Clone() {
      return new FeedModel(this);
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 1;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "summary" field.</summary>
    public const int SummaryFieldNumber = 2;
    private string summary_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Summary {
      get { return summary_; }
      set {
        summary_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "link" field.</summary>
    public const int LinkFieldNumber = 3;
    private string link_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Link {
      get { return link_; }
      set {
        link_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "publishDate" field.</summary>
    public const int PublishDateFieldNumber = 4;
    private string publishDate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PublishDate {
      get { return publishDate_; }
      set {
        publishDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Title != other.Title) return false;
      if (Summary != other.Summary) return false;
      if (Link != other.Link) return false;
      if (PublishDate != other.PublishDate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Summary.Length != 0) hash ^= Summary.GetHashCode();
      if (Link.Length != 0) hash ^= Link.GetHashCode();
      if (PublishDate.Length != 0) hash ^= PublishDate.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Summary.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Summary);
      }
      if (Link.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Link);
      }
      if (PublishDate.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PublishDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Summary.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Summary);
      }
      if (Link.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Link);
      }
      if (PublishDate.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PublishDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Summary.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Summary);
      }
      if (Link.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Link);
      }
      if (PublishDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PublishDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FeedModel other) {
      if (other == null) {
        return;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Summary.Length != 0) {
        Summary = other.Summary;
      }
      if (other.Link.Length != 0) {
        Link = other.Link;
      }
      if (other.PublishDate.Length != 0) {
        PublishDate = other.PublishDate;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Title = input.ReadString();
            break;
          }
          case 18: {
            Summary = input.ReadString();
            break;
          }
          case 26: {
            Link = input.ReadString();
            break;
          }
          case 34: {
            PublishDate = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Title = input.ReadString();
            break;
          }
          case 18: {
            Summary = input.ReadString();
            break;
          }
          case 26: {
            Link = input.ReadString();
            break;
          }
          case 34: {
            PublishDate = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
