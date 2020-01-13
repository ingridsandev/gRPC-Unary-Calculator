// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Calculator {

  /// <summary>Holder for reflection information generated from calculator.proto</summary>
  public static partial class CalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBjYWxjdWxhdG9yLnByb3RvEgpjYWxjdWxhdG9yIlEKEUNhbGN1bGF0b3JS",
            "ZXF1ZXN0EhMKC2ZpcnN0X3ZhbHVlGAEgASgFEhQKDHNlY29uZF92YWx1ZRgC",
            "IAEoBRIRCglvcGVyYXRpb24YAyABKAkiVAoSQ2FsY3VsYXRvclJlc3BvbnNl",
            "Ei4KB3JlcXVlc3QYASABKAsyHS5jYWxjdWxhdG9yLkNhbGN1bGF0b3JSZXF1",
            "ZXN0Eg4KBnJlc3VsdBgCIAEoBTJiChFDYWxjdWxhdG9yU2VydmljZRJNCgpD",
            "YWxjdWxhdG9yEh0uY2FsY3VsYXRvci5DYWxjdWxhdG9yUmVxdWVzdBoeLmNh",
            "bGN1bGF0b3IuQ2FsY3VsYXRvclJlc3BvbnNlIgBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Calculator.CalculatorRequest), global::Calculator.CalculatorRequest.Parser, new[]{ "FirstValue", "SecondValue", "Operation" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Calculator.CalculatorResponse), global::Calculator.CalculatorResponse.Parser, new[]{ "Request", "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CalculatorRequest : pb::IMessage<CalculatorRequest> {
    private static readonly pb::MessageParser<CalculatorRequest> _parser = new pb::MessageParser<CalculatorRequest>(() => new CalculatorRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CalculatorRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Calculator.CalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalculatorRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalculatorRequest(CalculatorRequest other) : this() {
      firstValue_ = other.firstValue_;
      secondValue_ = other.secondValue_;
      operation_ = other.operation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalculatorRequest Clone() {
      return new CalculatorRequest(this);
    }

    /// <summary>Field number for the "first_value" field.</summary>
    public const int FirstValueFieldNumber = 1;
    private int firstValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FirstValue {
      get { return firstValue_; }
      set {
        firstValue_ = value;
      }
    }

    /// <summary>Field number for the "second_value" field.</summary>
    public const int SecondValueFieldNumber = 2;
    private int secondValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SecondValue {
      get { return secondValue_; }
      set {
        secondValue_ = value;
      }
    }

    /// <summary>Field number for the "operation" field.</summary>
    public const int OperationFieldNumber = 3;
    private string operation_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Operation {
      get { return operation_; }
      set {
        operation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CalculatorRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CalculatorRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FirstValue != other.FirstValue) return false;
      if (SecondValue != other.SecondValue) return false;
      if (Operation != other.Operation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FirstValue != 0) hash ^= FirstValue.GetHashCode();
      if (SecondValue != 0) hash ^= SecondValue.GetHashCode();
      if (Operation.Length != 0) hash ^= Operation.GetHashCode();
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
      if (FirstValue != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(FirstValue);
      }
      if (SecondValue != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SecondValue);
      }
      if (Operation.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Operation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FirstValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FirstValue);
      }
      if (SecondValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SecondValue);
      }
      if (Operation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Operation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CalculatorRequest other) {
      if (other == null) {
        return;
      }
      if (other.FirstValue != 0) {
        FirstValue = other.FirstValue;
      }
      if (other.SecondValue != 0) {
        SecondValue = other.SecondValue;
      }
      if (other.Operation.Length != 0) {
        Operation = other.Operation;
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
            FirstValue = input.ReadInt32();
            break;
          }
          case 16: {
            SecondValue = input.ReadInt32();
            break;
          }
          case 26: {
            Operation = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CalculatorResponse : pb::IMessage<CalculatorResponse> {
    private static readonly pb::MessageParser<CalculatorResponse> _parser = new pb::MessageParser<CalculatorResponse>(() => new CalculatorResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CalculatorResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Calculator.CalculatorReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalculatorResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalculatorResponse(CalculatorResponse other) : this() {
      request_ = other.request_ != null ? other.request_.Clone() : null;
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalculatorResponse Clone() {
      return new CalculatorResponse(this);
    }

    /// <summary>Field number for the "request" field.</summary>
    public const int RequestFieldNumber = 1;
    private global::Calculator.CalculatorRequest request_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Calculator.CalculatorRequest Request {
      get { return request_; }
      set {
        request_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 2;
    private int result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CalculatorResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CalculatorResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Request, other.Request)) return false;
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (request_ != null) hash ^= Request.GetHashCode();
      if (Result != 0) hash ^= Result.GetHashCode();
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
      if (request_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Request);
      }
      if (Result != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (request_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Request);
      }
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CalculatorResponse other) {
      if (other == null) {
        return;
      }
      if (other.request_ != null) {
        if (request_ == null) {
          Request = new global::Calculator.CalculatorRequest();
        }
        Request.MergeFrom(other.Request);
      }
      if (other.Result != 0) {
        Result = other.Result;
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
            if (request_ == null) {
              Request = new global::Calculator.CalculatorRequest();
            }
            input.ReadMessage(Request);
            break;
          }
          case 16: {
            Result = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
