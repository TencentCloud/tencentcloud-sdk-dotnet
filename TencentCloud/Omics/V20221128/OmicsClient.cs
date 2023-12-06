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

namespace TencentCloud.Omics.V20221128
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Omics.V20221128.Models;

   public class OmicsClient : AbstractClient{

       private const string endpoint = "omics.tencentcloudapi.com";
       private const string version = "2022-11-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OmicsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OmicsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建组学平台计算环境。
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment");
        }

        /// <summary>
        /// 创建组学平台计算环境。
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除环境。
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentResponse"/></returns>
        public Task<DeleteEnvironmentResponse> DeleteEnvironment(DeleteEnvironmentRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentResponse>(req, "DeleteEnvironment");
        }

        /// <summary>
        /// 删除环境。
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentResponse"/></returns>
        public DeleteEnvironmentResponse DeleteEnvironmentSync(DeleteEnvironmentRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentResponse>(req, "DeleteEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询环境列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// 查询环境列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务批次列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunGroupsRequest"/></param>
        /// <returns><see cref="DescribeRunGroupsResponse"/></returns>
        public Task<DescribeRunGroupsResponse> DescribeRunGroups(DescribeRunGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRunGroupsResponse>(req, "DescribeRunGroups");
        }

        /// <summary>
        /// 查询任务批次列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunGroupsRequest"/></param>
        /// <returns><see cref="DescribeRunGroupsResponse"/></returns>
        public DescribeRunGroupsResponse DescribeRunGroupsSync(DescribeRunGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRunGroupsResponse>(req, "DescribeRunGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunsRequest"/></param>
        /// <returns><see cref="DescribeRunsResponse"/></returns>
        public Task<DescribeRunsResponse> DescribeRuns(DescribeRunsRequest req)
        {
            return InternalRequestAsync<DescribeRunsResponse>(req, "DescribeRuns");
        }

        /// <summary>
        /// 查询任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunsRequest"/></param>
        /// <returns><see cref="DescribeRunsResponse"/></returns>
        public DescribeRunsResponse DescribeRunsSync(DescribeRunsRequest req)
        {
            return InternalRequestAsync<DescribeRunsResponse>(req, "DescribeRuns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表格。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables");
        }

        /// <summary>
        /// 查询表格。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表格行数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRowsRequest"/></param>
        /// <returns><see cref="DescribeTablesRowsResponse"/></returns>
        public Task<DescribeTablesRowsResponse> DescribeTablesRows(DescribeTablesRowsRequest req)
        {
            return InternalRequestAsync<DescribeTablesRowsResponse>(req, "DescribeTablesRows");
        }

        /// <summary>
        /// 查询表格行数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRowsRequest"/></param>
        /// <returns><see cref="DescribeTablesRowsResponse"/></returns>
        public DescribeTablesRowsResponse DescribeTablesRowsSync(DescribeTablesRowsRequest req)
        {
            return InternalRequestAsync<DescribeTablesRowsResponse>(req, "DescribeTablesRows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询作业详情。
        /// </summary>
        /// <param name="req"><see cref="GetRunCallsRequest"/></param>
        /// <returns><see cref="GetRunCallsResponse"/></returns>
        public Task<GetRunCallsResponse> GetRunCalls(GetRunCallsRequest req)
        {
            return InternalRequestAsync<GetRunCallsResponse>(req, "GetRunCalls");
        }

        /// <summary>
        /// 查询作业详情。
        /// </summary>
        /// <param name="req"><see cref="GetRunCallsRequest"/></param>
        /// <returns><see cref="GetRunCallsResponse"/></returns>
        public GetRunCallsResponse GetRunCallsSync(GetRunCallsRequest req)
        {
            return InternalRequestAsync<GetRunCallsResponse>(req, "GetRunCalls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务详情文件。
        /// </summary>
        /// <param name="req"><see cref="GetRunMetadataFileRequest"/></param>
        /// <returns><see cref="GetRunMetadataFileResponse"/></returns>
        public Task<GetRunMetadataFileResponse> GetRunMetadataFile(GetRunMetadataFileRequest req)
        {
            return InternalRequestAsync<GetRunMetadataFileResponse>(req, "GetRunMetadataFile");
        }

        /// <summary>
        /// 查询任务详情文件。
        /// </summary>
        /// <param name="req"><see cref="GetRunMetadataFileRequest"/></param>
        /// <returns><see cref="GetRunMetadataFileResponse"/></returns>
        public GetRunMetadataFileResponse GetRunMetadataFileSync(GetRunMetadataFileRequest req)
        {
            return InternalRequestAsync<GetRunMetadataFileResponse>(req, "GetRunMetadataFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务详情。
        /// </summary>
        /// <param name="req"><see cref="GetRunStatusRequest"/></param>
        /// <returns><see cref="GetRunStatusResponse"/></returns>
        public Task<GetRunStatusResponse> GetRunStatus(GetRunStatusRequest req)
        {
            return InternalRequestAsync<GetRunStatusResponse>(req, "GetRunStatus");
        }

        /// <summary>
        /// 查询任务详情。
        /// </summary>
        /// <param name="req"><see cref="GetRunStatusRequest"/></param>
        /// <returns><see cref="GetRunStatusResponse"/></returns>
        public GetRunStatusResponse GetRunStatusSync(GetRunStatusRequest req)
        {
            return InternalRequestAsync<GetRunStatusResponse>(req, "GetRunStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入表格文件。
        /// </summary>
        /// <param name="req"><see cref="ImportTableFileRequest"/></param>
        /// <returns><see cref="ImportTableFileResponse"/></returns>
        public Task<ImportTableFileResponse> ImportTableFile(ImportTableFileRequest req)
        {
            return InternalRequestAsync<ImportTableFileResponse>(req, "ImportTableFile");
        }

        /// <summary>
        /// 导入表格文件。
        /// </summary>
        /// <param name="req"><see cref="ImportTableFileRequest"/></param>
        /// <returns><see cref="ImportTableFileResponse"/></returns>
        public ImportTableFileResponse ImportTableFileSync(ImportTableFileRequest req)
        {
            return InternalRequestAsync<ImportTableFileResponse>(req, "ImportTableFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重试任务。
        /// </summary>
        /// <param name="req"><see cref="RetryRunsRequest"/></param>
        /// <returns><see cref="RetryRunsResponse"/></returns>
        public Task<RetryRunsResponse> RetryRuns(RetryRunsRequest req)
        {
            return InternalRequestAsync<RetryRunsResponse>(req, "RetryRuns");
        }

        /// <summary>
        /// 重试任务。
        /// </summary>
        /// <param name="req"><see cref="RetryRunsRequest"/></param>
        /// <returns><see cref="RetryRunsResponse"/></returns>
        public RetryRunsResponse RetryRunsSync(RetryRunsRequest req)
        {
            return InternalRequestAsync<RetryRunsResponse>(req, "RetryRuns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运行应用。
        /// </summary>
        /// <param name="req"><see cref="RunApplicationRequest"/></param>
        /// <returns><see cref="RunApplicationResponse"/></returns>
        public Task<RunApplicationResponse> RunApplication(RunApplicationRequest req)
        {
            return InternalRequestAsync<RunApplicationResponse>(req, "RunApplication");
        }

        /// <summary>
        /// 运行应用。
        /// </summary>
        /// <param name="req"><see cref="RunApplicationRequest"/></param>
        /// <returns><see cref="RunApplicationResponse"/></returns>
        public RunApplicationResponse RunApplicationSync(RunApplicationRequest req)
        {
            return InternalRequestAsync<RunApplicationResponse>(req, "RunApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运行工作流。
        /// </summary>
        /// <param name="req"><see cref="RunWorkflowRequest"/></param>
        /// <returns><see cref="RunWorkflowResponse"/></returns>
        public Task<RunWorkflowResponse> RunWorkflow(RunWorkflowRequest req)
        {
            return InternalRequestAsync<RunWorkflowResponse>(req, "RunWorkflow");
        }

        /// <summary>
        /// 运行工作流。
        /// </summary>
        /// <param name="req"><see cref="RunWorkflowRequest"/></param>
        /// <returns><see cref="RunWorkflowResponse"/></returns>
        public RunWorkflowResponse RunWorkflowSync(RunWorkflowRequest req)
        {
            return InternalRequestAsync<RunWorkflowResponse>(req, "RunWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终止任务批次。
        /// </summary>
        /// <param name="req"><see cref="TerminateRunGroupRequest"/></param>
        /// <returns><see cref="TerminateRunGroupResponse"/></returns>
        public Task<TerminateRunGroupResponse> TerminateRunGroup(TerminateRunGroupRequest req)
        {
            return InternalRequestAsync<TerminateRunGroupResponse>(req, "TerminateRunGroup");
        }

        /// <summary>
        /// 终止任务批次。
        /// </summary>
        /// <param name="req"><see cref="TerminateRunGroupRequest"/></param>
        /// <returns><see cref="TerminateRunGroupResponse"/></returns>
        public TerminateRunGroupResponse TerminateRunGroupSync(TerminateRunGroupRequest req)
        {
            return InternalRequestAsync<TerminateRunGroupResponse>(req, "TerminateRunGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
