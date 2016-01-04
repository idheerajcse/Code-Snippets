parse json Data in c#


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Configuration;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string accessToken = ConfigurationManager.AppSettings["AccessToken"].ToString();

        try
        {
            if (Request.QueryString["url"] != null && Request.QueryString["type"] != null)
            {
                string url = Request.QueryString["url"].ToString().Trim();
                string type = Request.QueryString["type"].ToString().Trim();
                string urlData = "('" + url + "')" + "/Items";
                string urlTest = "https://netpeacho365.sharepoint.com/dev/_api/Web/Lists/GetByTitle" + urlData;
            
                HttpWebRequest endpointRequest =
                (HttpWebRequest)HttpWebRequest.Create(urlTest);
                
                //  string refreshToken="IAAAAN8pxoUjB-Sdklfh1bYO1eqmsUFogrrAaCZ7sBzmzQGMgmpH1ChiQnccET6-bqo-h9dF9C_uivFpf0EGPwq4vOlVN-hnONSNQ_5HZmX9ZhWoSUDW2o0v0-ieLOFRrUpgMd_-N7egQP1U8FeGwx1V07gN7ar9B7IVzVJf4G8fjHiCpLVg_daMqOD3ITLUOf0BEvtjSkvzzbThIhShusU07K2k3PkGkGlyFAA-ZlfKu8uuAc1EVWCJ6rLF309eyVCYJrZiYhBfoHgbqaWmjt660Xqc5xDf9QLkW51-3-EHZLk171377sY69g-HK_METBJDDKHnz63Rw5izqTEnLdnRadA";
                endpointRequest.Method = "GET";
                endpointRequest.Accept = "application/json;odata=verbose";
                endpointRequest.Headers.Add("Authorization",
                  "Bearer " + accessToken);
                HttpWebResponse endpointResponse =
                  (HttpWebResponse)endpointRequest.GetResponse();
                StreamReader reader = new StreamReader(endpointResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                Response.Write(reader.ReadToEnd());
                string value = reader.ReadToEnd();
            }
          //  var txt = Request.Form["txtName"];
            if (Request.Form["txtFName"] != null && Request.Form["txtLName"] != null && Request.Form["txtEmail"] != null && Request.Files["FileUploadResume"] != null)
            {
                
                string Fname = Request.Form["txtFName"];
                string Lname = Request.Form["txtLName"];
                string Email = Request.Form["txtEmail"];
                string JobCode = Request.Form["txtJobCode"];
                string JobId = Request.Form["jobId"];
                HttpPostedFile filee = Request.Files["FileUploadResume"];
                
                string url = Request.UrlReferrer.ToString() + "#/JobDetail/" + JobCode;
                string TargetLocation = Server.MapPath("~/Files/");
                //string fileName = filee.FileName;


                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://netpeacho365.sharepoint.com/dev/_api/Web/Lists/GetByTitle('UserRegistration')/Items");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                //httpWebRequest.Headers["Authorization"] = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Ik1uQ19WWmNBVGZNNXBPWWlKSE1iYTlnb0VLWSJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbmV0cGVhY2hvMzY1LnNoYXJlcG9pbnQuY29tQGI4NTMyNjhlLTk0MjItNGE3Zi1iOGJkLTMyNDllMDM5MjA2ZiIsImlzcyI6IjAwMDAwMDAxLTAwMDAtMDAwMC1jMDAwLTAwMDAwMDAwMDAwMEBiODUzMjY4ZS05NDIyLTRhN2YtYjhiZC0zMjQ5ZTAzOTIwNmYiLCJuYmYiOjE0NTE1Mzg0NDMsImV4cCI6MTQ1MTU4MTY0MywibmFtZWlkIjoiMTAwMzdmZmU4MjY0M2VjOSIsImFjdG9yIjoiMzNjYmQzYjMtNjBiYS00ZjAxLWFjOWMtYTI4OWRjYzg5MDgzQGI4NTMyNjhlLTk0MjItNGE3Zi1iOGJkLTMyNDllMDM5MjA2ZiIsImlkZW50aXR5cHJvdmlkZXIiOiJ1cm46ZmVkZXJhdGlvbjptaWNyb3NvZnRvbmxpbmUifQ.Hwk7zAarFDWehUkKb3rulHvgGS16eNgKpnQtwR3awL9TuKVv4ztkbREgsLXtvkjBtPWyFgwYRp7xE5MBmZhX3mO6HbZZNHMCzpGaAxoB39dQrbCj3fR6neY0-T21ysWbf4tY4Td2p_bBgh_2-uSWxQe_SU0FzAmiljTtN-QU4oQrbY98_iInItLpqUCSiVjhhNT1PbHy6hDqHAXv5OcD2vj_A5vn-H1TQiWZC8H0BuFTwCSYX_OzBgwmDE8TTUFrK1BjDmHOZqhd6WBLucrq1Y-igd6CSVMEJqiFTUjN-4KYrPw5WfCNxsaVpjcYNtj7hDHaeT7U3ngzew3WbqH3Fg";
                httpWebRequest.Headers.Add("Authorization",
                  "Bearer " + accessToken);
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"Title\":\"" + Fname + "\"," +
                                  "\"LastName\":\"" + Lname + " \"," +
                                   "\"Email\":\"" + Email + "\"," +
                                    "\"ResumePath\":\"" + JobId + "\"}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //Response.Write("Data Inserted Successfully");
                    //return "Data Inserted Successfully";
                }


               string id= GetITEMIDtoUpdate(Fname,Email);


                if (filee.ContentLength > 0)
                {

                    var fileName = Path.GetFileName(filee.FileName);
                    

                    var requestUrl = string.Format("https://netpeacho365.sharepoint.com/dev/_api/web/Lists/GetByTitle('UserRegistration')/items("+id+")/AttachmentFiles/add(FileName='{0}')",fileName);
                    var request = (HttpWebRequest)WebRequest.Create(requestUrl);
                    // request.Credentials = credentials;  //SharePointOnlineCredentials object 
                  //  request.Headers["Authorization"] = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Ik1uQ19WWmNBVGZNNXBPWWlKSE1iYTlnb0VLWSJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbmV0cGVhY2hvMzY1LnNoYXJlcG9pbnQuY29tQGI4NTMyNjhlLTk0MjItNGE3Zi1iOGJkLTMyNDllMDM5MjA2ZiIsImlzcyI6IjAwMDAwMDAxLTAwMDAtMDAwMC1jMDAwLTAwMDAwMDAwMDAwMEBiODUzMjY4ZS05NDIyLTRhN2YtYjhiZC0zMjQ5ZTAzOTIwNmYiLCJuYmYiOjE0NTE4ODcwMTYsImV4cCI6MTQ1MTkzMDIxNiwibmFtZWlkIjoiMTAwMzdmZmU4MjY0M2VjOSIsImFjdG9yIjoiMzNjYmQzYjMtNjBiYS00ZjAxLWFjOWMtYTI4OWRjYzg5MDgzQGI4NTMyNjhlLTk0MjItNGE3Zi1iOGJkLTMyNDllMDM5MjA2ZiIsImlkZW50aXR5cHJvdmlkZXIiOiJ1cm46ZmVkZXJhdGlvbjptaWNyb3NvZnRvbmxpbmUifQ.YIhVS8iqfu-__JxR0es7tDbyP5icgd9oqfw8bTNYMY8kMLJzEkeUfxYRPYMEOz7YKPGjjAPka-AFo6Xr6qnGY_BAtX2nFv8C2gnCeBTIm0J_cp5Wh4lJZ9MwDjPHUi2oZFLx7FdPSIqhQ0H4NUhplbEfn3-bblMjbOWxZBSbjzGcq8FD7xXjTJTB0byJqxI9ZZtdEzPAxoebOri_xXDXljOC_pXHe9ZNa33LiiIjjYbBbA7h7r_y52IaTeZxODqaY0UF73Ue0vqHBthuq1CxF_3a9W_l0YG0Dih-OqM3z_vEIV5r_2zGgQ0_ePSBdcCq-ylm2rEVf9DrER96HocyhA";
                    request.Headers.Add("Authorization",
                  "Bearer " + accessToken);
                    request.Headers.Add("X-FORMS_BASED_AUTH_ACCEPTED", "f");

                    request.Method = "POST";
                   

                    string FileNamee = filee.FileName;
                    //Determining file size.
                    int FileSizee = filee.ContentLength;
                    //Creating a byte array corresponding to file size.
                    byte[] FileByteArraye = new byte[FileSizee];
                    //Posted file is being pushed into byte array.
                    filee.InputStream.Read(FileByteArraye, 0, FileSizee);
                    //Uploading properly formatted file to server.
                    filee.SaveAs(TargetLocation + FileNamee);



                    request.ContentLength = filee.ContentLength;
                    using (var requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(FileByteArraye, 0, FileSizee);
                    }

                    var response = (HttpWebResponse)request.GetResponse();

                    var parseTree = JsonConvert.DeserializeObject<JObject>("{ a: 2, b: \"a string\", c: 1.75 }");
                    foreach (var prop in parseTree.Properties())
                    {
                        Console.WriteLine(prop.Name + ": " + prop.Value.ToObject<object>());
                    }
                   
                }


             
                Response.Write("<script type='text/javascript'>document.location='"+url+"'</script>");

                
                
                
            }

           
            //string TargetLocation = Server.MapPath("~/Files/"); 
        }
        catch (Exception ex)
        {
            Response.Write("Server Error");
        }

    }
    public string GetITEMIDtoUpdate(string Name,string Email)
    {

        HttpWebRequest endpointRequest =
              (HttpWebRequest)HttpWebRequest.Create(string.Format("https://netpeacho365.sharepoint.com/dev/_api/Web/Lists/GetByTitle('UserRegistration')/Items?$filter=Title eq '{0}' and Email eq '{1}'",Name,Email));

        //  string refreshToken="IAAAAN8pxoUjB-Sdklfh1bYO1eqmsUFogrrAaCZ7sBzmzQGMgmpH1ChiQnccET6-bqo-h9dF9C_uivFpf0EGPwq4vOlVN-hnONSNQ_5HZmX9ZhWoSUDW2o0v0-ieLOFRrUpgMd_-N7egQP1U8FeGwx1V07gN7ar9B7IVzVJf4G8fjHiCpLVg_daMqOD3ITLUOf0BEvtjSkvzzbThIhShusU07K2k3PkGkGlyFAA-ZlfKu8uuAc1EVWCJ6rLF309eyVCYJrZiYhBfoHgbqaWmjt660Xqc5xDf9QLkW51-3-EHZLk171377sY69g-HK_METBJDDKHnz63Rw5izqTEnLdnRadA";
        string accessToken = ConfigurationManager.AppSettings["AccessToken"].ToString();
        endpointRequest.Method = "GET";
        endpointRequest.Accept = "application/json;odata=verbose";
        endpointRequest.Headers.Add("Authorization",
          "Bearer " + accessToken);
        HttpWebResponse endpointResponse =
          (HttpWebResponse)endpointRequest.GetResponse();
       // StreamReader reader = new StreamReader(endpointResponse.GetResponseStream(), System.Text.Encoding.UTF8);
        var reader = new StreamReader(endpointResponse.GetResponseStream(), System.Text.Encoding.UTF8).ReadToEnd();

      
       // string readData = reader.ReadToEnd();
        var json = JObject.Parse(reader);  //Turns your raw string into a key value lookup
        string id = json["d"]["results"][0]["ID"].ToString();


        return id;
    
    }
}
