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

namespace TencentCloud.Fmu.V20191213
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Fmu.V20191213.Models;

   public class FmuClient : AbstractClient{

       private const string endpoint = "fmu.tencentcloudapi.com";
       private const string version = "2019-12-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FmuClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FmuClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用户上传一张人脸图片，精准定位五官，实现美肤、亮肤、祛痘等美颜功能。
        /// </summary>
        /// <param name="req"><see cref="BeautifyPicRequest"/></param>
        /// <returns><see cref="BeautifyPicResponse"/></returns>
        public async Task<BeautifyPicResponse> BeautifyPic(BeautifyPicRequest req)
        {
             JsonResponseModel<BeautifyPicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BeautifyPic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BeautifyPicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户上传一张人脸图片，精准定位五官，实现美肤、亮肤、祛痘等美颜功能。
        /// </summary>
        /// <param name="req"><see cref="BeautifyPicRequest"/></param>
        /// <returns><see cref="BeautifyPicResponse"/></returns>
        public BeautifyPicResponse BeautifyPicSync(BeautifyPicRequest req)
        {
             JsonResponseModel<BeautifyPicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BeautifyPic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BeautifyPicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 视频美颜
        /// </summary>
        /// <param name="req"><see cref="BeautifyVideoRequest"/></param>
        /// <returns><see cref="BeautifyVideoResponse"/></returns>
        public async Task<BeautifyVideoResponse> BeautifyVideo(BeautifyVideoRequest req)
        {
             JsonResponseModel<BeautifyVideoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BeautifyVideo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BeautifyVideoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 视频美颜
        /// </summary>
        /// <param name="req"><see cref="BeautifyVideoRequest"/></param>
        /// <returns><see cref="BeautifyVideoResponse"/></returns>
        public BeautifyVideoResponse BeautifyVideoSync(BeautifyVideoRequest req)
        {
             JsonResponseModel<BeautifyVideoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BeautifyVideo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BeautifyVideoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销视频美颜任务请求
        /// </summary>
        /// <param name="req"><see cref="CancelBeautifyVideoJobRequest"/></param>
        /// <returns><see cref="CancelBeautifyVideoJobResponse"/></returns>
        public async Task<CancelBeautifyVideoJobResponse> CancelBeautifyVideoJob(CancelBeautifyVideoJobRequest req)
        {
             JsonResponseModel<CancelBeautifyVideoJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelBeautifyVideoJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelBeautifyVideoJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销视频美颜任务请求
        /// </summary>
        /// <param name="req"><see cref="CancelBeautifyVideoJobRequest"/></param>
        /// <returns><see cref="CancelBeautifyVideoJobResponse"/></returns>
        public CancelBeautifyVideoJobResponse CancelBeautifyVideoJobSync(CancelBeautifyVideoJobRequest req)
        {
             JsonResponseModel<CancelBeautifyVideoJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelBeautifyVideoJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelBeautifyVideoJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在使用LUT素材的modelid实现试唇色前，您需要先上传 LUT 格式的cube文件注册唇色ID。查看 [LUT文件的使用说明](https://cloud.tencent.com/document/product/1172/41701)。
        /// 
        /// 注：您也可以直接使用 [试唇色接口](https://cloud.tencent.com/document/product/1172/40706)，通过输入RGBA模型数值的方式指定唇色，更简单易用。
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public async Task<CreateModelResponse> CreateModel(CreateModelRequest req)
        {
             JsonResponseModel<CreateModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在使用LUT素材的modelid实现试唇色前，您需要先上传 LUT 格式的cube文件注册唇色ID。查看 [LUT文件的使用说明](https://cloud.tencent.com/document/product/1172/41701)。
        /// 
        /// 注：您也可以直接使用 [试唇色接口](https://cloud.tencent.com/document/product/1172/40706)，通过输入RGBA模型数值的方式指定唇色，更简单易用。
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public CreateModelResponse CreateModelSync(CreateModelRequest req)
        {
             JsonResponseModel<CreateModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除已注册的唇色素材。
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public async Task<DeleteModelResponse> DeleteModel(DeleteModelRequest req)
        {
             JsonResponseModel<DeleteModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除已注册的唇色素材。
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public DeleteModelResponse DeleteModelSync(DeleteModelRequest req)
        {
             JsonResponseModel<DeleteModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询已注册的唇色素材。
        /// </summary>
        /// <param name="req"><see cref="GetModelListRequest"/></param>
        /// <returns><see cref="GetModelListResponse"/></returns>
        public async Task<GetModelListResponse> GetModelList(GetModelListRequest req)
        {
             JsonResponseModel<GetModelListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetModelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetModelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询已注册的唇色素材。
        /// </summary>
        /// <param name="req"><see cref="GetModelListRequest"/></param>
        /// <returns><see cref="GetModelListResponse"/></returns>
        public GetModelListResponse GetModelListSync(GetModelListRequest req)
        {
             JsonResponseModel<GetModelListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetModelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetModelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询视频美颜处理进度
        /// </summary>
        /// <param name="req"><see cref="QueryBeautifyVideoJobRequest"/></param>
        /// <returns><see cref="QueryBeautifyVideoJobResponse"/></returns>
        public async Task<QueryBeautifyVideoJobResponse> QueryBeautifyVideoJob(QueryBeautifyVideoJobRequest req)
        {
             JsonResponseModel<QueryBeautifyVideoJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryBeautifyVideoJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBeautifyVideoJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询视频美颜处理进度
        /// </summary>
        /// <param name="req"><see cref="QueryBeautifyVideoJobRequest"/></param>
        /// <returns><see cref="QueryBeautifyVideoJobResponse"/></returns>
        public QueryBeautifyVideoJobResponse QueryBeautifyVideoJobSync(QueryBeautifyVideoJobRequest req)
        {
             JsonResponseModel<QueryBeautifyVideoJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryBeautifyVideoJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBeautifyVideoJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传一张照片，输出滤镜处理后的图片。
        /// </summary>
        /// <param name="req"><see cref="StyleImageRequest"/></param>
        /// <returns><see cref="StyleImageResponse"/></returns>
        public async Task<StyleImageResponse> StyleImage(StyleImageRequest req)
        {
             JsonResponseModel<StyleImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StyleImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StyleImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传一张照片，输出滤镜处理后的图片。
        /// </summary>
        /// <param name="req"><see cref="StyleImageRequest"/></param>
        /// <returns><see cref="StyleImageResponse"/></returns>
        public StyleImageResponse StyleImageSync(StyleImageRequest req)
        {
             JsonResponseModel<StyleImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StyleImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StyleImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传一张照片，输出滤镜处理后的图片。
        /// </summary>
        /// <param name="req"><see cref="StyleImageProRequest"/></param>
        /// <returns><see cref="StyleImageProResponse"/></returns>
        public async Task<StyleImageProResponse> StyleImagePro(StyleImageProRequest req)
        {
             JsonResponseModel<StyleImageProResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StyleImagePro");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StyleImageProResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传一张照片，输出滤镜处理后的图片。
        /// </summary>
        /// <param name="req"><see cref="StyleImageProRequest"/></param>
        /// <returns><see cref="StyleImageProResponse"/></returns>
        public StyleImageProResponse StyleImageProSync(StyleImageProRequest req)
        {
             JsonResponseModel<StyleImageProResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StyleImagePro");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StyleImageProResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对图片中的人脸嘴唇进行着色，最多支持同时对一张图中的3张人脸进行试唇色。
        /// 
        /// 您可以通过事先注册在腾讯云的唇色素材（LUT文件）改变图片中的人脸唇色，也可以输入RGBA模型数值。
        /// 
        /// 为了更好的效果，建议您使用事先注册在腾讯云的唇色素材（LUT文件）。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="TryLipstickPicRequest"/></param>
        /// <returns><see cref="TryLipstickPicResponse"/></returns>
        public async Task<TryLipstickPicResponse> TryLipstickPic(TryLipstickPicRequest req)
        {
             JsonResponseModel<TryLipstickPicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TryLipstickPic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TryLipstickPicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对图片中的人脸嘴唇进行着色，最多支持同时对一张图中的3张人脸进行试唇色。
        /// 
        /// 您可以通过事先注册在腾讯云的唇色素材（LUT文件）改变图片中的人脸唇色，也可以输入RGBA模型数值。
        /// 
        /// 为了更好的效果，建议您使用事先注册在腾讯云的唇色素材（LUT文件）。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="TryLipstickPicRequest"/></param>
        /// <returns><see cref="TryLipstickPicResponse"/></returns>
        public TryLipstickPicResponse TryLipstickPicSync(TryLipstickPicRequest req)
        {
             JsonResponseModel<TryLipstickPicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TryLipstickPic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TryLipstickPicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
