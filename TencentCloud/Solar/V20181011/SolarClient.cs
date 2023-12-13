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
        public Task<CheckStaffChUserResponse> CheckStaffChUser(CheckStaffChUserRequest req)
        {
            return InternalRequestAsync<CheckStaffChUserResponse>(req, "CheckStaffChUser");
        }

        /// <summary>
        /// 员工渠道更改员工状态
        /// </summary>
        /// <param name="req"><see cref="CheckStaffChUserRequest"/></param>
        /// <returns><see cref="CheckStaffChUserResponse"/></returns>
        public CheckStaffChUserResponse CheckStaffChUserSync(CheckStaffChUserRequest req)
        {
            return InternalRequestAsync<CheckStaffChUserResponse>(req, "CheckStaffChUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制活动渠道的策略
        /// </summary>
        /// <param name="req"><see cref="CopyActivityChannelRequest"/></param>
        /// <returns><see cref="CopyActivityChannelResponse"/></returns>
        public Task<CopyActivityChannelResponse> CopyActivityChannel(CopyActivityChannelRequest req)
        {
            return InternalRequestAsync<CopyActivityChannelResponse>(req, "CopyActivityChannel");
        }

        /// <summary>
        /// 复制活动渠道的策略
        /// </summary>
        /// <param name="req"><see cref="CopyActivityChannelRequest"/></param>
        /// <returns><see cref="CopyActivityChannelResponse"/></returns>
        public CopyActivityChannelResponse CopyActivityChannelSync(CopyActivityChannelRequest req)
        {
            return InternalRequestAsync<CopyActivityChannelResponse>(req, "CopyActivityChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建子项目
        /// </summary>
        /// <param name="req"><see cref="CreateSubProjectRequest"/></param>
        /// <returns><see cref="CreateSubProjectResponse"/></returns>
        public Task<CreateSubProjectResponse> CreateSubProject(CreateSubProjectRequest req)
        {
            return InternalRequestAsync<CreateSubProjectResponse>(req, "CreateSubProject");
        }

        /// <summary>
        /// 创建子项目
        /// </summary>
        /// <param name="req"><see cref="CreateSubProjectRequest"/></param>
        /// <returns><see cref="CreateSubProjectResponse"/></returns>
        public CreateSubProjectResponse CreateSubProjectSync(CreateSubProjectRequest req)
        {
            return InternalRequestAsync<CreateSubProjectResponse>(req, "CreateSubProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 客户档案查询客户详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerRequest"/></param>
        /// <returns><see cref="DescribeCustomerResponse"/></returns>
        public Task<DescribeCustomerResponse> DescribeCustomer(DescribeCustomerRequest req)
        {
            return InternalRequestAsync<DescribeCustomerResponse>(req, "DescribeCustomer");
        }

        /// <summary>
        /// 客户档案查询客户详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerRequest"/></param>
        /// <returns><see cref="DescribeCustomerResponse"/></returns>
        public DescribeCustomerResponse DescribeCustomerSync(DescribeCustomerRequest req)
        {
            return InternalRequestAsync<DescribeCustomerResponse>(req, "DescribeCustomer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询客户档案列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomersRequest"/></param>
        /// <returns><see cref="DescribeCustomersResponse"/></returns>
        public Task<DescribeCustomersResponse> DescribeCustomers(DescribeCustomersRequest req)
        {
            return InternalRequestAsync<DescribeCustomersResponse>(req, "DescribeCustomers");
        }

        /// <summary>
        /// 查询客户档案列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomersRequest"/></param>
        /// <returns><see cref="DescribeCustomersResponse"/></returns>
        public DescribeCustomersResponse DescribeCustomersSync(DescribeCustomersRequest req)
        {
            return InternalRequestAsync<DescribeCustomersResponse>(req, "DescribeCustomers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目详情展示
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public Task<DescribeProjectResponse> DescribeProject(DescribeProjectRequest req)
        {
            return InternalRequestAsync<DescribeProjectResponse>(req, "DescribeProject");
        }

        /// <summary>
        /// 项目详情展示
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public DescribeProjectResponse DescribeProjectSync(DescribeProjectRequest req)
        {
            return InternalRequestAsync<DescribeProjectResponse>(req, "DescribeProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目库存详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectStockRequest"/></param>
        /// <returns><see cref="DescribeProjectStockResponse"/></returns>
        public Task<DescribeProjectStockResponse> DescribeProjectStock(DescribeProjectStockRequest req)
        {
            return InternalRequestAsync<DescribeProjectStockResponse>(req, "DescribeProjectStock");
        }

        /// <summary>
        /// 项目库存详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectStockRequest"/></param>
        /// <returns><see cref="DescribeProjectStockResponse"/></returns>
        public DescribeProjectStockResponse DescribeProjectStockSync(DescribeProjectStockRequest req)
        {
            return InternalRequestAsync<DescribeProjectStockResponse>(req, "DescribeProjectStock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目列表展示
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// 项目列表展示
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 素材查询服务号模板的列表（样例）
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTemplateHeadersRequest"/></param>
        /// <returns><see cref="DescribeResourceTemplateHeadersResponse"/></returns>
        public Task<DescribeResourceTemplateHeadersResponse> DescribeResourceTemplateHeaders(DescribeResourceTemplateHeadersRequest req)
        {
            return InternalRequestAsync<DescribeResourceTemplateHeadersResponse>(req, "DescribeResourceTemplateHeaders");
        }

        /// <summary>
        /// 素材查询服务号模板的列表（样例）
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTemplateHeadersRequest"/></param>
        /// <returns><see cref="DescribeResourceTemplateHeadersResponse"/></returns>
        public DescribeResourceTemplateHeadersResponse DescribeResourceTemplateHeadersSync(DescribeResourceTemplateHeadersRequest req)
        {
            return InternalRequestAsync<DescribeResourceTemplateHeadersResponse>(req, "DescribeResourceTemplateHeaders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 子项目详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSubProjectRequest"/></param>
        /// <returns><see cref="DescribeSubProjectResponse"/></returns>
        public Task<DescribeSubProjectResponse> DescribeSubProject(DescribeSubProjectRequest req)
        {
            return InternalRequestAsync<DescribeSubProjectResponse>(req, "DescribeSubProject");
        }

        /// <summary>
        /// 子项目详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSubProjectRequest"/></param>
        /// <returns><see cref="DescribeSubProjectResponse"/></returns>
        public DescribeSubProjectResponse DescribeSubProjectSync(DescribeSubProjectRequest req)
        {
            return InternalRequestAsync<DescribeSubProjectResponse>(req, "DescribeSubProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 把审批中的工单置为已失效
        /// </summary>
        /// <param name="req"><see cref="ExpireFlowRequest"/></param>
        /// <returns><see cref="ExpireFlowResponse"/></returns>
        public Task<ExpireFlowResponse> ExpireFlow(ExpireFlowRequest req)
        {
            return InternalRequestAsync<ExpireFlowResponse>(req, "ExpireFlow");
        }

        /// <summary>
        /// 把审批中的工单置为已失效
        /// </summary>
        /// <param name="req"><see cref="ExpireFlowRequest"/></param>
        /// <returns><see cref="ExpireFlowResponse"/></returns>
        public ExpireFlowResponse ExpireFlowSync(ExpireFlowRequest req)
        {
            return InternalRequestAsync<ExpireFlowResponse>(req, "ExpireFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下线项目
        /// </summary>
        /// <param name="req"><see cref="OffLineProjectRequest"/></param>
        /// <returns><see cref="OffLineProjectResponse"/></returns>
        public Task<OffLineProjectResponse> OffLineProject(OffLineProjectRequest req)
        {
            return InternalRequestAsync<OffLineProjectResponse>(req, "OffLineProject");
        }

        /// <summary>
        /// 下线项目
        /// </summary>
        /// <param name="req"><see cref="OffLineProjectRequest"/></param>
        /// <returns><see cref="OffLineProjectResponse"/></returns>
        public OffLineProjectResponse OffLineProjectSync(OffLineProjectRequest req)
        {
            return InternalRequestAsync<OffLineProjectResponse>(req, "OffLineProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 补充子项目库存
        /// </summary>
        /// <param name="req"><see cref="ReplenishProjectStockRequest"/></param>
        /// <returns><see cref="ReplenishProjectStockResponse"/></returns>
        public Task<ReplenishProjectStockResponse> ReplenishProjectStock(ReplenishProjectStockRequest req)
        {
            return InternalRequestAsync<ReplenishProjectStockResponse>(req, "ReplenishProjectStock");
        }

        /// <summary>
        /// 补充子项目库存
        /// </summary>
        /// <param name="req"><see cref="ReplenishProjectStockRequest"/></param>
        /// <returns><see cref="ReplenishProjectStockResponse"/></returns>
        public ReplenishProjectStockResponse ReplenishProjectStockSync(ReplenishProjectStockRequest req)
        {
            return InternalRequestAsync<ReplenishProjectStockResponse>(req, "ReplenishProjectStock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送企业微信触达任务
        /// </summary>
        /// <param name="req"><see cref="SendWxTouchTaskRequest"/></param>
        /// <returns><see cref="SendWxTouchTaskResponse"/></returns>
        public Task<SendWxTouchTaskResponse> SendWxTouchTask(SendWxTouchTaskRequest req)
        {
            return InternalRequestAsync<SendWxTouchTaskResponse>(req, "SendWxTouchTask");
        }

        /// <summary>
        /// 发送企业微信触达任务
        /// </summary>
        /// <param name="req"><see cref="SendWxTouchTaskRequest"/></param>
        /// <returns><see cref="SendWxTouchTaskResponse"/></returns>
        public SendWxTouchTaskResponse SendWxTouchTaskSync(SendWxTouchTaskRequest req)
        {
            return InternalRequestAsync<SendWxTouchTaskResponse>(req, "SendWxTouchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
