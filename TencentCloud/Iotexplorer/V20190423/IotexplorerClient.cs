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

namespace TencentCloud.Iotexplorer.V20190423
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotexplorer.V20190423.Models;

   public class IotexplorerClient : AbstractClient{

       private const string endpoint = "iotexplorer.tencentcloudapi.com";
       private const string version = "2019-04-23";
       private const string sdkVersion = "SDK_NET_3.0.1267";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotexplorerClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotexplorerClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 激活
        /// </summary>
        /// <param name="req"><see cref="ActivateTWeCallLicenseRequest"/></param>
        /// <returns><see cref="ActivateTWeCallLicenseResponse"/></returns>
        public Task<ActivateTWeCallLicenseResponse> ActivateTWeCallLicense(ActivateTWeCallLicenseRequest req)
        {
            return InternalRequestAsync<ActivateTWeCallLicenseResponse>(req, "ActivateTWeCallLicense");
        }

        /// <summary>
        /// 激活
        /// </summary>
        /// <param name="req"><see cref="ActivateTWeCallLicenseRequest"/></param>
        /// <returns><see cref="ActivateTWeCallLicenseResponse"/></returns>
        public ActivateTWeCallLicenseResponse ActivateTWeCallLicenseSync(ActivateTWeCallLicenseRequest req)
        {
            return InternalRequestAsync<ActivateTWeCallLicenseResponse>(req, "ActivateTWeCallLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定云存用户
        /// </summary>
        /// <param name="req"><see cref="BindCloudStorageUserRequest"/></param>
        /// <returns><see cref="BindCloudStorageUserResponse"/></returns>
        public Task<BindCloudStorageUserResponse> BindCloudStorageUser(BindCloudStorageUserRequest req)
        {
            return InternalRequestAsync<BindCloudStorageUserResponse>(req, "BindCloudStorageUser");
        }

        /// <summary>
        /// 绑定云存用户
        /// </summary>
        /// <param name="req"><see cref="BindCloudStorageUserRequest"/></param>
        /// <returns><see cref="BindCloudStorageUserResponse"/></returns>
        public BindCloudStorageUserResponse BindCloudStorageUserSync(BindCloudStorageUserRequest req)
        {
            return InternalRequestAsync<BindCloudStorageUserResponse>(req, "BindCloudStorageUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量绑定子设备
        /// </summary>
        /// <param name="req"><see cref="BindDevicesRequest"/></param>
        /// <returns><see cref="BindDevicesResponse"/></returns>
        public Task<BindDevicesResponse> BindDevices(BindDevicesRequest req)
        {
            return InternalRequestAsync<BindDevicesResponse>(req, "BindDevices");
        }

        /// <summary>
        /// 批量绑定子设备
        /// </summary>
        /// <param name="req"><see cref="BindDevicesRequest"/></param>
        /// <returns><see cref="BindDevicesResponse"/></returns>
        public BindDevicesResponse BindDevicesSync(BindDevicesRequest req)
        {
            return InternalRequestAsync<BindDevicesResponse>(req, "BindDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量绑定子产品。
        /// </summary>
        /// <param name="req"><see cref="BindProductsRequest"/></param>
        /// <returns><see cref="BindProductsResponse"/></returns>
        public Task<BindProductsResponse> BindProducts(BindProductsRequest req)
        {
            return InternalRequestAsync<BindProductsResponse>(req, "BindProducts");
        }

        /// <summary>
        /// 批量绑定子产品。
        /// </summary>
        /// <param name="req"><see cref="BindProductsRequest"/></param>
        /// <returns><see cref="BindProductsResponse"/></returns>
        public BindProductsResponse BindProductsSync(BindProductsRequest req)
        {
            return InternalRequestAsync<BindProductsResponse>(req, "BindProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供给用户异步调用设备行为的能力
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionAsyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionAsyncResponse"/></returns>
        public Task<CallDeviceActionAsyncResponse> CallDeviceActionAsync(CallDeviceActionAsyncRequest req)
        {
            return InternalRequestAsync<CallDeviceActionAsyncResponse>(req, "CallDeviceActionAsync");
        }

        /// <summary>
        /// 提供给用户异步调用设备行为的能力
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionAsyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionAsyncResponse"/></returns>
        public CallDeviceActionAsyncResponse CallDeviceActionAsyncSync(CallDeviceActionAsyncRequest req)
        {
            return InternalRequestAsync<CallDeviceActionAsyncResponse>(req, "CallDeviceActionAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为用户提供同步调用设备行为的能力。
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionSyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionSyncResponse"/></returns>
        public Task<CallDeviceActionSyncResponse> CallDeviceActionSync(CallDeviceActionSyncRequest req)
        {
            return InternalRequestAsync<CallDeviceActionSyncResponse>(req, "CallDeviceActionSync");
        }

        /// <summary>
        /// 为用户提供同步调用设备行为的能力。
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionSyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionSyncResponse"/></returns>
        public CallDeviceActionSyncResponse CallDeviceActionSyncSync(CallDeviceActionSyncRequest req)
        {
            return InternalRequestAsync<CallDeviceActionSyncResponse>(req, "CallDeviceActionSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消分配
        /// </summary>
        /// <param name="req"><see cref="CancelAssignTWeCallLicenseRequest"/></param>
        /// <returns><see cref="CancelAssignTWeCallLicenseResponse"/></returns>
        public Task<CancelAssignTWeCallLicenseResponse> CancelAssignTWeCallLicense(CancelAssignTWeCallLicenseRequest req)
        {
            return InternalRequestAsync<CancelAssignTWeCallLicenseResponse>(req, "CancelAssignTWeCallLicense");
        }

        /// <summary>
        /// 取消分配
        /// </summary>
        /// <param name="req"><see cref="CancelAssignTWeCallLicenseRequest"/></param>
        /// <returns><see cref="CancelAssignTWeCallLicenseResponse"/></returns>
        public CancelAssignTWeCallLicenseResponse CancelAssignTWeCallLicenseSync(CancelAssignTWeCallLicenseRequest req)
        {
            return InternalRequestAsync<CancelAssignTWeCallLicenseResponse>(req, "CancelAssignTWeCallLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// p2p路线切换（此接口目前处于内测接口，可以联系申请加白 ）
        /// </summary>
        /// <param name="req"><see cref="ChangeP2PRouteRequest"/></param>
        /// <returns><see cref="ChangeP2PRouteResponse"/></returns>
        public Task<ChangeP2PRouteResponse> ChangeP2PRoute(ChangeP2PRouteRequest req)
        {
            return InternalRequestAsync<ChangeP2PRouteResponse>(req, "ChangeP2PRoute");
        }

        /// <summary>
        /// p2p路线切换（此接口目前处于内测接口，可以联系申请加白 ）
        /// </summary>
        /// <param name="req"><see cref="ChangeP2PRouteRequest"/></param>
        /// <returns><see cref="ChangeP2PRouteResponse"/></returns>
        public ChangeP2PRouteResponse ChangeP2PRouteSync(ChangeP2PRouteRequest req)
        {
            return InternalRequestAsync<ChangeP2PRouteResponse>(req, "ChangeP2PRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CheckFirmwareUpdate）用于查询设备可升级固件版本
        /// </summary>
        /// <param name="req"><see cref="CheckFirmwareUpdateRequest"/></param>
        /// <returns><see cref="CheckFirmwareUpdateResponse"/></returns>
        public Task<CheckFirmwareUpdateResponse> CheckFirmwareUpdate(CheckFirmwareUpdateRequest req)
        {
            return InternalRequestAsync<CheckFirmwareUpdateResponse>(req, "CheckFirmwareUpdate");
        }

        /// <summary>
        /// 本接口（CheckFirmwareUpdate）用于查询设备可升级固件版本
        /// </summary>
        /// <param name="req"><see cref="CheckFirmwareUpdateRequest"/></param>
        /// <returns><see cref="CheckFirmwareUpdateResponse"/></returns>
        public CheckFirmwareUpdateResponse CheckFirmwareUpdateSync(CheckFirmwareUpdateRequest req)
        {
            return InternalRequestAsync<CheckFirmwareUpdateResponse>(req, "CheckFirmwareUpdate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，设置控制设备的属性数据。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceDataRequest"/></param>
        /// <returns><see cref="ControlDeviceDataResponse"/></returns>
        public Task<ControlDeviceDataResponse> ControlDeviceData(ControlDeviceDataRequest req)
        {
            return InternalRequestAsync<ControlDeviceDataResponse>(req, "ControlDeviceData");
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，设置控制设备的属性数据。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceDataRequest"/></param>
        /// <returns><see cref="ControlDeviceDataResponse"/></returns>
        public ControlDeviceDataResponse ControlDeviceDataSync(ControlDeviceDataRequest req)
        {
            return InternalRequestAsync<ControlDeviceDataResponse>(req, "ControlDeviceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建视频语义异步搜索任务
        /// </summary>
        /// <param name="req"><see cref="CreateAISearchTaskAsyncRequest"/></param>
        /// <returns><see cref="CreateAISearchTaskAsyncResponse"/></returns>
        public Task<CreateAISearchTaskAsyncResponse> CreateAISearchTaskAsync(CreateAISearchTaskAsyncRequest req)
        {
            return InternalRequestAsync<CreateAISearchTaskAsyncResponse>(req, "CreateAISearchTaskAsync");
        }

        /// <summary>
        /// 创建视频语义异步搜索任务
        /// </summary>
        /// <param name="req"><see cref="CreateAISearchTaskAsyncRequest"/></param>
        /// <returns><see cref="CreateAISearchTaskAsyncResponse"/></returns>
        public CreateAISearchTaskAsyncResponse CreateAISearchTaskAsyncSync(CreateAISearchTaskAsyncRequest req)
        {
            return InternalRequestAsync<CreateAISearchTaskAsyncResponse>(req, "CreateAISearchTaskAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于新建批量生产设备
        /// </summary>
        /// <param name="req"><see cref="CreateBatchProductionRequest"/></param>
        /// <returns><see cref="CreateBatchProductionResponse"/></returns>
        public Task<CreateBatchProductionResponse> CreateBatchProduction(CreateBatchProductionRequest req)
        {
            return InternalRequestAsync<CreateBatchProductionResponse>(req, "CreateBatchProduction");
        }

        /// <summary>
        /// 用于新建批量生产设备
        /// </summary>
        /// <param name="req"><see cref="CreateBatchProductionRequest"/></param>
        /// <returns><see cref="CreateBatchProductionResponse"/></returns>
        public CreateBatchProductionResponse CreateBatchProductionSync(CreateBatchProductionRequest req)
        {
            return InternalRequestAsync<CreateBatchProductionResponse>(req, "CreateBatchProduction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通设备云存AI分析服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="CreateCloudStorageAIServiceResponse"/></returns>
        public Task<CreateCloudStorageAIServiceResponse> CreateCloudStorageAIService(CreateCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudStorageAIServiceResponse>(req, "CreateCloudStorageAIService");
        }

        /// <summary>
        /// 开通设备云存AI分析服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="CreateCloudStorageAIServiceResponse"/></returns>
        public CreateCloudStorageAIServiceResponse CreateCloudStorageAIServiceSync(CreateCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudStorageAIServiceResponse>(req, "CreateCloudStorageAIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备云存 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudStorageAIServiceTaskRequest"/></param>
        /// <returns><see cref="CreateCloudStorageAIServiceTaskResponse"/></returns>
        public Task<CreateCloudStorageAIServiceTaskResponse> CreateCloudStorageAIServiceTask(CreateCloudStorageAIServiceTaskRequest req)
        {
            return InternalRequestAsync<CreateCloudStorageAIServiceTaskResponse>(req, "CreateCloudStorageAIServiceTask");
        }

        /// <summary>
        /// 创建设备云存 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudStorageAIServiceTaskRequest"/></param>
        /// <returns><see cref="CreateCloudStorageAIServiceTaskResponse"/></returns>
        public CreateCloudStorageAIServiceTaskResponse CreateCloudStorageAIServiceTaskSync(CreateCloudStorageAIServiceTaskRequest req)
        {
            return InternalRequestAsync<CreateCloudStorageAIServiceTaskResponse>(req, "CreateCloudStorageAIServiceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice");
        }

        /// <summary>
        /// 创建设备
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备通道
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceChannelRequest"/></param>
        /// <returns><see cref="CreateDeviceChannelResponse"/></returns>
        public Task<CreateDeviceChannelResponse> CreateDeviceChannel(CreateDeviceChannelRequest req)
        {
            return InternalRequestAsync<CreateDeviceChannelResponse>(req, "CreateDeviceChannel");
        }

        /// <summary>
        /// 创建设备通道
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceChannelRequest"/></param>
        /// <returns><see cref="CreateDeviceChannelResponse"/></returns>
        public CreateDeviceChannelResponse CreateDeviceChannelSync(CreateDeviceChannelRequest req)
        {
            return InternalRequestAsync<CreateDeviceChannelResponse>(req, "CreateDeviceChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建外部视频 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateExternalSourceAIServiceTaskRequest"/></param>
        /// <returns><see cref="CreateExternalSourceAIServiceTaskResponse"/></returns>
        public Task<CreateExternalSourceAIServiceTaskResponse> CreateExternalSourceAIServiceTask(CreateExternalSourceAIServiceTaskRequest req)
        {
            return InternalRequestAsync<CreateExternalSourceAIServiceTaskResponse>(req, "CreateExternalSourceAIServiceTask");
        }

        /// <summary>
        /// 创建外部视频 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateExternalSourceAIServiceTaskRequest"/></param>
        /// <returns><see cref="CreateExternalSourceAIServiceTaskResponse"/></returns>
        public CreateExternalSourceAIServiceTaskResponse CreateExternalSourceAIServiceTaskSync(CreateExternalSourceAIServiceTaskRequest req)
        {
            return InternalRequestAsync<CreateExternalSourceAIServiceTaskResponse>(req, "CreateExternalSourceAIServiceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// > 创建围栏绑定信息。
        /// </summary>
        /// <param name="req"><see cref="CreateFenceBindRequest"/></param>
        /// <returns><see cref="CreateFenceBindResponse"/></returns>
        public Task<CreateFenceBindResponse> CreateFenceBind(CreateFenceBindRequest req)
        {
            return InternalRequestAsync<CreateFenceBindResponse>(req, "CreateFenceBind");
        }

        /// <summary>
        /// > 创建围栏绑定信息。
        /// </summary>
        /// <param name="req"><see cref="CreateFenceBindRequest"/></param>
        /// <returns><see cref="CreateFenceBindResponse"/></returns>
        public CreateFenceBindResponse CreateFenceBindSync(CreateFenceBindRequest req)
        {
            return InternalRequestAsync<CreateFenceBindResponse>(req, "CreateFenceBind")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通免费云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateFreeCloudStorageRequest"/></param>
        /// <returns><see cref="CreateFreeCloudStorageResponse"/></returns>
        public Task<CreateFreeCloudStorageResponse> CreateFreeCloudStorage(CreateFreeCloudStorageRequest req)
        {
            return InternalRequestAsync<CreateFreeCloudStorageResponse>(req, "CreateFreeCloudStorage");
        }

        /// <summary>
        /// 开通免费云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateFreeCloudStorageRequest"/></param>
        /// <returns><see cref="CreateFreeCloudStorageResponse"/></returns>
        public CreateFreeCloudStorageResponse CreateFreeCloudStorageSync(CreateFreeCloudStorageRequest req)
        {
            return InternalRequestAsync<CreateFreeCloudStorageResponse>(req, "CreateFreeCloudStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateIotVideoCloudStorageRequest"/></param>
        /// <returns><see cref="CreateIotVideoCloudStorageResponse"/></returns>
        public Task<CreateIotVideoCloudStorageResponse> CreateIotVideoCloudStorage(CreateIotVideoCloudStorageRequest req)
        {
            return InternalRequestAsync<CreateIotVideoCloudStorageResponse>(req, "CreateIotVideoCloudStorage");
        }

        /// <summary>
        /// 开通云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateIotVideoCloudStorageRequest"/></param>
        /// <returns><see cref="CreateIotVideoCloudStorageResponse"/></returns>
        public CreateIotVideoCloudStorageResponse CreateIotVideoCloudStorageSync(CreateIotVideoCloudStorageRequest req)
        {
            return InternalRequestAsync<CreateIotVideoCloudStorageResponse>(req, "CreateIotVideoCloudStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 LoRa 自定义频点
        /// </summary>
        /// <param name="req"><see cref="CreateLoRaFrequencyRequest"/></param>
        /// <returns><see cref="CreateLoRaFrequencyResponse"/></returns>
        public Task<CreateLoRaFrequencyResponse> CreateLoRaFrequency(CreateLoRaFrequencyRequest req)
        {
            return InternalRequestAsync<CreateLoRaFrequencyResponse>(req, "CreateLoRaFrequency");
        }

        /// <summary>
        /// 创建 LoRa 自定义频点
        /// </summary>
        /// <param name="req"><see cref="CreateLoRaFrequencyRequest"/></param>
        /// <returns><see cref="CreateLoRaFrequencyResponse"/></returns>
        public CreateLoRaFrequencyResponse CreateLoRaFrequencySync(CreateLoRaFrequencyRequest req)
        {
            return InternalRequestAsync<CreateLoRaFrequencyResponse>(req, "CreateLoRaFrequency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建新 LoRa 网关设备接口
        /// </summary>
        /// <param name="req"><see cref="CreateLoRaGatewayRequest"/></param>
        /// <returns><see cref="CreateLoRaGatewayResponse"/></returns>
        public Task<CreateLoRaGatewayResponse> CreateLoRaGateway(CreateLoRaGatewayRequest req)
        {
            return InternalRequestAsync<CreateLoRaGatewayResponse>(req, "CreateLoRaGateway");
        }

        /// <summary>
        /// 创建新 LoRa 网关设备接口
        /// </summary>
        /// <param name="req"><see cref="CreateLoRaGatewayRequest"/></param>
        /// <returns><see cref="CreateLoRaGatewayResponse"/></returns>
        public CreateLoRaGatewayResponse CreateLoRaGatewaySync(CreateLoRaGatewayRequest req)
        {
            return InternalRequestAsync<CreateLoRaGatewayResponse>(req, "CreateLoRaGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建围栏。
        /// </summary>
        /// <param name="req"><see cref="CreatePositionFenceRequest"/></param>
        /// <returns><see cref="CreatePositionFenceResponse"/></returns>
        public Task<CreatePositionFenceResponse> CreatePositionFence(CreatePositionFenceRequest req)
        {
            return InternalRequestAsync<CreatePositionFenceResponse>(req, "CreatePositionFence");
        }

        /// <summary>
        /// 创建围栏。
        /// </summary>
        /// <param name="req"><see cref="CreatePositionFenceRequest"/></param>
        /// <returns><see cref="CreatePositionFenceResponse"/></returns>
        public CreatePositionFenceResponse CreatePositionFenceSync(CreatePositionFenceRequest req)
        {
            return InternalRequestAsync<CreatePositionFenceResponse>(req, "CreatePositionFence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建位置空间。
        /// </summary>
        /// <param name="req"><see cref="CreatePositionSpaceRequest"/></param>
        /// <returns><see cref="CreatePositionSpaceResponse"/></returns>
        public Task<CreatePositionSpaceResponse> CreatePositionSpace(CreatePositionSpaceRequest req)
        {
            return InternalRequestAsync<CreatePositionSpaceResponse>(req, "CreatePositionSpace");
        }

        /// <summary>
        /// 创建位置空间。
        /// </summary>
        /// <param name="req"><see cref="CreatePositionSpaceRequest"/></param>
        /// <returns><see cref="CreatePositionSpaceResponse"/></returns>
        public CreatePositionSpaceResponse CreatePositionSpaceSync(CreatePositionSpaceRequest req)
        {
            return InternalRequestAsync<CreatePositionSpaceResponse>(req, "CreatePositionSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为用户提供新建项目的能力，用于集中管理产品和应用。
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// 为用户提供新建项目的能力，用于集中管理产品和应用。
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为用户提供新建产品的能力，用于管理用户的设备
        /// </summary>
        /// <param name="req"><see cref="CreateStudioProductRequest"/></param>
        /// <returns><see cref="CreateStudioProductResponse"/></returns>
        public Task<CreateStudioProductResponse> CreateStudioProduct(CreateStudioProductRequest req)
        {
            return InternalRequestAsync<CreateStudioProductResponse>(req, "CreateStudioProduct");
        }

        /// <summary>
        /// 为用户提供新建产品的能力，用于管理用户的设备
        /// </summary>
        /// <param name="req"><see cref="CreateStudioProductRequest"/></param>
        /// <returns><see cref="CreateStudioProductResponse"/></returns>
        public CreateStudioProductResponse CreateStudioProductSync(CreateStudioProductRequest req)
        {
            return InternalRequestAsync<CreateStudioProductResponse>(req, "CreateStudioProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建TRTC通话参数
        /// </summary>
        /// <param name="req"><see cref="CreateTRTCSignaturesWithRoomIdRequest"/></param>
        /// <returns><see cref="CreateTRTCSignaturesWithRoomIdResponse"/></returns>
        public Task<CreateTRTCSignaturesWithRoomIdResponse> CreateTRTCSignaturesWithRoomId(CreateTRTCSignaturesWithRoomIdRequest req)
        {
            return InternalRequestAsync<CreateTRTCSignaturesWithRoomIdResponse>(req, "CreateTRTCSignaturesWithRoomId");
        }

        /// <summary>
        /// 创建TRTC通话参数
        /// </summary>
        /// <param name="req"><see cref="CreateTRTCSignaturesWithRoomIdRequest"/></param>
        /// <returns><see cref="CreateTRTCSignaturesWithRoomIdResponse"/></returns>
        public CreateTRTCSignaturesWithRoomIdResponse CreateTRTCSignaturesWithRoomIdSync(CreateTRTCSignaturesWithRoomIdRequest req)
        {
            return InternalRequestAsync<CreateTRTCSignaturesWithRoomIdResponse>(req, "CreateTRTCSignaturesWithRoomId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 TWeSee 语义理解任务
        /// </summary>
        /// <param name="req"><see cref="CreateTWeSeeRecognitionTaskRequest"/></param>
        /// <returns><see cref="CreateTWeSeeRecognitionTaskResponse"/></returns>
        public Task<CreateTWeSeeRecognitionTaskResponse> CreateTWeSeeRecognitionTask(CreateTWeSeeRecognitionTaskRequest req)
        {
            return InternalRequestAsync<CreateTWeSeeRecognitionTaskResponse>(req, "CreateTWeSeeRecognitionTask");
        }

        /// <summary>
        /// 创建 TWeSee 语义理解任务
        /// </summary>
        /// <param name="req"><see cref="CreateTWeSeeRecognitionTaskRequest"/></param>
        /// <returns><see cref="CreateTWeSeeRecognitionTaskResponse"/></returns>
        public CreateTWeSeeRecognitionTaskResponse CreateTWeSeeRecognitionTaskSync(CreateTWeSeeRecognitionTaskRequest req)
        {
            return InternalRequestAsync<CreateTWeSeeRecognitionTaskResponse>(req, "CreateTWeSeeRecognitionTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateTopicPolicy）用于创建一个Topic
        /// </summary>
        /// <param name="req"><see cref="CreateTopicPolicyRequest"/></param>
        /// <returns><see cref="CreateTopicPolicyResponse"/></returns>
        public Task<CreateTopicPolicyResponse> CreateTopicPolicy(CreateTopicPolicyRequest req)
        {
            return InternalRequestAsync<CreateTopicPolicyResponse>(req, "CreateTopicPolicy");
        }

        /// <summary>
        /// 本接口（CreateTopicPolicy）用于创建一个Topic
        /// </summary>
        /// <param name="req"><see cref="CreateTopicPolicyRequest"/></param>
        /// <returns><see cref="CreateTopicPolicyResponse"/></returns>
        public CreateTopicPolicyResponse CreateTopicPolicySync(CreateTopicPolicyRequest req)
        {
            return InternalRequestAsync<CreateTopicPolicyResponse>(req, "CreateTopicPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRuleRequest"/></param>
        /// <returns><see cref="CreateTopicRuleResponse"/></returns>
        public Task<CreateTopicRuleResponse> CreateTopicRule(CreateTopicRuleRequest req)
        {
            return InternalRequestAsync<CreateTopicRuleResponse>(req, "CreateTopicRule");
        }

        /// <summary>
        /// 创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRuleRequest"/></param>
        /// <returns><see cref="CreateTopicRuleResponse"/></returns>
        public CreateTopicRuleResponse CreateTopicRuleSync(CreateTopicRuleRequest req)
        {
            return InternalRequestAsync<CreateTopicRuleResponse>(req, "CreateTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云存事件
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudStorageEventRequest"/></param>
        /// <returns><see cref="DeleteCloudStorageEventResponse"/></returns>
        public Task<DeleteCloudStorageEventResponse> DeleteCloudStorageEvent(DeleteCloudStorageEventRequest req)
        {
            return InternalRequestAsync<DeleteCloudStorageEventResponse>(req, "DeleteCloudStorageEvent");
        }

        /// <summary>
        /// 删除云存事件
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudStorageEventRequest"/></param>
        /// <returns><see cref="DeleteCloudStorageEventResponse"/></returns>
        public DeleteCloudStorageEventResponse DeleteCloudStorageEventSync(DeleteCloudStorageEventRequest req)
        {
            return InternalRequestAsync<DeleteCloudStorageEventResponse>(req, "DeleteCloudStorageEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice");
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDevicesRequest"/></param>
        /// <returns><see cref="DeleteDevicesResponse"/></returns>
        public Task<DeleteDevicesResponse> DeleteDevices(DeleteDevicesRequest req)
        {
            return InternalRequestAsync<DeleteDevicesResponse>(req, "DeleteDevices");
        }

        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDevicesRequest"/></param>
        /// <returns><see cref="DeleteDevicesResponse"/></returns>
        public DeleteDevicesResponse DeleteDevicesSync(DeleteDevicesRequest req)
        {
            return InternalRequestAsync<DeleteDevicesResponse>(req, "DeleteDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除围栏绑定信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteFenceBindRequest"/></param>
        /// <returns><see cref="DeleteFenceBindResponse"/></returns>
        public Task<DeleteFenceBindResponse> DeleteFenceBind(DeleteFenceBindRequest req)
        {
            return InternalRequestAsync<DeleteFenceBindResponse>(req, "DeleteFenceBind");
        }

        /// <summary>
        /// 删除围栏绑定信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteFenceBindRequest"/></param>
        /// <returns><see cref="DeleteFenceBindResponse"/></returns>
        public DeleteFenceBindResponse DeleteFenceBindSync(DeleteFenceBindRequest req)
        {
            return InternalRequestAsync<DeleteFenceBindResponse>(req, "DeleteFenceBind")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供删除LoRa自定义频点的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteLoRaFrequencyRequest"/></param>
        /// <returns><see cref="DeleteLoRaFrequencyResponse"/></returns>
        public Task<DeleteLoRaFrequencyResponse> DeleteLoRaFrequency(DeleteLoRaFrequencyRequest req)
        {
            return InternalRequestAsync<DeleteLoRaFrequencyResponse>(req, "DeleteLoRaFrequency");
        }

        /// <summary>
        /// 提供删除LoRa自定义频点的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteLoRaFrequencyRequest"/></param>
        /// <returns><see cref="DeleteLoRaFrequencyResponse"/></returns>
        public DeleteLoRaFrequencyResponse DeleteLoRaFrequencySync(DeleteLoRaFrequencyRequest req)
        {
            return InternalRequestAsync<DeleteLoRaFrequencyResponse>(req, "DeleteLoRaFrequency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除  LoRa 网关的接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLoRaGatewayRequest"/></param>
        /// <returns><see cref="DeleteLoRaGatewayResponse"/></returns>
        public Task<DeleteLoRaGatewayResponse> DeleteLoRaGateway(DeleteLoRaGatewayRequest req)
        {
            return InternalRequestAsync<DeleteLoRaGatewayResponse>(req, "DeleteLoRaGateway");
        }

        /// <summary>
        /// 删除  LoRa 网关的接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLoRaGatewayRequest"/></param>
        /// <returns><see cref="DeleteLoRaGatewayResponse"/></returns>
        public DeleteLoRaGatewayResponse DeleteLoRaGatewaySync(DeleteLoRaGatewayRequest req)
        {
            return InternalRequestAsync<DeleteLoRaGatewayResponse>(req, "DeleteLoRaGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除围栏。
        /// </summary>
        /// <param name="req"><see cref="DeletePositionFenceRequest"/></param>
        /// <returns><see cref="DeletePositionFenceResponse"/></returns>
        public Task<DeletePositionFenceResponse> DeletePositionFence(DeletePositionFenceRequest req)
        {
            return InternalRequestAsync<DeletePositionFenceResponse>(req, "DeletePositionFence");
        }

        /// <summary>
        /// 删除围栏。
        /// </summary>
        /// <param name="req"><see cref="DeletePositionFenceRequest"/></param>
        /// <returns><see cref="DeletePositionFenceResponse"/></returns>
        public DeletePositionFenceResponse DeletePositionFenceSync(DeletePositionFenceRequest req)
        {
            return InternalRequestAsync<DeletePositionFenceResponse>(req, "DeletePositionFence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除位置空间。
        /// </summary>
        /// <param name="req"><see cref="DeletePositionSpaceRequest"/></param>
        /// <returns><see cref="DeletePositionSpaceResponse"/></returns>
        public Task<DeletePositionSpaceResponse> DeletePositionSpace(DeletePositionSpaceRequest req)
        {
            return InternalRequestAsync<DeletePositionSpaceResponse>(req, "DeletePositionSpace");
        }

        /// <summary>
        /// 删除位置空间。
        /// </summary>
        /// <param name="req"><see cref="DeletePositionSpaceRequest"/></param>
        /// <returns><see cref="DeletePositionSpaceResponse"/></returns>
        public DeletePositionSpaceResponse DeletePositionSpaceSync(DeletePositionSpaceRequest req)
        {
            return InternalRequestAsync<DeletePositionSpaceResponse>(req, "DeletePositionSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供删除某个项目的能力。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// 提供删除某个项目的能力。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供删除某个项目下产品的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteStudioProductRequest"/></param>
        /// <returns><see cref="DeleteStudioProductResponse"/></returns>
        public Task<DeleteStudioProductResponse> DeleteStudioProduct(DeleteStudioProductRequest req)
        {
            return InternalRequestAsync<DeleteStudioProductResponse>(req, "DeleteStudioProduct");
        }

        /// <summary>
        /// 提供删除某个项目下产品的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteStudioProductRequest"/></param>
        /// <returns><see cref="DeleteStudioProductResponse"/></returns>
        public DeleteStudioProductResponse DeleteStudioProductSync(DeleteStudioProductRequest req)
        {
            return InternalRequestAsync<DeleteStudioProductResponse>(req, "DeleteStudioProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteTopicPolicy）用于删除Topic
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicPolicyRequest"/></param>
        /// <returns><see cref="DeleteTopicPolicyResponse"/></returns>
        public Task<DeleteTopicPolicyResponse> DeleteTopicPolicy(DeleteTopicPolicyRequest req)
        {
            return InternalRequestAsync<DeleteTopicPolicyResponse>(req, "DeleteTopicPolicy");
        }

        /// <summary>
        /// 本接口（DeleteTopicPolicy）用于删除Topic
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicPolicyRequest"/></param>
        /// <returns><see cref="DeleteTopicPolicyResponse"/></returns>
        public DeleteTopicPolicyResponse DeleteTopicPolicySync(DeleteTopicPolicyRequest req)
        {
            return InternalRequestAsync<DeleteTopicPolicyResponse>(req, "DeleteTopicPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRuleRequest"/></param>
        /// <returns><see cref="DeleteTopicRuleResponse"/></returns>
        public Task<DeleteTopicRuleResponse> DeleteTopicRule(DeleteTopicRuleRequest req)
        {
            return InternalRequestAsync<DeleteTopicRuleResponse>(req, "DeleteTopicRule");
        }

        /// <summary>
        /// 删除规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRuleRequest"/></param>
        /// <returns><see cref="DeleteTopicRuleResponse"/></returns>
        public DeleteTopicRuleResponse DeleteTopicRuleSync(DeleteTopicRuleRequest req)
        {
            return InternalRequestAsync<DeleteTopicRuleResponse>(req, "DeleteTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取视频语义异步搜索任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAISearchTaskAsyncRequest"/></param>
        /// <returns><see cref="DescribeAISearchTaskAsyncResponse"/></returns>
        public Task<DescribeAISearchTaskAsyncResponse> DescribeAISearchTaskAsync(DescribeAISearchTaskAsyncRequest req)
        {
            return InternalRequestAsync<DescribeAISearchTaskAsyncResponse>(req, "DescribeAISearchTaskAsync");
        }

        /// <summary>
        /// 获取视频语义异步搜索任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAISearchTaskAsyncRequest"/></param>
        /// <returns><see cref="DescribeAISearchTaskAsyncResponse"/></returns>
        public DescribeAISearchTaskAsyncResponse DescribeAISearchTaskAsyncSync(DescribeAISearchTaskAsyncRequest req)
        {
            return InternalRequestAsync<DescribeAISearchTaskAsyncResponse>(req, "DescribeAISearchTaskAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备激活详情
        /// </summary>
        /// <param name="req"><see cref="DescribeActivateDeviceRequest"/></param>
        /// <returns><see cref="DescribeActivateDeviceResponse"/></returns>
        public Task<DescribeActivateDeviceResponse> DescribeActivateDevice(DescribeActivateDeviceRequest req)
        {
            return InternalRequestAsync<DescribeActivateDeviceResponse>(req, "DescribeActivateDevice");
        }

        /// <summary>
        /// 获取设备激活详情
        /// </summary>
        /// <param name="req"><see cref="DescribeActivateDeviceRequest"/></param>
        /// <returns><see cref="DescribeActivateDeviceResponse"/></returns>
        public DescribeActivateDeviceResponse DescribeActivateDeviceSync(DescribeActivateDeviceRequest req)
        {
            return InternalRequestAsync<DescribeActivateDeviceResponse>(req, "DescribeActivateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取增值服务激活码详情
        /// </summary>
        /// <param name="req"><see cref="DescribeActivateLicenseServiceRequest"/></param>
        /// <returns><see cref="DescribeActivateLicenseServiceResponse"/></returns>
        public Task<DescribeActivateLicenseServiceResponse> DescribeActivateLicenseService(DescribeActivateLicenseServiceRequest req)
        {
            return InternalRequestAsync<DescribeActivateLicenseServiceResponse>(req, "DescribeActivateLicenseService");
        }

        /// <summary>
        /// 获取增值服务激活码详情
        /// </summary>
        /// <param name="req"><see cref="DescribeActivateLicenseServiceRequest"/></param>
        /// <returns><see cref="DescribeActivateLicenseServiceResponse"/></returns>
        public DescribeActivateLicenseServiceResponse DescribeActivateLicenseServiceSync(DescribeActivateLicenseServiceRequest req)
        {
            return InternalRequestAsync<DescribeActivateLicenseServiceResponse>(req, "DescribeActivateLicenseService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取量产详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchProductionRequest"/></param>
        /// <returns><see cref="DescribeBatchProductionResponse"/></returns>
        public Task<DescribeBatchProductionResponse> DescribeBatchProduction(DescribeBatchProductionRequest req)
        {
            return InternalRequestAsync<DescribeBatchProductionResponse>(req, "DescribeBatchProduction");
        }

        /// <summary>
        /// 获取量产详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchProductionRequest"/></param>
        /// <returns><see cref="DescribeBatchProductionResponse"/></returns>
        public DescribeBatchProductionResponse DescribeBatchProductionSync(DescribeBatchProductionRequest req)
        {
            return InternalRequestAsync<DescribeBatchProductionResponse>(req, "DescribeBatchProduction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取网关产品已经绑定的子产品
        /// </summary>
        /// <param name="req"><see cref="DescribeBindedProductsRequest"/></param>
        /// <returns><see cref="DescribeBindedProductsResponse"/></returns>
        public Task<DescribeBindedProductsResponse> DescribeBindedProducts(DescribeBindedProductsRequest req)
        {
            return InternalRequestAsync<DescribeBindedProductsResponse>(req, "DescribeBindedProducts");
        }

        /// <summary>
        /// 获取网关产品已经绑定的子产品
        /// </summary>
        /// <param name="req"><see cref="DescribeBindedProductsRequest"/></param>
        /// <returns><see cref="DescribeBindedProductsResponse"/></returns>
        public DescribeBindedProductsResponse DescribeBindedProductsSync(DescribeBindedProductsRequest req)
        {
            return InternalRequestAsync<DescribeBindedProductsResponse>(req, "DescribeBindedProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备云存服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageResponse"/></returns>
        public Task<DescribeCloudStorageResponse> DescribeCloudStorage(DescribeCloudStorageRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageResponse>(req, "DescribeCloudStorage");
        }

        /// <summary>
        /// 获取设备云存服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageResponse"/></returns>
        public DescribeCloudStorageResponse DescribeCloudStorageSync(DescribeCloudStorageRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageResponse>(req, "DescribeCloudStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定设备的云存 AI 服务开通状态与参数配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageAIServiceResponse"/></returns>
        public Task<DescribeCloudStorageAIServiceResponse> DescribeCloudStorageAIService(DescribeCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageAIServiceResponse>(req, "DescribeCloudStorageAIService");
        }

        /// <summary>
        /// 查询指定设备的云存 AI 服务开通状态与参数配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageAIServiceResponse"/></returns>
        public DescribeCloudStorageAIServiceResponse DescribeCloudStorageAIServiceSync(DescribeCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageAIServiceResponse>(req, "DescribeCloudStorageAIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云存AI分析回调配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageAIServiceCallbackRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageAIServiceCallbackResponse"/></returns>
        public Task<DescribeCloudStorageAIServiceCallbackResponse> DescribeCloudStorageAIServiceCallback(DescribeCloudStorageAIServiceCallbackRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageAIServiceCallbackResponse>(req, "DescribeCloudStorageAIServiceCallback");
        }

        /// <summary>
        /// 查询云存AI分析回调配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageAIServiceCallbackRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageAIServiceCallbackResponse"/></returns>
        public DescribeCloudStorageAIServiceCallbackResponse DescribeCloudStorageAIServiceCallbackSync(DescribeCloudStorageAIServiceCallbackRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageAIServiceCallbackResponse>(req, "DescribeCloudStorageAIServiceCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定的云存 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageAIServiceTaskRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageAIServiceTaskResponse"/></returns>
        public Task<DescribeCloudStorageAIServiceTaskResponse> DescribeCloudStorageAIServiceTask(DescribeCloudStorageAIServiceTaskRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageAIServiceTaskResponse>(req, "DescribeCloudStorageAIServiceTask");
        }

        /// <summary>
        /// 查询指定的云存 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageAIServiceTaskRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageAIServiceTaskResponse"/></returns>
        public DescribeCloudStorageAIServiceTaskResponse DescribeCloudStorageAIServiceTaskSync(DescribeCloudStorageAIServiceTaskRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageAIServiceTaskResponse>(req, "DescribeCloudStorageAIServiceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定设备的云存 AI 分析任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageAIServiceTasksRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageAIServiceTasksResponse"/></returns>
        public Task<DescribeCloudStorageAIServiceTasksResponse> DescribeCloudStorageAIServiceTasks(DescribeCloudStorageAIServiceTasksRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageAIServiceTasksResponse>(req, "DescribeCloudStorageAIServiceTasks");
        }

        /// <summary>
        /// 查询指定设备的云存 AI 分析任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageAIServiceTasksRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageAIServiceTasksResponse"/></returns>
        public DescribeCloudStorageAIServiceTasksResponse DescribeCloudStorageAIServiceTasksSync(DescribeCloudStorageAIServiceTasksRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageAIServiceTasksResponse>(req, "DescribeCloudStorageAIServiceTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取具有云存的日期
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageDateRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageDateResponse"/></returns>
        public Task<DescribeCloudStorageDateResponse> DescribeCloudStorageDate(DescribeCloudStorageDateRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageDateResponse>(req, "DescribeCloudStorageDate");
        }

        /// <summary>
        /// 获取具有云存的日期
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageDateRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageDateResponse"/></returns>
        public DescribeCloudStorageDateResponse DescribeCloudStorageDateSync(DescribeCloudStorageDateRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageDateResponse>(req, "DescribeCloudStorageDate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取云存事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageEventsRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageEventsResponse"/></returns>
        public Task<DescribeCloudStorageEventsResponse> DescribeCloudStorageEvents(DescribeCloudStorageEventsRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageEventsResponse>(req, "DescribeCloudStorageEvents");
        }

        /// <summary>
        /// 拉取云存事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageEventsRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageEventsResponse"/></returns>
        public DescribeCloudStorageEventsResponse DescribeCloudStorageEventsSync(DescribeCloudStorageEventsRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageEventsResponse>(req, "DescribeCloudStorageEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取云存事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageEventsWithAITasksRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageEventsWithAITasksResponse"/></returns>
        public Task<DescribeCloudStorageEventsWithAITasksResponse> DescribeCloudStorageEventsWithAITasks(DescribeCloudStorageEventsWithAITasksRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageEventsWithAITasksResponse>(req, "DescribeCloudStorageEventsWithAITasks");
        }

        /// <summary>
        /// 拉取云存事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageEventsWithAITasksRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageEventsWithAITasksResponse"/></returns>
        public DescribeCloudStorageEventsWithAITasksResponse DescribeCloudStorageEventsWithAITasksSync(DescribeCloudStorageEventsWithAITasksRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageEventsWithAITasksResponse>(req, "DescribeCloudStorageEventsWithAITasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取多个云存事件缩略图
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageMultiThumbnailRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageMultiThumbnailResponse"/></returns>
        public Task<DescribeCloudStorageMultiThumbnailResponse> DescribeCloudStorageMultiThumbnail(DescribeCloudStorageMultiThumbnailRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageMultiThumbnailResponse>(req, "DescribeCloudStorageMultiThumbnail");
        }

        /// <summary>
        /// 拉取多个云存事件缩略图
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageMultiThumbnailRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageMultiThumbnailResponse"/></returns>
        public DescribeCloudStorageMultiThumbnailResponse DescribeCloudStorageMultiThumbnailSync(DescribeCloudStorageMultiThumbnailRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageMultiThumbnailResponse>(req, "DescribeCloudStorageMultiThumbnail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云存服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageOrderRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageOrderResponse"/></returns>
        public Task<DescribeCloudStorageOrderResponse> DescribeCloudStorageOrder(DescribeCloudStorageOrderRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageOrderResponse>(req, "DescribeCloudStorageOrder");
        }

        /// <summary>
        /// 查询云存服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageOrderRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageOrderResponse"/></returns>
        public DescribeCloudStorageOrderResponse DescribeCloudStorageOrderSync(DescribeCloudStorageOrderRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageOrderResponse>(req, "DescribeCloudStorageOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云存套餐包消耗详细记录
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStoragePackageConsumeDetailsRequest"/></param>
        /// <returns><see cref="DescribeCloudStoragePackageConsumeDetailsResponse"/></returns>
        public Task<DescribeCloudStoragePackageConsumeDetailsResponse> DescribeCloudStoragePackageConsumeDetails(DescribeCloudStoragePackageConsumeDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCloudStoragePackageConsumeDetailsResponse>(req, "DescribeCloudStoragePackageConsumeDetails");
        }

        /// <summary>
        /// 获取云存套餐包消耗详细记录
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStoragePackageConsumeDetailsRequest"/></param>
        /// <returns><see cref="DescribeCloudStoragePackageConsumeDetailsResponse"/></returns>
        public DescribeCloudStoragePackageConsumeDetailsResponse DescribeCloudStoragePackageConsumeDetailsSync(DescribeCloudStoragePackageConsumeDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCloudStoragePackageConsumeDetailsResponse>(req, "DescribeCloudStoragePackageConsumeDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云存套餐包消耗统计
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStoragePackageConsumeStatsRequest"/></param>
        /// <returns><see cref="DescribeCloudStoragePackageConsumeStatsResponse"/></returns>
        public Task<DescribeCloudStoragePackageConsumeStatsResponse> DescribeCloudStoragePackageConsumeStats(DescribeCloudStoragePackageConsumeStatsRequest req)
        {
            return InternalRequestAsync<DescribeCloudStoragePackageConsumeStatsResponse>(req, "DescribeCloudStoragePackageConsumeStats");
        }

        /// <summary>
        /// 获取云存套餐包消耗统计
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStoragePackageConsumeStatsRequest"/></param>
        /// <returns><see cref="DescribeCloudStoragePackageConsumeStatsResponse"/></returns>
        public DescribeCloudStoragePackageConsumeStatsResponse DescribeCloudStoragePackageConsumeStatsSync(DescribeCloudStoragePackageConsumeStatsRequest req)
        {
            return InternalRequestAsync<DescribeCloudStoragePackageConsumeStatsResponse>(req, "DescribeCloudStoragePackageConsumeStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备图片流数据
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageStreamDataRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageStreamDataResponse"/></returns>
        public Task<DescribeCloudStorageStreamDataResponse> DescribeCloudStorageStreamData(DescribeCloudStorageStreamDataRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageStreamDataResponse>(req, "DescribeCloudStorageStreamData");
        }

        /// <summary>
        /// 获取设备图片流数据
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageStreamDataRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageStreamDataResponse"/></returns>
        public DescribeCloudStorageStreamDataResponse DescribeCloudStorageStreamDataSync(DescribeCloudStorageStreamDataRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageStreamDataResponse>(req, "DescribeCloudStorageStreamData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取云存事件缩略图
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageThumbnailRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageThumbnailResponse"/></returns>
        public Task<DescribeCloudStorageThumbnailResponse> DescribeCloudStorageThumbnail(DescribeCloudStorageThumbnailRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageThumbnailResponse>(req, "DescribeCloudStorageThumbnail");
        }

        /// <summary>
        /// 拉取云存事件缩略图
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageThumbnailRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageThumbnailResponse"/></returns>
        public DescribeCloudStorageThumbnailResponse DescribeCloudStorageThumbnailSync(DescribeCloudStorageThumbnailRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageThumbnailResponse>(req, "DescribeCloudStorageThumbnail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量拉取云存事件缩略图
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageThumbnailListRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageThumbnailListResponse"/></returns>
        public Task<DescribeCloudStorageThumbnailListResponse> DescribeCloudStorageThumbnailList(DescribeCloudStorageThumbnailListRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageThumbnailListResponse>(req, "DescribeCloudStorageThumbnailList");
        }

        /// <summary>
        /// 批量拉取云存事件缩略图
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageThumbnailListRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageThumbnailListResponse"/></returns>
        public DescribeCloudStorageThumbnailListResponse DescribeCloudStorageThumbnailListSync(DescribeCloudStorageThumbnailListRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageThumbnailListResponse>(req, "DescribeCloudStorageThumbnailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取某一天云存时间轴
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageTimeRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageTimeResponse"/></returns>
        public Task<DescribeCloudStorageTimeResponse> DescribeCloudStorageTime(DescribeCloudStorageTimeRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageTimeResponse>(req, "DescribeCloudStorageTime");
        }

        /// <summary>
        /// 获取某一天云存时间轴
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageTimeRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageTimeResponse"/></returns>
        public DescribeCloudStorageTimeResponse DescribeCloudStorageTimeSync(DescribeCloudStorageTimeRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageTimeResponse>(req, "DescribeCloudStorageTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取云存用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageUsersRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageUsersResponse"/></returns>
        public Task<DescribeCloudStorageUsersResponse> DescribeCloudStorageUsers(DescribeCloudStorageUsersRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageUsersResponse>(req, "DescribeCloudStorageUsers");
        }

        /// <summary>
        /// 拉取云存用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageUsersRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageUsersResponse"/></returns>
        public DescribeCloudStorageUsersResponse DescribeCloudStorageUsersSync(DescribeCloudStorageUsersRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageUsersResponse>(req, "DescribeCloudStorageUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云存上报统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCsReportCountDataInfoRequest"/></param>
        /// <returns><see cref="DescribeCsReportCountDataInfoResponse"/></returns>
        public Task<DescribeCsReportCountDataInfoResponse> DescribeCsReportCountDataInfo(DescribeCsReportCountDataInfoRequest req)
        {
            return InternalRequestAsync<DescribeCsReportCountDataInfoResponse>(req, "DescribeCsReportCountDataInfo");
        }

        /// <summary>
        /// 获取云存上报统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCsReportCountDataInfoRequest"/></param>
        /// <returns><see cref="DescribeCsReportCountDataInfoResponse"/></returns>
        public DescribeCsReportCountDataInfoResponse DescribeCsReportCountDataInfoSync(DescribeCsReportCountDataInfoRequest req)
        {
            return InternalRequestAsync<DescribeCsReportCountDataInfoResponse>(req, "DescribeCsReportCountDataInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查看某个设备的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice");
        }

        /// <summary>
        /// 用于查看某个设备的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备绑定的网关设备
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceBindGatewayRequest"/></param>
        /// <returns><see cref="DescribeDeviceBindGatewayResponse"/></returns>
        public Task<DescribeDeviceBindGatewayResponse> DescribeDeviceBindGateway(DescribeDeviceBindGatewayRequest req)
        {
            return InternalRequestAsync<DescribeDeviceBindGatewayResponse>(req, "DescribeDeviceBindGateway");
        }

        /// <summary>
        /// 查询设备绑定的网关设备
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceBindGatewayRequest"/></param>
        /// <returns><see cref="DescribeDeviceBindGatewayResponse"/></returns>
        public DescribeDeviceBindGatewayResponse DescribeDeviceBindGatewaySync(DescribeDeviceBindGatewayRequest req)
        {
            return InternalRequestAsync<DescribeDeviceBindGatewayResponse>(req, "DescribeDeviceBindGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，获取设备上报的属性数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataResponse"/></returns>
        public Task<DescribeDeviceDataResponse> DescribeDeviceData(DescribeDeviceDataRequest req)
        {
            return InternalRequestAsync<DescribeDeviceDataResponse>(req, "DescribeDeviceData");
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，获取设备上报的属性数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataResponse"/></returns>
        public DescribeDeviceDataResponse DescribeDeviceDataSync(DescribeDeviceDataRequest req)
        {
            return InternalRequestAsync<DescribeDeviceDataResponse>(req, "DescribeDeviceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备在指定时间范围内上报的历史数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataHistoryResponse"/></returns>
        public Task<DescribeDeviceDataHistoryResponse> DescribeDeviceDataHistory(DescribeDeviceDataHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceDataHistoryResponse>(req, "DescribeDeviceDataHistory");
        }

        /// <summary>
        /// 获取设备在指定时间范围内上报的历史数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataHistoryResponse"/></returns>
        public DescribeDeviceDataHistoryResponse DescribeDeviceDataHistorySync(DescribeDeviceDataHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceDataHistoryResponse>(req, "DescribeDeviceDataHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceFirmWareRequest"/></param>
        /// <returns><see cref="DescribeDeviceFirmWareResponse"/></returns>
        public Task<DescribeDeviceFirmWareResponse> DescribeDeviceFirmWare(DescribeDeviceFirmWareRequest req)
        {
            return InternalRequestAsync<DescribeDeviceFirmWareResponse>(req, "DescribeDeviceFirmWare");
        }

        /// <summary>
        /// 获取设备固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceFirmWareRequest"/></param>
        /// <returns><see cref="DescribeDeviceFirmWareResponse"/></returns>
        public DescribeDeviceFirmWareResponse DescribeDeviceFirmWareSync(DescribeDeviceFirmWareRequest req)
        {
            return InternalRequestAsync<DescribeDeviceFirmWareResponse>(req, "DescribeDeviceFirmWare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备当前固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceFirmwaresRequest"/></param>
        /// <returns><see cref="DescribeDeviceFirmwaresResponse"/></returns>
        public Task<DescribeDeviceFirmwaresResponse> DescribeDeviceFirmwares(DescribeDeviceFirmwaresRequest req)
        {
            return InternalRequestAsync<DescribeDeviceFirmwaresResponse>(req, "DescribeDeviceFirmwares");
        }

        /// <summary>
        /// 获取设备当前固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceFirmwaresRequest"/></param>
        /// <returns><see cref="DescribeDeviceFirmwaresResponse"/></returns>
        public DescribeDeviceFirmwaresResponse DescribeDeviceFirmwaresSync(DescribeDeviceFirmwaresRequest req)
        {
            return InternalRequestAsync<DescribeDeviceFirmwaresResponse>(req, "DescribeDeviceFirmwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实时位置解析依赖于teg位置服务，近30天调用只有2个个人账号调用，产品推下线
        /// 
        /// 获取实时位置解析
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceLocationSolveRequest"/></param>
        /// <returns><see cref="DescribeDeviceLocationSolveResponse"/></returns>
        public Task<DescribeDeviceLocationSolveResponse> DescribeDeviceLocationSolve(DescribeDeviceLocationSolveRequest req)
        {
            return InternalRequestAsync<DescribeDeviceLocationSolveResponse>(req, "DescribeDeviceLocationSolve");
        }

        /// <summary>
        /// 获取实时位置解析依赖于teg位置服务，近30天调用只有2个个人账号调用，产品推下线
        /// 
        /// 获取实时位置解析
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceLocationSolveRequest"/></param>
        /// <returns><see cref="DescribeDeviceLocationSolveResponse"/></returns>
        public DescribeDeviceLocationSolveResponse DescribeDeviceLocationSolveSync(DescribeDeviceLocationSolveRequest req)
        {
            return InternalRequestAsync<DescribeDeviceLocationSolveResponse>(req, "DescribeDeviceLocationSolve")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据设备信息拉取有效套餐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePackagesRequest"/></param>
        /// <returns><see cref="DescribeDevicePackagesResponse"/></returns>
        public Task<DescribeDevicePackagesResponse> DescribeDevicePackages(DescribeDevicePackagesRequest req)
        {
            return InternalRequestAsync<DescribeDevicePackagesResponse>(req, "DescribeDevicePackages");
        }

        /// <summary>
        /// 根据设备信息拉取有效套餐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePackagesRequest"/></param>
        /// <returns><see cref="DescribeDevicePackagesResponse"/></returns>
        public DescribeDevicePackagesResponse DescribeDevicePackagesSync(DescribeDevicePackagesRequest req)
        {
            return InternalRequestAsync<DescribeDevicePackagesResponse>(req, "DescribeDevicePackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备位置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePositionListRequest"/></param>
        /// <returns><see cref="DescribeDevicePositionListResponse"/></returns>
        public Task<DescribeDevicePositionListResponse> DescribeDevicePositionList(DescribeDevicePositionListRequest req)
        {
            return InternalRequestAsync<DescribeDevicePositionListResponse>(req, "DescribeDevicePositionList");
        }

        /// <summary>
        /// 获取设备位置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePositionListRequest"/></param>
        /// <returns><see cref="DescribeDevicePositionListResponse"/></returns>
        public DescribeDevicePositionListResponse DescribeDevicePositionListSync(DescribeDevicePositionListRequest req)
        {
            return InternalRequestAsync<DescribeDevicePositionListResponse>(req, "DescribeDevicePositionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取围栏绑定信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFenceBindListRequest"/></param>
        /// <returns><see cref="DescribeFenceBindListResponse"/></returns>
        public Task<DescribeFenceBindListResponse> DescribeFenceBindList(DescribeFenceBindListRequest req)
        {
            return InternalRequestAsync<DescribeFenceBindListResponse>(req, "DescribeFenceBindList");
        }

        /// <summary>
        /// 获取围栏绑定信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFenceBindListRequest"/></param>
        /// <returns><see cref="DescribeFenceBindListResponse"/></returns>
        public DescribeFenceBindListResponse DescribeFenceBindListSync(DescribeFenceBindListRequest req)
        {
            return InternalRequestAsync<DescribeFenceBindListResponse>(req, "DescribeFenceBindList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取围栏告警事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFenceEventListRequest"/></param>
        /// <returns><see cref="DescribeFenceEventListResponse"/></returns>
        public Task<DescribeFenceEventListResponse> DescribeFenceEventList(DescribeFenceEventListRequest req)
        {
            return InternalRequestAsync<DescribeFenceEventListResponse>(req, "DescribeFenceEventList");
        }

        /// <summary>
        /// 获取围栏告警事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFenceEventListRequest"/></param>
        /// <returns><see cref="DescribeFenceEventListResponse"/></returns>
        public DescribeFenceEventListResponse DescribeFenceEventListSync(DescribeFenceEventListRequest req)
        {
            return InternalRequestAsync<DescribeFenceEventListResponse>(req, "DescribeFenceEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareRequest"/></param>
        /// <returns><see cref="DescribeFirmwareResponse"/></returns>
        public Task<DescribeFirmwareResponse> DescribeFirmware(DescribeFirmwareRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareResponse>(req, "DescribeFirmware");
        }

        /// <summary>
        /// 查询固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareRequest"/></param>
        /// <returns><see cref="DescribeFirmwareResponse"/></returns>
        public DescribeFirmwareResponse DescribeFirmwareSync(DescribeFirmwareRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareResponse>(req, "DescribeFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询固件升级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskResponse"/></returns>
        public Task<DescribeFirmwareTaskResponse> DescribeFirmwareTask(DescribeFirmwareTaskRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskResponse>(req, "DescribeFirmwareTask");
        }

        /// <summary>
        /// 查询固件升级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskResponse"/></returns>
        public DescribeFirmwareTaskResponse DescribeFirmwareTaskSync(DescribeFirmwareTaskRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskResponse>(req, "DescribeFirmwareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFirmwareUpdateStatus）用于查询设备固件升级状态及进度。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareUpdateStatusRequest"/></param>
        /// <returns><see cref="DescribeFirmwareUpdateStatusResponse"/></returns>
        public Task<DescribeFirmwareUpdateStatusResponse> DescribeFirmwareUpdateStatus(DescribeFirmwareUpdateStatusRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareUpdateStatusResponse>(req, "DescribeFirmwareUpdateStatus");
        }

        /// <summary>
        /// 本接口（DescribeFirmwareUpdateStatus）用于查询设备固件升级状态及进度。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareUpdateStatusRequest"/></param>
        /// <returns><see cref="DescribeFirmwareUpdateStatusResponse"/></returns>
        public DescribeFirmwareUpdateStatusResponse DescribeFirmwareUpdateStatusSync(DescribeFirmwareUpdateStatusRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareUpdateStatusResponse>(req, "DescribeFirmwareUpdateStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云存卡套餐信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFreeCloudStorageNumRequest"/></param>
        /// <returns><see cref="DescribeFreeCloudStorageNumResponse"/></returns>
        public Task<DescribeFreeCloudStorageNumResponse> DescribeFreeCloudStorageNum(DescribeFreeCloudStorageNumRequest req)
        {
            return InternalRequestAsync<DescribeFreeCloudStorageNumResponse>(req, "DescribeFreeCloudStorageNum");
        }

        /// <summary>
        /// 查询云存卡套餐信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFreeCloudStorageNumRequest"/></param>
        /// <returns><see cref="DescribeFreeCloudStorageNumResponse"/></returns>
        public DescribeFreeCloudStorageNumResponse DescribeFreeCloudStorageNumSync(DescribeFreeCloudStorageNumRequest req)
        {
            return InternalRequestAsync<DescribeFreeCloudStorageNumResponse>(req, "DescribeFreeCloudStorageNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取网关绑定的子设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayBindDevicesRequest"/></param>
        /// <returns><see cref="DescribeGatewayBindDevicesResponse"/></returns>
        public Task<DescribeGatewayBindDevicesResponse> DescribeGatewayBindDevices(DescribeGatewayBindDevicesRequest req)
        {
            return InternalRequestAsync<DescribeGatewayBindDevicesResponse>(req, "DescribeGatewayBindDevices");
        }

        /// <summary>
        /// 获取网关绑定的子设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayBindDevicesRequest"/></param>
        /// <returns><see cref="DescribeGatewayBindDevicesResponse"/></returns>
        public DescribeGatewayBindDevicesResponse DescribeGatewayBindDevicesSync(DescribeGatewayBindDevicesRequest req)
        {
            return InternalRequestAsync<DescribeGatewayBindDevicesResponse>(req, "DescribeGatewayBindDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询绑定到家庭的网关设备的子设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewaySubDeviceListRequest"/></param>
        /// <returns><see cref="DescribeGatewaySubDeviceListResponse"/></returns>
        public Task<DescribeGatewaySubDeviceListResponse> DescribeGatewaySubDeviceList(DescribeGatewaySubDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeGatewaySubDeviceListResponse>(req, "DescribeGatewaySubDeviceList");
        }

        /// <summary>
        /// 查询绑定到家庭的网关设备的子设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewaySubDeviceListRequest"/></param>
        /// <returns><see cref="DescribeGatewaySubDeviceListResponse"/></returns>
        public DescribeGatewaySubDeviceListResponse DescribeGatewaySubDeviceListSync(DescribeGatewaySubDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeGatewaySubDeviceListResponse>(req, "DescribeGatewaySubDeviceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取网关可绑定或解绑的子产品。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewaySubProductsRequest"/></param>
        /// <returns><see cref="DescribeGatewaySubProductsResponse"/></returns>
        public Task<DescribeGatewaySubProductsResponse> DescribeGatewaySubProducts(DescribeGatewaySubProductsRequest req)
        {
            return InternalRequestAsync<DescribeGatewaySubProductsResponse>(req, "DescribeGatewaySubProducts");
        }

        /// <summary>
        /// 用于获取网关可绑定或解绑的子产品。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewaySubProductsRequest"/></param>
        /// <returns><see cref="DescribeGatewaySubProductsResponse"/></returns>
        public DescribeGatewaySubProductsResponse DescribeGatewaySubProductsSync(DescribeGatewaySubProductsRequest req)
        {
            return InternalRequestAsync<DescribeGatewaySubProductsResponse>(req, "DescribeGatewaySubProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 公共实例过期时间 0001-01-01T00:00:00Z，公共实例是永久有效
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// 公共实例过期时间 0001-01-01T00:00:00Z，公共实例是永久有效
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供查询LoRa自定义频点详情的能力
        /// </summary>
        /// <param name="req"><see cref="DescribeLoRaFrequencyRequest"/></param>
        /// <returns><see cref="DescribeLoRaFrequencyResponse"/></returns>
        public Task<DescribeLoRaFrequencyResponse> DescribeLoRaFrequency(DescribeLoRaFrequencyRequest req)
        {
            return InternalRequestAsync<DescribeLoRaFrequencyResponse>(req, "DescribeLoRaFrequency");
        }

        /// <summary>
        /// 提供查询LoRa自定义频点详情的能力
        /// </summary>
        /// <param name="req"><see cref="DescribeLoRaFrequencyRequest"/></param>
        /// <returns><see cref="DescribeLoRaFrequencyResponse"/></returns>
        public DescribeLoRaFrequencyResponse DescribeLoRaFrequencySync(DescribeLoRaFrequencyRequest req)
        {
            return InternalRequestAsync<DescribeLoRaFrequencyResponse>(req, "DescribeLoRaFrequency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询产品配置的数据模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDefinitionRequest"/></param>
        /// <returns><see cref="DescribeModelDefinitionResponse"/></returns>
        public Task<DescribeModelDefinitionResponse> DescribeModelDefinition(DescribeModelDefinitionRequest req)
        {
            return InternalRequestAsync<DescribeModelDefinitionResponse>(req, "DescribeModelDefinition");
        }

        /// <summary>
        /// 查询产品配置的数据模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDefinitionRequest"/></param>
        /// <returns><see cref="DescribeModelDefinitionResponse"/></returns>
        public DescribeModelDefinitionResponse DescribeModelDefinitionSync(DescribeModelDefinitionRequest req)
        {
            return InternalRequestAsync<DescribeModelDefinitionResponse>(req, "DescribeModelDefinition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当前p2p线路
        /// </summary>
        /// <param name="req"><see cref="DescribeP2PRouteRequest"/></param>
        /// <returns><see cref="DescribeP2PRouteResponse"/></returns>
        public Task<DescribeP2PRouteResponse> DescribeP2PRoute(DescribeP2PRouteRequest req)
        {
            return InternalRequestAsync<DescribeP2PRouteResponse>(req, "DescribeP2PRoute");
        }

        /// <summary>
        /// 当前p2p线路
        /// </summary>
        /// <param name="req"><see cref="DescribeP2PRouteRequest"/></param>
        /// <returns><see cref="DescribeP2PRouteResponse"/></returns>
        public DescribeP2PRouteResponse DescribeP2PRouteSync(DescribeP2PRouteRequest req)
        {
            return InternalRequestAsync<DescribeP2PRouteResponse>(req, "DescribeP2PRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询套餐消耗记录详情
        /// </summary>
        /// <param name="req"><see cref="DescribePackageConsumeTaskRequest"/></param>
        /// <returns><see cref="DescribePackageConsumeTaskResponse"/></returns>
        public Task<DescribePackageConsumeTaskResponse> DescribePackageConsumeTask(DescribePackageConsumeTaskRequest req)
        {
            return InternalRequestAsync<DescribePackageConsumeTaskResponse>(req, "DescribePackageConsumeTask");
        }

        /// <summary>
        /// 查询套餐消耗记录详情
        /// </summary>
        /// <param name="req"><see cref="DescribePackageConsumeTaskRequest"/></param>
        /// <returns><see cref="DescribePackageConsumeTaskResponse"/></returns>
        public DescribePackageConsumeTaskResponse DescribePackageConsumeTaskSync(DescribePackageConsumeTaskRequest req)
        {
            return InternalRequestAsync<DescribePackageConsumeTaskResponse>(req, "DescribePackageConsumeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询套餐消耗记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribePackageConsumeTasksRequest"/></param>
        /// <returns><see cref="DescribePackageConsumeTasksResponse"/></returns>
        public Task<DescribePackageConsumeTasksResponse> DescribePackageConsumeTasks(DescribePackageConsumeTasksRequest req)
        {
            return InternalRequestAsync<DescribePackageConsumeTasksResponse>(req, "DescribePackageConsumeTasks");
        }

        /// <summary>
        /// 查询套餐消耗记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribePackageConsumeTasksRequest"/></param>
        /// <returns><see cref="DescribePackageConsumeTasksResponse"/></returns>
        public DescribePackageConsumeTasksResponse DescribePackageConsumeTasksSync(DescribePackageConsumeTasksRequest req)
        {
            return InternalRequestAsync<DescribePackageConsumeTasksResponse>(req, "DescribePackageConsumeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取围栏列表
        /// </summary>
        /// <param name="req"><see cref="DescribePositionFenceListRequest"/></param>
        /// <returns><see cref="DescribePositionFenceListResponse"/></returns>
        public Task<DescribePositionFenceListResponse> DescribePositionFenceList(DescribePositionFenceListRequest req)
        {
            return InternalRequestAsync<DescribePositionFenceListResponse>(req, "DescribePositionFenceList");
        }

        /// <summary>
        /// 获取围栏列表
        /// </summary>
        /// <param name="req"><see cref="DescribePositionFenceListRequest"/></param>
        /// <returns><see cref="DescribePositionFenceListResponse"/></returns>
        public DescribePositionFenceListResponse DescribePositionFenceListSync(DescribePositionFenceListRequest req)
        {
            return InternalRequestAsync<DescribePositionFenceListResponse>(req, "DescribePositionFenceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定产品的云存 AI 服务开通状态
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="DescribeProductCloudStorageAIServiceResponse"/></returns>
        public Task<DescribeProductCloudStorageAIServiceResponse> DescribeProductCloudStorageAIService(DescribeProductCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<DescribeProductCloudStorageAIServiceResponse>(req, "DescribeProductCloudStorageAIService");
        }

        /// <summary>
        /// 查询指定产品的云存 AI 服务开通状态
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="DescribeProductCloudStorageAIServiceResponse"/></returns>
        public DescribeProductCloudStorageAIServiceResponse DescribeProductCloudStorageAIServiceSync(DescribeProductCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<DescribeProductCloudStorageAIServiceResponse>(req, "DescribeProductCloudStorageAIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public Task<DescribeProjectResponse> DescribeProject(DescribeProjectRequest req)
        {
            return InternalRequestAsync<DescribeProjectResponse>(req, "DescribeProject");
        }

        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public DescribeProjectResponse DescribeProjectSync(DescribeProjectRequest req)
        {
            return InternalRequestAsync<DescribeProjectResponse>(req, "DescribeProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取位置空间中围栏告警事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceFenceEventListRequest"/></param>
        /// <returns><see cref="DescribeSpaceFenceEventListResponse"/></returns>
        public Task<DescribeSpaceFenceEventListResponse> DescribeSpaceFenceEventList(DescribeSpaceFenceEventListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceFenceEventListResponse>(req, "DescribeSpaceFenceEventList");
        }

        /// <summary>
        /// 获取位置空间中围栏告警事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceFenceEventListRequest"/></param>
        /// <returns><see cref="DescribeSpaceFenceEventListResponse"/></returns>
        public DescribeSpaceFenceEventListResponse DescribeSpaceFenceEventListSync(DescribeSpaceFenceEventListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceFenceEventListResponse>(req, "DescribeSpaceFenceEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供查看产品详细信息的能力，包括产品的ID、数据协议、认证类型等重要参数
        /// </summary>
        /// <param name="req"><see cref="DescribeStudioProductRequest"/></param>
        /// <returns><see cref="DescribeStudioProductResponse"/></returns>
        public Task<DescribeStudioProductResponse> DescribeStudioProduct(DescribeStudioProductRequest req)
        {
            return InternalRequestAsync<DescribeStudioProductResponse>(req, "DescribeStudioProduct");
        }

        /// <summary>
        /// 提供查看产品详细信息的能力，包括产品的ID、数据协议、认证类型等重要参数
        /// </summary>
        /// <param name="req"><see cref="DescribeStudioProductRequest"/></param>
        /// <returns><see cref="DescribeStudioProductResponse"/></returns>
        public DescribeStudioProductResponse DescribeStudioProductSync(DescribeStudioProductRequest req)
        {
            return InternalRequestAsync<DescribeStudioProductResponse>(req, "DescribeStudioProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取 TWeSee 配置
        /// </summary>
        /// <param name="req"><see cref="DescribeTWeSeeConfigRequest"/></param>
        /// <returns><see cref="DescribeTWeSeeConfigResponse"/></returns>
        public Task<DescribeTWeSeeConfigResponse> DescribeTWeSeeConfig(DescribeTWeSeeConfigRequest req)
        {
            return InternalRequestAsync<DescribeTWeSeeConfigResponse>(req, "DescribeTWeSeeConfig");
        }

        /// <summary>
        /// 拉取 TWeSee 配置
        /// </summary>
        /// <param name="req"><see cref="DescribeTWeSeeConfigRequest"/></param>
        /// <returns><see cref="DescribeTWeSeeConfigResponse"/></returns>
        public DescribeTWeSeeConfigResponse DescribeTWeSeeConfigSync(DescribeTWeSeeConfigRequest req)
        {
            return InternalRequestAsync<DescribeTWeSeeConfigResponse>(req, "DescribeTWeSeeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTopicPolicy）用于查看Topic详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicPolicyRequest"/></param>
        /// <returns><see cref="DescribeTopicPolicyResponse"/></returns>
        public Task<DescribeTopicPolicyResponse> DescribeTopicPolicy(DescribeTopicPolicyRequest req)
        {
            return InternalRequestAsync<DescribeTopicPolicyResponse>(req, "DescribeTopicPolicy");
        }

        /// <summary>
        /// 本接口（DescribeTopicPolicy）用于查看Topic详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicPolicyRequest"/></param>
        /// <returns><see cref="DescribeTopicPolicyResponse"/></returns>
        public DescribeTopicPolicyResponse DescribeTopicPolicySync(DescribeTopicPolicyRequest req)
        {
            return InternalRequestAsync<DescribeTopicPolicyResponse>(req, "DescribeTopicPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRuleRequest"/></param>
        /// <returns><see cref="DescribeTopicRuleResponse"/></returns>
        public Task<DescribeTopicRuleResponse> DescribeTopicRule(DescribeTopicRuleRequest req)
        {
            return InternalRequestAsync<DescribeTopicRuleResponse>(req, "DescribeTopicRule");
        }

        /// <summary>
        /// 获取规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRuleRequest"/></param>
        /// <returns><see cref="DescribeTopicRuleResponse"/></returns>
        public DescribeTopicRuleResponse DescribeTopicRuleSync(DescribeTopicRuleRequest req)
        {
            return InternalRequestAsync<DescribeTopicRuleResponse>(req, "DescribeTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取未绑定的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnbindedDevicesRequest"/></param>
        /// <returns><see cref="DescribeUnbindedDevicesResponse"/></returns>
        public Task<DescribeUnbindedDevicesResponse> DescribeUnbindedDevices(DescribeUnbindedDevicesRequest req)
        {
            return InternalRequestAsync<DescribeUnbindedDevicesResponse>(req, "DescribeUnbindedDevices");
        }

        /// <summary>
        /// 获取未绑定的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnbindedDevicesRequest"/></param>
        /// <returns><see cref="DescribeUnbindedDevicesResponse"/></returns>
        public DescribeUnbindedDevicesResponse DescribeUnbindedDevicesSync(DescribeUnbindedDevicesRequest req)
        {
            return InternalRequestAsync<DescribeUnbindedDevicesResponse>(req, "DescribeUnbindedDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询视频激活码统计概览
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoLicenseRequest"/></param>
        /// <returns><see cref="DescribeVideoLicenseResponse"/></returns>
        public Task<DescribeVideoLicenseResponse> DescribeVideoLicense(DescribeVideoLicenseRequest req)
        {
            return InternalRequestAsync<DescribeVideoLicenseResponse>(req, "DescribeVideoLicense");
        }

        /// <summary>
        /// 用于查询视频激活码统计概览
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoLicenseRequest"/></param>
        /// <returns><see cref="DescribeVideoLicenseResponse"/></returns>
        public DescribeVideoLicenseResponse DescribeVideoLicenseSync(DescribeVideoLicenseRequest req)
        {
            return InternalRequestAsync<DescribeVideoLicenseResponse>(req, "DescribeVideoLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直接绑定设备和家庭
        /// </summary>
        /// <param name="req"><see cref="DirectBindDeviceInFamilyRequest"/></param>
        /// <returns><see cref="DirectBindDeviceInFamilyResponse"/></returns>
        public Task<DirectBindDeviceInFamilyResponse> DirectBindDeviceInFamily(DirectBindDeviceInFamilyRequest req)
        {
            return InternalRequestAsync<DirectBindDeviceInFamilyResponse>(req, "DirectBindDeviceInFamily");
        }

        /// <summary>
        /// 直接绑定设备和家庭
        /// </summary>
        /// <param name="req"><see cref="DirectBindDeviceInFamilyRequest"/></param>
        /// <returns><see cref="DirectBindDeviceInFamilyResponse"/></returns>
        public DirectBindDeviceInFamilyResponse DirectBindDeviceInFamilySync(DirectBindDeviceInFamilyRequest req)
        {
            return InternalRequestAsync<DirectBindDeviceInFamilyResponse>(req, "DirectBindDeviceInFamily")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用规则
        /// </summary>
        /// <param name="req"><see cref="DisableTopicRuleRequest"/></param>
        /// <returns><see cref="DisableTopicRuleResponse"/></returns>
        public Task<DisableTopicRuleResponse> DisableTopicRule(DisableTopicRuleRequest req)
        {
            return InternalRequestAsync<DisableTopicRuleResponse>(req, "DisableTopicRule");
        }

        /// <summary>
        /// 禁用规则
        /// </summary>
        /// <param name="req"><see cref="DisableTopicRuleRequest"/></param>
        /// <returns><see cref="DisableTopicRuleResponse"/></returns>
        public DisableTopicRuleResponse DisableTopicRuleSync(DisableTopicRuleRequest req)
        {
            return InternalRequestAsync<DisableTopicRuleResponse>(req, "DisableTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解散TRTC房间
        /// </summary>
        /// <param name="req"><see cref="DismissRoomByStrRoomIdFromTRTCRequest"/></param>
        /// <returns><see cref="DismissRoomByStrRoomIdFromTRTCResponse"/></returns>
        public Task<DismissRoomByStrRoomIdFromTRTCResponse> DismissRoomByStrRoomIdFromTRTC(DismissRoomByStrRoomIdFromTRTCRequest req)
        {
            return InternalRequestAsync<DismissRoomByStrRoomIdFromTRTCResponse>(req, "DismissRoomByStrRoomIdFromTRTC");
        }

        /// <summary>
        /// 解散TRTC房间
        /// </summary>
        /// <param name="req"><see cref="DismissRoomByStrRoomIdFromTRTCRequest"/></param>
        /// <returns><see cref="DismissRoomByStrRoomIdFromTRTCResponse"/></returns>
        public DismissRoomByStrRoomIdFromTRTCResponse DismissRoomByStrRoomIdFromTRTCSync(DismissRoomByStrRoomIdFromTRTCRequest req)
        {
            return InternalRequestAsync<DismissRoomByStrRoomIdFromTRTCResponse>(req, "DismissRoomByStrRoomIdFromTRTC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用规则
        /// </summary>
        /// <param name="req"><see cref="EnableTopicRuleRequest"/></param>
        /// <returns><see cref="EnableTopicRuleResponse"/></returns>
        public Task<EnableTopicRuleResponse> EnableTopicRule(EnableTopicRuleRequest req)
        {
            return InternalRequestAsync<EnableTopicRuleResponse>(req, "EnableTopicRule");
        }

        /// <summary>
        /// 启用规则
        /// </summary>
        /// <param name="req"><see cref="EnableTopicRuleRequest"/></param>
        /// <returns><see cref="EnableTopicRuleResponse"/></returns>
        public EnableTopicRuleResponse EnableTopicRuleSync(EnableTopicRuleRequest req)
        {
            return InternalRequestAsync<EnableTopicRuleResponse>(req, "EnableTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="GenSingleDeviceSignatureOfPublicRequest"/></param>
        /// <returns><see cref="GenSingleDeviceSignatureOfPublicResponse"/></returns>
        public Task<GenSingleDeviceSignatureOfPublicResponse> GenSingleDeviceSignatureOfPublic(GenSingleDeviceSignatureOfPublicRequest req)
        {
            return InternalRequestAsync<GenSingleDeviceSignatureOfPublicResponse>(req, "GenSingleDeviceSignatureOfPublic");
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="GenSingleDeviceSignatureOfPublicRequest"/></param>
        /// <returns><see cref="GenSingleDeviceSignatureOfPublicResponse"/></returns>
        public GenSingleDeviceSignatureOfPublicResponse GenSingleDeviceSignatureOfPublicSync(GenSingleDeviceSignatureOfPublicRequest req)
        {
            return InternalRequestAsync<GenSingleDeviceSignatureOfPublicResponse>(req, "GenSingleDeviceSignatureOfPublic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云存 AI 分析任务输出文件的下载地址
        /// </summary>
        /// <param name="req"><see cref="GenerateCloudStorageAIServiceTaskFileURLRequest"/></param>
        /// <returns><see cref="GenerateCloudStorageAIServiceTaskFileURLResponse"/></returns>
        public Task<GenerateCloudStorageAIServiceTaskFileURLResponse> GenerateCloudStorageAIServiceTaskFileURL(GenerateCloudStorageAIServiceTaskFileURLRequest req)
        {
            return InternalRequestAsync<GenerateCloudStorageAIServiceTaskFileURLResponse>(req, "GenerateCloudStorageAIServiceTaskFileURL");
        }

        /// <summary>
        /// 获取云存 AI 分析任务输出文件的下载地址
        /// </summary>
        /// <param name="req"><see cref="GenerateCloudStorageAIServiceTaskFileURLRequest"/></param>
        /// <returns><see cref="GenerateCloudStorageAIServiceTaskFileURLResponse"/></returns>
        public GenerateCloudStorageAIServiceTaskFileURLResponse GenerateCloudStorageAIServiceTaskFileURLSync(GenerateCloudStorageAIServiceTaskFileURLRequest req)
        {
            return InternalRequestAsync<GenerateCloudStorageAIServiceTaskFileURLResponse>(req, "GenerateCloudStorageAIServiceTaskFileURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取视频防盗链播放URL
        /// </summary>
        /// <param name="req"><see cref="GenerateSignedVideoURLRequest"/></param>
        /// <returns><see cref="GenerateSignedVideoURLResponse"/></returns>
        public Task<GenerateSignedVideoURLResponse> GenerateSignedVideoURL(GenerateSignedVideoURLRequest req)
        {
            return InternalRequestAsync<GenerateSignedVideoURLResponse>(req, "GenerateSignedVideoURL");
        }

        /// <summary>
        /// 获取视频防盗链播放URL
        /// </summary>
        /// <param name="req"><see cref="GenerateSignedVideoURLRequest"/></param>
        /// <returns><see cref="GenerateSignedVideoURLResponse"/></returns>
        public GenerateSignedVideoURLResponse GenerateSignedVideoURLSync(GenerateSignedVideoURLRequest req)
        {
            return InternalRequestAsync<GenerateSignedVideoURLResponse>(req, "GenerateSignedVideoURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询小程序列表
        /// </summary>
        /// <param name="req"><see cref="GetAuthMiniProgramAppListRequest"/></param>
        /// <returns><see cref="GetAuthMiniProgramAppListResponse"/></returns>
        public Task<GetAuthMiniProgramAppListResponse> GetAuthMiniProgramAppList(GetAuthMiniProgramAppListRequest req)
        {
            return InternalRequestAsync<GetAuthMiniProgramAppListResponse>(req, "GetAuthMiniProgramAppList");
        }

        /// <summary>
        /// 查询小程序列表
        /// </summary>
        /// <param name="req"><see cref="GetAuthMiniProgramAppListRequest"/></param>
        /// <returns><see cref="GetAuthMiniProgramAppListResponse"/></returns>
        public GetAuthMiniProgramAppListResponse GetAuthMiniProgramAppListSync(GetAuthMiniProgramAppListRequest req)
        {
            return InternalRequestAsync<GetAuthMiniProgramAppListResponse>(req, "GetAuthMiniProgramAppList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出量产数据列表信息。
        /// </summary>
        /// <param name="req"><see cref="GetBatchProductionsListRequest"/></param>
        /// <returns><see cref="GetBatchProductionsListResponse"/></returns>
        public Task<GetBatchProductionsListResponse> GetBatchProductionsList(GetBatchProductionsListRequest req)
        {
            return InternalRequestAsync<GetBatchProductionsListResponse>(req, "GetBatchProductionsList");
        }

        /// <summary>
        /// 列出量产数据列表信息。
        /// </summary>
        /// <param name="req"><see cref="GetBatchProductionsListRequest"/></param>
        /// <returns><see cref="GetBatchProductionsListResponse"/></returns>
        public GetBatchProductionsListResponse GetBatchProductionsListSync(GetBatchProductionsListRequest req)
        {
            return InternalRequestAsync<GetBatchProductionsListResponse>(req, "GetBatchProductionsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetCOSURL）用于获取固件COS存储的上传请求URL地址
        /// </summary>
        /// <param name="req"><see cref="GetCOSURLRequest"/></param>
        /// <returns><see cref="GetCOSURLResponse"/></returns>
        public Task<GetCOSURLResponse> GetCOSURL(GetCOSURLRequest req)
        {
            return InternalRequestAsync<GetCOSURLResponse>(req, "GetCOSURL");
        }

        /// <summary>
        /// 本接口（GetCOSURL）用于获取固件COS存储的上传请求URL地址
        /// </summary>
        /// <param name="req"><see cref="GetCOSURLRequest"/></param>
        /// <returns><see cref="GetCOSURLResponse"/></returns>
        public GetCOSURLResponse GetCOSURLSync(GetCOSURLRequest req)
        {
            return InternalRequestAsync<GetCOSURLResponse>(req, "GetCOSURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询某个产品下的设备列表
        /// </summary>
        /// <param name="req"><see cref="GetDeviceListRequest"/></param>
        /// <returns><see cref="GetDeviceListResponse"/></returns>
        public Task<GetDeviceListResponse> GetDeviceList(GetDeviceListRequest req)
        {
            return InternalRequestAsync<GetDeviceListResponse>(req, "GetDeviceList");
        }

        /// <summary>
        /// 用于查询某个产品下的设备列表
        /// </summary>
        /// <param name="req"><see cref="GetDeviceListRequest"/></param>
        /// <returns><see cref="GetDeviceListResponse"/></returns>
        public GetDeviceListResponse GetDeviceListSync(GetDeviceListRequest req)
        {
            return InternalRequestAsync<GetDeviceListResponse>(req, "GetDeviceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备历史位置
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLocationHistoryRequest"/></param>
        /// <returns><see cref="GetDeviceLocationHistoryResponse"/></returns>
        public Task<GetDeviceLocationHistoryResponse> GetDeviceLocationHistory(GetDeviceLocationHistoryRequest req)
        {
            return InternalRequestAsync<GetDeviceLocationHistoryResponse>(req, "GetDeviceLocationHistory");
        }

        /// <summary>
        /// 获取设备历史位置
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLocationHistoryRequest"/></param>
        /// <returns><see cref="GetDeviceLocationHistoryResponse"/></returns>
        public GetDeviceLocationHistoryResponse GetDeviceLocationHistorySync(GetDeviceLocationHistoryRequest req)
        {
            return InternalRequestAsync<GetDeviceLocationHistoryResponse>(req, "GetDeviceLocationHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取设备统计汇总数据
        /// </summary>
        /// <param name="req"><see cref="GetDeviceSumStatisticsRequest"/></param>
        /// <returns><see cref="GetDeviceSumStatisticsResponse"/></returns>
        public Task<GetDeviceSumStatisticsResponse> GetDeviceSumStatistics(GetDeviceSumStatisticsRequest req)
        {
            return InternalRequestAsync<GetDeviceSumStatisticsResponse>(req, "GetDeviceSumStatistics");
        }

        /// <summary>
        /// 拉取设备统计汇总数据
        /// </summary>
        /// <param name="req"><see cref="GetDeviceSumStatisticsRequest"/></param>
        /// <returns><see cref="GetDeviceSumStatisticsResponse"/></returns>
        public GetDeviceSumStatisticsResponse GetDeviceSumStatisticsSync(GetDeviceSumStatisticsRequest req)
        {
            return InternalRequestAsync<GetDeviceSumStatisticsResponse>(req, "GetDeviceSumStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取设备绑定的用户列表
        /// </summary>
        /// <param name="req"><see cref="GetFamilyDeviceUserListRequest"/></param>
        /// <returns><see cref="GetFamilyDeviceUserListResponse"/></returns>
        public Task<GetFamilyDeviceUserListResponse> GetFamilyDeviceUserList(GetFamilyDeviceUserListRequest req)
        {
            return InternalRequestAsync<GetFamilyDeviceUserListResponse>(req, "GetFamilyDeviceUserList");
        }

        /// <summary>
        /// 用于获取设备绑定的用户列表
        /// </summary>
        /// <param name="req"><see cref="GetFamilyDeviceUserListRequest"/></param>
        /// <returns><see cref="GetFamilyDeviceUserListResponse"/></returns>
        public GetFamilyDeviceUserListResponse GetFamilyDeviceUserListSync(GetFamilyDeviceUserListRequest req)
        {
            return InternalRequestAsync<GetFamilyDeviceUserListResponse>(req, "GetFamilyDeviceUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定网关设备的子设备列表
        /// </summary>
        /// <param name="req"><see cref="GetGatewaySubDeviceListRequest"/></param>
        /// <returns><see cref="GetGatewaySubDeviceListResponse"/></returns>
        public Task<GetGatewaySubDeviceListResponse> GetGatewaySubDeviceList(GetGatewaySubDeviceListRequest req)
        {
            return InternalRequestAsync<GetGatewaySubDeviceListResponse>(req, "GetGatewaySubDeviceList");
        }

        /// <summary>
        /// 获取指定网关设备的子设备列表
        /// </summary>
        /// <param name="req"><see cref="GetGatewaySubDeviceListRequest"/></param>
        /// <returns><see cref="GetGatewaySubDeviceListResponse"/></returns>
        public GetGatewaySubDeviceListResponse GetGatewaySubDeviceListSync(GetGatewaySubDeviceListRequest req)
        {
            return InternalRequestAsync<GetGatewaySubDeviceListResponse>(req, "GetGatewaySubDeviceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 LoRa 网关列表接口
        /// </summary>
        /// <param name="req"><see cref="GetLoRaGatewayListRequest"/></param>
        /// <returns><see cref="GetLoRaGatewayListResponse"/></returns>
        public Task<GetLoRaGatewayListResponse> GetLoRaGatewayList(GetLoRaGatewayListRequest req)
        {
            return InternalRequestAsync<GetLoRaGatewayListResponse>(req, "GetLoRaGatewayList");
        }

        /// <summary>
        /// 获取 LoRa 网关列表接口
        /// </summary>
        /// <param name="req"><see cref="GetLoRaGatewayListRequest"/></param>
        /// <returns><see cref="GetLoRaGatewayListResponse"/></returns>
        public GetLoRaGatewayListResponse GetLoRaGatewayListSync(GetLoRaGatewayListRequest req)
        {
            return InternalRequestAsync<GetLoRaGatewayListResponse>(req, "GetLoRaGatewayList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取位置空间列表
        /// </summary>
        /// <param name="req"><see cref="GetPositionSpaceListRequest"/></param>
        /// <returns><see cref="GetPositionSpaceListResponse"/></returns>
        public Task<GetPositionSpaceListResponse> GetPositionSpaceList(GetPositionSpaceListRequest req)
        {
            return InternalRequestAsync<GetPositionSpaceListResponse>(req, "GetPositionSpaceList");
        }

        /// <summary>
        /// 获取位置空间列表
        /// </summary>
        /// <param name="req"><see cref="GetPositionSpaceListRequest"/></param>
        /// <returns><see cref="GetPositionSpaceListResponse"/></returns>
        public GetPositionSpaceListResponse GetPositionSpaceListSync(GetPositionSpaceListRequest req)
        {
            return InternalRequestAsync<GetPositionSpaceListResponse>(req, "GetPositionSpaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供查询用户所创建的项目列表查询功能。
        /// </summary>
        /// <param name="req"><see cref="GetProjectListRequest"/></param>
        /// <returns><see cref="GetProjectListResponse"/></returns>
        public Task<GetProjectListResponse> GetProjectList(GetProjectListRequest req)
        {
            return InternalRequestAsync<GetProjectListResponse>(req, "GetProjectList");
        }

        /// <summary>
        /// 提供查询用户所创建的项目列表查询功能。
        /// </summary>
        /// <param name="req"><see cref="GetProjectListRequest"/></param>
        /// <returns><see cref="GetProjectListResponse"/></returns>
        public GetProjectListResponse GetProjectListSync(GetProjectListRequest req)
        {
            return InternalRequestAsync<GetProjectListResponse>(req, "GetProjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供查询某个项目下所有产品信息的能力。
        /// </summary>
        /// <param name="req"><see cref="GetStudioProductListRequest"/></param>
        /// <returns><see cref="GetStudioProductListResponse"/></returns>
        public Task<GetStudioProductListResponse> GetStudioProductList(GetStudioProductListRequest req)
        {
            return InternalRequestAsync<GetStudioProductListResponse>(req, "GetStudioProductList");
        }

        /// <summary>
        /// 提供查询某个项目下所有产品信息的能力。
        /// </summary>
        /// <param name="req"><see cref="GetStudioProductListRequest"/></param>
        /// <returns><see cref="GetStudioProductListResponse"/></returns>
        public GetStudioProductListResponse GetStudioProductListSync(GetStudioProductListRequest req)
        {
            return InternalRequestAsync<GetStudioProductListResponse>(req, "GetStudioProductList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询激活状态
        /// </summary>
        /// <param name="req"><see cref="GetTWeCallActiveStatusRequest"/></param>
        /// <returns><see cref="GetTWeCallActiveStatusResponse"/></returns>
        public Task<GetTWeCallActiveStatusResponse> GetTWeCallActiveStatus(GetTWeCallActiveStatusRequest req)
        {
            return InternalRequestAsync<GetTWeCallActiveStatusResponse>(req, "GetTWeCallActiveStatus");
        }

        /// <summary>
        /// 查询激活状态
        /// </summary>
        /// <param name="req"><see cref="GetTWeCallActiveStatusRequest"/></param>
        /// <returns><see cref="GetTWeCallActiveStatusResponse"/></returns>
        public GetTWeCallActiveStatusResponse GetTWeCallActiveStatusSync(GetTWeCallActiveStatusRequest req)
        {
            return InternalRequestAsync<GetTWeCallActiveStatusResponse>(req, "GetTWeCallActiveStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取规则列表
        /// </summary>
        /// <param name="req"><see cref="GetTopicRuleListRequest"/></param>
        /// <returns><see cref="GetTopicRuleListResponse"/></returns>
        public Task<GetTopicRuleListResponse> GetTopicRuleList(GetTopicRuleListRequest req)
        {
            return InternalRequestAsync<GetTopicRuleListResponse>(req, "GetTopicRuleList");
        }

        /// <summary>
        /// 获取规则列表
        /// </summary>
        /// <param name="req"><see cref="GetTopicRuleListRequest"/></param>
        /// <returns><see cref="GetTopicRuleListResponse"/></returns>
        public GetTopicRuleListResponse GetTopicRuleListSync(GetTopicRuleListRequest req)
        {
            return InternalRequestAsync<GetTopicRuleListResponse>(req, "GetTopicRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询微信设备授权票据
        /// </summary>
        /// <param name="req"><see cref="GetWechatDeviceTicketRequest"/></param>
        /// <returns><see cref="GetWechatDeviceTicketResponse"/></returns>
        public Task<GetWechatDeviceTicketResponse> GetWechatDeviceTicket(GetWechatDeviceTicketRequest req)
        {
            return InternalRequestAsync<GetWechatDeviceTicketResponse>(req, "GetWechatDeviceTicket");
        }

        /// <summary>
        /// 查询微信设备授权票据
        /// </summary>
        /// <param name="req"><see cref="GetWechatDeviceTicketRequest"/></param>
        /// <returns><see cref="GetWechatDeviceTicketResponse"/></returns>
        public GetWechatDeviceTicketResponse GetWechatDeviceTicketSync(GetWechatDeviceTicketRequest req)
        {
            return InternalRequestAsync<GetWechatDeviceTicketResponse>(req, "GetWechatDeviceTicket")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 继承云存用户
        /// </summary>
        /// <param name="req"><see cref="InheritCloudStorageUserRequest"/></param>
        /// <returns><see cref="InheritCloudStorageUserResponse"/></returns>
        public Task<InheritCloudStorageUserResponse> InheritCloudStorageUser(InheritCloudStorageUserRequest req)
        {
            return InternalRequestAsync<InheritCloudStorageUserResponse>(req, "InheritCloudStorageUser");
        }

        /// <summary>
        /// 继承云存用户
        /// </summary>
        /// <param name="req"><see cref="InheritCloudStorageUserRequest"/></param>
        /// <returns><see cref="InheritCloudStorageUserResponse"/></returns>
        public InheritCloudStorageUserResponse InheritCloudStorageUserSync(InheritCloudStorageUserRequest req)
        {
            return InternalRequestAsync<InheritCloudStorageUserResponse>(req, "InheritCloudStorageUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 视频语义搜索
        /// </summary>
        /// <param name="req"><see cref="InvokeAISearchServiceRequest"/></param>
        /// <returns><see cref="InvokeAISearchServiceResponse"/></returns>
        public Task<InvokeAISearchServiceResponse> InvokeAISearchService(InvokeAISearchServiceRequest req)
        {
            return InternalRequestAsync<InvokeAISearchServiceResponse>(req, "InvokeAISearchService");
        }

        /// <summary>
        /// 视频语义搜索
        /// </summary>
        /// <param name="req"><see cref="InvokeAISearchServiceRequest"/></param>
        /// <returns><see cref="InvokeAISearchServiceResponse"/></returns>
        public InvokeAISearchServiceResponse InvokeAISearchServiceSync(InvokeAISearchServiceRequest req)
        {
            return InternalRequestAsync<InvokeAISearchServiceResponse>(req, "InvokeAISearchService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步执行设备云存 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="InvokeCloudStorageAIServiceTaskRequest"/></param>
        /// <returns><see cref="InvokeCloudStorageAIServiceTaskResponse"/></returns>
        public Task<InvokeCloudStorageAIServiceTaskResponse> InvokeCloudStorageAIServiceTask(InvokeCloudStorageAIServiceTaskRequest req)
        {
            return InternalRequestAsync<InvokeCloudStorageAIServiceTaskResponse>(req, "InvokeCloudStorageAIServiceTask");
        }

        /// <summary>
        /// 同步执行设备云存 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="InvokeCloudStorageAIServiceTaskRequest"/></param>
        /// <returns><see cref="InvokeCloudStorageAIServiceTaskResponse"/></returns>
        public InvokeCloudStorageAIServiceTaskResponse InvokeCloudStorageAIServiceTaskSync(InvokeCloudStorageAIServiceTaskRequest req)
        {
            return InternalRequestAsync<InvokeCloudStorageAIServiceTaskResponse>(req, "InvokeCloudStorageAIServiceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建外部视频 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="InvokeExternalSourceAIServiceTaskRequest"/></param>
        /// <returns><see cref="InvokeExternalSourceAIServiceTaskResponse"/></returns>
        public Task<InvokeExternalSourceAIServiceTaskResponse> InvokeExternalSourceAIServiceTask(InvokeExternalSourceAIServiceTaskRequest req)
        {
            return InternalRequestAsync<InvokeExternalSourceAIServiceTaskResponse>(req, "InvokeExternalSourceAIServiceTask");
        }

        /// <summary>
        /// 创建外部视频 AI 分析任务
        /// </summary>
        /// <param name="req"><see cref="InvokeExternalSourceAIServiceTaskRequest"/></param>
        /// <returns><see cref="InvokeExternalSourceAIServiceTaskResponse"/></returns>
        public InvokeExternalSourceAIServiceTaskResponse InvokeExternalSourceAIServiceTaskSync(InvokeExternalSourceAIServiceTaskRequest req)
        {
            return InternalRequestAsync<InvokeExternalSourceAIServiceTaskResponse>(req, "InvokeExternalSourceAIServiceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步执行 TWeSee 语义理解任务
        /// </summary>
        /// <param name="req"><see cref="InvokeTWeSeeRecognitionTaskRequest"/></param>
        /// <returns><see cref="InvokeTWeSeeRecognitionTaskResponse"/></returns>
        public Task<InvokeTWeSeeRecognitionTaskResponse> InvokeTWeSeeRecognitionTask(InvokeTWeSeeRecognitionTaskRequest req)
        {
            return InternalRequestAsync<InvokeTWeSeeRecognitionTaskResponse>(req, "InvokeTWeSeeRecognitionTask");
        }

        /// <summary>
        /// 同步执行 TWeSee 语义理解任务
        /// </summary>
        /// <param name="req"><see cref="InvokeTWeSeeRecognitionTaskRequest"/></param>
        /// <returns><see cref="InvokeTWeSeeRecognitionTaskResponse"/></returns>
        public InvokeTWeSeeRecognitionTaskResponse InvokeTWeSeeRecognitionTaskSync(InvokeTWeSeeRecognitionTaskRequest req)
        {
            return InternalRequestAsync<InvokeTWeSeeRecognitionTaskResponse>(req, "InvokeTWeSeeRecognitionTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取某个时间段的视频内容关键字
        /// </summary>
        /// <param name="req"><see cref="InvokeVideosKeywordsAnalyzerRequest"/></param>
        /// <returns><see cref="InvokeVideosKeywordsAnalyzerResponse"/></returns>
        public Task<InvokeVideosKeywordsAnalyzerResponse> InvokeVideosKeywordsAnalyzer(InvokeVideosKeywordsAnalyzerRequest req)
        {
            return InternalRequestAsync<InvokeVideosKeywordsAnalyzerResponse>(req, "InvokeVideosKeywordsAnalyzer");
        }

        /// <summary>
        /// 获取某个时间段的视频内容关键字
        /// </summary>
        /// <param name="req"><see cref="InvokeVideosKeywordsAnalyzerRequest"/></param>
        /// <returns><see cref="InvokeVideosKeywordsAnalyzerResponse"/></returns>
        public InvokeVideosKeywordsAnalyzerResponse InvokeVideosKeywordsAnalyzerSync(InvokeVideosKeywordsAnalyzerRequest req)
        {
            return InternalRequestAsync<InvokeVideosKeywordsAnalyzerResponse>(req, "InvokeVideosKeywordsAnalyzer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备的历史事件
        /// </summary>
        /// <param name="req"><see cref="ListEventHistoryRequest"/></param>
        /// <returns><see cref="ListEventHistoryResponse"/></returns>
        public Task<ListEventHistoryResponse> ListEventHistory(ListEventHistoryRequest req)
        {
            return InternalRequestAsync<ListEventHistoryResponse>(req, "ListEventHistory");
        }

        /// <summary>
        /// 获取设备的历史事件
        /// </summary>
        /// <param name="req"><see cref="ListEventHistoryRequest"/></param>
        /// <returns><see cref="ListEventHistoryResponse"/></returns>
        public ListEventHistoryResponse ListEventHistorySync(ListEventHistoryRequest req)
        {
            return InternalRequestAsync<ListEventHistoryResponse>(req, "ListEventHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListFirmwares）用于获取固件列表
        /// </summary>
        /// <param name="req"><see cref="ListFirmwaresRequest"/></param>
        /// <returns><see cref="ListFirmwaresResponse"/></returns>
        public Task<ListFirmwaresResponse> ListFirmwares(ListFirmwaresRequest req)
        {
            return InternalRequestAsync<ListFirmwaresResponse>(req, "ListFirmwares");
        }

        /// <summary>
        /// 本接口（ListFirmwares）用于获取固件列表
        /// </summary>
        /// <param name="req"><see cref="ListFirmwaresRequest"/></param>
        /// <returns><see cref="ListFirmwaresResponse"/></returns>
        public ListFirmwaresResponse ListFirmwaresSync(ListFirmwaresRequest req)
        {
            return InternalRequestAsync<ListFirmwaresResponse>(req, "ListFirmwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListTopicPolicy）用于获取Topic列表
        /// </summary>
        /// <param name="req"><see cref="ListTopicPolicyRequest"/></param>
        /// <returns><see cref="ListTopicPolicyResponse"/></returns>
        public Task<ListTopicPolicyResponse> ListTopicPolicy(ListTopicPolicyRequest req)
        {
            return InternalRequestAsync<ListTopicPolicyResponse>(req, "ListTopicPolicy");
        }

        /// <summary>
        /// 本接口（ListTopicPolicy）用于获取Topic列表
        /// </summary>
        /// <param name="req"><see cref="ListTopicPolicyRequest"/></param>
        /// <returns><see cref="ListTopicPolicyResponse"/></returns>
        public ListTopicPolicyResponse ListTopicPolicySync(ListTopicPolicyRequest req)
        {
            return InternalRequestAsync<ListTopicPolicyResponse>(req, "ListTopicPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新应用信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication");
        }

        /// <summary>
        /// 更新应用信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改指定设备的云存 AI 服务参数配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudStorageAIServiceResponse"/></returns>
        public Task<ModifyCloudStorageAIServiceResponse> ModifyCloudStorageAIService(ModifyCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudStorageAIServiceResponse>(req, "ModifyCloudStorageAIService");
        }

        /// <summary>
        /// 修改指定设备的云存 AI 服务参数配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudStorageAIServiceResponse"/></returns>
        public ModifyCloudStorageAIServiceResponse ModifyCloudStorageAIServiceSync(ModifyCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudStorageAIServiceResponse>(req, "ModifyCloudStorageAIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云存AI分析回调配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudStorageAIServiceCallbackRequest"/></param>
        /// <returns><see cref="ModifyCloudStorageAIServiceCallbackResponse"/></returns>
        public Task<ModifyCloudStorageAIServiceCallbackResponse> ModifyCloudStorageAIServiceCallback(ModifyCloudStorageAIServiceCallbackRequest req)
        {
            return InternalRequestAsync<ModifyCloudStorageAIServiceCallbackResponse>(req, "ModifyCloudStorageAIServiceCallback");
        }

        /// <summary>
        /// 修改云存AI分析回调配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudStorageAIServiceCallbackRequest"/></param>
        /// <returns><see cref="ModifyCloudStorageAIServiceCallbackResponse"/></returns>
        public ModifyCloudStorageAIServiceCallbackResponse ModifyCloudStorageAIServiceCallbackSync(ModifyCloudStorageAIServiceCallbackRequest req)
        {
            return InternalRequestAsync<ModifyCloudStorageAIServiceCallbackResponse>(req, "ModifyCloudStorageAIServiceCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新围栏绑定信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyFenceBindRequest"/></param>
        /// <returns><see cref="ModifyFenceBindResponse"/></returns>
        public Task<ModifyFenceBindResponse> ModifyFenceBind(ModifyFenceBindRequest req)
        {
            return InternalRequestAsync<ModifyFenceBindResponse>(req, "ModifyFenceBind");
        }

        /// <summary>
        /// 更新围栏绑定信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyFenceBindRequest"/></param>
        /// <returns><see cref="ModifyFenceBindResponse"/></returns>
        public ModifyFenceBindResponse ModifyFenceBindSync(ModifyFenceBindRequest req)
        {
            return InternalRequestAsync<ModifyFenceBindResponse>(req, "ModifyFenceBind")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改LoRa自定义频点
        /// </summary>
        /// <param name="req"><see cref="ModifyLoRaFrequencyRequest"/></param>
        /// <returns><see cref="ModifyLoRaFrequencyResponse"/></returns>
        public Task<ModifyLoRaFrequencyResponse> ModifyLoRaFrequency(ModifyLoRaFrequencyRequest req)
        {
            return InternalRequestAsync<ModifyLoRaFrequencyResponse>(req, "ModifyLoRaFrequency");
        }

        /// <summary>
        /// 修改LoRa自定义频点
        /// </summary>
        /// <param name="req"><see cref="ModifyLoRaFrequencyRequest"/></param>
        /// <returns><see cref="ModifyLoRaFrequencyResponse"/></returns>
        public ModifyLoRaFrequencyResponse ModifyLoRaFrequencySync(ModifyLoRaFrequencyRequest req)
        {
            return InternalRequestAsync<ModifyLoRaFrequencyResponse>(req, "ModifyLoRaFrequency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 LoRa 网关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLoRaGatewayRequest"/></param>
        /// <returns><see cref="ModifyLoRaGatewayResponse"/></returns>
        public Task<ModifyLoRaGatewayResponse> ModifyLoRaGateway(ModifyLoRaGatewayRequest req)
        {
            return InternalRequestAsync<ModifyLoRaGatewayResponse>(req, "ModifyLoRaGateway");
        }

        /// <summary>
        /// 修改 LoRa 网关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLoRaGatewayRequest"/></param>
        /// <returns><see cref="ModifyLoRaGatewayResponse"/></returns>
        public ModifyLoRaGatewayResponse ModifyLoRaGatewaySync(ModifyLoRaGatewayRequest req)
        {
            return InternalRequestAsync<ModifyLoRaGatewayResponse>(req, "ModifyLoRaGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供修改产品的数据模板的能力
        /// </summary>
        /// <param name="req"><see cref="ModifyModelDefinitionRequest"/></param>
        /// <returns><see cref="ModifyModelDefinitionResponse"/></returns>
        public Task<ModifyModelDefinitionResponse> ModifyModelDefinition(ModifyModelDefinitionRequest req)
        {
            return InternalRequestAsync<ModifyModelDefinitionResponse>(req, "ModifyModelDefinition");
        }

        /// <summary>
        /// 提供修改产品的数据模板的能力
        /// </summary>
        /// <param name="req"><see cref="ModifyModelDefinitionRequest"/></param>
        /// <returns><see cref="ModifyModelDefinitionResponse"/></returns>
        public ModifyModelDefinitionResponse ModifyModelDefinitionSync(ModifyModelDefinitionRequest req)
        {
            return InternalRequestAsync<ModifyModelDefinitionResponse>(req, "ModifyModelDefinition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新围栏。
        /// </summary>
        /// <param name="req"><see cref="ModifyPositionFenceRequest"/></param>
        /// <returns><see cref="ModifyPositionFenceResponse"/></returns>
        public Task<ModifyPositionFenceResponse> ModifyPositionFence(ModifyPositionFenceRequest req)
        {
            return InternalRequestAsync<ModifyPositionFenceResponse>(req, "ModifyPositionFence");
        }

        /// <summary>
        /// 更新围栏。
        /// </summary>
        /// <param name="req"><see cref="ModifyPositionFenceRequest"/></param>
        /// <returns><see cref="ModifyPositionFenceResponse"/></returns>
        public ModifyPositionFenceResponse ModifyPositionFenceSync(ModifyPositionFenceRequest req)
        {
            return InternalRequestAsync<ModifyPositionFenceResponse>(req, "ModifyPositionFence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新位置空间。
        /// </summary>
        /// <param name="req"><see cref="ModifyPositionSpaceRequest"/></param>
        /// <returns><see cref="ModifyPositionSpaceResponse"/></returns>
        public Task<ModifyPositionSpaceResponse> ModifyPositionSpace(ModifyPositionSpaceRequest req)
        {
            return InternalRequestAsync<ModifyPositionSpaceResponse>(req, "ModifyPositionSpace");
        }

        /// <summary>
        /// 更新位置空间。
        /// </summary>
        /// <param name="req"><see cref="ModifyPositionSpaceRequest"/></param>
        /// <returns><see cref="ModifyPositionSpaceResponse"/></returns>
        public ModifyPositionSpaceResponse ModifyPositionSpaceSync(ModifyPositionSpaceRequest req)
        {
            return InternalRequestAsync<ModifyPositionSpaceResponse>(req, "ModifyPositionSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改指定产品的云存 AI 服务开通状态
        /// </summary>
        /// <param name="req"><see cref="ModifyProductCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="ModifyProductCloudStorageAIServiceResponse"/></returns>
        public Task<ModifyProductCloudStorageAIServiceResponse> ModifyProductCloudStorageAIService(ModifyProductCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<ModifyProductCloudStorageAIServiceResponse>(req, "ModifyProductCloudStorageAIService");
        }

        /// <summary>
        /// 修改指定产品的云存 AI 服务开通状态
        /// </summary>
        /// <param name="req"><see cref="ModifyProductCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="ModifyProductCloudStorageAIServiceResponse"/></returns>
        public ModifyProductCloudStorageAIServiceResponse ModifyProductCloudStorageAIServiceSync(ModifyProductCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<ModifyProductCloudStorageAIServiceResponse>(req, "ModifyProductCloudStorageAIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// 修改项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新位置空间产品属性
        /// </summary>
        /// <param name="req"><see cref="ModifySpacePropertyRequest"/></param>
        /// <returns><see cref="ModifySpacePropertyResponse"/></returns>
        public Task<ModifySpacePropertyResponse> ModifySpaceProperty(ModifySpacePropertyRequest req)
        {
            return InternalRequestAsync<ModifySpacePropertyResponse>(req, "ModifySpaceProperty");
        }

        /// <summary>
        /// 更新位置空间产品属性
        /// </summary>
        /// <param name="req"><see cref="ModifySpacePropertyRequest"/></param>
        /// <returns><see cref="ModifySpacePropertyResponse"/></returns>
        public ModifySpacePropertyResponse ModifySpacePropertySync(ModifySpacePropertyRequest req)
        {
            return InternalRequestAsync<ModifySpacePropertyResponse>(req, "ModifySpaceProperty")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供修改产品的名称和描述等信息的能力，对于已发布产品不允许进行修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyStudioProductRequest"/></param>
        /// <returns><see cref="ModifyStudioProductResponse"/></returns>
        public Task<ModifyStudioProductResponse> ModifyStudioProduct(ModifyStudioProductRequest req)
        {
            return InternalRequestAsync<ModifyStudioProductResponse>(req, "ModifyStudioProduct");
        }

        /// <summary>
        /// 提供修改产品的名称和描述等信息的能力，对于已发布产品不允许进行修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyStudioProductRequest"/></param>
        /// <returns><see cref="ModifyStudioProductResponse"/></returns>
        public ModifyStudioProductResponse ModifyStudioProductSync(ModifyStudioProductRequest req)
        {
            return InternalRequestAsync<ModifyStudioProductResponse>(req, "ModifyStudioProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 TWeSee 配置
        /// </summary>
        /// <param name="req"><see cref="ModifyTWeSeeConfigRequest"/></param>
        /// <returns><see cref="ModifyTWeSeeConfigResponse"/></returns>
        public Task<ModifyTWeSeeConfigResponse> ModifyTWeSeeConfig(ModifyTWeSeeConfigRequest req)
        {
            return InternalRequestAsync<ModifyTWeSeeConfigResponse>(req, "ModifyTWeSeeConfig");
        }

        /// <summary>
        /// 修改 TWeSee 配置
        /// </summary>
        /// <param name="req"><see cref="ModifyTWeSeeConfigRequest"/></param>
        /// <returns><see cref="ModifyTWeSeeConfigResponse"/></returns>
        public ModifyTWeSeeConfigResponse ModifyTWeSeeConfigSync(ModifyTWeSeeConfigRequest req)
        {
            return InternalRequestAsync<ModifyTWeSeeConfigResponse>(req, "ModifyTWeSeeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateTopicPolicy）用于更新Topic信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicPolicyRequest"/></param>
        /// <returns><see cref="ModifyTopicPolicyResponse"/></returns>
        public Task<ModifyTopicPolicyResponse> ModifyTopicPolicy(ModifyTopicPolicyRequest req)
        {
            return InternalRequestAsync<ModifyTopicPolicyResponse>(req, "ModifyTopicPolicy");
        }

        /// <summary>
        /// 本接口（UpdateTopicPolicy）用于更新Topic信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicPolicyRequest"/></param>
        /// <returns><see cref="ModifyTopicPolicyResponse"/></returns>
        public ModifyTopicPolicyResponse ModifyTopicPolicySync(ModifyTopicPolicyRequest req)
        {
            return InternalRequestAsync<ModifyTopicPolicyResponse>(req, "ModifyTopicPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRuleRequest"/></param>
        /// <returns><see cref="ModifyTopicRuleResponse"/></returns>
        public Task<ModifyTopicRuleResponse> ModifyTopicRule(ModifyTopicRuleRequest req)
        {
            return InternalRequestAsync<ModifyTopicRuleResponse>(req, "ModifyTopicRule");
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRuleRequest"/></param>
        /// <returns><see cref="ModifyTopicRuleResponse"/></returns>
        public ModifyTopicRuleResponse ModifyTopicRuleSync(ModifyTopicRuleRequest req)
        {
            return InternalRequestAsync<ModifyTopicRuleResponse>(req, "ModifyTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停设备
        /// </summary>
        /// <param name="req"><see cref="PauseTWeCallDeviceRequest"/></param>
        /// <returns><see cref="PauseTWeCallDeviceResponse"/></returns>
        public Task<PauseTWeCallDeviceResponse> PauseTWeCallDevice(PauseTWeCallDeviceRequest req)
        {
            return InternalRequestAsync<PauseTWeCallDeviceResponse>(req, "PauseTWeCallDevice");
        }

        /// <summary>
        /// 暂停设备
        /// </summary>
        /// <param name="req"><see cref="PauseTWeCallDeviceRequest"/></param>
        /// <returns><see cref="PauseTWeCallDeviceResponse"/></returns>
        public PauseTWeCallDeviceResponse PauseTWeCallDeviceSync(PauseTWeCallDeviceRequest req)
        {
            return InternalRequestAsync<PauseTWeCallDeviceResponse>(req, "PauseTWeCallDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布广播消息、发布RRPC消息属于早期服务，目前已停止维护，需要从官网下线。
        /// 
        /// 发布广播消息
        /// </summary>
        /// <param name="req"><see cref="PublishBroadcastMessageRequest"/></param>
        /// <returns><see cref="PublishBroadcastMessageResponse"/></returns>
        public Task<PublishBroadcastMessageResponse> PublishBroadcastMessage(PublishBroadcastMessageRequest req)
        {
            return InternalRequestAsync<PublishBroadcastMessageResponse>(req, "PublishBroadcastMessage");
        }

        /// <summary>
        /// 发布广播消息、发布RRPC消息属于早期服务，目前已停止维护，需要从官网下线。
        /// 
        /// 发布广播消息
        /// </summary>
        /// <param name="req"><see cref="PublishBroadcastMessageRequest"/></param>
        /// <returns><see cref="PublishBroadcastMessageResponse"/></returns>
        public PublishBroadcastMessageResponse PublishBroadcastMessageSync(PublishBroadcastMessageRequest req)
        {
            return InternalRequestAsync<PublishBroadcastMessageResponse>(req, "PublishBroadcastMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（PublishFirmwareUpdateMessage）用于用户确认升级后，云端向设备发起固件升级请求。
        /// </summary>
        /// <param name="req"><see cref="PublishFirmwareUpdateMessageRequest"/></param>
        /// <returns><see cref="PublishFirmwareUpdateMessageResponse"/></returns>
        public Task<PublishFirmwareUpdateMessageResponse> PublishFirmwareUpdateMessage(PublishFirmwareUpdateMessageRequest req)
        {
            return InternalRequestAsync<PublishFirmwareUpdateMessageResponse>(req, "PublishFirmwareUpdateMessage");
        }

        /// <summary>
        /// 本接口（PublishFirmwareUpdateMessage）用于用户确认升级后，云端向设备发起固件升级请求。
        /// </summary>
        /// <param name="req"><see cref="PublishFirmwareUpdateMessageRequest"/></param>
        /// <returns><see cref="PublishFirmwareUpdateMessageResponse"/></returns>
        public PublishFirmwareUpdateMessageResponse PublishFirmwareUpdateMessageSync(PublishFirmwareUpdateMessageRequest req)
        {
            return InternalRequestAsync<PublishFirmwareUpdateMessageResponse>(req, "PublishFirmwareUpdateMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（PublishMessage）用于使用自定义透传协议进行设备远控
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public Task<PublishMessageResponse> PublishMessage(PublishMessageRequest req)
        {
            return InternalRequestAsync<PublishMessageResponse>(req, "PublishMessage");
        }

        /// <summary>
        /// 本接口（PublishMessage）用于使用自定义透传协议进行设备远控
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public PublishMessageResponse PublishMessageSync(PublishMessageRequest req)
        {
            return InternalRequestAsync<PublishMessageResponse>(req, "PublishMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布广播消息、发布RRPC消息属于早期服务，目前已停止维护，需要从官网下线。
        /// 
        /// 下发RRPC消息
        /// </summary>
        /// <param name="req"><see cref="PublishRRPCMessageRequest"/></param>
        /// <returns><see cref="PublishRRPCMessageResponse"/></returns>
        public Task<PublishRRPCMessageResponse> PublishRRPCMessage(PublishRRPCMessageRequest req)
        {
            return InternalRequestAsync<PublishRRPCMessageResponse>(req, "PublishRRPCMessage");
        }

        /// <summary>
        /// 发布广播消息、发布RRPC消息属于早期服务，目前已停止维护，需要从官网下线。
        /// 
        /// 下发RRPC消息
        /// </summary>
        /// <param name="req"><see cref="PublishRRPCMessageRequest"/></param>
        /// <returns><see cref="PublishRRPCMessageResponse"/></returns>
        public PublishRRPCMessageResponse PublishRRPCMessageSync(PublishRRPCMessageRequest req)
        {
            return InternalRequestAsync<PublishRRPCMessageResponse>(req, "PublishRRPCMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 产品开发完成并测试通过后，通过发布产品将产品设置为发布状态
        /// </summary>
        /// <param name="req"><see cref="ReleaseStudioProductRequest"/></param>
        /// <returns><see cref="ReleaseStudioProductResponse"/></returns>
        public Task<ReleaseStudioProductResponse> ReleaseStudioProduct(ReleaseStudioProductRequest req)
        {
            return InternalRequestAsync<ReleaseStudioProductResponse>(req, "ReleaseStudioProduct");
        }

        /// <summary>
        /// 产品开发完成并测试通过后，通过发布产品将产品设置为发布状态
        /// </summary>
        /// <param name="req"><see cref="ReleaseStudioProductRequest"/></param>
        /// <returns><see cref="ReleaseStudioProductResponse"/></returns>
        public ReleaseStudioProductResponse ReleaseStudioProductSync(ReleaseStudioProductRequest req)
        {
            return InternalRequestAsync<ReleaseStudioProductResponse>(req, "ReleaseStudioProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// TRTC操作，将用户从房间移出
        /// </summary>
        /// <param name="req"><see cref="RemoveUserByRoomIdFromTRTCRequest"/></param>
        /// <returns><see cref="RemoveUserByRoomIdFromTRTCResponse"/></returns>
        public Task<RemoveUserByRoomIdFromTRTCResponse> RemoveUserByRoomIdFromTRTC(RemoveUserByRoomIdFromTRTCRequest req)
        {
            return InternalRequestAsync<RemoveUserByRoomIdFromTRTCResponse>(req, "RemoveUserByRoomIdFromTRTC");
        }

        /// <summary>
        /// TRTC操作，将用户从房间移出
        /// </summary>
        /// <param name="req"><see cref="RemoveUserByRoomIdFromTRTCRequest"/></param>
        /// <returns><see cref="RemoveUserByRoomIdFromTRTCResponse"/></returns>
        public RemoveUserByRoomIdFromTRTCResponse RemoveUserByRoomIdFromTRTCSync(RemoveUserByRoomIdFromTRTCRequest req)
        {
            return InternalRequestAsync<RemoveUserByRoomIdFromTRTCResponse>(req, "RemoveUserByRoomIdFromTRTC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置云存服务
        /// </summary>
        /// <param name="req"><see cref="ResetCloudStorageRequest"/></param>
        /// <returns><see cref="ResetCloudStorageResponse"/></returns>
        public Task<ResetCloudStorageResponse> ResetCloudStorage(ResetCloudStorageRequest req)
        {
            return InternalRequestAsync<ResetCloudStorageResponse>(req, "ResetCloudStorage");
        }

        /// <summary>
        /// 重置云存服务
        /// </summary>
        /// <param name="req"><see cref="ResetCloudStorageRequest"/></param>
        /// <returns><see cref="ResetCloudStorageResponse"/></returns>
        public ResetCloudStorageResponse ResetCloudStorageSync(ResetCloudStorageRequest req)
        {
            return InternalRequestAsync<ResetCloudStorageResponse>(req, "ResetCloudStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置指定设备的云存 AI 服务
        /// </summary>
        /// <param name="req"><see cref="ResetCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="ResetCloudStorageAIServiceResponse"/></returns>
        public Task<ResetCloudStorageAIServiceResponse> ResetCloudStorageAIService(ResetCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<ResetCloudStorageAIServiceResponse>(req, "ResetCloudStorageAIService");
        }

        /// <summary>
        /// 重置指定设备的云存 AI 服务
        /// </summary>
        /// <param name="req"><see cref="ResetCloudStorageAIServiceRequest"/></param>
        /// <returns><see cref="ResetCloudStorageAIServiceResponse"/></returns>
        public ResetCloudStorageAIServiceResponse ResetCloudStorageAIServiceSync(ResetCloudStorageAIServiceRequest req)
        {
            return InternalRequestAsync<ResetCloudStorageAIServiceResponse>(req, "ResetCloudStorageAIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置云存事件
        /// </summary>
        /// <param name="req"><see cref="ResetCloudStorageEventRequest"/></param>
        /// <returns><see cref="ResetCloudStorageEventResponse"/></returns>
        public Task<ResetCloudStorageEventResponse> ResetCloudStorageEvent(ResetCloudStorageEventRequest req)
        {
            return InternalRequestAsync<ResetCloudStorageEventResponse>(req, "ResetCloudStorageEvent");
        }

        /// <summary>
        /// 重置云存事件
        /// </summary>
        /// <param name="req"><see cref="ResetCloudStorageEventRequest"/></param>
        /// <returns><see cref="ResetCloudStorageEventResponse"/></returns>
        public ResetCloudStorageEventResponse ResetCloudStorageEventSync(ResetCloudStorageEventRequest req)
        {
            return InternalRequestAsync<ResetCloudStorageEventResponse>(req, "ResetCloudStorageEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置设备
        /// </summary>
        /// <param name="req"><see cref="ResetTWeCallDeviceRequest"/></param>
        /// <returns><see cref="ResetTWeCallDeviceResponse"/></returns>
        public Task<ResetTWeCallDeviceResponse> ResetTWeCallDevice(ResetTWeCallDeviceRequest req)
        {
            return InternalRequestAsync<ResetTWeCallDeviceResponse>(req, "ResetTWeCallDevice");
        }

        /// <summary>
        /// 重置设备
        /// </summary>
        /// <param name="req"><see cref="ResetTWeCallDeviceRequest"/></param>
        /// <returns><see cref="ResetTWeCallDeviceResponse"/></returns>
        public ResetTWeCallDeviceResponse ResetTWeCallDeviceSync(ResetTWeCallDeviceRequest req)
        {
            return InternalRequestAsync<ResetTWeCallDeviceResponse>(req, "ResetTWeCallDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复设备
        /// </summary>
        /// <param name="req"><see cref="ResumeWeCallDeviceRequest"/></param>
        /// <returns><see cref="ResumeWeCallDeviceResponse"/></returns>
        public Task<ResumeWeCallDeviceResponse> ResumeWeCallDevice(ResumeWeCallDeviceRequest req)
        {
            return InternalRequestAsync<ResumeWeCallDeviceResponse>(req, "ResumeWeCallDevice");
        }

        /// <summary>
        /// 恢复设备
        /// </summary>
        /// <param name="req"><see cref="ResumeWeCallDeviceRequest"/></param>
        /// <returns><see cref="ResumeWeCallDeviceResponse"/></returns>
        public ResumeWeCallDeviceResponse ResumeWeCallDeviceSync(ResumeWeCallDeviceRequest req)
        {
            return InternalRequestAsync<ResumeWeCallDeviceResponse>(req, "ResumeWeCallDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 搜索位置空间
        /// </summary>
        /// <param name="req"><see cref="SearchPositionSpaceRequest"/></param>
        /// <returns><see cref="SearchPositionSpaceResponse"/></returns>
        public Task<SearchPositionSpaceResponse> SearchPositionSpace(SearchPositionSpaceRequest req)
        {
            return InternalRequestAsync<SearchPositionSpaceResponse>(req, "SearchPositionSpace");
        }

        /// <summary>
        /// 搜索位置空间
        /// </summary>
        /// <param name="req"><see cref="SearchPositionSpaceRequest"/></param>
        /// <returns><see cref="SearchPositionSpaceResponse"/></returns>
        public SearchPositionSpaceResponse SearchPositionSpaceSync(SearchPositionSpaceRequest req)
        {
            return InternalRequestAsync<SearchPositionSpaceResponse>(req, "SearchPositionSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供根据产品名称查找产品的能力
        /// </summary>
        /// <param name="req"><see cref="SearchStudioProductRequest"/></param>
        /// <returns><see cref="SearchStudioProductResponse"/></returns>
        public Task<SearchStudioProductResponse> SearchStudioProduct(SearchStudioProductRequest req)
        {
            return InternalRequestAsync<SearchStudioProductResponse>(req, "SearchStudioProduct");
        }

        /// <summary>
        /// 提供根据产品名称查找产品的能力
        /// </summary>
        /// <param name="req"><see cref="SearchStudioProductRequest"/></param>
        /// <returns><see cref="SearchStudioProductResponse"/></returns>
        public SearchStudioProductResponse SearchStudioProductSync(SearchStudioProductRequest req)
        {
            return InternalRequestAsync<SearchStudioProductResponse>(req, "SearchStudioProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 搜索规则
        /// </summary>
        /// <param name="req"><see cref="SearchTopicRuleRequest"/></param>
        /// <returns><see cref="SearchTopicRuleResponse"/></returns>
        public Task<SearchTopicRuleResponse> SearchTopicRule(SearchTopicRuleRequest req)
        {
            return InternalRequestAsync<SearchTopicRuleResponse>(req, "SearchTopicRule");
        }

        /// <summary>
        /// 搜索规则
        /// </summary>
        /// <param name="req"><see cref="SearchTopicRuleRequest"/></param>
        /// <returns><see cref="SearchTopicRuleResponse"/></returns>
        public SearchTopicRuleResponse SearchTopicRuleSync(SearchTopicRuleRequest req)
        {
            return InternalRequestAsync<SearchTopicRuleResponse>(req, "SearchTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 转移云存服务
        /// </summary>
        /// <param name="req"><see cref="TransferCloudStorageRequest"/></param>
        /// <returns><see cref="TransferCloudStorageResponse"/></returns>
        public Task<TransferCloudStorageResponse> TransferCloudStorage(TransferCloudStorageRequest req)
        {
            return InternalRequestAsync<TransferCloudStorageResponse>(req, "TransferCloudStorage");
        }

        /// <summary>
        /// 转移云存服务
        /// </summary>
        /// <param name="req"><see cref="TransferCloudStorageRequest"/></param>
        /// <returns><see cref="TransferCloudStorageResponse"/></returns>
        public TransferCloudStorageResponse TransferCloudStorageSync(TransferCloudStorageRequest req)
        {
            return InternalRequestAsync<TransferCloudStorageResponse>(req, "TransferCloudStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 转移设备
        /// </summary>
        /// <param name="req"><see cref="TransferTWeCallDeviceRequest"/></param>
        /// <returns><see cref="TransferTWeCallDeviceResponse"/></returns>
        public Task<TransferTWeCallDeviceResponse> TransferTWeCallDevice(TransferTWeCallDeviceRequest req)
        {
            return InternalRequestAsync<TransferTWeCallDeviceResponse>(req, "TransferTWeCallDevice");
        }

        /// <summary>
        /// 转移设备
        /// </summary>
        /// <param name="req"><see cref="TransferTWeCallDeviceRequest"/></param>
        /// <returns><see cref="TransferTWeCallDeviceResponse"/></returns>
        public TransferTWeCallDeviceResponse TransferTWeCallDeviceSync(TransferTWeCallDeviceRequest req)
        {
            return InternalRequestAsync<TransferTWeCallDeviceResponse>(req, "TransferTWeCallDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量解绑子设备
        /// </summary>
        /// <param name="req"><see cref="UnbindDevicesRequest"/></param>
        /// <returns><see cref="UnbindDevicesResponse"/></returns>
        public Task<UnbindDevicesResponse> UnbindDevices(UnbindDevicesRequest req)
        {
            return InternalRequestAsync<UnbindDevicesResponse>(req, "UnbindDevices");
        }

        /// <summary>
        /// 批量解绑子设备
        /// </summary>
        /// <param name="req"><see cref="UnbindDevicesRequest"/></param>
        /// <returns><see cref="UnbindDevicesResponse"/></returns>
        public UnbindDevicesResponse UnbindDevicesSync(UnbindDevicesRequest req)
        {
            return InternalRequestAsync<UnbindDevicesResponse>(req, "UnbindDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量解绑子产品。
        /// </summary>
        /// <param name="req"><see cref="UnbindProductsRequest"/></param>
        /// <returns><see cref="UnbindProductsResponse"/></returns>
        public Task<UnbindProductsResponse> UnbindProducts(UnbindProductsRequest req)
        {
            return InternalRequestAsync<UnbindProductsResponse>(req, "UnbindProducts");
        }

        /// <summary>
        /// 批量解绑子产品。
        /// </summary>
        /// <param name="req"><see cref="UnbindProductsRequest"/></param>
        /// <returns><see cref="UnbindProductsResponse"/></returns>
        public UnbindProductsResponse UnbindProductsSync(UnbindProductsRequest req)
        {
            return InternalRequestAsync<UnbindProductsResponse>(req, "UnbindProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新用户对设备的TweCall授权状态
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceTWeCallAuthorizeStatusRequest"/></param>
        /// <returns><see cref="UpdateDeviceTWeCallAuthorizeStatusResponse"/></returns>
        public Task<UpdateDeviceTWeCallAuthorizeStatusResponse> UpdateDeviceTWeCallAuthorizeStatus(UpdateDeviceTWeCallAuthorizeStatusRequest req)
        {
            return InternalRequestAsync<UpdateDeviceTWeCallAuthorizeStatusResponse>(req, "UpdateDeviceTWeCallAuthorizeStatus");
        }

        /// <summary>
        /// 更新用户对设备的TweCall授权状态
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceTWeCallAuthorizeStatusRequest"/></param>
        /// <returns><see cref="UpdateDeviceTWeCallAuthorizeStatusResponse"/></returns>
        public UpdateDeviceTWeCallAuthorizeStatusResponse UpdateDeviceTWeCallAuthorizeStatusSync(UpdateDeviceTWeCallAuthorizeStatusRequest req)
        {
            return InternalRequestAsync<UpdateDeviceTWeCallAuthorizeStatusResponse>(req, "UpdateDeviceTWeCallAuthorizeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量禁用启用设备
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public Task<UpdateDevicesEnableStateResponse> UpdateDevicesEnableState(UpdateDevicesEnableStateRequest req)
        {
            return InternalRequestAsync<UpdateDevicesEnableStateResponse>(req, "UpdateDevicesEnableState");
        }

        /// <summary>
        /// 批量禁用启用设备
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public UpdateDevicesEnableStateResponse UpdateDevicesEnableStateSync(UpdateDevicesEnableStateRequest req)
        {
            return InternalRequestAsync<UpdateDevicesEnableStateResponse>(req, "UpdateDevicesEnableState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateFirmware）用于对指定设备发起固件升级请求
        /// </summary>
        /// <param name="req"><see cref="UpdateFirmwareRequest"/></param>
        /// <returns><see cref="UpdateFirmwareResponse"/></returns>
        public Task<UpdateFirmwareResponse> UpdateFirmware(UpdateFirmwareRequest req)
        {
            return InternalRequestAsync<UpdateFirmwareResponse>(req, "UpdateFirmware");
        }

        /// <summary>
        /// 本接口（UpdateFirmware）用于对指定设备发起固件升级请求
        /// </summary>
        /// <param name="req"><see cref="UpdateFirmwareRequest"/></param>
        /// <returns><see cref="UpdateFirmwareResponse"/></returns>
        public UpdateFirmwareResponse UpdateFirmwareSync(UpdateFirmwareRequest req)
        {
            return InternalRequestAsync<UpdateFirmwareResponse>(req, "UpdateFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UploadFirmware）用于创建设备固件版本信息，在平台用于固件版本升级、固件资源下发等。
        /// </summary>
        /// <param name="req"><see cref="UploadFirmwareRequest"/></param>
        /// <returns><see cref="UploadFirmwareResponse"/></returns>
        public Task<UploadFirmwareResponse> UploadFirmware(UploadFirmwareRequest req)
        {
            return InternalRequestAsync<UploadFirmwareResponse>(req, "UploadFirmware");
        }

        /// <summary>
        /// 本接口（UploadFirmware）用于创建设备固件版本信息，在平台用于固件版本升级、固件资源下发等。
        /// </summary>
        /// <param name="req"><see cref="UploadFirmwareRequest"/></param>
        /// <returns><see cref="UploadFirmwareResponse"/></returns>
        public UploadFirmwareResponse UploadFirmwareSync(UploadFirmwareRequest req)
        {
            return InternalRequestAsync<UploadFirmwareResponse>(req, "UploadFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
