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

namespace TencentCloud.Yunjing.V20180228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Yunjing.V20180228.Models;

   public class YunjingClient : AbstractClient{

       private const string endpoint = "yunjing.tencentcloudapi.com";
       private const string version = "2018-02-28";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public YunjingClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public YunjingClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口 (CloseProVersion) 用于关闭专业版。
        /// </summary>
        /// <param name="req">参考<see cref="CloseProVersionRequest"/></param>
        /// <returns>参考<see cref="CloseProVersionResponse"/>实例</returns>
        public async Task<CloseProVersionResponse> CloseProVersion(CloseProVersionRequest req)
        {
             JsonResponseModel<CloseProVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseProVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseProVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateProcessTask) 用于创建实时拉取进程任务。
        /// </summary>
        /// <param name="req">参考<see cref="CreateProcessTaskRequest"/></param>
        /// <returns>参考<see cref="CreateProcessTaskResponse"/>实例</returns>
        public async Task<CreateProcessTaskResponse> CreateProcessTask(CreateProcessTaskRequest req)
        {
             JsonResponseModel<CreateProcessTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProcessTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProcessTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateUsualLoginPlaces）用于添加常用登录地。
        /// </summary>
        /// <param name="req">参考<see cref="CreateUsualLoginPlacesRequest"/></param>
        /// <returns>参考<see cref="CreateUsualLoginPlacesResponse"/>实例</returns>
        public async Task<CreateUsualLoginPlacesResponse> CreateUsualLoginPlaces(CreateUsualLoginPlacesRequest req)
        {
             JsonResponseModel<CreateUsualLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUsualLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUsualLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteBruteAttacks) 用于删除暴力破解记录。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteBruteAttacksRequest"/></param>
        /// <returns>参考<see cref="DeleteBruteAttacksResponse"/>实例</returns>
        public async Task<DeleteBruteAttacksResponse> DeleteBruteAttacks(DeleteBruteAttacksRequest req)
        {
             JsonResponseModel<DeleteBruteAttacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBruteAttacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBruteAttacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMachine）用于卸载云镜客户端。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMachineRequest"/></param>
        /// <returns>参考<see cref="DeleteMachineResponse"/>实例</returns>
        public async Task<DeleteMachineResponse> DeleteMachine(DeleteMachineRequest req)
        {
             JsonResponseModel<DeleteMachineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteMaliciousRequests) 用于删除恶意请求记录。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMaliciousRequestsRequest"/></param>
        /// <returns>参考<see cref="DeleteMaliciousRequestsResponse"/>实例</returns>
        public async Task<DeleteMaliciousRequestsResponse> DeleteMaliciousRequests(DeleteMaliciousRequestsRequest req)
        {
             JsonResponseModel<DeleteMaliciousRequestsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMaliciousRequests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMaliciousRequestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteMalwares) 用于删除木马记录。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMalwaresRequest"/></param>
        /// <returns>参考<see cref="DeleteMalwaresResponse"/>实例</returns>
        public async Task<DeleteMalwaresResponse> DeleteMalwares(DeleteMalwaresRequest req)
        {
             JsonResponseModel<DeleteMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteNonlocalLoginPlaces) 用于删除异地登录记录。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteNonlocalLoginPlacesRequest"/></param>
        /// <returns>参考<see cref="DeleteNonlocalLoginPlacesResponse"/>实例</returns>
        public async Task<DeleteNonlocalLoginPlacesResponse> DeleteNonlocalLoginPlaces(DeleteNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<DeleteNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteUsualLoginPlaces）用于删除常用登录地。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteUsualLoginPlacesRequest"/></param>
        /// <returns>参考<see cref="DeleteUsualLoginPlacesResponse"/>实例</returns>
        public async Task<DeleteUsualLoginPlacesResponse> DeleteUsualLoginPlaces(DeleteUsualLoginPlacesRequest req)
        {
             JsonResponseModel<DeleteUsualLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUsualLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsualLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAccountStatistics) 用于获取帐号统计列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountStatisticsResponse"/>实例</returns>
        public async Task<DescribeAccountStatisticsResponse> DescribeAccountStatistics(DescribeAccountStatisticsRequest req)
        {
             JsonResponseModel<DescribeAccountStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAccounts) 用于获取帐号列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountsRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountsResponse"/>实例</returns>
        public async Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAgentVuls) 用于获取主机的漏洞列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAgentVulsRequest"/></param>
        /// <returns>参考<see cref="DescribeAgentVulsResponse"/>实例</returns>
        public async Task<DescribeAgentVulsResponse> DescribeAgentVuls(DescribeAgentVulsRequest req)
        {
             JsonResponseModel<DescribeAgentVulsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentVuls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentVulsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAlarmAttribute) 用于获取告警设置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAlarmAttributeRequest"/></param>
        /// <returns>参考<see cref="DescribeAlarmAttributeResponse"/>实例</returns>
        public async Task<DescribeAlarmAttributeResponse> DescribeAlarmAttribute(DescribeAlarmAttributeRequest req)
        {
             JsonResponseModel<DescribeAlarmAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口{DescribeBruteAttacks}用于获取暴力破解事件列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBruteAttacksRequest"/></param>
        /// <returns>参考<see cref="DescribeBruteAttacksResponse"/>实例</returns>
        public async Task<DescribeBruteAttacksResponse> DescribeBruteAttacks(DescribeBruteAttacksRequest req)
        {
             JsonResponseModel<DescribeBruteAttacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBruteAttacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBruteAttacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeComponentInfo) 用于获取组件信息数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeComponentInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeComponentInfoResponse"/>实例</returns>
        public async Task<DescribeComponentInfoResponse> DescribeComponentInfo(DescribeComponentInfoRequest req)
        {
             JsonResponseModel<DescribeComponentInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComponentInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComponentInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeComponentStatistics) 用于获取组件统计列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeComponentStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeComponentStatisticsResponse"/>实例</returns>
        public async Task<DescribeComponentStatisticsResponse> DescribeComponentStatistics(DescribeComponentStatisticsRequest req)
        {
             JsonResponseModel<DescribeComponentStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComponentStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComponentStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeComponents) 用于获取组件列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeComponentsRequest"/></param>
        /// <returns>参考<see cref="DescribeComponentsResponse"/>实例</returns>
        public async Task<DescribeComponentsResponse> DescribeComponents(DescribeComponentsRequest req)
        {
             JsonResponseModel<DescribeComponentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComponents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComponentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeHistoryAccounts) 用于获取帐号变更历史列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHistoryAccountsRequest"/></param>
        /// <returns>参考<see cref="DescribeHistoryAccountsResponse"/>实例</returns>
        public async Task<DescribeHistoryAccountsResponse> DescribeHistoryAccounts(DescribeHistoryAccountsRequest req)
        {
             JsonResponseModel<DescribeHistoryAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHistoryAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeImpactedHosts) 用于获取漏洞受影响机器列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImpactedHostsRequest"/></param>
        /// <returns>参考<see cref="DescribeImpactedHostsResponse"/>实例</returns>
        public async Task<DescribeImpactedHostsResponse> DescribeImpactedHosts(DescribeImpactedHostsRequest req)
        {
             JsonResponseModel<DescribeImpactedHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImpactedHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImpactedHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMachineInfo）用于获取机器详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMachineInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeMachineInfoResponse"/>实例</returns>
        public async Task<DescribeMachineInfoResponse> DescribeMachineInfo(DescribeMachineInfoRequest req)
        {
             JsonResponseModel<DescribeMachineInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeMachines) 用于获取区域主机列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMachinesRequest"/></param>
        /// <returns>参考<see cref="DescribeMachinesResponse"/>实例</returns>
        public async Task<DescribeMachinesResponse> DescribeMachines(DescribeMachinesRequest req)
        {
             JsonResponseModel<DescribeMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeMaliciousRequests) 用于获取恶意请求数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMaliciousRequestsRequest"/></param>
        /// <returns>参考<see cref="DescribeMaliciousRequestsResponse"/>实例</returns>
        public async Task<DescribeMaliciousRequestsResponse> DescribeMaliciousRequests(DescribeMaliciousRequestsRequest req)
        {
             JsonResponseModel<DescribeMaliciousRequestsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMaliciousRequests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaliciousRequestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMalwares）用于获取木马事件列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMalwaresRequest"/></param>
        /// <returns>参考<see cref="DescribeMalwaresResponse"/>实例</returns>
        public async Task<DescribeMalwaresResponse> DescribeMalwares(DescribeMalwaresRequest req)
        {
             JsonResponseModel<DescribeMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeNonlocalLoginPlaces)用于获取异地登录事件。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNonlocalLoginPlacesRequest"/></param>
        /// <returns>参考<see cref="DescribeNonlocalLoginPlacesResponse"/>实例</returns>
        public async Task<DescribeNonlocalLoginPlacesResponse> DescribeNonlocalLoginPlaces(DescribeNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<DescribeNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeOpenPortStatistics) 用于获取端口统计列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOpenPortStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeOpenPortStatisticsResponse"/>实例</returns>
        public async Task<DescribeOpenPortStatisticsResponse> DescribeOpenPortStatistics(DescribeOpenPortStatisticsRequest req)
        {
             JsonResponseModel<DescribeOpenPortStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOpenPortStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOpenPortStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeOpenPorts) 用于获取端口列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOpenPortsRequest"/></param>
        /// <returns>参考<see cref="DescribeOpenPortsResponse"/>实例</returns>
        public async Task<DescribeOpenPortsResponse> DescribeOpenPorts(DescribeOpenPortsRequest req)
        {
             JsonResponseModel<DescribeOpenPortsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOpenPorts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOpenPortsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于（DescribeOverviewStatistics）获取概览统计数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOverviewStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeOverviewStatisticsResponse"/>实例</returns>
        public async Task<DescribeOverviewStatisticsResponse> DescribeOverviewStatistics(DescribeOverviewStatisticsRequest req)
        {
             JsonResponseModel<DescribeOverviewStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeProVersionInfo) 用于获取专业版信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeProVersionInfoResponse"/>实例</returns>
        public async Task<DescribeProVersionInfoResponse> DescribeProVersionInfo(DescribeProVersionInfoRequest req)
        {
             JsonResponseModel<DescribeProVersionInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProVersionInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProVersionInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeProcessStatistics) 用于获取进程统计列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProcessStatisticsRequest"/></param>
        /// <returns>参考<see cref="DescribeProcessStatisticsResponse"/>实例</returns>
        public async Task<DescribeProcessStatisticsResponse> DescribeProcessStatistics(DescribeProcessStatisticsRequest req)
        {
             JsonResponseModel<DescribeProcessStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProcessStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcessStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeProcessTaskStatus) 用于获取实时拉取进程任务状态。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProcessTaskStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeProcessTaskStatusResponse"/>实例</returns>
        public async Task<DescribeProcessTaskStatusResponse> DescribeProcessTaskStatus(DescribeProcessTaskStatusRequest req)
        {
             JsonResponseModel<DescribeProcessTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProcessTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcessTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeProcesses) 用于获取进程列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProcessesRequest"/></param>
        /// <returns>参考<see cref="DescribeProcessesResponse"/>实例</returns>
        public async Task<DescribeProcessesResponse> DescribeProcesses(DescribeProcessesRequest req)
        {
             JsonResponseModel<DescribeProcessesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProcesses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcessesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeSecurityDynamics) 用于获取安全事件消息数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSecurityDynamicsRequest"/></param>
        /// <returns>参考<see cref="DescribeSecurityDynamicsResponse"/>实例</returns>
        public async Task<DescribeSecurityDynamicsResponse> DescribeSecurityDynamics(DescribeSecurityDynamicsRequest req)
        {
             JsonResponseModel<DescribeSecurityDynamicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityDynamics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityDynamicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeSecurityTrends) 用于获取安全事件统计数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSecurityTrendsRequest"/></param>
        /// <returns>参考<see cref="DescribeSecurityTrendsResponse"/>实例</returns>
        public async Task<DescribeSecurityTrendsResponse> DescribeSecurityTrends(DescribeSecurityTrendsRequest req)
        {
             JsonResponseModel<DescribeSecurityTrendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityTrends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityTrendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsualLoginPlaces）用于查询常用登录地。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUsualLoginPlacesRequest"/></param>
        /// <returns>参考<see cref="DescribeUsualLoginPlacesResponse"/>实例</returns>
        public async Task<DescribeUsualLoginPlacesResponse> DescribeUsualLoginPlaces(DescribeUsualLoginPlacesRequest req)
        {
             JsonResponseModel<DescribeUsualLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsualLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsualLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeVulInfo) 用于获取漏洞详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVulInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeVulInfoResponse"/>实例</returns>
        public async Task<DescribeVulInfoResponse> DescribeVulInfo(DescribeVulInfoRequest req)
        {
             JsonResponseModel<DescribeVulInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeVulScanResult) 用于获取漏洞检测结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVulScanResultRequest"/></param>
        /// <returns>参考<see cref="DescribeVulScanResultResponse"/>实例</returns>
        public async Task<DescribeVulScanResultResponse> DescribeVulScanResult(DescribeVulScanResultRequest req)
        {
             JsonResponseModel<DescribeVulScanResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulScanResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulScanResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeVuls) 用于获取漏洞列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVulsRequest"/></param>
        /// <returns>参考<see cref="DescribeVulsResponse"/>实例</returns>
        public async Task<DescribeVulsResponse> DescribeVuls(DescribeVulsRequest req)
        {
             JsonResponseModel<DescribeVulsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVuls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportBruteAttacks) 用于获取专业周报密码破解数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWeeklyReportBruteAttacksRequest"/></param>
        /// <returns>参考<see cref="DescribeWeeklyReportBruteAttacksResponse"/>实例</returns>
        public async Task<DescribeWeeklyReportBruteAttacksResponse> DescribeWeeklyReportBruteAttacks(DescribeWeeklyReportBruteAttacksRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportBruteAttacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportBruteAttacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportBruteAttacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportInfo) 用于获取专业周报详情数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWeeklyReportInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeWeeklyReportInfoResponse"/>实例</returns>
        public async Task<DescribeWeeklyReportInfoResponse> DescribeWeeklyReportInfo(DescribeWeeklyReportInfoRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportMalwares) 用于获取专业周报木马数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWeeklyReportMalwaresRequest"/></param>
        /// <returns>参考<see cref="DescribeWeeklyReportMalwaresResponse"/>实例</returns>
        public async Task<DescribeWeeklyReportMalwaresResponse> DescribeWeeklyReportMalwares(DescribeWeeklyReportMalwaresRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportNonlocalLoginPlaces) 用于获取专业周报异地登录数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWeeklyReportNonlocalLoginPlacesRequest"/></param>
        /// <returns>参考<see cref="DescribeWeeklyReportNonlocalLoginPlacesResponse"/>实例</returns>
        public async Task<DescribeWeeklyReportNonlocalLoginPlacesResponse> DescribeWeeklyReportNonlocalLoginPlaces(DescribeWeeklyReportNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportVuls) 用于专业版周报漏洞数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWeeklyReportVulsRequest"/></param>
        /// <returns>参考<see cref="DescribeWeeklyReportVulsResponse"/>实例</returns>
        public async Task<DescribeWeeklyReportVulsResponse> DescribeWeeklyReportVuls(DescribeWeeklyReportVulsRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportVulsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportVuls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportVulsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReports) 用于获取周报列表数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWeeklyReportsRequest"/></param>
        /// <returns>参考<see cref="DescribeWeeklyReportsResponse"/>实例</returns>
        public async Task<DescribeWeeklyReportsResponse> DescribeWeeklyReports(DescribeWeeklyReportsRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ExportMaliciousRequests) 用于导出下载恶意请求文件。
        /// </summary>
        /// <param name="req">参考<see cref="ExportMaliciousRequestsRequest"/></param>
        /// <returns>参考<see cref="ExportMaliciousRequestsResponse"/>实例</returns>
        public async Task<ExportMaliciousRequestsResponse> ExportMaliciousRequests(ExportMaliciousRequestsRequest req)
        {
             JsonResponseModel<ExportMaliciousRequestsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportMaliciousRequests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportMaliciousRequestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (IngoreImpactedHosts) 用于忽略漏洞。
        /// </summary>
        /// <param name="req">参考<see cref="IgnoreImpactedHostsRequest"/></param>
        /// <returns>参考<see cref="IgnoreImpactedHostsResponse"/>实例</returns>
        public async Task<IgnoreImpactedHostsResponse> IgnoreImpactedHosts(IgnoreImpactedHostsRequest req)
        {
             JsonResponseModel<IgnoreImpactedHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IgnoreImpactedHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IgnoreImpactedHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceOpenProVersionPrepaid) 用于开通专业版询价(预付费)。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceOpenProVersionPrepaidRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceOpenProVersionPrepaidResponse"/>实例</returns>
        public async Task<InquiryPriceOpenProVersionPrepaidResponse> InquiryPriceOpenProVersionPrepaid(InquiryPriceOpenProVersionPrepaidRequest req)
        {
             JsonResponseModel<InquiryPriceOpenProVersionPrepaidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceOpenProVersionPrepaid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceOpenProVersionPrepaidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口{MisAlarmNonlocalLoginPlaces}将设置当前地点为常用登录地。
        /// </summary>
        /// <param name="req">参考<see cref="MisAlarmNonlocalLoginPlacesRequest"/></param>
        /// <returns>参考<see cref="MisAlarmNonlocalLoginPlacesResponse"/>实例</returns>
        public async Task<MisAlarmNonlocalLoginPlacesResponse> MisAlarmNonlocalLoginPlaces(MisAlarmNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<MisAlarmNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MisAlarmNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MisAlarmNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAlarmAttribute）用于修改告警设置。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAlarmAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyAlarmAttributeResponse"/>实例</returns>
        public async Task<ModifyAlarmAttributeResponse> ModifyAlarmAttribute(ModifyAlarmAttributeRequest req)
        {
             JsonResponseModel<ModifyAlarmAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyAutoOpenProVersionConfig) 用于设置新增主机自动开通专业版配置。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAutoOpenProVersionConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyAutoOpenProVersionConfigResponse"/>实例</returns>
        public async Task<ModifyAutoOpenProVersionConfigResponse> ModifyAutoOpenProVersionConfig(ModifyAutoOpenProVersionConfigRequest req)
        {
             JsonResponseModel<ModifyAutoOpenProVersionConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoOpenProVersionConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoOpenProVersionConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyProVersionRenewFlag) 用于修改专业版包年包月续费标识。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyProVersionRenewFlagRequest"/></param>
        /// <returns>参考<see cref="ModifyProVersionRenewFlagResponse"/>实例</returns>
        public async Task<ModifyProVersionRenewFlagResponse> ModifyProVersionRenewFlag(ModifyProVersionRenewFlagRequest req)
        {
             JsonResponseModel<ModifyProVersionRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProVersionRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProVersionRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (OpenProVersionPrepaid) 用于开通专业版(包年包月)。
        /// </summary>
        /// <param name="req">参考<see cref="OpenProVersionPrepaidRequest"/></param>
        /// <returns>参考<see cref="OpenProVersionPrepaidResponse"/>实例</returns>
        public async Task<OpenProVersionPrepaidResponse> OpenProVersionPrepaid(OpenProVersionPrepaidRequest req)
        {
             JsonResponseModel<OpenProVersionPrepaidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenProVersionPrepaid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProVersionPrepaidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RecoverMalwares）用于批量恢复已经被隔离的木马文件。
        /// </summary>
        /// <param name="req">参考<see cref="RecoverMalwaresRequest"/></param>
        /// <returns>参考<see cref="RecoverMalwaresResponse"/>实例</returns>
        public async Task<RecoverMalwaresResponse> RecoverMalwares(RecoverMalwaresRequest req)
        {
             JsonResponseModel<RecoverMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (RenewProVersion) 用于续费专业版(包年包月)。
        /// </summary>
        /// <param name="req">参考<see cref="RenewProVersionRequest"/></param>
        /// <returns>参考<see cref="RenewProVersionResponse"/>实例</returns>
        public async Task<RenewProVersionResponse> RenewProVersion(RenewProVersionRequest req)
        {
             JsonResponseModel<RenewProVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewProVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewProVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (RescanImpactedHosts) 用于漏洞重新检测。
        /// </summary>
        /// <param name="req">参考<see cref="RescanImpactedHostRequest"/></param>
        /// <returns>参考<see cref="RescanImpactedHostResponse"/>实例</returns>
        public async Task<RescanImpactedHostResponse> RescanImpactedHost(RescanImpactedHostRequest req)
        {
             JsonResponseModel<RescanImpactedHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RescanImpactedHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RescanImpactedHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SeparateMalwares）用于隔离木马。
        /// </summary>
        /// <param name="req">参考<see cref="SeparateMalwaresRequest"/></param>
        /// <returns>参考<see cref="SeparateMalwaresResponse"/>实例</returns>
        public async Task<SeparateMalwaresResponse> SeparateMalwares(SeparateMalwaresRequest req)
        {
             JsonResponseModel<SeparateMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SeparateMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SeparateMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (TrustMaliciousRequest) 用于恶意请求添加信任。
        /// </summary>
        /// <param name="req">参考<see cref="TrustMaliciousRequestRequest"/></param>
        /// <returns>参考<see cref="TrustMaliciousRequestResponse"/>实例</returns>
        public async Task<TrustMaliciousRequestResponse> TrustMaliciousRequest(TrustMaliciousRequestRequest req)
        {
             JsonResponseModel<TrustMaliciousRequestResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TrustMaliciousRequest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TrustMaliciousRequestResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(TrustMalwares)将被识别木马文件设为信任。
        /// </summary>
        /// <param name="req">参考<see cref="TrustMalwaresRequest"/></param>
        /// <returns>参考<see cref="TrustMalwaresResponse"/>实例</returns>
        public async Task<TrustMalwaresResponse> TrustMalwares(TrustMalwaresRequest req)
        {
             JsonResponseModel<TrustMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TrustMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TrustMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (UntrustMaliciousRequest) 用于取消信任恶意请求。
        /// </summary>
        /// <param name="req">参考<see cref="UntrustMaliciousRequestRequest"/></param>
        /// <returns>参考<see cref="UntrustMaliciousRequestResponse"/>实例</returns>
        public async Task<UntrustMaliciousRequestResponse> UntrustMaliciousRequest(UntrustMaliciousRequestRequest req)
        {
             JsonResponseModel<UntrustMaliciousRequestResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UntrustMaliciousRequest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UntrustMaliciousRequestResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UntrustMalwares）用于取消信任木马文件。
        /// </summary>
        /// <param name="req">参考<see cref="UntrustMalwaresRequest"/></param>
        /// <returns>参考<see cref="UntrustMalwaresResponse"/>实例</returns>
        public async Task<UntrustMalwaresResponse> UntrustMalwares(UntrustMalwaresRequest req)
        {
             JsonResponseModel<UntrustMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UntrustMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UntrustMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
