// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: crosschain.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Kernel {

  /// <summary>Holder for reflection information generated from crosschain.proto</summary>
  public static partial class CrosschainReflection {

    #region Descriptor
    /// <summary>File descriptor for crosschain.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CrosschainReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBjcm9zc2NoYWluLnByb3RvGgxjb21tb24ucHJvdG8aHXBhcmVudC1jaGFp",
            "bi1ibG9jay1pbmZvLnByb3RvIn4KElNpZGVDaGFpbkJsb2NrSW5mbxIOCgZI",
            "ZWlnaHQYASABKAQSHgoPQmxvY2tIZWFkZXJIYXNoGAIgASgLMgUuSGFzaBIg",
            "ChFUcmFuc2FjdGlvbk1LUm9vdBgDIAEoCzIFLkhhc2gSFgoHQ2hhaW5JZBgE",
            "IAEoCzIFLkhhc2gizAEKFFBhcmVudENoYWluQmxvY2tJbmZvEicKBFJvb3QY",
            "ASABKAsyGS5QYXJlbnRDaGFpbkJsb2NrUm9vdEluZm8SRQoQSW5kZXhlZEJs",
            "b2NrSW5mbxgCIAMoCzIrLlBhcmVudENoYWluQmxvY2tJbmZvLkluZGV4ZWRC",
            "bG9ja0luZm9FbnRyeRpEChVJbmRleGVkQmxvY2tJbmZvRW50cnkSCwoDa2V5",
            "GAEgASgEEhoKBXZhbHVlGAIgASgLMgsuTWVya2xlUGF0aDoCOAEiIQoKTWVy",
            "a2xlUGF0aBITCgRQYXRoGAEgAygLMgUuSGFzaEIOqgILQUVsZi5LZXJuZWxi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Common.CommonReflection.Descriptor, global::AElf.Contracts.SideChain.ParentChainBlockInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Kernel.SideChainBlockInfo), global::AElf.Kernel.SideChainBlockInfo.Parser, new[]{ "Height", "BlockHeaderHash", "TransactionMKRoot", "ChainId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Kernel.ParentChainBlockInfo), global::AElf.Kernel.ParentChainBlockInfo.Parser, new[]{ "Root", "IndexedBlockInfo" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Kernel.MerklePath), global::AElf.Kernel.MerklePath.Parser, new[]{ "Path" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SideChainBlockInfo : pb::IMessage<SideChainBlockInfo> {
    private static readonly pb::MessageParser<SideChainBlockInfo> _parser = new pb::MessageParser<SideChainBlockInfo>(() => new SideChainBlockInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SideChainBlockInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Kernel.CrosschainReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SideChainBlockInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SideChainBlockInfo(SideChainBlockInfo other) : this() {
      height_ = other.height_;
      blockHeaderHash_ = other.blockHeaderHash_ != null ? other.blockHeaderHash_.Clone() : null;
      transactionMKRoot_ = other.transactionMKRoot_ != null ? other.transactionMKRoot_.Clone() : null;
      chainId_ = other.chainId_ != null ? other.chainId_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SideChainBlockInfo Clone() {
      return new SideChainBlockInfo(this);
    }

    /// <summary>Field number for the "Height" field.</summary>
    public const int HeightFieldNumber = 1;
    private ulong height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "BlockHeaderHash" field.</summary>
    public const int BlockHeaderHashFieldNumber = 2;
    private global::AElf.Common.Hash blockHeaderHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Common.Hash BlockHeaderHash {
      get { return blockHeaderHash_; }
      set {
        blockHeaderHash_ = value;
      }
    }

    /// <summary>Field number for the "TransactionMKRoot" field.</summary>
    public const int TransactionMKRootFieldNumber = 3;
    private global::AElf.Common.Hash transactionMKRoot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Common.Hash TransactionMKRoot {
      get { return transactionMKRoot_; }
      set {
        transactionMKRoot_ = value;
      }
    }

    /// <summary>Field number for the "ChainId" field.</summary>
    public const int ChainIdFieldNumber = 4;
    private global::AElf.Common.Hash chainId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Common.Hash ChainId {
      get { return chainId_; }
      set {
        chainId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SideChainBlockInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SideChainBlockInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Height != other.Height) return false;
      if (!object.Equals(BlockHeaderHash, other.BlockHeaderHash)) return false;
      if (!object.Equals(TransactionMKRoot, other.TransactionMKRoot)) return false;
      if (!object.Equals(ChainId, other.ChainId)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Height != 0UL) hash ^= Height.GetHashCode();
      if (blockHeaderHash_ != null) hash ^= BlockHeaderHash.GetHashCode();
      if (transactionMKRoot_ != null) hash ^= TransactionMKRoot.GetHashCode();
      if (chainId_ != null) hash ^= ChainId.GetHashCode();
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
      if (Height != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Height);
      }
      if (blockHeaderHash_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BlockHeaderHash);
      }
      if (transactionMKRoot_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TransactionMKRoot);
      }
      if (chainId_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ChainId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Height != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Height);
      }
      if (blockHeaderHash_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BlockHeaderHash);
      }
      if (transactionMKRoot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TransactionMKRoot);
      }
      if (chainId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChainId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SideChainBlockInfo other) {
      if (other == null) {
        return;
      }
      if (other.Height != 0UL) {
        Height = other.Height;
      }
      if (other.blockHeaderHash_ != null) {
        if (blockHeaderHash_ == null) {
          blockHeaderHash_ = new global::AElf.Common.Hash();
        }
        BlockHeaderHash.MergeFrom(other.BlockHeaderHash);
      }
      if (other.transactionMKRoot_ != null) {
        if (transactionMKRoot_ == null) {
          transactionMKRoot_ = new global::AElf.Common.Hash();
        }
        TransactionMKRoot.MergeFrom(other.TransactionMKRoot);
      }
      if (other.chainId_ != null) {
        if (chainId_ == null) {
          chainId_ = new global::AElf.Common.Hash();
        }
        ChainId.MergeFrom(other.ChainId);
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
            Height = input.ReadUInt64();
            break;
          }
          case 18: {
            if (blockHeaderHash_ == null) {
              blockHeaderHash_ = new global::AElf.Common.Hash();
            }
            input.ReadMessage(blockHeaderHash_);
            break;
          }
          case 26: {
            if (transactionMKRoot_ == null) {
              transactionMKRoot_ = new global::AElf.Common.Hash();
            }
            input.ReadMessage(transactionMKRoot_);
            break;
          }
          case 34: {
            if (chainId_ == null) {
              chainId_ = new global::AElf.Common.Hash();
            }
            input.ReadMessage(chainId_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ParentChainBlockInfo : pb::IMessage<ParentChainBlockInfo> {
    private static readonly pb::MessageParser<ParentChainBlockInfo> _parser = new pb::MessageParser<ParentChainBlockInfo>(() => new ParentChainBlockInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParentChainBlockInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Kernel.CrosschainReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParentChainBlockInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParentChainBlockInfo(ParentChainBlockInfo other) : this() {
      root_ = other.root_ != null ? other.root_.Clone() : null;
      indexedBlockInfo_ = other.indexedBlockInfo_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParentChainBlockInfo Clone() {
      return new ParentChainBlockInfo(this);
    }

    /// <summary>Field number for the "Root" field.</summary>
    public const int RootFieldNumber = 1;
    private global::AElf.Contracts.SideChain.ParentChainBlockRootInfo root_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Contracts.SideChain.ParentChainBlockRootInfo Root {
      get { return root_; }
      set {
        root_ = value;
      }
    }

    /// <summary>Field number for the "IndexedBlockInfo" field.</summary>
    public const int IndexedBlockInfoFieldNumber = 2;
    private static readonly pbc::MapField<ulong, global::AElf.Kernel.MerklePath>.Codec _map_indexedBlockInfo_codec
        = new pbc::MapField<ulong, global::AElf.Kernel.MerklePath>.Codec(pb::FieldCodec.ForUInt64(8), pb::FieldCodec.ForMessage(18, global::AElf.Kernel.MerklePath.Parser), 18);
    private readonly pbc::MapField<ulong, global::AElf.Kernel.MerklePath> indexedBlockInfo_ = new pbc::MapField<ulong, global::AElf.Kernel.MerklePath>();
    /// <summary>
    /// Indexed block height from side chain and merkle path for this side chain block
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<ulong, global::AElf.Kernel.MerklePath> IndexedBlockInfo {
      get { return indexedBlockInfo_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParentChainBlockInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParentChainBlockInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Root, other.Root)) return false;
      if (!IndexedBlockInfo.Equals(other.IndexedBlockInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (root_ != null) hash ^= Root.GetHashCode();
      hash ^= IndexedBlockInfo.GetHashCode();
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
      if (root_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Root);
      }
      indexedBlockInfo_.WriteTo(output, _map_indexedBlockInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (root_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Root);
      }
      size += indexedBlockInfo_.CalculateSize(_map_indexedBlockInfo_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParentChainBlockInfo other) {
      if (other == null) {
        return;
      }
      if (other.root_ != null) {
        if (root_ == null) {
          root_ = new global::AElf.Contracts.SideChain.ParentChainBlockRootInfo();
        }
        Root.MergeFrom(other.Root);
      }
      indexedBlockInfo_.Add(other.indexedBlockInfo_);
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
            if (root_ == null) {
              root_ = new global::AElf.Contracts.SideChain.ParentChainBlockRootInfo();
            }
            input.ReadMessage(root_);
            break;
          }
          case 18: {
            indexedBlockInfo_.AddEntriesFrom(input, _map_indexedBlockInfo_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class MerklePath : pb::IMessage<MerklePath> {
    private static readonly pb::MessageParser<MerklePath> _parser = new pb::MessageParser<MerklePath>(() => new MerklePath());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MerklePath> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Kernel.CrosschainReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerklePath() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerklePath(MerklePath other) : this() {
      path_ = other.path_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerklePath Clone() {
      return new MerklePath(this);
    }

    /// <summary>Field number for the "Path" field.</summary>
    public const int PathFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AElf.Common.Hash> _repeated_path_codec
        = pb::FieldCodec.ForMessage(10, global::AElf.Common.Hash.Parser);
    private readonly pbc::RepeatedField<global::AElf.Common.Hash> path_ = new pbc::RepeatedField<global::AElf.Common.Hash>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AElf.Common.Hash> Path {
      get { return path_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MerklePath);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MerklePath other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!path_.Equals(other.path_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= path_.GetHashCode();
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
      path_.WriteTo(output, _repeated_path_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += path_.CalculateSize(_repeated_path_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MerklePath other) {
      if (other == null) {
        return;
      }
      path_.Add(other.path_);
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
            path_.AddEntriesFrom(input, _repeated_path_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code