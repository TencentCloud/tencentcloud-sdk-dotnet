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

namespace TencentCloud.Trro.V20220325
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trro.V20220325.Models;

   public class TrroClient : AbstractClient{

       private const string endpoint = "trro.tencentcloudapi.com";
       private const string version = "2022-03-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrroClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrroClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用于批量删除设备
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteDevicesRequest"/></param>
        /// <returns><see cref="BatchDeleteDevicesResponse"/></returns>
        public async Task<BatchDeleteDevicesResponse> BatchDeleteDevices(BatchDeleteDevicesRequest req)
        {
             JsonResponseModel<BatchDeleteDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量删除设备
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteDevicesRequest"/></param>
        /// <returns><see cref="BatchDeleteDevicesResponse"/></returns>
        public BatchDeleteDevicesResponse BatchDeleteDevicesSync(BatchDeleteDevicesRequest req)
        {
             JsonResponseModel<BatchDeleteDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量删除修改权限配置
        /// </summary>
        /// <param name="req"><see cref="BatchDeletePolicyRequest"/></param>
        /// <returns><see cref="BatchDeletePolicyResponse"/></returns>
        public async Task<BatchDeletePolicyResponse> BatchDeletePolicy(BatchDeletePolicyRequest req)
        {
             JsonResponseModel<BatchDeletePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeletePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeletePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量删除修改权限配置
        /// </summary>
        /// <param name="req"><see cref="BatchDeletePolicyRequest"/></param>
        /// <returns><see cref="BatchDeletePolicyResponse"/></returns>
        public BatchDeletePolicyResponse BatchDeletePolicySync(BatchDeletePolicyRequest req)
        {
             JsonResponseModel<BatchDeletePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeletePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeletePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建设备
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public async Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
             JsonResponseModel<CreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建设备
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
             JsonResponseModel<CreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public async Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public async Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
             JsonResponseModel<DeleteProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
             JsonResponseModel<DeleteProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取指定设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceInfoResponse"/></returns>
        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfo(DescribeDeviceInfoRequest req)
        {
             JsonResponseModel<DescribeDeviceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取指定设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceInfoResponse"/></returns>
        public DescribeDeviceInfoResponse DescribeDeviceInfoSync(DescribeDeviceInfoRequest req)
        {
             JsonResponseModel<DescribeDeviceInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取设备信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public async Task<DescribeDeviceListResponse> DescribeDeviceList(DescribeDeviceListRequest req)
        {
             JsonResponseModel<DescribeDeviceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取设备信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public DescribeDeviceListResponse DescribeDeviceListSync(DescribeDeviceListRequest req)
        {
             JsonResponseModel<DescribeDeviceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备会话数据详单
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionDetailsResponse"/></returns>
        public async Task<DescribeDeviceSessionDetailsResponse> DescribeDeviceSessionDetails(DescribeDeviceSessionDetailsRequest req)
        {
             JsonResponseModel<DescribeDeviceSessionDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceSessionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceSessionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备会话数据详单
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionDetailsResponse"/></returns>
        public DescribeDeviceSessionDetailsResponse DescribeDeviceSessionDetailsSync(DescribeDeviceSessionDetailsRequest req)
        {
             JsonResponseModel<DescribeDeviceSessionDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceSessionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceSessionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionListRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionListResponse"/></returns>
        public async Task<DescribeDeviceSessionListResponse> DescribeDeviceSessionList(DescribeDeviceSessionListRequest req)
        {
             JsonResponseModel<DescribeDeviceSessionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceSessionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceSessionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionListRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionListResponse"/></returns>
        public DescribeDeviceSessionListResponse DescribeDeviceSessionListSync(DescribeDeviceSessionListRequest req)
        {
             JsonResponseModel<DescribeDeviceSessionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceSessionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceSessionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查看权限配置
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyRequest"/></param>
        /// <returns><see cref="DescribePolicyResponse"/></returns>
        public async Task<DescribePolicyResponse> DescribePolicy(DescribePolicyRequest req)
        {
             JsonResponseModel<DescribePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查看权限配置
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyRequest"/></param>
        /// <returns><see cref="DescribePolicyResponse"/></returns>
        public DescribePolicyResponse DescribePolicySync(DescribePolicyRequest req)
        {
             JsonResponseModel<DescribePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public async Task<DescribeProjectInfoResponse> DescribeProjectInfo(DescribeProjectInfoRequest req)
        {
             JsonResponseModel<DescribeProjectInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public DescribeProjectInfoResponse DescribeProjectInfoSync(DescribeProjectInfoRequest req)
        {
             JsonResponseModel<DescribeProjectInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public async Task<DescribeProjectListResponse> DescribeProjectList(DescribeProjectListRequest req)
        {
             JsonResponseModel<DescribeProjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public DescribeProjectListResponse DescribeProjectListSync(DescribeProjectListRequest req)
        {
             JsonResponseModel<DescribeProjectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取会话统计值
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsResponse"/></returns>
        public async Task<DescribeSessionStatisticsResponse> DescribeSessionStatistics(DescribeSessionStatisticsRequest req)
        {
             JsonResponseModel<DescribeSessionStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSessionStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSessionStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取会话统计值
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsResponse"/></returns>
        public DescribeSessionStatisticsResponse DescribeSessionStatisticsSync(DescribeSessionStatisticsRequest req)
        {
             JsonResponseModel<DescribeSessionStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSessionStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSessionStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各时间段的会话统计值
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsByIntervalRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsByIntervalResponse"/></returns>
        public async Task<DescribeSessionStatisticsByIntervalResponse> DescribeSessionStatisticsByInterval(DescribeSessionStatisticsByIntervalRequest req)
        {
             JsonResponseModel<DescribeSessionStatisticsByIntervalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSessionStatisticsByInterval");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSessionStatisticsByIntervalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各时间段的会话统计值
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsByIntervalRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsByIntervalResponse"/></returns>
        public DescribeSessionStatisticsByIntervalResponse DescribeSessionStatisticsByIntervalSync(DescribeSessionStatisticsByIntervalRequest req)
        {
             JsonResponseModel<DescribeSessionStatisticsByIntervalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSessionStatisticsByInterval");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSessionStatisticsByIntervalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public async Task<ModifyDeviceResponse> ModifyDevice(ModifyDeviceRequest req)
        {
             JsonResponseModel<ModifyDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public ModifyDeviceResponse ModifyDeviceSync(ModifyDeviceRequest req)
        {
             JsonResponseModel<ModifyDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改权限配置
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyRequest"/></param>
        /// <returns><see cref="ModifyPolicyResponse"/></returns>
        public async Task<ModifyPolicyResponse> ModifyPolicy(ModifyPolicyRequest req)
        {
             JsonResponseModel<ModifyPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改权限配置
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyRequest"/></param>
        /// <returns><see cref="ModifyPolicyResponse"/></returns>
        public ModifyPolicyResponse ModifyPolicySync(ModifyPolicyRequest req)
        {
             JsonResponseModel<ModifyPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改项目信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public async Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
             JsonResponseModel<ModifyProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改项目信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
             JsonResponseModel<ModifyProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
