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

namespace TencentCloud.Asw.V20200722
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Asw.V20200722.Models;

   public class AswClient : AbstractClient{

       private const string endpoint = "asw.tencentcloudapi.com";
       private const string version = "2020-07-22";
       private const string sdkVersion = "SDK_NET_3.0.955";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AswClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AswClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 该接口用于生成状态机服务
        /// </summary>
        /// <param name="req"><see cref="CreateFlowServiceRequest"/></param>
        /// <returns><see cref="CreateFlowServiceResponse"/></returns>
        public Task<CreateFlowServiceResponse> CreateFlowService(CreateFlowServiceRequest req)
        {
            return InternalRequestAsync<CreateFlowServiceResponse>(req, "CreateFlowService");
        }

        /// <summary>
        /// 该接口用于生成状态机服务
        /// </summary>
        /// <param name="req"><see cref="CreateFlowServiceRequest"/></param>
        /// <returns><see cref="CreateFlowServiceResponse"/></returns>
        public CreateFlowServiceResponse CreateFlowServiceSync(CreateFlowServiceRequest req)
        {
            return InternalRequestAsync<CreateFlowServiceResponse>(req, "CreateFlowService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询执行详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionRequest"/></param>
        /// <returns><see cref="DescribeExecutionResponse"/></returns>
        public Task<DescribeExecutionResponse> DescribeExecution(DescribeExecutionRequest req)
        {
            return InternalRequestAsync<DescribeExecutionResponse>(req, "DescribeExecution");
        }

        /// <summary>
        /// 查询执行详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionRequest"/></param>
        /// <returns><see cref="DescribeExecutionResponse"/></returns>
        public DescribeExecutionResponse DescribeExecutionSync(DescribeExecutionRequest req)
        {
            return InternalRequestAsync<DescribeExecutionResponse>(req, "DescribeExecution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 一次执行会有很多步骤，经过很多节点，这个接口描述某一次执行的事件的历史
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionHistoryRequest"/></param>
        /// <returns><see cref="DescribeExecutionHistoryResponse"/></returns>
        public Task<DescribeExecutionHistoryResponse> DescribeExecutionHistory(DescribeExecutionHistoryRequest req)
        {
            return InternalRequestAsync<DescribeExecutionHistoryResponse>(req, "DescribeExecutionHistory");
        }

        /// <summary>
        /// 一次执行会有很多步骤，经过很多节点，这个接口描述某一次执行的事件的历史
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionHistoryRequest"/></param>
        /// <returns><see cref="DescribeExecutionHistoryResponse"/></returns>
        public DescribeExecutionHistoryResponse DescribeExecutionHistorySync(DescribeExecutionHistoryRequest req)
        {
            return InternalRequestAsync<DescribeExecutionHistoryResponse>(req, "DescribeExecutionHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对状态机的执行历史进行描述.
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionsRequest"/></param>
        /// <returns><see cref="DescribeExecutionsResponse"/></returns>
        public Task<DescribeExecutionsResponse> DescribeExecutions(DescribeExecutionsRequest req)
        {
            return InternalRequestAsync<DescribeExecutionsResponse>(req, "DescribeExecutions");
        }

        /// <summary>
        /// 对状态机的执行历史进行描述.
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionsRequest"/></param>
        /// <returns><see cref="DescribeExecutionsResponse"/></returns>
        public DescribeExecutionsResponse DescribeExecutionsSync(DescribeExecutionsRequest req)
        {
            return InternalRequestAsync<DescribeExecutionsResponse>(req, "DescribeExecutions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询该用户指定状态机下的详情数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowServiceDetailRequest"/></param>
        /// <returns><see cref="DescribeFlowServiceDetailResponse"/></returns>
        public Task<DescribeFlowServiceDetailResponse> DescribeFlowServiceDetail(DescribeFlowServiceDetailRequest req)
        {
            return InternalRequestAsync<DescribeFlowServiceDetailResponse>(req, "DescribeFlowServiceDetail");
        }

        /// <summary>
        /// 查询该用户指定状态机下的详情数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowServiceDetailRequest"/></param>
        /// <returns><see cref="DescribeFlowServiceDetailResponse"/></returns>
        public DescribeFlowServiceDetailResponse DescribeFlowServiceDetailSync(DescribeFlowServiceDetailRequest req)
        {
            return InternalRequestAsync<DescribeFlowServiceDetailResponse>(req, "DescribeFlowServiceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定用户下所有状态机，以列表形式返回
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowServicesRequest"/></param>
        /// <returns><see cref="DescribeFlowServicesResponse"/></returns>
        public Task<DescribeFlowServicesResponse> DescribeFlowServices(DescribeFlowServicesRequest req)
        {
            return InternalRequestAsync<DescribeFlowServicesResponse>(req, "DescribeFlowServices");
        }

        /// <summary>
        /// 查询指定用户下所有状态机，以列表形式返回
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowServicesRequest"/></param>
        /// <returns><see cref="DescribeFlowServicesResponse"/></returns>
        public DescribeFlowServicesResponse DescribeFlowServicesSync(DescribeFlowServicesRequest req)
        {
            return InternalRequestAsync<DescribeFlowServicesResponse>(req, "DescribeFlowServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改状态机
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowServiceRequest"/></param>
        /// <returns><see cref="ModifyFlowServiceResponse"/></returns>
        public Task<ModifyFlowServiceResponse> ModifyFlowService(ModifyFlowServiceRequest req)
        {
            return InternalRequestAsync<ModifyFlowServiceResponse>(req, "ModifyFlowService");
        }

        /// <summary>
        /// 该接口用于修改状态机
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowServiceRequest"/></param>
        /// <returns><see cref="ModifyFlowServiceResponse"/></returns>
        public ModifyFlowServiceResponse ModifyFlowServiceSync(ModifyFlowServiceRequest req)
        {
            return InternalRequestAsync<ModifyFlowServiceResponse>(req, "ModifyFlowService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为指定的状态机启动一次执行
        /// </summary>
        /// <param name="req"><see cref="StartExecutionRequest"/></param>
        /// <returns><see cref="StartExecutionResponse"/></returns>
        public Task<StartExecutionResponse> StartExecution(StartExecutionRequest req)
        {
            return InternalRequestAsync<StartExecutionResponse>(req, "StartExecution");
        }

        /// <summary>
        /// 为指定的状态机启动一次执行
        /// </summary>
        /// <param name="req"><see cref="StartExecutionRequest"/></param>
        /// <returns><see cref="StartExecutionResponse"/></returns>
        public StartExecutionResponse StartExecutionSync(StartExecutionRequest req)
        {
            return InternalRequestAsync<StartExecutionResponse>(req, "StartExecution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终止某个状态机
        /// </summary>
        /// <param name="req"><see cref="StopExecutionRequest"/></param>
        /// <returns><see cref="StopExecutionResponse"/></returns>
        public Task<StopExecutionResponse> StopExecution(StopExecutionRequest req)
        {
            return InternalRequestAsync<StopExecutionResponse>(req, "StopExecution");
        }

        /// <summary>
        /// 终止某个状态机
        /// </summary>
        /// <param name="req"><see cref="StopExecutionRequest"/></param>
        /// <returns><see cref="StopExecutionResponse"/></returns>
        public StopExecutionResponse StopExecutionSync(StopExecutionRequest req)
        {
            return InternalRequestAsync<StopExecutionResponse>(req, "StopExecution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
