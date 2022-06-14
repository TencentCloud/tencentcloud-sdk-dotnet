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

namespace TencentCloud.Cat.V20180409
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cat.V20180409.Models;

   public class CatClient : AbstractClient{

       private const string endpoint = "cat.tencentcloudapi.com";
       private const string version = "2018-04-09";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CatClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CatClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 批量创建拨测任务
        /// </summary>
        /// <param name="req"><see cref="CreateProbeTasksRequest"/></param>
        /// <returns><see cref="CreateProbeTasksResponse"/></returns>
        public async Task<CreateProbeTasksResponse> CreateProbeTasks(CreateProbeTasksRequest req)
        {
             JsonResponseModel<CreateProbeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProbeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProbeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量创建拨测任务
        /// </summary>
        /// <param name="req"><see cref="CreateProbeTasksRequest"/></param>
        /// <returns><see cref="CreateProbeTasksResponse"/></returns>
        public CreateProbeTasksResponse CreateProbeTasksSync(CreateProbeTasksRequest req)
        {
             JsonResponseModel<CreateProbeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProbeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProbeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除拨测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteProbeTaskRequest"/></param>
        /// <returns><see cref="DeleteProbeTaskResponse"/></returns>
        public async Task<DeleteProbeTaskResponse> DeleteProbeTask(DeleteProbeTaskRequest req)
        {
             JsonResponseModel<DeleteProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除拨测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteProbeTaskRequest"/></param>
        /// <returns><see cref="DeleteProbeTaskResponse"/></returns>
        public DeleteProbeTaskResponse DeleteProbeTaskSync(DeleteProbeTaskRequest req)
        {
             JsonResponseModel<DeleteProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据时间范围、任务ID、运营商等条件查询单次拨测详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSingleProbeDataRequest"/></param>
        /// <returns><see cref="DescribeDetailedSingleProbeDataResponse"/></returns>
        public async Task<DescribeDetailedSingleProbeDataResponse> DescribeDetailedSingleProbeData(DescribeDetailedSingleProbeDataRequest req)
        {
             JsonResponseModel<DescribeDetailedSingleProbeDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDetailedSingleProbeData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDetailedSingleProbeDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据时间范围、任务ID、运营商等条件查询单次拨测详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSingleProbeDataRequest"/></param>
        /// <returns><see cref="DescribeDetailedSingleProbeDataResponse"/></returns>
        public DescribeDetailedSingleProbeDataResponse DescribeDetailedSingleProbeDataSync(DescribeDetailedSingleProbeDataRequest req)
        {
             JsonResponseModel<DescribeDetailedSingleProbeDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDetailedSingleProbeData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDetailedSingleProbeDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出云拨测指标详细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeMetricDataRequest"/></param>
        /// <returns><see cref="DescribeProbeMetricDataResponse"/></returns>
        public async Task<DescribeProbeMetricDataResponse> DescribeProbeMetricData(DescribeProbeMetricDataRequest req)
        {
             JsonResponseModel<DescribeProbeMetricDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProbeMetricData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeMetricDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出云拨测指标详细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeMetricDataRequest"/></param>
        /// <returns><see cref="DescribeProbeMetricDataResponse"/></returns>
        public DescribeProbeMetricDataResponse DescribeProbeMetricDataSync(DescribeProbeMetricDataRequest req)
        {
             JsonResponseModel<DescribeProbeMetricDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProbeMetricData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeMetricDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测节点
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeNodesRequest"/></param>
        /// <returns><see cref="DescribeProbeNodesResponse"/></returns>
        public async Task<DescribeProbeNodesResponse> DescribeProbeNodes(DescribeProbeNodesRequest req)
        {
             JsonResponseModel<DescribeProbeNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProbeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测节点
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeNodesRequest"/></param>
        /// <returns><see cref="DescribeProbeNodesResponse"/></returns>
        public DescribeProbeNodesResponse DescribeProbeNodesSync(DescribeProbeNodesRequest req)
        {
             JsonResponseModel<DescribeProbeNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProbeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeTasksRequest"/></param>
        /// <returns><see cref="DescribeProbeTasksResponse"/></returns>
        public async Task<DescribeProbeTasksResponse> DescribeProbeTasks(DescribeProbeTasksRequest req)
        {
             JsonResponseModel<DescribeProbeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProbeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询拨测任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProbeTasksRequest"/></param>
        /// <returns><see cref="DescribeProbeTasksResponse"/></returns>
        public DescribeProbeTasksResponse DescribeProbeTasksSync(DescribeProbeTasksRequest req)
        {
             JsonResponseModel<DescribeProbeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProbeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProbeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复拨测任务
        /// </summary>
        /// <param name="req"><see cref="ResumeProbeTaskRequest"/></param>
        /// <returns><see cref="ResumeProbeTaskResponse"/></returns>
        public async Task<ResumeProbeTaskResponse> ResumeProbeTask(ResumeProbeTaskRequest req)
        {
             JsonResponseModel<ResumeProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复拨测任务
        /// </summary>
        /// <param name="req"><see cref="ResumeProbeTaskRequest"/></param>
        /// <returns><see cref="ResumeProbeTaskResponse"/></returns>
        public ResumeProbeTaskResponse ResumeProbeTaskSync(ResumeProbeTaskRequest req)
        {
             JsonResponseModel<ResumeProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停拨测任务
        /// </summary>
        /// <param name="req"><see cref="SuspendProbeTaskRequest"/></param>
        /// <returns><see cref="SuspendProbeTaskResponse"/></returns>
        public async Task<SuspendProbeTaskResponse> SuspendProbeTask(SuspendProbeTaskRequest req)
        {
             JsonResponseModel<SuspendProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SuspendProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停拨测任务
        /// </summary>
        /// <param name="req"><see cref="SuspendProbeTaskRequest"/></param>
        /// <returns><see cref="SuspendProbeTaskResponse"/></returns>
        public SuspendProbeTaskResponse SuspendProbeTaskSync(SuspendProbeTaskRequest req)
        {
             JsonResponseModel<SuspendProbeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SuspendProbeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendProbeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新拨测任务配置
        /// </summary>
        /// <param name="req"><see cref="UpdateProbeTaskConfigurationListRequest"/></param>
        /// <returns><see cref="UpdateProbeTaskConfigurationListResponse"/></returns>
        public async Task<UpdateProbeTaskConfigurationListResponse> UpdateProbeTaskConfigurationList(UpdateProbeTaskConfigurationListRequest req)
        {
             JsonResponseModel<UpdateProbeTaskConfigurationListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProbeTaskConfigurationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProbeTaskConfigurationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新拨测任务配置
        /// </summary>
        /// <param name="req"><see cref="UpdateProbeTaskConfigurationListRequest"/></param>
        /// <returns><see cref="UpdateProbeTaskConfigurationListResponse"/></returns>
        public UpdateProbeTaskConfigurationListResponse UpdateProbeTaskConfigurationListSync(UpdateProbeTaskConfigurationListRequest req)
        {
             JsonResponseModel<UpdateProbeTaskConfigurationListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateProbeTaskConfigurationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProbeTaskConfigurationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
