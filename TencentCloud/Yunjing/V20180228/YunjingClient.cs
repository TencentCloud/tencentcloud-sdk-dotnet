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
