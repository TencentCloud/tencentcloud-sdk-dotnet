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

namespace TencentCloud.Solar.V20181011
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Solar.V20181011.Models;

   public class SolarClient : AbstractClient{

       private const string endpoint = "solar.tencentcloudapi.com";
       private const string version = "2018-10-11";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SolarClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SolarClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 员工渠道更改员工状态
        /// </summary>
        /// <param name="req"><see cref="CheckStaffChUserRequest"/></param>
        /// <returns><see cref="CheckStaffChUserResponse"/></returns>
        public async Task<CheckStaffChUserResponse> CheckStaffChUser(CheckStaffChUserRequest req)
        {
             JsonResponseModel<CheckStaffChUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckStaffChUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckStaffChUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 员工渠道更改员工状态
        /// </summary>
        /// <param name="req"><see cref="CheckStaffChUserRequest"/></param>
        /// <returns><see cref="CheckStaffChUserResponse"/></returns>
        public CheckStaffChUserResponse CheckStaffChUserSync(CheckStaffChUserRequest req)
        {
             JsonResponseModel<CheckStaffChUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckStaffChUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckStaffChUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制活动渠道的策略
        /// </summary>
        /// <param name="req"><see cref="CopyActivityChannelRequest"/></param>
        /// <returns><see cref="CopyActivityChannelResponse"/></returns>
        public async Task<CopyActivityChannelResponse> CopyActivityChannel(CopyActivityChannelRequest req)
        {
             JsonResponseModel<CopyActivityChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyActivityChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyActivityChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制活动渠道的策略
        /// </summary>
        /// <param name="req"><see cref="CopyActivityChannelRequest"/></param>
        /// <returns><see cref="CopyActivityChannelResponse"/></returns>
        public CopyActivityChannelResponse CopyActivityChannelSync(CopyActivityChannelRequest req)
        {
             JsonResponseModel<CopyActivityChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyActivityChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyActivityChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建项目
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
        /// 创建项目
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
        /// 创建子项目
        /// </summary>
        /// <param name="req"><see cref="CreateSubProjectRequest"/></param>
        /// <returns><see cref="CreateSubProjectResponse"/></returns>
        public async Task<CreateSubProjectResponse> CreateSubProject(CreateSubProjectRequest req)
        {
             JsonResponseModel<CreateSubProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建子项目
        /// </summary>
        /// <param name="req"><see cref="CreateSubProjectRequest"/></param>
        /// <returns><see cref="CreateSubProjectResponse"/></returns>
        public CreateSubProjectResponse CreateSubProjectSync(CreateSubProjectRequest req)
        {
             JsonResponseModel<CreateSubProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除项目
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
        /// 删除项目
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
        /// 客户档案查询客户详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerRequest"/></param>
        /// <returns><see cref="DescribeCustomerResponse"/></returns>
        public async Task<DescribeCustomerResponse> DescribeCustomer(DescribeCustomerRequest req)
        {
             JsonResponseModel<DescribeCustomerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 客户档案查询客户详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerRequest"/></param>
        /// <returns><see cref="DescribeCustomerResponse"/></returns>
        public DescribeCustomerResponse DescribeCustomerSync(DescribeCustomerRequest req)
        {
             JsonResponseModel<DescribeCustomerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询客户档案列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomersRequest"/></param>
        /// <returns><see cref="DescribeCustomersResponse"/></returns>
        public async Task<DescribeCustomersResponse> DescribeCustomers(DescribeCustomersRequest req)
        {
             JsonResponseModel<DescribeCustomersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询客户档案列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomersRequest"/></param>
        /// <returns><see cref="DescribeCustomersResponse"/></returns>
        public DescribeCustomersResponse DescribeCustomersSync(DescribeCustomersRequest req)
        {
             JsonResponseModel<DescribeCustomersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目详情展示
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public async Task<DescribeProjectResponse> DescribeProject(DescribeProjectRequest req)
        {
             JsonResponseModel<DescribeProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目详情展示
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public DescribeProjectResponse DescribeProjectSync(DescribeProjectRequest req)
        {
             JsonResponseModel<DescribeProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目库存详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectStockRequest"/></param>
        /// <returns><see cref="DescribeProjectStockResponse"/></returns>
        public async Task<DescribeProjectStockResponse> DescribeProjectStock(DescribeProjectStockRequest req)
        {
             JsonResponseModel<DescribeProjectStockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectStock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectStockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目库存详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectStockRequest"/></param>
        /// <returns><see cref="DescribeProjectStockResponse"/></returns>
        public DescribeProjectStockResponse DescribeProjectStockSync(DescribeProjectStockRequest req)
        {
             JsonResponseModel<DescribeProjectStockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectStock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectStockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目列表展示
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public async Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目列表展示
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 素材查询服务号模板的列表（样例）
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTemplateHeadersRequest"/></param>
        /// <returns><see cref="DescribeResourceTemplateHeadersResponse"/></returns>
        public async Task<DescribeResourceTemplateHeadersResponse> DescribeResourceTemplateHeaders(DescribeResourceTemplateHeadersRequest req)
        {
             JsonResponseModel<DescribeResourceTemplateHeadersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceTemplateHeaders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTemplateHeadersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 素材查询服务号模板的列表（样例）
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTemplateHeadersRequest"/></param>
        /// <returns><see cref="DescribeResourceTemplateHeadersResponse"/></returns>
        public DescribeResourceTemplateHeadersResponse DescribeResourceTemplateHeadersSync(DescribeResourceTemplateHeadersRequest req)
        {
             JsonResponseModel<DescribeResourceTemplateHeadersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceTemplateHeaders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTemplateHeadersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子项目详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSubProjectRequest"/></param>
        /// <returns><see cref="DescribeSubProjectResponse"/></returns>
        public async Task<DescribeSubProjectResponse> DescribeSubProject(DescribeSubProjectRequest req)
        {
             JsonResponseModel<DescribeSubProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子项目详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSubProjectRequest"/></param>
        /// <returns><see cref="DescribeSubProjectResponse"/></returns>
        public DescribeSubProjectResponse DescribeSubProjectSync(DescribeSubProjectRequest req)
        {
             JsonResponseModel<DescribeSubProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 把审批中的工单置为已失效
        /// </summary>
        /// <param name="req"><see cref="ExpireFlowRequest"/></param>
        /// <returns><see cref="ExpireFlowResponse"/></returns>
        public async Task<ExpireFlowResponse> ExpireFlow(ExpireFlowRequest req)
        {
             JsonResponseModel<ExpireFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExpireFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpireFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 把审批中的工单置为已失效
        /// </summary>
        /// <param name="req"><see cref="ExpireFlowRequest"/></param>
        /// <returns><see cref="ExpireFlowResponse"/></returns>
        public ExpireFlowResponse ExpireFlowSync(ExpireFlowRequest req)
        {
             JsonResponseModel<ExpireFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExpireFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpireFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改项目
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
        /// 修改项目
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

        /// <summary>
        /// 下线项目
        /// </summary>
        /// <param name="req"><see cref="OffLineProjectRequest"/></param>
        /// <returns><see cref="OffLineProjectResponse"/></returns>
        public async Task<OffLineProjectResponse> OffLineProject(OffLineProjectRequest req)
        {
             JsonResponseModel<OffLineProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OffLineProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OffLineProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线项目
        /// </summary>
        /// <param name="req"><see cref="OffLineProjectRequest"/></param>
        /// <returns><see cref="OffLineProjectResponse"/></returns>
        public OffLineProjectResponse OffLineProjectSync(OffLineProjectRequest req)
        {
             JsonResponseModel<OffLineProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OffLineProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OffLineProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 补充子项目库存
        /// </summary>
        /// <param name="req"><see cref="ReplenishProjectStockRequest"/></param>
        /// <returns><see cref="ReplenishProjectStockResponse"/></returns>
        public async Task<ReplenishProjectStockResponse> ReplenishProjectStock(ReplenishProjectStockRequest req)
        {
             JsonResponseModel<ReplenishProjectStockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplenishProjectStock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplenishProjectStockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 补充子项目库存
        /// </summary>
        /// <param name="req"><see cref="ReplenishProjectStockRequest"/></param>
        /// <returns><see cref="ReplenishProjectStockResponse"/></returns>
        public ReplenishProjectStockResponse ReplenishProjectStockSync(ReplenishProjectStockRequest req)
        {
             JsonResponseModel<ReplenishProjectStockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplenishProjectStock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplenishProjectStockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送企业微信触达任务
        /// </summary>
        /// <param name="req"><see cref="SendWxTouchTaskRequest"/></param>
        /// <returns><see cref="SendWxTouchTaskResponse"/></returns>
        public async Task<SendWxTouchTaskResponse> SendWxTouchTask(SendWxTouchTaskRequest req)
        {
             JsonResponseModel<SendWxTouchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendWxTouchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendWxTouchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送企业微信触达任务
        /// </summary>
        /// <param name="req"><see cref="SendWxTouchTaskRequest"/></param>
        /// <returns><see cref="SendWxTouchTaskResponse"/></returns>
        public SendWxTouchTaskResponse SendWxTouchTaskSync(SendWxTouchTaskRequest req)
        {
             JsonResponseModel<SendWxTouchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendWxTouchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendWxTouchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
