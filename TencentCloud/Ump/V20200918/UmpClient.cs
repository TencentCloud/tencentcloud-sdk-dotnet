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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public UmpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 上报相机移动、遮挡等告警信息
        /// 
        /// </summary>
        /// <param name="req"><see cref="CreateCameraAlertsRequest"/></param>
        /// <returns><see cref="CreateCameraAlertsResponse"/></returns>
        public async Task<CreateCameraAlertsResponse> CreateCameraAlerts(CreateCameraAlertsRequest req)
        {
             JsonResponseModel<CreateCameraAlertsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCameraAlerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCameraAlertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报相机移动、遮挡等告警信息
        /// 
        /// </summary>
        /// <param name="req"><see cref="CreateCameraAlertsRequest"/></param>
        /// <returns><see cref="CreateCameraAlertsResponse"/></returns>
        public CreateCameraAlertsResponse CreateCameraAlertsSync(CreateCameraAlertsRequest req)
        {
             JsonResponseModel<CreateCameraAlertsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCameraAlerts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCameraAlertsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 场内抓拍上报接口
        /// </summary>
        /// <param name="req"><see cref="CreateCaptureRequest"/></param>
        /// <returns><see cref="CreateCaptureResponse"/></returns>
        public async Task<CreateCaptureResponse> CreateCapture(CreateCaptureRequest req)
        {
             JsonResponseModel<CreateCaptureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCapture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCaptureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 场内抓拍上报接口
        /// </summary>
        /// <param name="req"><see cref="CreateCaptureRequest"/></param>
        /// <returns><see cref="CreateCaptureResponse"/></returns>
        public CreateCaptureResponse CreateCaptureSync(CreateCaptureRequest req)
        {
             JsonResponseModel<CreateCaptureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCapture");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCaptureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集团广场的多经点位告警
        /// </summary>
        /// <param name="req"><see cref="CreateMultiBizAlertRequest"/></param>
        /// <returns><see cref="CreateMultiBizAlertResponse"/></returns>
        public async Task<CreateMultiBizAlertResponse> CreateMultiBizAlert(CreateMultiBizAlertRequest req)
        {
             JsonResponseModel<CreateMultiBizAlertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMultiBizAlert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiBizAlertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集团广场的多经点位告警
        /// </summary>
        /// <param name="req"><see cref="CreateMultiBizAlertRequest"/></param>
        /// <returns><see cref="CreateMultiBizAlertResponse"/></returns>
        public CreateMultiBizAlertResponse CreateMultiBizAlertSync(CreateMultiBizAlertRequest req)
        {
             JsonResponseModel<CreateMultiBizAlertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMultiBizAlert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiBizAlertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报所有进程监控信息
        /// </summary>
        /// <param name="req"><see cref="CreateProgramStateRequest"/></param>
        /// <returns><see cref="CreateProgramStateResponse"/></returns>
        public async Task<CreateProgramStateResponse> CreateProgramState(CreateProgramStateRequest req)
        {
             JsonResponseModel<CreateProgramStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProgramState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProgramStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报所有进程监控信息
        /// </summary>
        /// <param name="req"><see cref="CreateProgramStateRequest"/></param>
        /// <returns><see cref="CreateProgramStateResponse"/></returns>
        public CreateProgramStateResponse CreateProgramStateSync(CreateProgramStateRequest req)
        {
             JsonResponseModel<CreateProgramStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProgramState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProgramStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报所有服务器硬件监控信息
        /// </summary>
        /// <param name="req"><see cref="CreateServerStateRequest"/></param>
        /// <returns><see cref="CreateServerStateResponse"/></returns>
        public async Task<CreateServerStateResponse> CreateServerState(CreateServerStateRequest req)
        {
             JsonResponseModel<CreateServerStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServerState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报所有服务器硬件监控信息
        /// </summary>
        /// <param name="req"><see cref="CreateServerStateRequest"/></param>
        /// <returns><see cref="CreateServerStateResponse"/></returns>
        public CreateServerStateResponse CreateServerStateSync(CreateServerStateRequest req)
        {
             JsonResponseModel<CreateServerStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServerState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集团广场的多经点位消警
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiBizAlertRequest"/></param>
        /// <returns><see cref="DeleteMultiBizAlertResponse"/></returns>
        public async Task<DeleteMultiBizAlertResponse> DeleteMultiBizAlert(DeleteMultiBizAlertRequest req)
        {
             JsonResponseModel<DeleteMultiBizAlertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMultiBizAlert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMultiBizAlertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集团广场的多经点位消警
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiBizAlertRequest"/></param>
        /// <returns><see cref="DeleteMultiBizAlertResponse"/></returns>
        public DeleteMultiBizAlertResponse DeleteMultiBizAlertSync(DeleteMultiBizAlertRequest req)
        {
             JsonResponseModel<DeleteMultiBizAlertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMultiBizAlert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMultiBizAlertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集团广场对应的任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public async Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
             JsonResponseModel<DeleteTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集团广场对应的任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
             JsonResponseModel<DeleteTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集团广场对应的摄像头列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCamerasRequest"/></param>
        /// <returns><see cref="DescribeCamerasResponse"/></returns>
        public async Task<DescribeCamerasResponse> DescribeCameras(DescribeCamerasRequest req)
        {
             JsonResponseModel<DescribeCamerasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCameras");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCamerasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集团广场对应的摄像头列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCamerasRequest"/></param>
        /// <returns><see cref="DescribeCamerasResponse"/></returns>
        public DescribeCamerasResponse DescribeCamerasSync(DescribeCamerasRequest req)
        {
             JsonResponseModel<DescribeCamerasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCameras");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCamerasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取摄像头配置信息
        /// mac不为空返回指定相机配置
        /// mac为空返回对应GroupCode和MallId全量配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public async Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取摄像头配置信息
        /// mac不为空返回指定相机配置
        /// mac为空返回对应GroupCode和MallId全量配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时获取底图接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public async Task<DescribeImageResponse> DescribeImage(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时获取底图接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImageSync(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取多经点位底图
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiBizBaseImageRequest"/></param>
        /// <returns><see cref="DescribeMultiBizBaseImageResponse"/></returns>
        public async Task<DescribeMultiBizBaseImageResponse> DescribeMultiBizBaseImage(DescribeMultiBizBaseImageRequest req)
        {
             JsonResponseModel<DescribeMultiBizBaseImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMultiBizBaseImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMultiBizBaseImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取多经点位底图
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiBizBaseImageRequest"/></param>
        /// <returns><see cref="DescribeMultiBizBaseImageResponse"/></returns>
        public DescribeMultiBizBaseImageResponse DescribeMultiBizBaseImageSync(DescribeMultiBizBaseImageRequest req)
        {
             JsonResponseModel<DescribeMultiBizBaseImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMultiBizBaseImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMultiBizBaseImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集团广场对应的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集团广场对应的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集团广场的点位列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集团广场的点位列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 以图搜图
        /// </summary>
        /// <param name="req"><see cref="SearchImageRequest"/></param>
        /// <returns><see cref="SearchImageResponse"/></returns>
        public async Task<SearchImageResponse> SearchImage(SearchImageRequest req)
        {
             JsonResponseModel<SearchImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 以图搜图
        /// </summary>
        /// <param name="req"><see cref="SearchImageRequest"/></param>
        /// <returns><see cref="SearchImageResponse"/></returns>
        public SearchImageResponse SearchImageSync(SearchImageRequest req)
        {
             JsonResponseModel<SearchImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
