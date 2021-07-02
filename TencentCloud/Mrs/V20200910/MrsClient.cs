/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mrs.V20200910
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mrs.V20200910.Models;

   public class MrsClient : AbstractClient{

       private const string endpoint = "mrs.tencentcloudapi.com";
       private const string version = "2020-09-10";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MrsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MrsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 图片分类
        /// </summary>
        /// <param name="req"><see cref="ImageToClassRequest"/></param>
        /// <returns><see cref="ImageToClassResponse"/></returns>
        public async Task<ImageToClassResponse> ImageToClass(ImageToClassRequest req)
        {
             JsonResponseModel<ImageToClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImageToClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageToClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图片分类
        /// </summary>
        /// <param name="req"><see cref="ImageToClassRequest"/></param>
        /// <returns><see cref="ImageToClassResponse"/></returns>
        public ImageToClassResponse ImageToClassSync(ImageToClassRequest req)
        {
             JsonResponseModel<ImageToClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImageToClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageToClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图片转结构化对象
        /// </summary>
        /// <param name="req"><see cref="ImageToObjectRequest"/></param>
        /// <returns><see cref="ImageToObjectResponse"/></returns>
        public async Task<ImageToObjectResponse> ImageToObject(ImageToObjectRequest req)
        {
             JsonResponseModel<ImageToObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImageToObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageToObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图片转结构化对象
        /// </summary>
        /// <param name="req"><see cref="ImageToObjectRequest"/></param>
        /// <returns><see cref="ImageToObjectResponse"/></returns>
        public ImageToObjectResponse ImageToObjectSync(ImageToObjectRequest req)
        {
             JsonResponseModel<ImageToObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImageToObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageToObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口没有流量
        /// 
        /// 将输入的图片类型报告结构化
        /// </summary>
        /// <param name="req"><see cref="ReportImageStructuredRequest"/></param>
        /// <returns><see cref="ReportImageStructuredResponse"/></returns>
        public async Task<ReportImageStructuredResponse> ReportImageStructured(ReportImageStructuredRequest req)
        {
             JsonResponseModel<ReportImageStructuredResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReportImageStructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportImageStructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口没有流量
        /// 
        /// 将输入的图片类型报告结构化
        /// </summary>
        /// <param name="req"><see cref="ReportImageStructuredRequest"/></param>
        /// <returns><see cref="ReportImageStructuredResponse"/></returns>
        public ReportImageStructuredResponse ReportImageStructuredSync(ReportImageStructuredRequest req)
        {
             JsonResponseModel<ReportImageStructuredResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReportImageStructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportImageStructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口还未上线
        /// 
        /// 将输入的医疗报告文本内容进行结构化输出
        /// </summary>
        /// <param name="req"><see cref="ReportTextStructuredRequest"/></param>
        /// <returns><see cref="ReportTextStructuredResponse"/></returns>
        public async Task<ReportTextStructuredResponse> ReportTextStructured(ReportTextStructuredRequest req)
        {
             JsonResponseModel<ReportTextStructuredResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReportTextStructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportTextStructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口还未上线
        /// 
        /// 将输入的医疗报告文本内容进行结构化输出
        /// </summary>
        /// <param name="req"><see cref="ReportTextStructuredRequest"/></param>
        /// <returns><see cref="ReportTextStructuredResponse"/></returns>
        public ReportTextStructuredResponse ReportTextStructuredSync(ReportTextStructuredRequest req)
        {
             JsonResponseModel<ReportTextStructuredResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReportTextStructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportTextStructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本分类
        /// </summary>
        /// <param name="req"><see cref="TextToClassRequest"/></param>
        /// <returns><see cref="TextToClassResponse"/></returns>
        public async Task<TextToClassResponse> TextToClass(TextToClassRequest req)
        {
             JsonResponseModel<TextToClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextToClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextToClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本分类
        /// </summary>
        /// <param name="req"><see cref="TextToClassRequest"/></param>
        /// <returns><see cref="TextToClassResponse"/></returns>
        public TextToClassResponse TextToClassSync(TextToClassRequest req)
        {
             JsonResponseModel<TextToClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextToClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextToClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本转结构化对象
        /// </summary>
        /// <param name="req"><see cref="TextToObjectRequest"/></param>
        /// <returns><see cref="TextToObjectResponse"/></returns>
        public async Task<TextToObjectResponse> TextToObject(TextToObjectRequest req)
        {
             JsonResponseModel<TextToObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextToObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextToObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本转结构化对象
        /// </summary>
        /// <param name="req"><see cref="TextToObjectRequest"/></param>
        /// <returns><see cref="TextToObjectResponse"/></returns>
        public TextToObjectResponse TextToObjectSync(TextToObjectRequest req)
        {
             JsonResponseModel<TextToObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextToObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextToObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
