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

namespace TencentCloud.Ump.V20200918
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ump.V20200918.Models;

   public class UmpClient : AbstractClient{

       private const string endpoint = "ump.tencentcloudapi.com";
       private const string version = "2020-09-18";
       private const string sdkVersion = "SDK_NET_3.0.1053";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public UmpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public UmpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报相机移动、遮挡等告警信息
        /// 
        /// </summary>
        /// <param name="req"><see cref="CreateCameraAlertsRequest"/></param>
        /// <returns><see cref="CreateCameraAlertsResponse"/></returns>
        public Task<CreateCameraAlertsResponse> CreateCameraAlerts(CreateCameraAlertsRequest req)
        {
            return InternalRequestAsync<CreateCameraAlertsResponse>(req, "CreateCameraAlerts");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报相机移动、遮挡等告警信息
        /// 
        /// </summary>
        /// <param name="req"><see cref="CreateCameraAlertsRequest"/></param>
        /// <returns><see cref="CreateCameraAlertsResponse"/></returns>
        public CreateCameraAlertsResponse CreateCameraAlertsSync(CreateCameraAlertsRequest req)
        {
            return InternalRequestAsync<CreateCameraAlertsResponse>(req, "CreateCameraAlerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报当前场内所有相机的当前状态
        /// </summary>
        /// <param name="req"><see cref="CreateCameraStateRequest"/></param>
        /// <returns><see cref="CreateCameraStateResponse"/></returns>
        public Task<CreateCameraStateResponse> CreateCameraState(CreateCameraStateRequest req)
        {
            return InternalRequestAsync<CreateCameraStateResponse>(req, "CreateCameraState");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报当前场内所有相机的当前状态
        /// </summary>
        /// <param name="req"><see cref="CreateCameraStateRequest"/></param>
        /// <returns><see cref="CreateCameraStateResponse"/></returns>
        public CreateCameraStateResponse CreateCameraStateSync(CreateCameraStateRequest req)
        {
            return InternalRequestAsync<CreateCameraStateResponse>(req, "CreateCameraState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品下线
        /// 
        /// 场内抓拍上报接口
        /// </summary>
        /// <param name="req"><see cref="CreateCaptureRequest"/></param>
        /// <returns><see cref="CreateCaptureResponse"/></returns>
        public Task<CreateCaptureResponse> CreateCapture(CreateCaptureRequest req)
        {
            return InternalRequestAsync<CreateCaptureResponse>(req, "CreateCapture");
        }

        /// <summary>
        /// 优mall产品下线
        /// 
        /// 场内抓拍上报接口
        /// </summary>
        /// <param name="req"><see cref="CreateCaptureRequest"/></param>
        /// <returns><see cref="CreateCaptureResponse"/></returns>
        public CreateCaptureResponse CreateCaptureSync(CreateCaptureRequest req)
        {
            return InternalRequestAsync<CreateCaptureResponse>(req, "CreateCapture")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 集团广场的多经点位告警
        /// </summary>
        /// <param name="req"><see cref="CreateMultiBizAlertRequest"/></param>
        /// <returns><see cref="CreateMultiBizAlertResponse"/></returns>
        public Task<CreateMultiBizAlertResponse> CreateMultiBizAlert(CreateMultiBizAlertRequest req)
        {
            return InternalRequestAsync<CreateMultiBizAlertResponse>(req, "CreateMultiBizAlert");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 集团广场的多经点位告警
        /// </summary>
        /// <param name="req"><see cref="CreateMultiBizAlertRequest"/></param>
        /// <returns><see cref="CreateMultiBizAlertResponse"/></returns>
        public CreateMultiBizAlertResponse CreateMultiBizAlertSync(CreateMultiBizAlertRequest req)
        {
            return InternalRequestAsync<CreateMultiBizAlertResponse>(req, "CreateMultiBizAlert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报所有进程监控信息
        /// </summary>
        /// <param name="req"><see cref="CreateProgramStateRequest"/></param>
        /// <returns><see cref="CreateProgramStateResponse"/></returns>
        public Task<CreateProgramStateResponse> CreateProgramState(CreateProgramStateRequest req)
        {
            return InternalRequestAsync<CreateProgramStateResponse>(req, "CreateProgramState");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报所有进程监控信息
        /// </summary>
        /// <param name="req"><see cref="CreateProgramStateRequest"/></param>
        /// <returns><see cref="CreateProgramStateResponse"/></returns>
        public CreateProgramStateResponse CreateProgramStateSync(CreateProgramStateRequest req)
        {
            return InternalRequestAsync<CreateProgramStateResponse>(req, "CreateProgramState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报所有服务器硬件监控信息
        /// </summary>
        /// <param name="req"><see cref="CreateServerStateRequest"/></param>
        /// <returns><see cref="CreateServerStateResponse"/></returns>
        public Task<CreateServerStateResponse> CreateServerState(CreateServerStateRequest req)
        {
            return InternalRequestAsync<CreateServerStateResponse>(req, "CreateServerState");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报所有服务器硬件监控信息
        /// </summary>
        /// <param name="req"><see cref="CreateServerStateRequest"/></param>
        /// <returns><see cref="CreateServerStateResponse"/></returns>
        public CreateServerStateResponse CreateServerStateSync(CreateServerStateRequest req)
        {
            return InternalRequestAsync<CreateServerStateResponse>(req, "CreateServerState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 集团广场的多经点位消警
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiBizAlertRequest"/></param>
        /// <returns><see cref="DeleteMultiBizAlertResponse"/></returns>
        public Task<DeleteMultiBizAlertResponse> DeleteMultiBizAlert(DeleteMultiBizAlertRequest req)
        {
            return InternalRequestAsync<DeleteMultiBizAlertResponse>(req, "DeleteMultiBizAlert");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 集团广场的多经点位消警
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiBizAlertRequest"/></param>
        /// <returns><see cref="DeleteMultiBizAlertResponse"/></returns>
        public DeleteMultiBizAlertResponse DeleteMultiBizAlertSync(DeleteMultiBizAlertRequest req)
        {
            return InternalRequestAsync<DeleteMultiBizAlertResponse>(req, "DeleteMultiBizAlert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 删除集团广场对应的任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 删除集团广场对应的任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 获取集团广场对应的摄像头列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCamerasRequest"/></param>
        /// <returns><see cref="DescribeCamerasResponse"/></returns>
        public Task<DescribeCamerasResponse> DescribeCameras(DescribeCamerasRequest req)
        {
            return InternalRequestAsync<DescribeCamerasResponse>(req, "DescribeCameras");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 获取集团广场对应的摄像头列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCamerasRequest"/></param>
        /// <returns><see cref="DescribeCamerasResponse"/></returns>
        public DescribeCamerasResponse DescribeCamerasSync(DescribeCamerasRequest req)
        {
            return InternalRequestAsync<DescribeCamerasResponse>(req, "DescribeCameras")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 获取摄像头配置信息
        /// mac不为空返回指定相机配置
        /// mac为空返回对应GroupCode和MallId全量配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 获取摄像头配置信息
        /// mac不为空返回指定相机配置
        /// mac为空返回对应GroupCode和MallId全量配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 实时获取底图接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public Task<DescribeImageResponse> DescribeImage(DescribeImageRequest req)
        {
            return InternalRequestAsync<DescribeImageResponse>(req, "DescribeImage");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 实时获取底图接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImageSync(DescribeImageRequest req)
        {
            return InternalRequestAsync<DescribeImageResponse>(req, "DescribeImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 获取多经点位底图
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiBizBaseImageRequest"/></param>
        /// <returns><see cref="DescribeMultiBizBaseImageResponse"/></returns>
        public Task<DescribeMultiBizBaseImageResponse> DescribeMultiBizBaseImage(DescribeMultiBizBaseImageRequest req)
        {
            return InternalRequestAsync<DescribeMultiBizBaseImageResponse>(req, "DescribeMultiBizBaseImage");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 获取多经点位底图
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiBizBaseImageRequest"/></param>
        /// <returns><see cref="DescribeMultiBizBaseImageResponse"/></returns>
        public DescribeMultiBizBaseImageResponse DescribeMultiBizBaseImageSync(DescribeMultiBizBaseImageRequest req)
        {
            return InternalRequestAsync<DescribeMultiBizBaseImageResponse>(req, "DescribeMultiBizBaseImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 查询集团广场对应的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 查询集团广场对应的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 获取集团广场的点位列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 获取集团广场的点位列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 集团广场的多经点位配置更新
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiBizConfigRequest"/></param>
        /// <returns><see cref="ModifyMultiBizConfigResponse"/></returns>
        public Task<ModifyMultiBizConfigResponse> ModifyMultiBizConfig(ModifyMultiBizConfigRequest req)
        {
            return InternalRequestAsync<ModifyMultiBizConfigResponse>(req, "ModifyMultiBizConfig");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 集团广场的多经点位配置更新
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiBizConfigRequest"/></param>
        /// <returns><see cref="ModifyMultiBizConfigResponse"/></returns>
        public ModifyMultiBizConfigResponse ModifyMultiBizConfigSync(ModifyMultiBizConfigRequest req)
        {
            return InternalRequestAsync<ModifyMultiBizConfigResponse>(req, "ModifyMultiBizConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报服务注册自身的服务地址作为回调地址, 用于信息回传。
        /// </summary>
        /// <param name="req"><see cref="ReportServiceRegisterRequest"/></param>
        /// <returns><see cref="ReportServiceRegisterResponse"/></returns>
        public Task<ReportServiceRegisterResponse> ReportServiceRegister(ReportServiceRegisterRequest req)
        {
            return InternalRequestAsync<ReportServiceRegisterResponse>(req, "ReportServiceRegister");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 上报服务注册自身的服务地址作为回调地址, 用于信息回传。
        /// </summary>
        /// <param name="req"><see cref="ReportServiceRegisterRequest"/></param>
        /// <returns><see cref="ReportServiceRegisterResponse"/></returns>
        public ReportServiceRegisterResponse ReportServiceRegisterSync(ReportServiceRegisterRequest req)
        {
            return InternalRequestAsync<ReportServiceRegisterResponse>(req, "ReportServiceRegister")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 以图搜图
        /// </summary>
        /// <param name="req"><see cref="SearchImageRequest"/></param>
        /// <returns><see cref="SearchImageResponse"/></returns>
        public Task<SearchImageResponse> SearchImage(SearchImageRequest req)
        {
            return InternalRequestAsync<SearchImageResponse>(req, "SearchImage");
        }

        /// <summary>
        /// 优mall产品启动下线流程
        /// 
        /// 以图搜图
        /// </summary>
        /// <param name="req"><see cref="SearchImageRequest"/></param>
        /// <returns><see cref="SearchImageResponse"/></returns>
        public SearchImageResponse SearchImageSync(SearchImageRequest req)
        {
            return InternalRequestAsync<SearchImageResponse>(req, "SearchImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
