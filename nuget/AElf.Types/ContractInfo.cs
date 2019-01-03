// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: contract-info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.Genesis {

  /// <summary>Holder for reflection information generated from contract-info.proto</summary>
  public static partial class ContractInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for contract-info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContractInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNjb250cmFjdC1pbmZvLnByb3RvGgxjb21tb24ucHJvdG8ibAoMQ29udHJh",
            "Y3RJbmZvEhQKDFNlcmlhbE51bWJlchgBIAEoBBIQCghDYXRlZ29yeRgCIAEo",
            "BRIXCgVPd25lchgDIAEoCzIILkFkZHJlc3MSGwoMQ29udHJhY3RIYXNoGAQg",
            "ASgLMgUuSGFzaEIZqgIWQUVsZi5Db250cmFjdHMuR2VuZXNpc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Common.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.Genesis.ContractInfo), global::AElf.Contracts.Genesis.ContractInfo.Parser, new[]{ "SerialNumber", "Category", "Owner", "ContractHash" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ContractInfo : pb::IMessage<ContractInfo> {
    private static readonly pb::MessageParser<ContractInfo> _parser = new pb::MessageParser<ContractInfo>(() => new ContractInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContractInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.Genesis.ContractInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContractInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContractInfo(ContractInfo other) : this() {
      serialNumber_ = other.serialNumber_;
      category_ = other.category_;
      owner_ = other.owner_ != null ? other.owner_.Clone() : null;
      contractHash_ = other.contractHash_ != null ? other.contractHash_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContractInfo Clone() {
      return new ContractInfo(this);
    }

    /// <summary>Field number for the "SerialNumber" field.</summary>
    public const int SerialNumberFieldNumber = 1;
    private ulong serialNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong SerialNumber {
      get { return serialNumber_; }
      set {
        serialNumber_ = value;
      }
    }

    /// <summary>Field number for the "Category" field.</summary>
    public const int CategoryFieldNumber = 2;
    private int category_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "Owner" field.</summary>
    public const int OwnerFieldNumber = 3;
    private global::AElf.Common.Address owner_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Common.Address Owner {
      get { return owner_; }
      set {
        owner_ = value;
      }
    }

    /// <summary>Field number for the "ContractHash" field.</summary>
    public const int ContractHashFieldNumber = 4;
    private global::AElf.Common.Hash contractHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Common.Hash ContractHash {
      get { return contractHash_; }
      set {
        contractHash_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContractInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContractInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SerialNumber != other.SerialNumber) return false;
      if (Category != other.Category) return false;
      if (!object.Equals(Owner, other.Owner)) return false;
      if (!object.Equals(ContractHash, other.ContractHash)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SerialNumber != 0UL) hash ^= SerialNumber.GetHashCode();
      if (Category != 0) hash ^= Category.GetHashCode();
      if (owner_ != null) hash ^= Owner.GetHashCode();
      if (contractHash_ != null) hash ^= ContractHash.GetHashCode();
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
      if (SerialNumber != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(SerialNumber);
      }
      if (Category != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Category);
      }
      if (owner_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Owner);
      }
      if (contractHash_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ContractHash);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SerialNumber != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SerialNumber);
      }
      if (Category != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Category);
      }
      if (owner_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Owner);
      }
      if (contractHash_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContractHash);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContractInfo other) {
      if (other == null) {
        return;
      }
      if (other.SerialNumber != 0UL) {
        SerialNumber = other.SerialNumber;
      }
      if (other.Category != 0) {
        Category = other.Category;
      }
      if (other.owner_ != null) {
        if (owner_ == null) {
          owner_ = new global::AElf.Common.Address();
        }
        Owner.MergeFrom(other.Owner);
      }
      if (other.contractHash_ != null) {
        if (contractHash_ == null) {
          contractHash_ = new global::AElf.Common.Hash();
        }
        ContractHash.MergeFrom(other.ContractHash);
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
          case 8: {
            SerialNumber = input.ReadUInt64();
            break;
          }
          case 16: {
            Category = input.ReadInt32();
            break;
          }
          case 26: {
            if (owner_ == null) {
              owner_ = new global::AElf.Common.Address();
            }
            input.ReadMessage(owner_);
            break;
          }
          case 34: {
            if (contractHash_ == null) {
              contractHash_ = new global::AElf.Common.Hash();
            }
            input.ReadMessage(contractHash_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code