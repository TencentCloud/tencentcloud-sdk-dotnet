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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AswClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 该接口用于生成状态机服务
        /// </summary>
        /// <param name="req"><see cref="CreateFlowServiceRequest"/></param>
        /// <returns><see cref="CreateFlowServiceResponse"/></returns>
        public async Task<CreateFlowServiceResponse> CreateFlowService(CreateFlowServiceRequest req)
        {
             JsonResponseModel<CreateFlowServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于生成状态机服务
        /// </summary>
        /// <param name="req"><see cref="CreateFlowServiceRequest"/></param>
        /// <returns><see cref="CreateFlowServiceResponse"/></returns>
        public CreateFlowServiceResponse CreateFlowServiceSync(CreateFlowServiceRequest req)
        {
             JsonResponseModel<CreateFlowServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询执行详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionRequest"/></param>
        /// <returns><see cref="DescribeExecutionResponse"/></returns>
        public async Task<DescribeExecutionResponse> DescribeExecution(DescribeExecutionRequest req)
        {
             JsonResponseModel<DescribeExecutionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询执行详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionRequest"/></param>
        /// <returns><see cref="DescribeExecutionResponse"/></returns>
        public DescribeExecutionResponse DescribeExecutionSync(DescribeExecutionRequest req)
        {
             JsonResponseModel<DescribeExecutionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对状态机的执行历史进行描述.
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionsRequest"/></param>
        /// <returns><see cref="DescribeExecutionsResponse"/></returns>
        public async Task<DescribeExecutionsResponse> DescribeExecutions(DescribeExecutionsRequest req)
        {
             JsonResponseModel<DescribeExecutionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExecutions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExecutionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对状态机的执行历史进行描述.
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionsRequest"/></param>
        /// <returns><see cref="DescribeExecutionsResponse"/></returns>
        public DescribeExecutionsResponse DescribeExecutionsSync(DescribeExecutionsRequest req)
        {
             JsonResponseModel<DescribeExecutionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExecutions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExecutionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询该用户指定状态机下的详情数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowServiceDetailRequest"/></param>
        /// <returns><see cref="DescribeFlowServiceDetailResponse"/></returns>
        public async Task<DescribeFlowServiceDetailResponse> DescribeFlowServiceDetail(DescribeFlowServiceDetailRequest req)
        {
             JsonResponseModel<DescribeFlowServiceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowServiceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowServiceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询该用户指定状态机下的详情数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowServiceDetailRequest"/></param>
        /// <returns><see cref="DescribeFlowServiceDetailResponse"/></returns>
        public DescribeFlowServiceDetailResponse DescribeFlowServiceDetailSync(DescribeFlowServiceDetailRequest req)
        {
             JsonResponseModel<DescribeFlowServiceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowServiceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowServiceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改状态机
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowServiceRequest"/></param>
        /// <returns><see cref="ModifyFlowServiceResponse"/></returns>
        public async Task<ModifyFlowServiceResponse> ModifyFlowService(ModifyFlowServiceRequest req)
        {
             JsonResponseModel<ModifyFlowServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFlowService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFlowServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改状态机
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowServiceRequest"/></param>
        /// <returns><see cref="ModifyFlowServiceResponse"/></returns>
        public ModifyFlowServiceResponse ModifyFlowServiceSync(ModifyFlowServiceRequest req)
        {
             JsonResponseModel<ModifyFlowServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFlowService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFlowServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为指定的状态机启动一次执行
        /// </summary>
        /// <param name="req"><see cref="StartExecutionRequest"/></param>
        /// <returns><see cref="StartExecutionResponse"/></returns>
        public async Task<StartExecutionResponse> StartExecution(StartExecutionRequest req)
        {
             JsonResponseModel<StartExecutionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为指定的状态机启动一次执行
        /// </summary>
        /// <param name="req"><see cref="StartExecutionRequest"/></param>
        /// <returns><see cref="StartExecutionResponse"/></returns>
        public StartExecutionResponse StartExecutionSync(StartExecutionRequest req)
        {
             JsonResponseModel<StartExecutionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartExecution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartExecutionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
