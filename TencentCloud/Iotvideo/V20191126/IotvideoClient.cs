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

namespace TencentCloud.Iotvideo.V20191126
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotvideo.V20191126.Models;

   public class IotvideoClient : AbstractClient{

       private const string endpoint = "iotvideo.tencentcloudapi.com";
       private const string version = "2019-11-26";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotvideoClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotvideoClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 清除设备激活码
        /// </summary>
        /// <param name="req"><see cref="ClearDeviceActiveCodeRequest"/></param>
        /// <returns><see cref="ClearDeviceActiveCodeResponse"/></returns>
        public async Task<ClearDeviceActiveCodeResponse> ClearDeviceActiveCode(ClearDeviceActiveCodeRequest req)
        {
             JsonResponseModel<ClearDeviceActiveCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearDeviceActiveCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearDeviceActiveCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清除设备激活码
        /// </summary>
        /// <param name="req"><see cref="ClearDeviceActiveCodeRequest"/></param>
        /// <returns><see cref="ClearDeviceActiveCodeResponse"/></returns>
        public ClearDeviceActiveCodeResponse ClearDeviceActiveCodeSync(ClearDeviceActiveCodeRequest req)
        {
             JsonResponseModel<ClearDeviceActiveCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearDeviceActiveCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearDeviceActiveCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建匿名访问Token
        /// </summary>
        /// <param name="req"><see cref="CreateAnonymousAccessTokenRequest"/></param>
        /// <returns><see cref="CreateAnonymousAccessTokenResponse"/></returns>
        public async Task<CreateAnonymousAccessTokenResponse> CreateAnonymousAccessToken(CreateAnonymousAccessTokenRequest req)
        {
             JsonResponseModel<CreateAnonymousAccessTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAnonymousAccessToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnonymousAccessTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建匿名访问Token
        /// </summary>
        /// <param name="req"><see cref="CreateAnonymousAccessTokenRequest"/></param>
        /// <returns><see cref="CreateAnonymousAccessTokenResponse"/></returns>
        public CreateAnonymousAccessTokenResponse CreateAnonymousAccessTokenSync(CreateAnonymousAccessTokenRequest req)
        {
             JsonResponseModel<CreateAnonymousAccessTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAnonymousAccessToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnonymousAccessTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAppUsr）用于接收由厂商云发送过来的注册请求,建立厂商云终端用户与IoT Video终端用户的映射关系。
        /// </summary>
        /// <param name="req"><see cref="CreateAppUsrRequest"/></param>
        /// <returns><see cref="CreateAppUsrResponse"/></returns>
        public async Task<CreateAppUsrResponse> CreateAppUsr(CreateAppUsrRequest req)
        {
             JsonResponseModel<CreateAppUsrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAppUsr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppUsrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAppUsr）用于接收由厂商云发送过来的注册请求,建立厂商云终端用户与IoT Video终端用户的映射关系。
        /// </summary>
        /// <param name="req"><see cref="CreateAppUsrRequest"/></param>
        /// <returns><see cref="CreateAppUsrResponse"/></returns>
        public CreateAppUsrResponse CreateAppUsrSync(CreateAppUsrRequest req)
        {
             JsonResponseModel<CreateAppUsrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAppUsr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppUsrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateBinding）用于终端用户和设备进行绑定，具体的应用场景如下：
        ///     终端用户与设备具有“强关联”关系。用户与设备绑定之后，用户终端即具备了该设备的访问权限,访问或操作设备时，无需获取设备访问Token。
        /// </summary>
        /// <param name="req"><see cref="CreateBindingRequest"/></param>
        /// <returns><see cref="CreateBindingResponse"/></returns>
        public async Task<CreateBindingResponse> CreateBinding(CreateBindingRequest req)
        {
             JsonResponseModel<CreateBindingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBinding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBindingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateBinding）用于终端用户和设备进行绑定，具体的应用场景如下：
        ///     终端用户与设备具有“强关联”关系。用户与设备绑定之后，用户终端即具备了该设备的访问权限,访问或操作设备时，无需获取设备访问Token。
        /// </summary>
        /// <param name="req"><see cref="CreateBindingRequest"/></param>
        /// <returns><see cref="CreateBindingResponse"/></returns>
        public CreateBindingResponse CreateBindingSync(CreateBindingRequest req)
        {
             JsonResponseModel<CreateBindingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBinding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBindingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDevToken）用于以下场景：
        /// 终端用户与设备没有强绑定关联关系;
        /// 允许终端用户短时或一次性临时访问设备;
        /// 当终端用户与设备有强绑定关系时，可以不用调用此接口
        /// </summary>
        /// <param name="req"><see cref="CreateDevTokenRequest"/></param>
        /// <returns><see cref="CreateDevTokenResponse"/></returns>
        public async Task<CreateDevTokenResponse> CreateDevToken(CreateDevTokenRequest req)
        {
             JsonResponseModel<CreateDevTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDevToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDevTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDevToken）用于以下场景：
        /// 终端用户与设备没有强绑定关联关系;
        /// 允许终端用户短时或一次性临时访问设备;
        /// 当终端用户与设备有强绑定关系时，可以不用调用此接口
        /// </summary>
        /// <param name="req"><see cref="CreateDevTokenRequest"/></param>
        /// <returns><see cref="CreateDevTokenResponse"/></returns>
        public CreateDevTokenResponse CreateDevTokenSync(CreateDevTokenRequest req)
        {
             JsonResponseModel<CreateDevTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDevToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDevTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDevices）用于批量创建新的物联网视频通信设备。
        /// 注意：腾讯云不会对设备私钥进行保存，请自行保管好您的设备私钥。
        /// </summary>
        /// <param name="req"><see cref="CreateDevicesRequest"/></param>
        /// <returns><see cref="CreateDevicesResponse"/></returns>
        public async Task<CreateDevicesResponse> CreateDevices(CreateDevicesRequest req)
        {
             JsonResponseModel<CreateDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDevices）用于批量创建新的物联网视频通信设备。
        /// 注意：腾讯云不会对设备私钥进行保存，请自行保管好您的设备私钥。
        /// </summary>
        /// <param name="req"><see cref="CreateDevicesRequest"/></param>
        /// <returns><see cref="CreateDevicesResponse"/></returns>
        public CreateDevicesResponse CreateDevicesSync(CreateDevicesRequest req)
        {
             JsonResponseModel<CreateDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateGencode）用于生成设备物模型源代码
        /// </summary>
        /// <param name="req"><see cref="CreateGencodeRequest"/></param>
        /// <returns><see cref="CreateGencodeResponse"/></returns>
        public async Task<CreateGencodeResponse> CreateGencode(CreateGencodeRequest req)
        {
             JsonResponseModel<CreateGencodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGencode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGencodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateGencode）用于生成设备物模型源代码
        /// </summary>
        /// <param name="req"><see cref="CreateGencodeRequest"/></param>
        /// <returns><see cref="CreateGencodeResponse"/></returns>
        public CreateGencodeResponse CreateGencodeSync(CreateGencodeRequest req)
        {
             JsonResponseModel<CreateGencodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGencode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGencodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateIotDataType）用于创建自定义物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="CreateIotDataTypeRequest"/></param>
        /// <returns><see cref="CreateIotDataTypeResponse"/></returns>
        public async Task<CreateIotDataTypeResponse> CreateIotDataType(CreateIotDataTypeRequest req)
        {
             JsonResponseModel<CreateIotDataTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIotDataType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIotDataTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateIotDataType）用于创建自定义物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="CreateIotDataTypeRequest"/></param>
        /// <returns><see cref="CreateIotDataTypeResponse"/></returns>
        public CreateIotDataTypeResponse CreateIotDataTypeSync(CreateIotDataTypeRequest req)
        {
             JsonResponseModel<CreateIotDataTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIotDataType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIotDataTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateIotModel）用于定义的物模型提交。
        /// 该接口实现了物模型草稿箱的功能，保存用户最后一次编辑的物模型数据。
        /// </summary>
        /// <param name="req"><see cref="CreateIotModelRequest"/></param>
        /// <returns><see cref="CreateIotModelResponse"/></returns>
        public async Task<CreateIotModelResponse> CreateIotModel(CreateIotModelRequest req)
        {
             JsonResponseModel<CreateIotModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIotModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIotModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateIotModel）用于定义的物模型提交。
        /// 该接口实现了物模型草稿箱的功能，保存用户最后一次编辑的物模型数据。
        /// </summary>
        /// <param name="req"><see cref="CreateIotModelRequest"/></param>
        /// <returns><see cref="CreateIotModelResponse"/></returns>
        public CreateIotModelResponse CreateIotModelSync(CreateIotModelRequest req)
        {
             JsonResponseModel<CreateIotModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIotModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIotModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateProduct）用于创建一个新的物联网智能视频产品。
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public async Task<CreateProductResponse> CreateProduct(CreateProductRequest req)
        {
             JsonResponseModel<CreateProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateProduct）用于创建一个新的物联网智能视频产品。
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public CreateProductResponse CreateProductSync(CreateProductRequest req)
        {
             JsonResponseModel<CreateProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口已经停止维护，请勿使用
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRequest"/></param>
        /// <returns><see cref="CreateStorageResponse"/></returns>
        public async Task<CreateStorageResponse> CreateStorage(CreateStorageRequest req)
        {
             JsonResponseModel<CreateStorageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStorage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStorageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口已经停止维护，请勿使用
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRequest"/></param>
        /// <returns><see cref="CreateStorageResponse"/></returns>
        public CreateStorageResponse CreateStorageSync(CreateStorageRequest req)
        {
             JsonResponseModel<CreateStorageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStorage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStorageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateStorageServiceRequest"/></param>
        /// <returns><see cref="CreateStorageServiceResponse"/></returns>
        public async Task<CreateStorageServiceResponse> CreateStorageService(CreateStorageServiceRequest req)
        {
             JsonResponseModel<CreateStorageServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStorageService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStorageServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateStorageServiceRequest"/></param>
        /// <returns><see cref="CreateStorageServiceResponse"/></returns>
        public CreateStorageServiceResponse CreateStorageServiceSync(CreateStorageServiceRequest req)
        {
             JsonResponseModel<CreateStorageServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStorageService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStorageServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTraceIds）用于将设备加到日志跟踪白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateTraceIdsRequest"/></param>
        /// <returns><see cref="CreateTraceIdsResponse"/></returns>
        public async Task<CreateTraceIdsResponse> CreateTraceIds(CreateTraceIdsRequest req)
        {
             JsonResponseModel<CreateTraceIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTraceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTraceIds）用于将设备加到日志跟踪白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateTraceIdsRequest"/></param>
        /// <returns><see cref="CreateTraceIdsResponse"/></returns>
        public CreateTraceIdsResponse CreateTraceIdsSync(CreateTraceIdsRequest req)
        {
             JsonResponseModel<CreateTraceIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTraceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateUploadPath）用于获取固件上传路径。
        /// </summary>
        /// <param name="req"><see cref="CreateUploadPathRequest"/></param>
        /// <returns><see cref="CreateUploadPathResponse"/></returns>
        public async Task<CreateUploadPathResponse> CreateUploadPath(CreateUploadPathRequest req)
        {
             JsonResponseModel<CreateUploadPathResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUploadPath");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUploadPathResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateUploadPath）用于获取固件上传路径。
        /// </summary>
        /// <param name="req"><see cref="CreateUploadPathRequest"/></param>
        /// <returns><see cref="CreateUploadPathResponse"/></returns>
        public CreateUploadPathResponse CreateUploadPathSync(CreateUploadPathRequest req)
        {
             JsonResponseModel<CreateUploadPathResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUploadPath");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUploadPathResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateUsrToken）用于终端用户获取IoT Video平台的accessToken，初始化SDK,连接到IoT Video接入服务器。
        /// </summary>
        /// <param name="req"><see cref="CreateUsrTokenRequest"/></param>
        /// <returns><see cref="CreateUsrTokenResponse"/></returns>
        public async Task<CreateUsrTokenResponse> CreateUsrToken(CreateUsrTokenRequest req)
        {
             JsonResponseModel<CreateUsrTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUsrToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUsrTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateUsrToken）用于终端用户获取IoT Video平台的accessToken，初始化SDK,连接到IoT Video接入服务器。
        /// </summary>
        /// <param name="req"><see cref="CreateUsrTokenRequest"/></param>
        /// <returns><see cref="CreateUsrTokenResponse"/></returns>
        public CreateUsrTokenResponse CreateUsrTokenSync(CreateUsrTokenRequest req)
        {
             JsonResponseModel<CreateUsrTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUsrToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUsrTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAppUsr）用于删除终端用户。
        /// </summary>
        /// <param name="req"><see cref="DeleteAppUsrRequest"/></param>
        /// <returns><see cref="DeleteAppUsrResponse"/></returns>
        public async Task<DeleteAppUsrResponse> DeleteAppUsr(DeleteAppUsrRequest req)
        {
             JsonResponseModel<DeleteAppUsrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAppUsr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAppUsrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAppUsr）用于删除终端用户。
        /// </summary>
        /// <param name="req"><see cref="DeleteAppUsrRequest"/></param>
        /// <returns><see cref="DeleteAppUsrResponse"/></returns>
        public DeleteAppUsrResponse DeleteAppUsrSync(DeleteAppUsrRequest req)
        {
             JsonResponseModel<DeleteAppUsrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAppUsr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAppUsrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteBinding）用于终端用户和设备进行解绑定。
        /// </summary>
        /// <param name="req"><see cref="DeleteBindingRequest"/></param>
        /// <returns><see cref="DeleteBindingResponse"/></returns>
        public async Task<DeleteBindingResponse> DeleteBinding(DeleteBindingRequest req)
        {
             JsonResponseModel<DeleteBindingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBinding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBindingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteBinding）用于终端用户和设备进行解绑定。
        /// </summary>
        /// <param name="req"><see cref="DeleteBindingRequest"/></param>
        /// <returns><see cref="DeleteBindingResponse"/></returns>
        public DeleteBindingResponse DeleteBindingSync(DeleteBindingRequest req)
        {
             JsonResponseModel<DeleteBindingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBinding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBindingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDevice）用于删除设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public async Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
             JsonResponseModel<DeleteDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDevice）用于删除设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
             JsonResponseModel<DeleteDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteIotDataType）用于删除自定义物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="DeleteIotDataTypeRequest"/></param>
        /// <returns><see cref="DeleteIotDataTypeResponse"/></returns>
        public async Task<DeleteIotDataTypeResponse> DeleteIotDataType(DeleteIotDataTypeRequest req)
        {
             JsonResponseModel<DeleteIotDataTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIotDataType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIotDataTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteIotDataType）用于删除自定义物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="DeleteIotDataTypeRequest"/></param>
        /// <returns><see cref="DeleteIotDataTypeResponse"/></returns>
        public DeleteIotDataTypeResponse DeleteIotDataTypeSync(DeleteIotDataTypeRequest req)
        {
             JsonResponseModel<DeleteIotDataTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIotDataType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIotDataTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMessageQueue）用于删除物联网智能视频产品的转发消息配置信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageQueueRequest"/></param>
        /// <returns><see cref="DeleteMessageQueueResponse"/></returns>
        public async Task<DeleteMessageQueueResponse> DeleteMessageQueue(DeleteMessageQueueRequest req)
        {
             JsonResponseModel<DeleteMessageQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMessageQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMessageQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMessageQueue）用于删除物联网智能视频产品的转发消息配置信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageQueueRequest"/></param>
        /// <returns><see cref="DeleteMessageQueueResponse"/></returns>
        public DeleteMessageQueueResponse DeleteMessageQueueSync(DeleteMessageQueueRequest req)
        {
             JsonResponseModel<DeleteMessageQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMessageQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMessageQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteOtaVersion）用于删除固件版本信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteOtaVersionRequest"/></param>
        /// <returns><see cref="DeleteOtaVersionResponse"/></returns>
        public async Task<DeleteOtaVersionResponse> DeleteOtaVersion(DeleteOtaVersionRequest req)
        {
             JsonResponseModel<DeleteOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteOtaVersion）用于删除固件版本信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteOtaVersionRequest"/></param>
        /// <returns><see cref="DeleteOtaVersionResponse"/></returns>
        public DeleteOtaVersionResponse DeleteOtaVersionSync(DeleteOtaVersionRequest req)
        {
             JsonResponseModel<DeleteOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网智能视频产品。
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网智能视频产品。
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteTraceIds）用于将设备从日志跟踪白名单中删除，该接口可批量操作，最多支持同时操作100台设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteTraceIdsRequest"/></param>
        /// <returns><see cref="DeleteTraceIdsResponse"/></returns>
        public async Task<DeleteTraceIdsResponse> DeleteTraceIds(DeleteTraceIdsRequest req)
        {
             JsonResponseModel<DeleteTraceIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTraceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTraceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteTraceIds）用于将设备从日志跟踪白名单中删除，该接口可批量操作，最多支持同时操作100台设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteTraceIdsRequest"/></param>
        /// <returns><see cref="DeleteTraceIdsResponse"/></returns>
        public DeleteTraceIdsResponse DeleteTraceIdsSync(DeleteTraceIdsRequest req)
        {
             JsonResponseModel<DeleteTraceIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTraceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTraceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将已购买的云存服务转移到另一设备
        /// </summary>
        /// <param name="req"><see cref="DeliverStorageServiceRequest"/></param>
        /// <returns><see cref="DeliverStorageServiceResponse"/></returns>
        public async Task<DeliverStorageServiceResponse> DeliverStorageService(DeliverStorageServiceRequest req)
        {
             JsonResponseModel<DeliverStorageServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeliverStorageService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeliverStorageServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将已购买的云存服务转移到另一设备
        /// </summary>
        /// <param name="req"><see cref="DeliverStorageServiceRequest"/></param>
        /// <returns><see cref="DeliverStorageServiceResponse"/></returns>
        public DeliverStorageServiceResponse DeliverStorageServiceSync(DeliverStorageServiceRequest req)
        {
             JsonResponseModel<DeliverStorageServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeliverStorageService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeliverStorageServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 客户可通过本接口获取账户余额信息, 默认接口请求频率限制：1次/秒
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public async Task<DescribeAccountBalanceResponse> DescribeAccountBalance(DescribeAccountBalanceRequest req)
        {
             JsonResponseModel<DescribeAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 客户可通过本接口获取账户余额信息, 默认接口请求频率限制：1次/秒
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public DescribeAccountBalanceResponse DescribeAccountBalanceSync(DescribeAccountBalanceRequest req)
        {
             JsonResponseModel<DescribeAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBindDev）用于查询终端用户绑定的设备列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBindDevRequest"/></param>
        /// <returns><see cref="DescribeBindDevResponse"/></returns>
        public async Task<DescribeBindDevResponse> DescribeBindDev(DescribeBindDevRequest req)
        {
             JsonResponseModel<DescribeBindDevResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindDev");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindDevResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBindDev）用于查询终端用户绑定的设备列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBindDevRequest"/></param>
        /// <returns><see cref="DescribeBindDevResponse"/></returns>
        public DescribeBindDevResponse DescribeBindDevSync(DescribeBindDevRequest req)
        {
             JsonResponseModel<DescribeBindDevResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindDev");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindDevResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBindUsr）用于查询设备被分享的所有用户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBindUsrRequest"/></param>
        /// <returns><see cref="DescribeBindUsrResponse"/></returns>
        public async Task<DescribeBindUsrResponse> DescribeBindUsr(DescribeBindUsrRequest req)
        {
             JsonResponseModel<DescribeBindUsrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindUsr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindUsrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBindUsr）用于查询设备被分享的所有用户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBindUsrRequest"/></param>
        /// <returns><see cref="DescribeBindUsrResponse"/></returns>
        public DescribeBindUsrResponse DescribeBindUsrSync(DescribeBindUsrRequest req)
        {
             JsonResponseModel<DescribeBindUsrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindUsr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindUsrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevice）获取设备信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public async Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
             JsonResponseModel<DescribeDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevice）获取设备信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
             JsonResponseModel<DescribeDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceModel）用于获取设备物模型。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceModelRequest"/></param>
        /// <returns><see cref="DescribeDeviceModelResponse"/></returns>
        public async Task<DescribeDeviceModelResponse> DescribeDeviceModel(DescribeDeviceModelRequest req)
        {
             JsonResponseModel<DescribeDeviceModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceModel）用于获取设备物模型。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceModelRequest"/></param>
        /// <returns><see cref="DescribeDeviceModelResponse"/></returns>
        public DescribeDeviceModelResponse DescribeDeviceModelSync(DescribeDeviceModelRequest req)
        {
             JsonResponseModel<DescribeDeviceModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于获取设备信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public async Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于获取设备信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIotDataType）用于查询自定义的物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotDataTypeRequest"/></param>
        /// <returns><see cref="DescribeIotDataTypeResponse"/></returns>
        public async Task<DescribeIotDataTypeResponse> DescribeIotDataType(DescribeIotDataTypeRequest req)
        {
             JsonResponseModel<DescribeIotDataTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIotDataType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIotDataTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIotDataType）用于查询自定义的物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotDataTypeRequest"/></param>
        /// <returns><see cref="DescribeIotDataTypeResponse"/></returns>
        public DescribeIotDataTypeResponse DescribeIotDataTypeSync(DescribeIotDataTypeRequest req)
        {
             JsonResponseModel<DescribeIotDataTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIotDataType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIotDataTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIotModel）用于获取物模型定义详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotModelRequest"/></param>
        /// <returns><see cref="DescribeIotModelResponse"/></returns>
        public async Task<DescribeIotModelResponse> DescribeIotModel(DescribeIotModelRequest req)
        {
             JsonResponseModel<DescribeIotModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIotModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIotModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIotModel）用于获取物模型定义详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotModelRequest"/></param>
        /// <returns><see cref="DescribeIotModelResponse"/></returns>
        public DescribeIotModelResponse DescribeIotModelSync(DescribeIotModelRequest req)
        {
             JsonResponseModel<DescribeIotModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIotModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIotModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIotModels）用于列出物模型历史版本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotModelsRequest"/></param>
        /// <returns><see cref="DescribeIotModelsResponse"/></returns>
        public async Task<DescribeIotModelsResponse> DescribeIotModels(DescribeIotModelsRequest req)
        {
             JsonResponseModel<DescribeIotModelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIotModels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIotModelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIotModels）用于列出物模型历史版本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotModelsRequest"/></param>
        /// <returns><see cref="DescribeIotModelsResponse"/></returns>
        public DescribeIotModelsResponse DescribeIotModelsSync(DescribeIotModelsRequest req)
        {
             JsonResponseModel<DescribeIotModelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIotModels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIotModelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLogs）用于查询设备日志列表。
        /// 设备日志最长保留时长为15天,超期自动清除。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public async Task<DescribeLogsResponse> DescribeLogs(DescribeLogsRequest req)
        {
             JsonResponseModel<DescribeLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLogs）用于查询设备日志列表。
        /// 设备日志最长保留时长为15天,超期自动清除。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public DescribeLogsResponse DescribeLogsSync(DescribeLogsRequest req)
        {
             JsonResponseModel<DescribeLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMessageQueue）用于查询物联网智能视频产品转发消息配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageQueueRequest"/></param>
        /// <returns><see cref="DescribeMessageQueueResponse"/></returns>
        public async Task<DescribeMessageQueueResponse> DescribeMessageQueue(DescribeMessageQueueRequest req)
        {
             JsonResponseModel<DescribeMessageQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMessageQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMessageQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMessageQueue）用于查询物联网智能视频产品转发消息配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageQueueRequest"/></param>
        /// <returns><see cref="DescribeMessageQueueResponse"/></returns>
        public DescribeMessageQueueResponse DescribeMessageQueueSync(DescribeMessageQueueRequest req)
        {
             JsonResponseModel<DescribeMessageQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMessageQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMessageQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeModelDataRet）用于根据TaskId获取对设备物模型操作最终响应的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDataRetRequest"/></param>
        /// <returns><see cref="DescribeModelDataRetResponse"/></returns>
        public async Task<DescribeModelDataRetResponse> DescribeModelDataRet(DescribeModelDataRetRequest req)
        {
             JsonResponseModel<DescribeModelDataRetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelDataRet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelDataRetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeModelDataRet）用于根据TaskId获取对设备物模型操作最终响应的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDataRetRequest"/></param>
        /// <returns><see cref="DescribeModelDataRetResponse"/></returns>
        public DescribeModelDataRetResponse DescribeModelDataRetSync(DescribeModelDataRetRequest req)
        {
             JsonResponseModel<DescribeModelDataRetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelDataRet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelDataRetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看操作系统支持的芯片列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOsListRequest"/></param>
        /// <returns><see cref="DescribeOsListResponse"/></returns>
        public async Task<DescribeOsListResponse> DescribeOsList(DescribeOsListRequest req)
        {
             JsonResponseModel<DescribeOsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看操作系统支持的芯片列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOsListRequest"/></param>
        /// <returns><see cref="DescribeOsListResponse"/></returns>
        public DescribeOsListResponse DescribeOsListSync(DescribeOsListRequest req)
        {
             JsonResponseModel<DescribeOsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOtaVersions）用于查询固件版本信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOtaVersionsRequest"/></param>
        /// <returns><see cref="DescribeOtaVersionsResponse"/></returns>
        public async Task<DescribeOtaVersionsResponse> DescribeOtaVersions(DescribeOtaVersionsRequest req)
        {
             JsonResponseModel<DescribeOtaVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOtaVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOtaVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOtaVersions）用于查询固件版本信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOtaVersionsRequest"/></param>
        /// <returns><see cref="DescribeOtaVersionsResponse"/></returns>
        public DescribeOtaVersionsResponse DescribeOtaVersionsSync(DescribeOtaVersionsRequest req)
        {
             JsonResponseModel<DescribeOtaVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOtaVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOtaVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProduct）用于获取单个产品的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public async Task<DescribeProductResponse> DescribeProduct(DescribeProductRequest req)
        {
             JsonResponseModel<DescribeProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProduct）用于获取单个产品的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public DescribeProductResponse DescribeProductSync(DescribeProductRequest req)
        {
             JsonResponseModel<DescribeProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProducts）用于列出用户账号下的物联网智能视频产品列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public async Task<DescribeProductsResponse> DescribeProducts(DescribeProductsRequest req)
        {
             JsonResponseModel<DescribeProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProducts）用于列出用户账号下的物联网智能视频产品列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public DescribeProductsResponse DescribeProductsSync(DescribeProductsRequest req)
        {
             JsonResponseModel<DescribeProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePubVersions）用于获取某一产品发布过的全部固件版本。
        /// </summary>
        /// <param name="req"><see cref="DescribePubVersionsRequest"/></param>
        /// <returns><see cref="DescribePubVersionsResponse"/></returns>
        public async Task<DescribePubVersionsResponse> DescribePubVersions(DescribePubVersionsRequest req)
        {
             JsonResponseModel<DescribePubVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePubVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePubVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePubVersions）用于获取某一产品发布过的全部固件版本。
        /// </summary>
        /// <param name="req"><see cref="DescribePubVersionsRequest"/></param>
        /// <returns><see cref="DescribePubVersionsResponse"/></returns>
        public DescribePubVersionsResponse DescribePubVersionsSync(DescribePubVersionsRequest req)
        {
             JsonResponseModel<DescribePubVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePubVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePubVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 客户可通过本接口获取充值记录信息, 一次最多返回50条记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeRechargeRecordsRequest"/></param>
        /// <returns><see cref="DescribeRechargeRecordsResponse"/></returns>
        public async Task<DescribeRechargeRecordsResponse> DescribeRechargeRecords(DescribeRechargeRecordsRequest req)
        {
             JsonResponseModel<DescribeRechargeRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRechargeRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRechargeRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 客户可通过本接口获取充值记录信息, 一次最多返回50条记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeRechargeRecordsRequest"/></param>
        /// <returns><see cref="DescribeRechargeRecordsResponse"/></returns>
        public DescribeRechargeRecordsResponse DescribeRechargeRecordsSync(DescribeRechargeRecordsRequest req)
        {
             JsonResponseModel<DescribeRechargeRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRechargeRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRechargeRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRegistrationStatus）用于查询终端用户的注册状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistrationStatusRequest"/></param>
        /// <returns><see cref="DescribeRegistrationStatusResponse"/></returns>
        public async Task<DescribeRegistrationStatusResponse> DescribeRegistrationStatus(DescribeRegistrationStatusRequest req)
        {
             JsonResponseModel<DescribeRegistrationStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegistrationStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegistrationStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRegistrationStatus）用于查询终端用户的注册状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistrationStatusRequest"/></param>
        /// <returns><see cref="DescribeRegistrationStatusResponse"/></returns>
        public DescribeRegistrationStatusResponse DescribeRegistrationStatusSync(DescribeRegistrationStatusRequest req)
        {
             JsonResponseModel<DescribeRegistrationStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegistrationStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegistrationStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRunLog）用于获取设备运行日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunLogRequest"/></param>
        /// <returns><see cref="DescribeRunLogResponse"/></returns>
        public async Task<DescribeRunLogResponse> DescribeRunLog(DescribeRunLogRequest req)
        {
             JsonResponseModel<DescribeRunLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRunLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRunLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRunLog）用于获取设备运行日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunLogRequest"/></param>
        /// <returns><see cref="DescribeRunLogResponse"/></returns>
        public DescribeRunLogResponse DescribeRunLogSync(DescribeRunLogRequest req)
        {
             JsonResponseModel<DescribeRunLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRunLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRunLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云存服务
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageServiceRequest"/></param>
        /// <returns><see cref="DescribeStorageServiceResponse"/></returns>
        public async Task<DescribeStorageServiceResponse> DescribeStorageService(DescribeStorageServiceRequest req)
        {
             JsonResponseModel<DescribeStorageServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStorageService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云存服务
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageServiceRequest"/></param>
        /// <returns><see cref="DescribeStorageServiceResponse"/></returns>
        public DescribeStorageServiceResponse DescribeStorageServiceSync(DescribeStorageServiceRequest req)
        {
             JsonResponseModel<DescribeStorageServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStorageService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTraceIds）用于查询设备日志跟踪白名单。
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceIdsRequest"/></param>
        /// <returns><see cref="DescribeTraceIdsResponse"/></returns>
        public async Task<DescribeTraceIdsResponse> DescribeTraceIds(DescribeTraceIdsRequest req)
        {
             JsonResponseModel<DescribeTraceIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTraceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTraceIds）用于查询设备日志跟踪白名单。
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceIdsRequest"/></param>
        /// <returns><see cref="DescribeTraceIdsResponse"/></returns>
        public DescribeTraceIdsResponse DescribeTraceIdsSync(DescribeTraceIdsRequest req)
        {
             JsonResponseModel<DescribeTraceIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTraceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTraceStatus）用于查询指定设备是否在白名单中。
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceStatusRequest"/></param>
        /// <returns><see cref="DescribeTraceStatusResponse"/></returns>
        public async Task<DescribeTraceStatusResponse> DescribeTraceStatus(DescribeTraceStatusRequest req)
        {
             JsonResponseModel<DescribeTraceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTraceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTraceStatus）用于查询指定设备是否在白名单中。
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceStatusRequest"/></param>
        /// <returns><see cref="DescribeTraceStatusResponse"/></returns>
        public DescribeTraceStatusResponse DescribeTraceStatusSync(DescribeTraceStatusRequest req)
        {
             JsonResponseModel<DescribeTraceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTraceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableDevice）用于禁用设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DisableDeviceRequest"/></param>
        /// <returns><see cref="DisableDeviceResponse"/></returns>
        public async Task<DisableDeviceResponse> DisableDevice(DisableDeviceRequest req)
        {
             JsonResponseModel<DisableDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableDevice）用于禁用设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DisableDeviceRequest"/></param>
        /// <returns><see cref="DisableDeviceResponse"/></returns>
        public DisableDeviceResponse DisableDeviceSync(DisableDeviceRequest req)
        {
             JsonResponseModel<DisableDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableDeviceStream）用于停止设备推流，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DisableDeviceStreamRequest"/></param>
        /// <returns><see cref="DisableDeviceStreamResponse"/></returns>
        public async Task<DisableDeviceStreamResponse> DisableDeviceStream(DisableDeviceStreamRequest req)
        {
             JsonResponseModel<DisableDeviceStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableDeviceStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableDeviceStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableDeviceStream）用于停止设备推流，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DisableDeviceStreamRequest"/></param>
        /// <returns><see cref="DisableDeviceStreamResponse"/></returns>
        public DisableDeviceStreamResponse DisableDeviceStreamSync(DisableDeviceStreamRequest req)
        {
             JsonResponseModel<DisableDeviceStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableDeviceStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableDeviceStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableOtaVersion）用于禁用固件版本。
        /// </summary>
        /// <param name="req"><see cref="DisableOtaVersionRequest"/></param>
        /// <returns><see cref="DisableOtaVersionResponse"/></returns>
        public async Task<DisableOtaVersionResponse> DisableOtaVersion(DisableOtaVersionRequest req)
        {
             JsonResponseModel<DisableOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableOtaVersion）用于禁用固件版本。
        /// </summary>
        /// <param name="req"><see cref="DisableOtaVersionRequest"/></param>
        /// <returns><see cref="DisableOtaVersionResponse"/></returns>
        public DisableOtaVersionResponse DisableOtaVersionSync(DisableOtaVersionRequest req)
        {
             JsonResponseModel<DisableOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDeviceAction）用于修改设备物模型的行为（Action）。
        /// 
        /// 可对ctlVal数据属性进行写入,如:Action.takePhoto.ctlVal,设备在线且成功发送到设备才返回,物模型写入数据时,不需要传入时标信息,平台以当前时标作为数据的时标更新物模型中的时标信息。
        /// 注意:
        ///   1.若设备当前不在线,会直接返回错误
        ///   2.若设备网络出现异常时,消息发送可能超时,超时等待最长时间为3秒
        ///   3.value的内容必须与实际物模型的定义一致
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceActionRequest"/></param>
        /// <returns><see cref="ModifyDeviceActionResponse"/></returns>
        public async Task<ModifyDeviceActionResponse> ModifyDeviceAction(ModifyDeviceActionRequest req)
        {
             JsonResponseModel<ModifyDeviceActionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDeviceAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDeviceAction）用于修改设备物模型的行为（Action）。
        /// 
        /// 可对ctlVal数据属性进行写入,如:Action.takePhoto.ctlVal,设备在线且成功发送到设备才返回,物模型写入数据时,不需要传入时标信息,平台以当前时标作为数据的时标更新物模型中的时标信息。
        /// 注意:
        ///   1.若设备当前不在线,会直接返回错误
        ///   2.若设备网络出现异常时,消息发送可能超时,超时等待最长时间为3秒
        ///   3.value的内容必须与实际物模型的定义一致
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceActionRequest"/></param>
        /// <returns><see cref="ModifyDeviceActionResponse"/></returns>
        public ModifyDeviceActionResponse ModifyDeviceActionSync(ModifyDeviceActionRequest req)
        {
             JsonResponseModel<ModifyDeviceActionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDeviceAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDeviceProperty）用于修改设备物模型的属性（ProWritable）。
        /// 可对setVal数据属性进行写入,如:
        /// ProWritable.Pos.setVal
        /// 对于嵌套类型的可写属性，可以仅对其部分数据内容进行写入，如:
        /// ProWritable.Pos.setVal.x;
        /// 可写属性云端写入成功即返回;云端向设备端发布属性变更参数;若当前设备不在线,在设备下次上线时会自动更新这些属性参数;
        /// 物模型写入数据时,不需要传入时标信息,平台以当前时标作为数据的时标更新物模型中的时标信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDevicePropertyRequest"/></param>
        /// <returns><see cref="ModifyDevicePropertyResponse"/></returns>
        public async Task<ModifyDevicePropertyResponse> ModifyDeviceProperty(ModifyDevicePropertyRequest req)
        {
             JsonResponseModel<ModifyDevicePropertyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDeviceProperty");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDevicePropertyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDeviceProperty）用于修改设备物模型的属性（ProWritable）。
        /// 可对setVal数据属性进行写入,如:
        /// ProWritable.Pos.setVal
        /// 对于嵌套类型的可写属性，可以仅对其部分数据内容进行写入，如:
        /// ProWritable.Pos.setVal.x;
        /// 可写属性云端写入成功即返回;云端向设备端发布属性变更参数;若当前设备不在线,在设备下次上线时会自动更新这些属性参数;
        /// 物模型写入数据时,不需要传入时标信息,平台以当前时标作为数据的时标更新物模型中的时标信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDevicePropertyRequest"/></param>
        /// <returns><see cref="ModifyDevicePropertyResponse"/></returns>
        public ModifyDevicePropertyResponse ModifyDevicePropertySync(ModifyDevicePropertyRequest req)
        {
             JsonResponseModel<ModifyDevicePropertyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDeviceProperty");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDevicePropertyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyProduct）用于编辑物联网智能视频产品的相关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public async Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest req)
        {
             JsonResponseModel<ModifyProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyProduct）用于编辑物联网智能视频产品的相关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public ModifyProductResponse ModifyProductSync(ModifyProductRequest req)
        {
             JsonResponseModel<ModifyProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑版本描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyVerContentRequest"/></param>
        /// <returns><see cref="ModifyVerContentResponse"/></returns>
        public async Task<ModifyVerContentResponse> ModifyVerContent(ModifyVerContentRequest req)
        {
             JsonResponseModel<ModifyVerContentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVerContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVerContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑版本描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyVerContentRequest"/></param>
        /// <returns><see cref="ModifyVerContentResponse"/></returns>
        public ModifyVerContentResponse ModifyVerContentSync(ModifyVerContentRequest req)
        {
             JsonResponseModel<ModifyVerContentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVerContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVerContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RefundStorageService）用于退订已购买的云存服务。
        /// 退订时，云存服务对应订单的处理方式 : 
        /// 1. 未开始的订单自动回到已付费订单池
        /// 2. 已开始的订单自动失效
        /// 3. 购买云存接口,优先从已付费订单池中分配订单
        /// </summary>
        /// <param name="req"><see cref="RefundStorageServiceRequest"/></param>
        /// <returns><see cref="RefundStorageServiceResponse"/></returns>
        public async Task<RefundStorageServiceResponse> RefundStorageService(RefundStorageServiceRequest req)
        {
             JsonResponseModel<RefundStorageServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefundStorageService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundStorageServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RefundStorageService）用于退订已购买的云存服务。
        /// 退订时，云存服务对应订单的处理方式 : 
        /// 1. 未开始的订单自动回到已付费订单池
        /// 2. 已开始的订单自动失效
        /// 3. 购买云存接口,优先从已付费订单池中分配订单
        /// </summary>
        /// <param name="req"><see cref="RefundStorageServiceRequest"/></param>
        /// <returns><see cref="RefundStorageServiceResponse"/></returns>
        public RefundStorageServiceResponse RefundStorageServiceSync(RefundStorageServiceRequest req)
        {
             JsonResponseModel<RefundStorageServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefundStorageService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundStorageServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunDevice）用于启用设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="RunDeviceRequest"/></param>
        /// <returns><see cref="RunDeviceResponse"/></returns>
        public async Task<RunDeviceResponse> RunDevice(RunDeviceRequest req)
        {
             JsonResponseModel<RunDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunDevice）用于启用设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="RunDeviceRequest"/></param>
        /// <returns><see cref="RunDeviceResponse"/></returns>
        public RunDeviceResponse RunDeviceSync(RunDeviceRequest req)
        {
             JsonResponseModel<RunDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunDeviceStream）用于开启设备推流，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="RunDeviceStreamRequest"/></param>
        /// <returns><see cref="RunDeviceStreamResponse"/></returns>
        public async Task<RunDeviceStreamResponse> RunDeviceStream(RunDeviceStreamRequest req)
        {
             JsonResponseModel<RunDeviceStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunDeviceStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunDeviceStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunDeviceStream）用于开启设备推流，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="RunDeviceStreamRequest"/></param>
        /// <returns><see cref="RunDeviceStreamResponse"/></returns>
        public RunDeviceStreamResponse RunDeviceStreamSync(RunDeviceStreamRequest req)
        {
             JsonResponseModel<RunDeviceStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunDeviceStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunDeviceStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunIotModel）用于对定义的物模型进行发布。
        /// </summary>
        /// <param name="req"><see cref="RunIotModelRequest"/></param>
        /// <returns><see cref="RunIotModelResponse"/></returns>
        public async Task<RunIotModelResponse> RunIotModel(RunIotModelRequest req)
        {
             JsonResponseModel<RunIotModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunIotModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunIotModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunIotModel）用于对定义的物模型进行发布。
        /// </summary>
        /// <param name="req"><see cref="RunIotModelRequest"/></param>
        /// <returns><see cref="RunIotModelResponse"/></returns>
        public RunIotModelResponse RunIotModelSync(RunIotModelRequest req)
        {
             JsonResponseModel<RunIotModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunIotModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunIotModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunOtaVersion）用于固件版本正式发布。
        /// </summary>
        /// <param name="req"><see cref="RunOtaVersionRequest"/></param>
        /// <returns><see cref="RunOtaVersionResponse"/></returns>
        public async Task<RunOtaVersionResponse> RunOtaVersion(RunOtaVersionRequest req)
        {
             JsonResponseModel<RunOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunOtaVersion）用于固件版本正式发布。
        /// </summary>
        /// <param name="req"><see cref="RunOtaVersionRequest"/></param>
        /// <returns><see cref="RunOtaVersionResponse"/></returns>
        public RunOtaVersionResponse RunOtaVersionSync(RunOtaVersionRequest req)
        {
             JsonResponseModel<RunOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunTestOtaVersion）用于固件版本测试发布。
        /// </summary>
        /// <param name="req"><see cref="RunTestOtaVersionRequest"/></param>
        /// <returns><see cref="RunTestOtaVersionResponse"/></returns>
        public async Task<RunTestOtaVersionResponse> RunTestOtaVersion(RunTestOtaVersionRequest req)
        {
             JsonResponseModel<RunTestOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunTestOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunTestOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunTestOtaVersion）用于固件版本测试发布。
        /// </summary>
        /// <param name="req"><see cref="RunTestOtaVersionRequest"/></param>
        /// <returns><see cref="RunTestOtaVersionResponse"/></returns>
        public RunTestOtaVersionResponse RunTestOtaVersionSync(RunTestOtaVersionRequest req)
        {
             JsonResponseModel<RunTestOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunTestOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunTestOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SendOnlineMsg）用于向设备发送在线消息。
        /// 注意：
        /// 若设备当前不在线,会直接返回错误;
        /// 若设备网络出现异常时,消息发送可能超时,超时等待最长时间为3秒.waitresp非0情况下,会导致本接口阻塞3秒。
        /// </summary>
        /// <param name="req"><see cref="SendOnlineMsgRequest"/></param>
        /// <returns><see cref="SendOnlineMsgResponse"/></returns>
        public async Task<SendOnlineMsgResponse> SendOnlineMsg(SendOnlineMsgRequest req)
        {
             JsonResponseModel<SendOnlineMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendOnlineMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendOnlineMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SendOnlineMsg）用于向设备发送在线消息。
        /// 注意：
        /// 若设备当前不在线,会直接返回错误;
        /// 若设备网络出现异常时,消息发送可能超时,超时等待最长时间为3秒.waitresp非0情况下,会导致本接口阻塞3秒。
        /// </summary>
        /// <param name="req"><see cref="SendOnlineMsgRequest"/></param>
        /// <returns><see cref="SendOnlineMsgResponse"/></returns>
        public SendOnlineMsgResponse SendOnlineMsgSync(SendOnlineMsgRequest req)
        {
             JsonResponseModel<SendOnlineMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendOnlineMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendOnlineMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetMessageQueue）用于配置物联网智能视频产品的转发消息队列。
        /// </summary>
        /// <param name="req"><see cref="SetMessageQueueRequest"/></param>
        /// <returns><see cref="SetMessageQueueResponse"/></returns>
        public async Task<SetMessageQueueResponse> SetMessageQueue(SetMessageQueueRequest req)
        {
             JsonResponseModel<SetMessageQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetMessageQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetMessageQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetMessageQueue）用于配置物联网智能视频产品的转发消息队列。
        /// </summary>
        /// <param name="req"><see cref="SetMessageQueueRequest"/></param>
        /// <returns><see cref="SetMessageQueueResponse"/></returns>
        public SetMessageQueueResponse SetMessageQueueSync(SetMessageQueueRequest req)
        {
             JsonResponseModel<SetMessageQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetMessageQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetMessageQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeDevice）用于对设备进行固件升级。
        /// 该接口向指定的设备下发固件更新指令,可将固件升级到任意版本(可实现固件降级)。
        /// 警告:使能UpgradeNow参数存在一定的风险性！建议仅在debug场景下使用!
        /// </summary>
        /// <param name="req"><see cref="UpgradeDeviceRequest"/></param>
        /// <returns><see cref="UpgradeDeviceResponse"/></returns>
        public async Task<UpgradeDeviceResponse> UpgradeDevice(UpgradeDeviceRequest req)
        {
             JsonResponseModel<UpgradeDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeDevice）用于对设备进行固件升级。
        /// 该接口向指定的设备下发固件更新指令,可将固件升级到任意版本(可实现固件降级)。
        /// 警告:使能UpgradeNow参数存在一定的风险性！建议仅在debug场景下使用!
        /// </summary>
        /// <param name="req"><see cref="UpgradeDeviceRequest"/></param>
        /// <returns><see cref="UpgradeDeviceResponse"/></returns>
        public UpgradeDeviceResponse UpgradeDeviceSync(UpgradeDeviceRequest req)
        {
             JsonResponseModel<UpgradeDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadOtaVersion）接收上传到控制台的固件版本信息。
        /// </summary>
        /// <param name="req"><see cref="UploadOtaVersionRequest"/></param>
        /// <returns><see cref="UploadOtaVersionResponse"/></returns>
        public async Task<UploadOtaVersionResponse> UploadOtaVersion(UploadOtaVersionRequest req)
        {
             JsonResponseModel<UploadOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadOtaVersion）接收上传到控制台的固件版本信息。
        /// </summary>
        /// <param name="req"><see cref="UploadOtaVersionRequest"/></param>
        /// <returns><see cref="UploadOtaVersionResponse"/></returns>
        public UploadOtaVersionResponse UploadOtaVersionSync(UploadOtaVersionRequest req)
        {
             JsonResponseModel<UploadOtaVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadOtaVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadOtaVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
