// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: execution.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Execution {

  /// <summary>Holder for reflection information generated from execution.proto</summary>
  public static partial class ExecutionReflection {

    #region Descriptor
    /// <summary>File descriptor for execution.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExecutionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9leGVjdXRpb24ucHJvdG8aDGNvbW1vbi5wcm90bxoMa2VybmVsLnByb3Rv",
            "IloKF1RyYW5zYWN0aW9uVHJhY2VNZXNzYWdlEhEKCVJlcXVlc3RJZBgBIAEo",
            "AxIsChFUcmFuc2FjdGlvblRyYWNlcxgCIAMoCzIRLlRyYW5zYWN0aW9uVHJh",
            "Y2VCEaoCDkFFbGYuRXhlY3V0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Common.CommonReflection.Descriptor, global::AElf.Kernel.KernelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Execution.TransactionTraceMessage), global::AElf.Execution.TransactionTraceMessage.Parser, new[]{ "RequestId", "TransactionTraces" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TransactionTraceMessage : pb::IMessage<TransactionTraceMessage> {
    private static readonly pb::MessageParser<TransactionTraceMessage> _parser = new pb::MessageParser<TransactionTraceMessage>(() => new TransactionTraceMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TransactionTraceMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Execution.ExecutionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionTraceMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionTraceMessage(TransactionTraceMessage other) : this() {
      requestId_ = other.requestId_;
      transactionTraces_ = other.transactionTraces_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionTraceMessage Clone() {
      return new TransactionTraceMessage(this);
    }

    /// <summary>Field number for the "RequestId" field.</summary>
    public const int RequestIdFieldNumber = 1;
    private long requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    /// <summary>Field number for the "TransactionTraces" field.</summary>
    public const int TransactionTracesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AElf.Kernel.TransactionTrace> _repeated_transactionTraces_codec
        = pb::FieldCodec.ForMessage(18, global::AElf.Kernel.TransactionTrace.Parser);
    private readonly pbc::RepeatedField<global::AElf.Kernel.TransactionTrace> transactionTraces_ = new pbc::RepeatedField<global::AElf.Kernel.TransactionTrace>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AElf.Kernel.TransactionTrace> TransactionTraces {
      get { return transactionTraces_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TransactionTraceMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TransactionTraceMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequestId != other.RequestId) return false;
      if(!transactionTraces_.Equals(other.transactionTraces_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RequestId != 0L) hash ^= RequestId.GetHashCode();
      hash ^= transactionTraces_.GetHashCode();
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
      if (RequestId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RequestId);
      }
      transactionTraces_.WriteTo(output, _repeated_transactionTraces_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RequestId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RequestId);
      }
      size += transactionTraces_.CalculateSize(_repeated_transactionTraces_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TransactionTraceMessage other) {
      if (other == null) {
        return;
      }
      if (other.RequestId != 0L) {
        RequestId = other.RequestId;
      }
      transactionTraces_.Add(other.transactionTraces_);
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
            RequestId = input.ReadInt64();
            break;
          }
          case 18: {
            transactionTraces_.AddEntriesFrom(input, _repeated_transactionTraces_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code