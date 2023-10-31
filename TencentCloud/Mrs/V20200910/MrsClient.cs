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
        /// 文本转结构化对象。
        /// 
        /// 适用场景：经过腾讯医疗专用 OCR 从图片识别之后的文本，可以调用此接口。通过其它 OCR 识别的文本可能不适配。医院的 XML 格式文本也不适配，XML 文件需要经过特殊转换才能直接调用此接口。单次调用传入的文本不宜超过 2000 字。
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
        /// 文本转结构化对象。
        /// 
        /// 适用场景：经过腾讯医疗专用 OCR 从图片识别之后的文本，可以调用此接口。通过其它 OCR 识别的文本可能不适配。医院的 XML 格式文本也不适配，XML 文件需要经过特殊转换才能直接调用此接口。单次调用传入的文本不宜超过 2000 字。
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

        /// <summary>
        /// 将PDF格式的体检报告文件结构化，解析关键信息。
        /// 注意：该接口是按照体检报告 PDF 页面数量统计次数，不是按照 PDF 文件数量统计次数。通过该接口传入的报告必须是体检报告，非体检报告可能无法正确解析。
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectResponse"/></returns>
        public async Task<TurnPDFToObjectResponse> TurnPDFToObject(TurnPDFToObjectRequest req)
        {
             JsonResponseModel<TurnPDFToObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TurnPDFToObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TurnPDFToObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将PDF格式的体检报告文件结构化，解析关键信息。
        /// 注意：该接口是按照体检报告 PDF 页面数量统计次数，不是按照 PDF 文件数量统计次数。通过该接口传入的报告必须是体检报告，非体检报告可能无法正确解析。
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectResponse"/></returns>
        public TurnPDFToObjectResponse TurnPDFToObjectSync(TurnPDFToObjectRequest req)
        {
             JsonResponseModel<TurnPDFToObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TurnPDFToObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TurnPDFToObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 体检报告PDF文件结构化-异步接口
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectAsyncRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectAsyncResponse"/></returns>
        public async Task<TurnPDFToObjectAsyncResponse> TurnPDFToObjectAsync(TurnPDFToObjectAsyncRequest req)
        {
             JsonResponseModel<TurnPDFToObjectAsyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TurnPDFToObjectAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TurnPDFToObjectAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 体检报告PDF文件结构化-异步接口
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectAsyncRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectAsyncResponse"/></returns>
        public TurnPDFToObjectAsyncResponse TurnPDFToObjectAsyncSync(TurnPDFToObjectAsyncRequest req)
        {
             JsonResponseModel<TurnPDFToObjectAsyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TurnPDFToObjectAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TurnPDFToObjectAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 体检报告PDF文件结构化异步获取结果接口
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectAsyncGetResultRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectAsyncGetResultResponse"/></returns>
        public async Task<TurnPDFToObjectAsyncGetResultResponse> TurnPDFToObjectAsyncGetResult(TurnPDFToObjectAsyncGetResultRequest req)
        {
             JsonResponseModel<TurnPDFToObjectAsyncGetResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TurnPDFToObjectAsyncGetResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TurnPDFToObjectAsyncGetResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 体检报告PDF文件结构化异步获取结果接口
        /// </summary>
        /// <param name="req"><see cref="TurnPDFToObjectAsyncGetResultRequest"/></param>
        /// <returns><see cref="TurnPDFToObjectAsyncGetResultResponse"/></returns>
        public TurnPDFToObjectAsyncGetResultResponse TurnPDFToObjectAsyncGetResultSync(TurnPDFToObjectAsyncGetResultRequest req)
        {
             JsonResponseModel<TurnPDFToObjectAsyncGetResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TurnPDFToObjectAsyncGetResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TurnPDFToObjectAsyncGetResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
