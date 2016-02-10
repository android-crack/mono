// 
// A WebService to retrieve and post comments for a specific
// Monodoc url
//
// Authors:
//   Johannes Roith <johannes@jroith.de>
//
//   This source code was (initially) auto-generated by wsdl, Version=1.0.3705.0.
//   but is cleaned and has MonoDoc namespace
//
// TODO: right now, hosted on jroith2.de
//         must be moved to Ximian server


namespace Monodoc {

using System.Diagnostics;
using System.Xml.Serialization;
using System;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Web.Services;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="CommentServiceSoap", Namespace="http://www.go-mono.org/monodoc/")]
public class CommentService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    public CommentService() {
        this.Url = "http://www.jroith2.de/comments.asmx";
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.go-mono.org/monodoc/AddComment", RequestNamespace="http://www.go-mono.org/monodoc/", ResponseNamespace="http://www.go-mono.org/monodoc/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int AddComment(string author, string mail, string title, string comment, string url) {
        object[] results = this.Invoke("AddComment", new object[] {
                    author,
                    mail,
                    title,
                    comment,
                    url});
        return ((int)(results[0]));
    }
    
    public System.IAsyncResult BeginAddComment(string author, string mail, string title, string comment, string url, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("AddComment", new object[] {
                    author,
                    mail,
                    title,
                    comment,
                    url}, callback, asyncState);
    }
    
    public int EndAddComment(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.go-mono.org/monodoc/GetCommentsByUrl", RequestNamespace="http://www.go-mono.org/monodoc/", ResponseNamespace="http://www.go-mono.org/monodoc/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public Comment[] GetCommentsByUrl(string url) {
        object[] results = this.Invoke("GetCommentsByUrl", new object[] {
                    url});
        return ((Comment[])(results[0]));
    }

    public System.IAsyncResult BeginGetCommentsByUrl(string url, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetCommentsByUrl", new object[] {
                    url}, callback, asyncState);
    }
    
    public Comment[] EndGetCommentsByUrl(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Comment[])(results[0]));
    }
}

[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.go-mono.org/monodoc/")]
public class Comment {
    
    public string Author;
    public string Mail;
    public string Date;
    public string Text;
    public string Title;
}

}