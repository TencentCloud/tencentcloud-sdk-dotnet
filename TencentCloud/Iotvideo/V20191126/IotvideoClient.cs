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
       private const string sdkVersion = "SDK_NET_3.0.1109";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotvideoClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 清除设备激活码
        /// </summary>
        /// <param name="req"><see cref="ClearDeviceActiveCodeRequest"/></param>
        /// <returns><see cref="ClearDeviceActiveCodeResponse"/></returns>
        public Task<ClearDeviceActiveCodeResponse> ClearDeviceActiveCode(ClearDeviceActiveCodeRequest req)
        {
            return InternalRequestAsync<ClearDeviceActiveCodeResponse>(req, "ClearDeviceActiveCode");
        }

        /// <summary>
        /// 清除设备激活码
        /// </summary>
        /// <param name="req"><see cref="ClearDeviceActiveCodeRequest"/></param>
        /// <returns><see cref="ClearDeviceActiveCodeResponse"/></returns>
        public ClearDeviceActiveCodeResponse ClearDeviceActiveCodeSync(ClearDeviceActiveCodeRequest req)
        {
            return InternalRequestAsync<ClearDeviceActiveCodeResponse>(req, "ClearDeviceActiveCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建匿名访问Token
        /// </summary>
        /// <param name="req"><see cref="CreateAnonymousAccessTokenRequest"/></param>
        /// <returns><see cref="CreateAnonymousAccessTokenResponse"/></returns>
        public Task<CreateAnonymousAccessTokenResponse> CreateAnonymousAccessToken(CreateAnonymousAccessTokenRequest req)
        {
            return InternalRequestAsync<CreateAnonymousAccessTokenResponse>(req, "CreateAnonymousAccessToken");
        }

        /// <summary>
        /// 创建匿名访问Token
        /// </summary>
        /// <param name="req"><see cref="CreateAnonymousAccessTokenRequest"/></param>
        /// <returns><see cref="CreateAnonymousAccessTokenResponse"/></returns>
        public CreateAnonymousAccessTokenResponse CreateAnonymousAccessTokenSync(CreateAnonymousAccessTokenRequest req)
        {
            return InternalRequestAsync<CreateAnonymousAccessTokenResponse>(req, "CreateAnonymousAccessToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAppUsr）用于接收由厂商云发送过来的注册请求,建立厂商云终端用户与IoT Video终端用户的映射关系。
        /// </summary>
        /// <param name="req"><see cref="CreateAppUsrRequest"/></param>
        /// <returns><see cref="CreateAppUsrResponse"/></returns>
        public Task<CreateAppUsrResponse> CreateAppUsr(CreateAppUsrRequest req)
        {
            return InternalRequestAsync<CreateAppUsrResponse>(req, "CreateAppUsr");
        }

        /// <summary>
        /// 本接口（CreateAppUsr）用于接收由厂商云发送过来的注册请求,建立厂商云终端用户与IoT Video终端用户的映射关系。
        /// </summary>
        /// <param name="req"><see cref="CreateAppUsrRequest"/></param>
        /// <returns><see cref="CreateAppUsrResponse"/></returns>
        public CreateAppUsrResponse CreateAppUsrSync(CreateAppUsrRequest req)
        {
            return InternalRequestAsync<CreateAppUsrResponse>(req, "CreateAppUsr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateBinding）用于终端用户和设备进行绑定，具体的应用场景如下：
        ///     终端用户与设备具有“强关联”关系。用户与设备绑定之后，用户终端即具备了该设备的访问权限,访问或操作设备时，无需获取设备访问Token。
        /// </summary>
        /// <param name="req"><see cref="CreateBindingRequest"/></param>
        /// <returns><see cref="CreateBindingResponse"/></returns>
        public Task<CreateBindingResponse> CreateBinding(CreateBindingRequest req)
        {
            return InternalRequestAsync<CreateBindingResponse>(req, "CreateBinding");
        }

        /// <summary>
        /// 本接口（CreateBinding）用于终端用户和设备进行绑定，具体的应用场景如下：
        ///     终端用户与设备具有“强关联”关系。用户与设备绑定之后，用户终端即具备了该设备的访问权限,访问或操作设备时，无需获取设备访问Token。
        /// </summary>
        /// <param name="req"><see cref="CreateBindingRequest"/></param>
        /// <returns><see cref="CreateBindingResponse"/></returns>
        public CreateBindingResponse CreateBindingSync(CreateBindingRequest req)
        {
            return InternalRequestAsync<CreateBindingResponse>(req, "CreateBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDevToken）用于以下场景：
        /// 终端用户与设备没有强绑定关联关系;
        /// 允许终端用户短时或一次性临时访问设备;
        /// 当终端用户与设备有强绑定关系时，可以不用调用此接口
        /// </summary>
        /// <param name="req"><see cref="CreateDevTokenRequest"/></param>
        /// <returns><see cref="CreateDevTokenResponse"/></returns>
        public Task<CreateDevTokenResponse> CreateDevToken(CreateDevTokenRequest req)
        {
            return InternalRequestAsync<CreateDevTokenResponse>(req, "CreateDevToken");
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
            return InternalRequestAsync<CreateDevTokenResponse>(req, "CreateDevToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDevices）用于批量创建新的物联网视频通信设备。
        /// 注意：腾讯云不会对设备私钥进行保存，请自行保管好您的设备私钥。
        /// </summary>
        /// <param name="req"><see cref="CreateDevicesRequest"/></param>
        /// <returns><see cref="CreateDevicesResponse"/></returns>
        public Task<CreateDevicesResponse> CreateDevices(CreateDevicesRequest req)
        {
            return InternalRequestAsync<CreateDevicesResponse>(req, "CreateDevices");
        }

        /// <summary>
        /// 本接口（CreateDevices）用于批量创建新的物联网视频通信设备。
        /// 注意：腾讯云不会对设备私钥进行保存，请自行保管好您的设备私钥。
        /// </summary>
        /// <param name="req"><see cref="CreateDevicesRequest"/></param>
        /// <returns><see cref="CreateDevicesResponse"/></returns>
        public CreateDevicesResponse CreateDevicesSync(CreateDevicesRequest req)
        {
            return InternalRequestAsync<CreateDevicesResponse>(req, "CreateDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateGencode）用于生成设备物模型源代码
        /// </summary>
        /// <param name="req"><see cref="CreateGencodeRequest"/></param>
        /// <returns><see cref="CreateGencodeResponse"/></returns>
        public Task<CreateGencodeResponse> CreateGencode(CreateGencodeRequest req)
        {
            return InternalRequestAsync<CreateGencodeResponse>(req, "CreateGencode");
        }

        /// <summary>
        /// 本接口（CreateGencode）用于生成设备物模型源代码
        /// </summary>
        /// <param name="req"><see cref="CreateGencodeRequest"/></param>
        /// <returns><see cref="CreateGencodeResponse"/></returns>
        public CreateGencodeResponse CreateGencodeSync(CreateGencodeRequest req)
        {
            return InternalRequestAsync<CreateGencodeResponse>(req, "CreateGencode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateIotDataType）用于创建自定义物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="CreateIotDataTypeRequest"/></param>
        /// <returns><see cref="CreateIotDataTypeResponse"/></returns>
        public Task<CreateIotDataTypeResponse> CreateIotDataType(CreateIotDataTypeRequest req)
        {
            return InternalRequestAsync<CreateIotDataTypeResponse>(req, "CreateIotDataType");
        }

        /// <summary>
        /// 本接口（CreateIotDataType）用于创建自定义物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="CreateIotDataTypeRequest"/></param>
        /// <returns><see cref="CreateIotDataTypeResponse"/></returns>
        public CreateIotDataTypeResponse CreateIotDataTypeSync(CreateIotDataTypeRequest req)
        {
            return InternalRequestAsync<CreateIotDataTypeResponse>(req, "CreateIotDataType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateIotModel）用于定义的物模型提交。
        /// 该接口实现了物模型草稿箱的功能，保存用户最后一次编辑的物模型数据。
        /// </summary>
        /// <param name="req"><see cref="CreateIotModelRequest"/></param>
        /// <returns><see cref="CreateIotModelResponse"/></returns>
        public Task<CreateIotModelResponse> CreateIotModel(CreateIotModelRequest req)
        {
            return InternalRequestAsync<CreateIotModelResponse>(req, "CreateIotModel");
        }

        /// <summary>
        /// 本接口（CreateIotModel）用于定义的物模型提交。
        /// 该接口实现了物模型草稿箱的功能，保存用户最后一次编辑的物模型数据。
        /// </summary>
        /// <param name="req"><see cref="CreateIotModelRequest"/></param>
        /// <returns><see cref="CreateIotModelResponse"/></returns>
        public CreateIotModelResponse CreateIotModelSync(CreateIotModelRequest req)
        {
            return InternalRequestAsync<CreateIotModelResponse>(req, "CreateIotModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateProduct）用于创建一个新的物联网智能视频产品。
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public Task<CreateProductResponse> CreateProduct(CreateProductRequest req)
        {
            return InternalRequestAsync<CreateProductResponse>(req, "CreateProduct");
        }

        /// <summary>
        /// 本接口（CreateProduct）用于创建一个新的物联网智能视频产品。
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public CreateProductResponse CreateProductSync(CreateProductRequest req)
        {
            return InternalRequestAsync<CreateProductResponse>(req, "CreateProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口已经停止维护，请勿使用
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRequest"/></param>
        /// <returns><see cref="CreateStorageResponse"/></returns>
        public Task<CreateStorageResponse> CreateStorage(CreateStorageRequest req)
        {
            return InternalRequestAsync<CreateStorageResponse>(req, "CreateStorage");
        }

        /// <summary>
        /// 该接口已经停止维护，请勿使用
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRequest"/></param>
        /// <returns><see cref="CreateStorageResponse"/></returns>
        public CreateStorageResponse CreateStorageSync(CreateStorageRequest req)
        {
            return InternalRequestAsync<CreateStorageResponse>(req, "CreateStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateStorageServiceRequest"/></param>
        /// <returns><see cref="CreateStorageServiceResponse"/></returns>
        public Task<CreateStorageServiceResponse> CreateStorageService(CreateStorageServiceRequest req)
        {
            return InternalRequestAsync<CreateStorageServiceResponse>(req, "CreateStorageService");
        }

        /// <summary>
        /// 购买云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateStorageServiceRequest"/></param>
        /// <returns><see cref="CreateStorageServiceResponse"/></returns>
        public CreateStorageServiceResponse CreateStorageServiceSync(CreateStorageServiceRequest req)
        {
            return InternalRequestAsync<CreateStorageServiceResponse>(req, "CreateStorageService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateTraceIds）用于将设备加到日志跟踪白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateTraceIdsRequest"/></param>
        /// <returns><see cref="CreateTraceIdsResponse"/></returns>
        public Task<CreateTraceIdsResponse> CreateTraceIds(CreateTraceIdsRequest req)
        {
            return InternalRequestAsync<CreateTraceIdsResponse>(req, "CreateTraceIds");
        }

        /// <summary>
        /// 本接口（CreateTraceIds）用于将设备加到日志跟踪白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateTraceIdsRequest"/></param>
        /// <returns><see cref="CreateTraceIdsResponse"/></returns>
        public CreateTraceIdsResponse CreateTraceIdsSync(CreateTraceIdsRequest req)
        {
            return InternalRequestAsync<CreateTraceIdsResponse>(req, "CreateTraceIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateUploadPath）用于获取固件上传路径。
        /// </summary>
        /// <param name="req"><see cref="CreateUploadPathRequest"/></param>
        /// <returns><see cref="CreateUploadPathResponse"/></returns>
        public Task<CreateUploadPathResponse> CreateUploadPath(CreateUploadPathRequest req)
        {
            return InternalRequestAsync<CreateUploadPathResponse>(req, "CreateUploadPath");
        }

        /// <summary>
        /// 本接口（CreateUploadPath）用于获取固件上传路径。
        /// </summary>
        /// <param name="req"><see cref="CreateUploadPathRequest"/></param>
        /// <returns><see cref="CreateUploadPathResponse"/></returns>
        public CreateUploadPathResponse CreateUploadPathSync(CreateUploadPathRequest req)
        {
            return InternalRequestAsync<CreateUploadPathResponse>(req, "CreateUploadPath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateUsrToken）用于终端用户获取IoT Video平台的accessToken，初始化SDK,连接到IoT Video接入服务器。
        /// </summary>
        /// <param name="req"><see cref="CreateUsrTokenRequest"/></param>
        /// <returns><see cref="CreateUsrTokenResponse"/></returns>
        public Task<CreateUsrTokenResponse> CreateUsrToken(CreateUsrTokenRequest req)
        {
            return InternalRequestAsync<CreateUsrTokenResponse>(req, "CreateUsrToken");
        }

        /// <summary>
        /// 本接口（CreateUsrToken）用于终端用户获取IoT Video平台的accessToken，初始化SDK,连接到IoT Video接入服务器。
        /// </summary>
        /// <param name="req"><see cref="CreateUsrTokenRequest"/></param>
        /// <returns><see cref="CreateUsrTokenResponse"/></returns>
        public CreateUsrTokenResponse CreateUsrTokenSync(CreateUsrTokenRequest req)
        {
            return InternalRequestAsync<CreateUsrTokenResponse>(req, "CreateUsrToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteAppUsr）用于删除终端用户。
        /// </summary>
        /// <param name="req"><see cref="DeleteAppUsrRequest"/></param>
        /// <returns><see cref="DeleteAppUsrResponse"/></returns>
        public Task<DeleteAppUsrResponse> DeleteAppUsr(DeleteAppUsrRequest req)
        {
            return InternalRequestAsync<DeleteAppUsrResponse>(req, "DeleteAppUsr");
        }

        /// <summary>
        /// 本接口（DeleteAppUsr）用于删除终端用户。
        /// </summary>
        /// <param name="req"><see cref="DeleteAppUsrRequest"/></param>
        /// <returns><see cref="DeleteAppUsrResponse"/></returns>
        public DeleteAppUsrResponse DeleteAppUsrSync(DeleteAppUsrRequest req)
        {
            return InternalRequestAsync<DeleteAppUsrResponse>(req, "DeleteAppUsr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteBinding）用于终端用户和设备进行解绑定。
        /// </summary>
        /// <param name="req"><see cref="DeleteBindingRequest"/></param>
        /// <returns><see cref="DeleteBindingResponse"/></returns>
        public Task<DeleteBindingResponse> DeleteBinding(DeleteBindingRequest req)
        {
            return InternalRequestAsync<DeleteBindingResponse>(req, "DeleteBinding");
        }

        /// <summary>
        /// 本接口（DeleteBinding）用于终端用户和设备进行解绑定。
        /// </summary>
        /// <param name="req"><see cref="DeleteBindingRequest"/></param>
        /// <returns><see cref="DeleteBindingResponse"/></returns>
        public DeleteBindingResponse DeleteBindingSync(DeleteBindingRequest req)
        {
            return InternalRequestAsync<DeleteBindingResponse>(req, "DeleteBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteDevice）用于删除设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice");
        }

        /// <summary>
        /// 本接口（DeleteDevice）用于删除设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteIotDataType）用于删除自定义物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="DeleteIotDataTypeRequest"/></param>
        /// <returns><see cref="DeleteIotDataTypeResponse"/></returns>
        public Task<DeleteIotDataTypeResponse> DeleteIotDataType(DeleteIotDataTypeRequest req)
        {
            return InternalRequestAsync<DeleteIotDataTypeResponse>(req, "DeleteIotDataType");
        }

        /// <summary>
        /// 本接口（DeleteIotDataType）用于删除自定义物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="DeleteIotDataTypeRequest"/></param>
        /// <returns><see cref="DeleteIotDataTypeResponse"/></returns>
        public DeleteIotDataTypeResponse DeleteIotDataTypeSync(DeleteIotDataTypeRequest req)
        {
            return InternalRequestAsync<DeleteIotDataTypeResponse>(req, "DeleteIotDataType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteMessageQueue）用于删除物联网智能视频产品的转发消息配置信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageQueueRequest"/></param>
        /// <returns><see cref="DeleteMessageQueueResponse"/></returns>
        public Task<DeleteMessageQueueResponse> DeleteMessageQueue(DeleteMessageQueueRequest req)
        {
            return InternalRequestAsync<DeleteMessageQueueResponse>(req, "DeleteMessageQueue");
        }

        /// <summary>
        /// 本接口（DeleteMessageQueue）用于删除物联网智能视频产品的转发消息配置信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageQueueRequest"/></param>
        /// <returns><see cref="DeleteMessageQueueResponse"/></returns>
        public DeleteMessageQueueResponse DeleteMessageQueueSync(DeleteMessageQueueRequest req)
        {
            return InternalRequestAsync<DeleteMessageQueueResponse>(req, "DeleteMessageQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteOtaVersion）用于删除固件版本信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteOtaVersionRequest"/></param>
        /// <returns><see cref="DeleteOtaVersionResponse"/></returns>
        public Task<DeleteOtaVersionResponse> DeleteOtaVersion(DeleteOtaVersionRequest req)
        {
            return InternalRequestAsync<DeleteOtaVersionResponse>(req, "DeleteOtaVersion");
        }

        /// <summary>
        /// 本接口（DeleteOtaVersion）用于删除固件版本信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteOtaVersionRequest"/></param>
        /// <returns><see cref="DeleteOtaVersionResponse"/></returns>
        public DeleteOtaVersionResponse DeleteOtaVersionSync(DeleteOtaVersionRequest req)
        {
            return InternalRequestAsync<DeleteOtaVersionResponse>(req, "DeleteOtaVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网智能视频产品。
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct");
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网智能视频产品。
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteTraceIds）用于将设备从日志跟踪白名单中删除，该接口可批量操作，最多支持同时操作100台设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteTraceIdsRequest"/></param>
        /// <returns><see cref="DeleteTraceIdsResponse"/></returns>
        public Task<DeleteTraceIdsResponse> DeleteTraceIds(DeleteTraceIdsRequest req)
        {
            return InternalRequestAsync<DeleteTraceIdsResponse>(req, "DeleteTraceIds");
        }

        /// <summary>
        /// 本接口（DeleteTraceIds）用于将设备从日志跟踪白名单中删除，该接口可批量操作，最多支持同时操作100台设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteTraceIdsRequest"/></param>
        /// <returns><see cref="DeleteTraceIdsResponse"/></returns>
        public DeleteTraceIdsResponse DeleteTraceIdsSync(DeleteTraceIdsRequest req)
        {
            return InternalRequestAsync<DeleteTraceIdsResponse>(req, "DeleteTraceIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将已购买的云存服务转移到另一设备
        /// </summary>
        /// <param name="req"><see cref="DeliverStorageServiceRequest"/></param>
        /// <returns><see cref="DeliverStorageServiceResponse"/></returns>
        public Task<DeliverStorageServiceResponse> DeliverStorageService(DeliverStorageServiceRequest req)
        {
            return InternalRequestAsync<DeliverStorageServiceResponse>(req, "DeliverStorageService");
        }

        /// <summary>
        /// 将已购买的云存服务转移到另一设备
        /// </summary>
        /// <param name="req"><see cref="DeliverStorageServiceRequest"/></param>
        /// <returns><see cref="DeliverStorageServiceResponse"/></returns>
        public DeliverStorageServiceResponse DeliverStorageServiceSync(DeliverStorageServiceRequest req)
        {
            return InternalRequestAsync<DeliverStorageServiceResponse>(req, "DeliverStorageService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 客户可通过本接口获取账户余额信息, 默认接口请求频率限制：1次/秒
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public Task<DescribeAccountBalanceResponse> DescribeAccountBalance(DescribeAccountBalanceRequest req)
        {
            return InternalRequestAsync<DescribeAccountBalanceResponse>(req, "DescribeAccountBalance");
        }

        /// <summary>
        /// 客户可通过本接口获取账户余额信息, 默认接口请求频率限制：1次/秒
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public DescribeAccountBalanceResponse DescribeAccountBalanceSync(DescribeAccountBalanceRequest req)
        {
            return InternalRequestAsync<DescribeAccountBalanceResponse>(req, "DescribeAccountBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBindDev）用于查询终端用户绑定的设备列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBindDevRequest"/></param>
        /// <returns><see cref="DescribeBindDevResponse"/></returns>
        public Task<DescribeBindDevResponse> DescribeBindDev(DescribeBindDevRequest req)
        {
            return InternalRequestAsync<DescribeBindDevResponse>(req, "DescribeBindDev");
        }

        /// <summary>
        /// 本接口（DescribeBindDev）用于查询终端用户绑定的设备列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBindDevRequest"/></param>
        /// <returns><see cref="DescribeBindDevResponse"/></returns>
        public DescribeBindDevResponse DescribeBindDevSync(DescribeBindDevRequest req)
        {
            return InternalRequestAsync<DescribeBindDevResponse>(req, "DescribeBindDev")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBindUsr）用于查询设备被分享的所有用户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBindUsrRequest"/></param>
        /// <returns><see cref="DescribeBindUsrResponse"/></returns>
        public Task<DescribeBindUsrResponse> DescribeBindUsr(DescribeBindUsrRequest req)
        {
            return InternalRequestAsync<DescribeBindUsrResponse>(req, "DescribeBindUsr");
        }

        /// <summary>
        /// 本接口（DescribeBindUsr）用于查询设备被分享的所有用户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBindUsrRequest"/></param>
        /// <returns><see cref="DescribeBindUsrResponse"/></returns>
        public DescribeBindUsrResponse DescribeBindUsrSync(DescribeBindUsrRequest req)
        {
            return InternalRequestAsync<DescribeBindUsrResponse>(req, "DescribeBindUsr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDevice）获取设备信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice");
        }

        /// <summary>
        /// 本接口（DescribeDevice）获取设备信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDeviceModel）用于获取设备物模型。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceModelRequest"/></param>
        /// <returns><see cref="DescribeDeviceModelResponse"/></returns>
        public Task<DescribeDeviceModelResponse> DescribeDeviceModel(DescribeDeviceModelRequest req)
        {
            return InternalRequestAsync<DescribeDeviceModelResponse>(req, "DescribeDeviceModel");
        }

        /// <summary>
        /// 本接口（DescribeDeviceModel）用于获取设备物模型。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceModelRequest"/></param>
        /// <returns><see cref="DescribeDeviceModelResponse"/></returns>
        public DescribeDeviceModelResponse DescribeDeviceModelSync(DescribeDeviceModelRequest req)
        {
            return InternalRequestAsync<DescribeDeviceModelResponse>(req, "DescribeDeviceModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于获取设备信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices");
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于获取设备信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIotDataType）用于查询自定义的物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotDataTypeRequest"/></param>
        /// <returns><see cref="DescribeIotDataTypeResponse"/></returns>
        public Task<DescribeIotDataTypeResponse> DescribeIotDataType(DescribeIotDataTypeRequest req)
        {
            return InternalRequestAsync<DescribeIotDataTypeResponse>(req, "DescribeIotDataType");
        }

        /// <summary>
        /// 本接口（DescribeIotDataType）用于查询自定义的物模型数据类型。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotDataTypeRequest"/></param>
        /// <returns><see cref="DescribeIotDataTypeResponse"/></returns>
        public DescribeIotDataTypeResponse DescribeIotDataTypeSync(DescribeIotDataTypeRequest req)
        {
            return InternalRequestAsync<DescribeIotDataTypeResponse>(req, "DescribeIotDataType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIotModel）用于获取物模型定义详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotModelRequest"/></param>
        /// <returns><see cref="DescribeIotModelResponse"/></returns>
        public Task<DescribeIotModelResponse> DescribeIotModel(DescribeIotModelRequest req)
        {
            return InternalRequestAsync<DescribeIotModelResponse>(req, "DescribeIotModel");
        }

        /// <summary>
        /// 本接口（DescribeIotModel）用于获取物模型定义详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotModelRequest"/></param>
        /// <returns><see cref="DescribeIotModelResponse"/></returns>
        public DescribeIotModelResponse DescribeIotModelSync(DescribeIotModelRequest req)
        {
            return InternalRequestAsync<DescribeIotModelResponse>(req, "DescribeIotModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIotModels）用于列出物模型历史版本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotModelsRequest"/></param>
        /// <returns><see cref="DescribeIotModelsResponse"/></returns>
        public Task<DescribeIotModelsResponse> DescribeIotModels(DescribeIotModelsRequest req)
        {
            return InternalRequestAsync<DescribeIotModelsResponse>(req, "DescribeIotModels");
        }

        /// <summary>
        /// 本接口（DescribeIotModels）用于列出物模型历史版本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIotModelsRequest"/></param>
        /// <returns><see cref="DescribeIotModelsResponse"/></returns>
        public DescribeIotModelsResponse DescribeIotModelsSync(DescribeIotModelsRequest req)
        {
            return InternalRequestAsync<DescribeIotModelsResponse>(req, "DescribeIotModels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeLogs）用于查询设备日志列表。
        /// 设备日志最长保留时长为15天,超期自动清除。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public Task<DescribeLogsResponse> DescribeLogs(DescribeLogsRequest req)
        {
            return InternalRequestAsync<DescribeLogsResponse>(req, "DescribeLogs");
        }

        /// <summary>
        /// 本接口（DescribeLogs）用于查询设备日志列表。
        /// 设备日志最长保留时长为15天,超期自动清除。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public DescribeLogsResponse DescribeLogsSync(DescribeLogsRequest req)
        {
            return InternalRequestAsync<DescribeLogsResponse>(req, "DescribeLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMessageQueue）用于查询物联网智能视频产品转发消息配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageQueueRequest"/></param>
        /// <returns><see cref="DescribeMessageQueueResponse"/></returns>
        public Task<DescribeMessageQueueResponse> DescribeMessageQueue(DescribeMessageQueueRequest req)
        {
            return InternalRequestAsync<DescribeMessageQueueResponse>(req, "DescribeMessageQueue");
        }

        /// <summary>
        /// 本接口（DescribeMessageQueue）用于查询物联网智能视频产品转发消息配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageQueueRequest"/></param>
        /// <returns><see cref="DescribeMessageQueueResponse"/></returns>
        public DescribeMessageQueueResponse DescribeMessageQueueSync(DescribeMessageQueueRequest req)
        {
            return InternalRequestAsync<DescribeMessageQueueResponse>(req, "DescribeMessageQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeModelDataRet）用于根据TaskId获取对设备物模型操作最终响应的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDataRetRequest"/></param>
        /// <returns><see cref="DescribeModelDataRetResponse"/></returns>
        public Task<DescribeModelDataRetResponse> DescribeModelDataRet(DescribeModelDataRetRequest req)
        {
            return InternalRequestAsync<DescribeModelDataRetResponse>(req, "DescribeModelDataRet");
        }

        /// <summary>
        /// 本接口（DescribeModelDataRet）用于根据TaskId获取对设备物模型操作最终响应的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDataRetRequest"/></param>
        /// <returns><see cref="DescribeModelDataRetResponse"/></returns>
        public DescribeModelDataRetResponse DescribeModelDataRetSync(DescribeModelDataRetRequest req)
        {
            return InternalRequestAsync<DescribeModelDataRetResponse>(req, "DescribeModelDataRet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看操作系统支持的芯片列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOsListRequest"/></param>
        /// <returns><see cref="DescribeOsListResponse"/></returns>
        public Task<DescribeOsListResponse> DescribeOsList(DescribeOsListRequest req)
        {
            return InternalRequestAsync<DescribeOsListResponse>(req, "DescribeOsList");
        }

        /// <summary>
        /// 查看操作系统支持的芯片列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOsListRequest"/></param>
        /// <returns><see cref="DescribeOsListResponse"/></returns>
        public DescribeOsListResponse DescribeOsListSync(DescribeOsListRequest req)
        {
            return InternalRequestAsync<DescribeOsListResponse>(req, "DescribeOsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeOtaVersions）用于查询固件版本信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOtaVersionsRequest"/></param>
        /// <returns><see cref="DescribeOtaVersionsResponse"/></returns>
        public Task<DescribeOtaVersionsResponse> DescribeOtaVersions(DescribeOtaVersionsRequest req)
        {
            return InternalRequestAsync<DescribeOtaVersionsResponse>(req, "DescribeOtaVersions");
        }

        /// <summary>
        /// 本接口（DescribeOtaVersions）用于查询固件版本信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOtaVersionsRequest"/></param>
        /// <returns><see cref="DescribeOtaVersionsResponse"/></returns>
        public DescribeOtaVersionsResponse DescribeOtaVersionsSync(DescribeOtaVersionsRequest req)
        {
            return InternalRequestAsync<DescribeOtaVersionsResponse>(req, "DescribeOtaVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProduct）用于获取单个产品的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public Task<DescribeProductResponse> DescribeProduct(DescribeProductRequest req)
        {
            return InternalRequestAsync<DescribeProductResponse>(req, "DescribeProduct");
        }

        /// <summary>
        /// 本接口（DescribeProduct）用于获取单个产品的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public DescribeProductResponse DescribeProductSync(DescribeProductRequest req)
        {
            return InternalRequestAsync<DescribeProductResponse>(req, "DescribeProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProducts）用于列出用户账号下的物联网智能视频产品列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public Task<DescribeProductsResponse> DescribeProducts(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts");
        }

        /// <summary>
        /// 本接口（DescribeProducts）用于列出用户账号下的物联网智能视频产品列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public DescribeProductsResponse DescribeProductsSync(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePubVersions）用于获取某一产品发布过的全部固件版本。
        /// </summary>
        /// <param name="req"><see cref="DescribePubVersionsRequest"/></param>
        /// <returns><see cref="DescribePubVersionsResponse"/></returns>
        public Task<DescribePubVersionsResponse> DescribePubVersions(DescribePubVersionsRequest req)
        {
            return InternalRequestAsync<DescribePubVersionsResponse>(req, "DescribePubVersions");
        }

        /// <summary>
        /// 本接口（DescribePubVersions）用于获取某一产品发布过的全部固件版本。
        /// </summary>
        /// <param name="req"><see cref="DescribePubVersionsRequest"/></param>
        /// <returns><see cref="DescribePubVersionsResponse"/></returns>
        public DescribePubVersionsResponse DescribePubVersionsSync(DescribePubVersionsRequest req)
        {
            return InternalRequestAsync<DescribePubVersionsResponse>(req, "DescribePubVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 客户可通过本接口获取充值记录信息, 一次最多返回50条记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeRechargeRecordsRequest"/></param>
        /// <returns><see cref="DescribeRechargeRecordsResponse"/></returns>
        public Task<DescribeRechargeRecordsResponse> DescribeRechargeRecords(DescribeRechargeRecordsRequest req)
        {
            return InternalRequestAsync<DescribeRechargeRecordsResponse>(req, "DescribeRechargeRecords");
        }

        /// <summary>
        /// 客户可通过本接口获取充值记录信息, 一次最多返回50条记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeRechargeRecordsRequest"/></param>
        /// <returns><see cref="DescribeRechargeRecordsResponse"/></returns>
        public DescribeRechargeRecordsResponse DescribeRechargeRecordsSync(DescribeRechargeRecordsRequest req)
        {
            return InternalRequestAsync<DescribeRechargeRecordsResponse>(req, "DescribeRechargeRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRegistrationStatus）用于查询终端用户的注册状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistrationStatusRequest"/></param>
        /// <returns><see cref="DescribeRegistrationStatusResponse"/></returns>
        public Task<DescribeRegistrationStatusResponse> DescribeRegistrationStatus(DescribeRegistrationStatusRequest req)
        {
            return InternalRequestAsync<DescribeRegistrationStatusResponse>(req, "DescribeRegistrationStatus");
        }

        /// <summary>
        /// 本接口（DescribeRegistrationStatus）用于查询终端用户的注册状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistrationStatusRequest"/></param>
        /// <returns><see cref="DescribeRegistrationStatusResponse"/></returns>
        public DescribeRegistrationStatusResponse DescribeRegistrationStatusSync(DescribeRegistrationStatusRequest req)
        {
            return InternalRequestAsync<DescribeRegistrationStatusResponse>(req, "DescribeRegistrationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRunLog）用于获取设备运行日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunLogRequest"/></param>
        /// <returns><see cref="DescribeRunLogResponse"/></returns>
        public Task<DescribeRunLogResponse> DescribeRunLog(DescribeRunLogRequest req)
        {
            return InternalRequestAsync<DescribeRunLogResponse>(req, "DescribeRunLog");
        }

        /// <summary>
        /// 本接口（DescribeRunLog）用于获取设备运行日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunLogRequest"/></param>
        /// <returns><see cref="DescribeRunLogResponse"/></returns>
        public DescribeRunLogResponse DescribeRunLogSync(DescribeRunLogRequest req)
        {
            return InternalRequestAsync<DescribeRunLogResponse>(req, "DescribeRunLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云存服务
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageServiceRequest"/></param>
        /// <returns><see cref="DescribeStorageServiceResponse"/></returns>
        public Task<DescribeStorageServiceResponse> DescribeStorageService(DescribeStorageServiceRequest req)
        {
            return InternalRequestAsync<DescribeStorageServiceResponse>(req, "DescribeStorageService");
        }

        /// <summary>
        /// 查询云存服务
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageServiceRequest"/></param>
        /// <returns><see cref="DescribeStorageServiceResponse"/></returns>
        public DescribeStorageServiceResponse DescribeStorageServiceSync(DescribeStorageServiceRequest req)
        {
            return InternalRequestAsync<DescribeStorageServiceResponse>(req, "DescribeStorageService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 请求设备直播流地址
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamRequest"/></param>
        /// <returns><see cref="DescribeStreamResponse"/></returns>
        public Task<DescribeStreamResponse> DescribeStream(DescribeStreamRequest req)
        {
            return InternalRequestAsync<DescribeStreamResponse>(req, "DescribeStream");
        }

        /// <summary>
        /// 请求设备直播流地址
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamRequest"/></param>
        /// <returns><see cref="DescribeStreamResponse"/></returns>
        public DescribeStreamResponse DescribeStreamSync(DescribeStreamRequest req)
        {
            return InternalRequestAsync<DescribeStreamResponse>(req, "DescribeStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTraceIds）用于查询设备日志跟踪白名单。
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceIdsRequest"/></param>
        /// <returns><see cref="DescribeTraceIdsResponse"/></returns>
        public Task<DescribeTraceIdsResponse> DescribeTraceIds(DescribeTraceIdsRequest req)
        {
            return InternalRequestAsync<DescribeTraceIdsResponse>(req, "DescribeTraceIds");
        }

        /// <summary>
        /// 本接口（DescribeTraceIds）用于查询设备日志跟踪白名单。
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceIdsRequest"/></param>
        /// <returns><see cref="DescribeTraceIdsResponse"/></returns>
        public DescribeTraceIdsResponse DescribeTraceIdsSync(DescribeTraceIdsRequest req)
        {
            return InternalRequestAsync<DescribeTraceIdsResponse>(req, "DescribeTraceIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTraceStatus）用于查询指定设备是否在白名单中。
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceStatusRequest"/></param>
        /// <returns><see cref="DescribeTraceStatusResponse"/></returns>
        public Task<DescribeTraceStatusResponse> DescribeTraceStatus(DescribeTraceStatusRequest req)
        {
            return InternalRequestAsync<DescribeTraceStatusResponse>(req, "DescribeTraceStatus");
        }

        /// <summary>
        /// 本接口（DescribeTraceStatus）用于查询指定设备是否在白名单中。
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceStatusRequest"/></param>
        /// <returns><see cref="DescribeTraceStatusResponse"/></returns>
        public DescribeTraceStatusResponse DescribeTraceStatusSync(DescribeTraceStatusRequest req)
        {
            return InternalRequestAsync<DescribeTraceStatusResponse>(req, "DescribeTraceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableDevice）用于禁用设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DisableDeviceRequest"/></param>
        /// <returns><see cref="DisableDeviceResponse"/></returns>
        public Task<DisableDeviceResponse> DisableDevice(DisableDeviceRequest req)
        {
            return InternalRequestAsync<DisableDeviceResponse>(req, "DisableDevice");
        }

        /// <summary>
        /// 本接口（DisableDevice）用于禁用设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DisableDeviceRequest"/></param>
        /// <returns><see cref="DisableDeviceResponse"/></returns>
        public DisableDeviceResponse DisableDeviceSync(DisableDeviceRequest req)
        {
            return InternalRequestAsync<DisableDeviceResponse>(req, "DisableDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableDeviceStream）用于停止设备推流，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DisableDeviceStreamRequest"/></param>
        /// <returns><see cref="DisableDeviceStreamResponse"/></returns>
        public Task<DisableDeviceStreamResponse> DisableDeviceStream(DisableDeviceStreamRequest req)
        {
            return InternalRequestAsync<DisableDeviceStreamResponse>(req, "DisableDeviceStream");
        }

        /// <summary>
        /// 本接口（DisableDeviceStream）用于停止设备推流，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="DisableDeviceStreamRequest"/></param>
        /// <returns><see cref="DisableDeviceStreamResponse"/></returns>
        public DisableDeviceStreamResponse DisableDeviceStreamSync(DisableDeviceStreamRequest req)
        {
            return InternalRequestAsync<DisableDeviceStreamResponse>(req, "DisableDeviceStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableOtaVersion）用于禁用固件版本。
        /// </summary>
        /// <param name="req"><see cref="DisableOtaVersionRequest"/></param>
        /// <returns><see cref="DisableOtaVersionResponse"/></returns>
        public Task<DisableOtaVersionResponse> DisableOtaVersion(DisableOtaVersionRequest req)
        {
            return InternalRequestAsync<DisableOtaVersionResponse>(req, "DisableOtaVersion");
        }

        /// <summary>
        /// 本接口（DisableOtaVersion）用于禁用固件版本。
        /// </summary>
        /// <param name="req"><see cref="DisableOtaVersionRequest"/></param>
        /// <returns><see cref="DisableOtaVersionResponse"/></returns>
        public DisableOtaVersionResponse DisableOtaVersionSync(DisableOtaVersionRequest req)
        {
            return InternalRequestAsync<DisableOtaVersionResponse>(req, "DisableOtaVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public Task<ModifyDeviceResponse> ModifyDevice(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice");
        }

        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public ModifyDeviceResponse ModifyDeviceSync(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<ModifyDeviceActionResponse> ModifyDeviceAction(ModifyDeviceActionRequest req)
        {
            return InternalRequestAsync<ModifyDeviceActionResponse>(req, "ModifyDeviceAction");
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
            return InternalRequestAsync<ModifyDeviceActionResponse>(req, "ModifyDeviceAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<ModifyDevicePropertyResponse> ModifyDeviceProperty(ModifyDevicePropertyRequest req)
        {
            return InternalRequestAsync<ModifyDevicePropertyResponse>(req, "ModifyDeviceProperty");
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
            return InternalRequestAsync<ModifyDevicePropertyResponse>(req, "ModifyDeviceProperty")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyProduct）用于编辑物联网智能视频产品的相关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest req)
        {
            return InternalRequestAsync<ModifyProductResponse>(req, "ModifyProduct");
        }

        /// <summary>
        /// 本接口（ModifyProduct）用于编辑物联网智能视频产品的相关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public ModifyProductResponse ModifyProductSync(ModifyProductRequest req)
        {
            return InternalRequestAsync<ModifyProductResponse>(req, "ModifyProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑版本描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyVerContentRequest"/></param>
        /// <returns><see cref="ModifyVerContentResponse"/></returns>
        public Task<ModifyVerContentResponse> ModifyVerContent(ModifyVerContentRequest req)
        {
            return InternalRequestAsync<ModifyVerContentResponse>(req, "ModifyVerContent");
        }

        /// <summary>
        /// 编辑版本描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyVerContentRequest"/></param>
        /// <returns><see cref="ModifyVerContentResponse"/></returns>
        public ModifyVerContentResponse ModifyVerContentSync(ModifyVerContentRequest req)
        {
            return InternalRequestAsync<ModifyVerContentResponse>(req, "ModifyVerContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<RefundStorageServiceResponse> RefundStorageService(RefundStorageServiceRequest req)
        {
            return InternalRequestAsync<RefundStorageServiceResponse>(req, "RefundStorageService");
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
            return InternalRequestAsync<RefundStorageServiceResponse>(req, "RefundStorageService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RunDevice）用于启用设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="RunDeviceRequest"/></param>
        /// <returns><see cref="RunDeviceResponse"/></returns>
        public Task<RunDeviceResponse> RunDevice(RunDeviceRequest req)
        {
            return InternalRequestAsync<RunDeviceResponse>(req, "RunDevice");
        }

        /// <summary>
        /// 本接口（RunDevice）用于启用设备，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="RunDeviceRequest"/></param>
        /// <returns><see cref="RunDeviceResponse"/></returns>
        public RunDeviceResponse RunDeviceSync(RunDeviceRequest req)
        {
            return InternalRequestAsync<RunDeviceResponse>(req, "RunDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RunDeviceStream）用于开启设备推流，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="RunDeviceStreamRequest"/></param>
        /// <returns><see cref="RunDeviceStreamResponse"/></returns>
        public Task<RunDeviceStreamResponse> RunDeviceStream(RunDeviceStreamRequest req)
        {
            return InternalRequestAsync<RunDeviceStreamResponse>(req, "RunDeviceStream");
        }

        /// <summary>
        /// 本接口（RunDeviceStream）用于开启设备推流，可进行批量操作，每次操作最多100台设备。
        /// </summary>
        /// <param name="req"><see cref="RunDeviceStreamRequest"/></param>
        /// <returns><see cref="RunDeviceStreamResponse"/></returns>
        public RunDeviceStreamResponse RunDeviceStreamSync(RunDeviceStreamRequest req)
        {
            return InternalRequestAsync<RunDeviceStreamResponse>(req, "RunDeviceStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RunIotModel）用于对定义的物模型进行发布。
        /// </summary>
        /// <param name="req"><see cref="RunIotModelRequest"/></param>
        /// <returns><see cref="RunIotModelResponse"/></returns>
        public Task<RunIotModelResponse> RunIotModel(RunIotModelRequest req)
        {
            return InternalRequestAsync<RunIotModelResponse>(req, "RunIotModel");
        }

        /// <summary>
        /// 本接口（RunIotModel）用于对定义的物模型进行发布。
        /// </summary>
        /// <param name="req"><see cref="RunIotModelRequest"/></param>
        /// <returns><see cref="RunIotModelResponse"/></returns>
        public RunIotModelResponse RunIotModelSync(RunIotModelRequest req)
        {
            return InternalRequestAsync<RunIotModelResponse>(req, "RunIotModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RunOtaVersion）用于固件版本正式发布。
        /// </summary>
        /// <param name="req"><see cref="RunOtaVersionRequest"/></param>
        /// <returns><see cref="RunOtaVersionResponse"/></returns>
        public Task<RunOtaVersionResponse> RunOtaVersion(RunOtaVersionRequest req)
        {
            return InternalRequestAsync<RunOtaVersionResponse>(req, "RunOtaVersion");
        }

        /// <summary>
        /// 本接口（RunOtaVersion）用于固件版本正式发布。
        /// </summary>
        /// <param name="req"><see cref="RunOtaVersionRequest"/></param>
        /// <returns><see cref="RunOtaVersionResponse"/></returns>
        public RunOtaVersionResponse RunOtaVersionSync(RunOtaVersionRequest req)
        {
            return InternalRequestAsync<RunOtaVersionResponse>(req, "RunOtaVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RunTestOtaVersion）用于固件版本测试发布。
        /// </summary>
        /// <param name="req"><see cref="RunTestOtaVersionRequest"/></param>
        /// <returns><see cref="RunTestOtaVersionResponse"/></returns>
        public Task<RunTestOtaVersionResponse> RunTestOtaVersion(RunTestOtaVersionRequest req)
        {
            return InternalRequestAsync<RunTestOtaVersionResponse>(req, "RunTestOtaVersion");
        }

        /// <summary>
        /// 本接口（RunTestOtaVersion）用于固件版本测试发布。
        /// </summary>
        /// <param name="req"><see cref="RunTestOtaVersionRequest"/></param>
        /// <returns><see cref="RunTestOtaVersionResponse"/></returns>
        public RunTestOtaVersionResponse RunTestOtaVersionSync(RunTestOtaVersionRequest req)
        {
            return InternalRequestAsync<RunTestOtaVersionResponse>(req, "RunTestOtaVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SendOnlineMsg）用于向设备发送在线消息。
        /// 注意：
        /// 若设备当前不在线,会直接返回错误;
        /// 若设备网络出现异常时,消息发送可能超时,超时等待最长时间为3秒.waitresp非0情况下,会导致本接口阻塞3秒。
        /// </summary>
        /// <param name="req"><see cref="SendOnlineMsgRequest"/></param>
        /// <returns><see cref="SendOnlineMsgResponse"/></returns>
        public Task<SendOnlineMsgResponse> SendOnlineMsg(SendOnlineMsgRequest req)
        {
            return InternalRequestAsync<SendOnlineMsgResponse>(req, "SendOnlineMsg");
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
            return InternalRequestAsync<SendOnlineMsgResponse>(req, "SendOnlineMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetMessageQueue）用于配置物联网智能视频产品的转发消息队列。
        /// </summary>
        /// <param name="req"><see cref="SetMessageQueueRequest"/></param>
        /// <returns><see cref="SetMessageQueueResponse"/></returns>
        public Task<SetMessageQueueResponse> SetMessageQueue(SetMessageQueueRequest req)
        {
            return InternalRequestAsync<SetMessageQueueResponse>(req, "SetMessageQueue");
        }

        /// <summary>
        /// 本接口（SetMessageQueue）用于配置物联网智能视频产品的转发消息队列。
        /// </summary>
        /// <param name="req"><see cref="SetMessageQueueRequest"/></param>
        /// <returns><see cref="SetMessageQueueResponse"/></returns>
        public SetMessageQueueResponse SetMessageQueueSync(SetMessageQueueRequest req)
        {
            return InternalRequestAsync<SetMessageQueueResponse>(req, "SetMessageQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeDevice）用于对设备进行固件升级。
        /// 该接口向指定的设备下发固件更新指令,可将固件升级到任意版本(可实现固件降级)。
        /// 警告:使能UpgradeNow参数存在一定的风险性！建议仅在debug场景下使用!
        /// </summary>
        /// <param name="req"><see cref="UpgradeDeviceRequest"/></param>
        /// <returns><see cref="UpgradeDeviceResponse"/></returns>
        public Task<UpgradeDeviceResponse> UpgradeDevice(UpgradeDeviceRequest req)
        {
            return InternalRequestAsync<UpgradeDeviceResponse>(req, "UpgradeDevice");
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
            return InternalRequestAsync<UpgradeDeviceResponse>(req, "UpgradeDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UploadOtaVersion）接收上传到控制台的固件版本信息。
        /// </summary>
        /// <param name="req"><see cref="UploadOtaVersionRequest"/></param>
        /// <returns><see cref="UploadOtaVersionResponse"/></returns>
        public Task<UploadOtaVersionResponse> UploadOtaVersion(UploadOtaVersionRequest req)
        {
            return InternalRequestAsync<UploadOtaVersionResponse>(req, "UploadOtaVersion");
        }

        /// <summary>
        /// 本接口（UploadOtaVersion）接收上传到控制台的固件版本信息。
        /// </summary>
        /// <param name="req"><see cref="UploadOtaVersionRequest"/></param>
        /// <returns><see cref="UploadOtaVersionResponse"/></returns>
        public UploadOtaVersionResponse UploadOtaVersionSync(UploadOtaVersionRequest req)
        {
            return InternalRequestAsync<UploadOtaVersionResponse>(req, "UploadOtaVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
