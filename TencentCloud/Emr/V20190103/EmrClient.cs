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

namespace TencentCloud.Emr.V20190103
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Emr.V20190103.Models;

   public class EmrClient : AbstractClient{

       private const string endpoint = "emr.tencentcloudapi.com";
       private const string version = "2019-01-03";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EmrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EmrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 该接口支持安装了OpenLdap组件的集群。
        /// 新增用户列表（用户管理）。
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public async Task<AddUsersForUserManagerResponse> AddUsersForUserManager(AddUsersForUserManagerRequest req)
        {
             JsonResponseModel<AddUsersForUserManagerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUsersForUserManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUsersForUserManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口支持安装了OpenLdap组件的集群。
        /// 新增用户列表（用户管理）。
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public AddUsersForUserManagerResponse AddUsersForUserManagerSync(AddUsersForUserManagerRequest req)
        {
             JsonResponseModel<AddUsersForUserManagerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUsersForUserManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUsersForUserManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建EMR集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public async Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建EMR集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询硬件节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public async Task<DescribeClusterNodesResponse> DescribeClusterNodes(DescribeClusterNodesRequest req)
        {
             JsonResponseModel<DescribeClusterNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询硬件节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public DescribeClusterNodesResponse DescribeClusterNodesSync(DescribeClusterNodesRequest req)
        {
             JsonResponseModel<DescribeClusterNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账户的CVM配额
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmQuotaRequest"/></param>
        /// <returns><see cref="DescribeCvmQuotaResponse"/></returns>
        public async Task<DescribeCvmQuotaResponse> DescribeCvmQuota(DescribeCvmQuotaRequest req)
        {
             JsonResponseModel<DescribeCvmQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCvmQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCvmQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账户的CVM配额
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmQuotaRequest"/></param>
        /// <returns><see cref="DescribeCvmQuotaResponse"/></returns>
        public DescribeCvmQuotaResponse DescribeCvmQuotaSync(DescribeCvmQuotaRequest req)
        {
             JsonResponseModel<DescribeCvmQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCvmQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCvmQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// （通过走emrcc接入到cam） yarn applciation 统计接口
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public async Task<DescribeEmrApplicationStaticsResponse> DescribeEmrApplicationStatics(DescribeEmrApplicationStaticsRequest req)
        {
             JsonResponseModel<DescribeEmrApplicationStaticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEmrApplicationStatics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmrApplicationStaticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// （通过走emrcc接入到cam） yarn applciation 统计接口
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public DescribeEmrApplicationStaticsResponse DescribeEmrApplicationStaticsSync(DescribeEmrApplicationStaticsRequest req)
        {
             JsonResponseModel<DescribeEmrApplicationStaticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEmrApplicationStatics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmrApplicationStaticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 预付费集群隔离后续费资源查询
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRenewNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceRenewNodesResponse"/></returns>
        public async Task<DescribeInstanceRenewNodesResponse> DescribeInstanceRenewNodes(DescribeInstanceRenewNodesRequest req)
        {
             JsonResponseModel<DescribeInstanceRenewNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceRenewNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceRenewNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 预付费集群隔离后续费资源查询
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRenewNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceRenewNodesResponse"/></returns>
        public DescribeInstanceRenewNodesResponse DescribeInstanceRenewNodesSync(DescribeInstanceRenewNodesRequest req)
        {
             JsonResponseModel<DescribeInstanceRenewNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceRenewNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceRenewNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询EMR实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询EMR实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EMR集群实例列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public async Task<DescribeInstancesListResponse> DescribeInstancesList(DescribeInstancesListRequest req)
        {
             JsonResponseModel<DescribeInstancesListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EMR集群实例列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public DescribeInstancesListResponse DescribeInstancesListSync(DescribeInstancesListRequest req)
        {
             JsonResponseModel<DescribeInstancesListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程任务
        /// </summary>
        /// <param name="req"><see cref="DescribeJobFlowRequest"/></param>
        /// <returns><see cref="DescribeJobFlowResponse"/></returns>
        public async Task<DescribeJobFlowResponse> DescribeJobFlow(DescribeJobFlowRequest req)
        {
             JsonResponseModel<DescribeJobFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程任务
        /// </summary>
        /// <param name="req"><see cref="DescribeJobFlowRequest"/></param>
        /// <returns><see cref="DescribeJobFlowResponse"/></returns>
        public DescribeJobFlowResponse DescribeJobFlowSync(DescribeJobFlowRequest req)
        {
             JsonResponseModel<DescribeJobFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJobFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取yarn资源调度页面的数据
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public async Task<DescribeResourceScheduleResponse> DescribeResourceSchedule(DescribeResourceScheduleRequest req)
        {
             JsonResponseModel<DescribeResourceScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取yarn资源调度页面的数据
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public DescribeResourceScheduleResponse DescribeResourceScheduleSync(DescribeResourceScheduleRequest req)
        {
             JsonResponseModel<DescribeResourceScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口支持安装了OpenLdap组件的集群。
        /// 批量导出用户。对于kerberos集群，如果需要kertab文件下载地址，可以将NeedKeytabInfo设置为true；注意SupportDownLoadKeyTab为true，但是DownLoadKeyTabUrl为空字符串，表示keytab文件在后台没有准备好（正在生成）。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public async Task<DescribeUsersForUserManagerResponse> DescribeUsersForUserManager(DescribeUsersForUserManagerRequest req)
        {
             JsonResponseModel<DescribeUsersForUserManagerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsersForUserManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersForUserManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口支持安装了OpenLdap组件的集群。
        /// 批量导出用户。对于kerberos集群，如果需要kertab文件下载地址，可以将NeedKeytabInfo设置为true；注意SupportDownLoadKeyTab为true，但是DownLoadKeyTabUrl为空字符串，表示keytab文件在后台没有准备好（正在生成）。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public DescribeUsersForUserManagerResponse DescribeUsersForUserManagerSync(DescribeUsersForUserManagerRequest req)
        {
             JsonResponseModel<DescribeUsersForUserManagerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsersForUserManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersForUserManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群续费询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewEmrRequest"/></param>
        /// <returns><see cref="InquirePriceRenewEmrResponse"/></returns>
        public async Task<InquirePriceRenewEmrResponse> InquirePriceRenewEmr(InquirePriceRenewEmrRequest req)
        {
             JsonResponseModel<InquirePriceRenewEmrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceRenewEmr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewEmrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群续费询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewEmrRequest"/></param>
        /// <returns><see cref="InquirePriceRenewEmrResponse"/></returns>
        public InquirePriceRenewEmrResponse InquirePriceRenewEmrSync(InquirePriceRenewEmrRequest req)
        {
             JsonResponseModel<InquirePriceRenewEmrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceRenewEmr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewEmrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例询价
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public async Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceCreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例询价
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public InquiryPriceCreateInstanceResponse InquiryPriceCreateInstanceSync(InquiryPriceCreateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceCreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 续费询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public async Task<InquiryPriceRenewInstanceResponse> InquiryPriceRenewInstance(InquiryPriceRenewInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 续费询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public InquiryPriceRenewInstanceResponse InquiryPriceRenewInstanceSync(InquiryPriceRenewInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩容询价. 当扩容时候，请通过该接口查询价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public async Task<InquiryPriceScaleOutInstanceResponse> InquiryPriceScaleOutInstance(InquiryPriceScaleOutInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩容询价. 当扩容时候，请通过该接口查询价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public InquiryPriceScaleOutInstanceResponse InquiryPriceScaleOutInstanceSync(InquiryPriceScaleOutInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 变配询价
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public async Task<InquiryPriceUpdateInstanceResponse> InquiryPriceUpdateInstance(InquiryPriceUpdateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 变配询价
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public InquiryPriceUpdateInstanceResponse InquiryPriceUpdateInstanceSync(InquiryPriceUpdateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceUpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新动态资源池
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePoolsRequest"/></param>
        /// <returns><see cref="ModifyResourcePoolsResponse"/></returns>
        public async Task<ModifyResourcePoolsResponse> ModifyResourcePools(ModifyResourcePoolsRequest req)
        {
             JsonResponseModel<ModifyResourcePoolsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourcePools");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourcePoolsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新动态资源池
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePoolsRequest"/></param>
        /// <returns><see cref="ModifyResourcePoolsResponse"/></returns>
        public ModifyResourcePoolsResponse ModifyResourcePoolsSync(ModifyResourcePoolsRequest req)
        {
             JsonResponseModel<ModifyResourcePoolsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourcePools");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourcePoolsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改yarn资源调度的资源配置
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public async Task<ModifyResourceScheduleConfigResponse> ModifyResourceScheduleConfig(ModifyResourceScheduleConfigRequest req)
        {
             JsonResponseModel<ModifyResourceScheduleConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceScheduleConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceScheduleConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改yarn资源调度的资源配置
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public ModifyResourceScheduleConfigResponse ModifyResourceScheduleConfigSync(ModifyResourceScheduleConfigRequest req)
        {
             JsonResponseModel<ModifyResourceScheduleConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceScheduleConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceScheduleConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改了yarn的资源调度器，点击部署生效
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public async Task<ModifyResourceSchedulerResponse> ModifyResourceScheduler(ModifyResourceSchedulerRequest req)
        {
             JsonResponseModel<ModifyResourceSchedulerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceScheduler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceSchedulerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改了yarn的资源调度器，点击部署生效
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public ModifyResourceSchedulerResponse ModifyResourceSchedulerSync(ModifyResourceSchedulerRequest req)
        {
             JsonResponseModel<ModifyResourceSchedulerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceScheduler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceSchedulerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建流程作业
        /// </summary>
        /// <param name="req"><see cref="RunJobFlowRequest"/></param>
        /// <returns><see cref="RunJobFlowResponse"/></returns>
        public async Task<RunJobFlowResponse> RunJobFlow(RunJobFlowRequest req)
        {
             JsonResponseModel<RunJobFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunJobFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunJobFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建流程作业
        /// </summary>
        /// <param name="req"><see cref="RunJobFlowRequest"/></param>
        /// <returns><see cref="RunJobFlowResponse"/></returns>
        public RunJobFlowResponse RunJobFlowSync(RunJobFlowRequest req)
        {
             JsonResponseModel<RunJobFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunJobFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunJobFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例扩容
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public async Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
             JsonResponseModel<ScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例扩容
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
             JsonResponseModel<ScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EMR同步TKE中POD状态
        /// </summary>
        /// <param name="req"><see cref="SyncPodStateRequest"/></param>
        /// <returns><see cref="SyncPodStateResponse"/></returns>
        public async Task<SyncPodStateResponse> SyncPodState(SyncPodStateRequest req)
        {
             JsonResponseModel<SyncPodStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncPodState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncPodStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EMR同步TKE中POD状态
        /// </summary>
        /// <param name="req"><see cref="SyncPodStateRequest"/></param>
        /// <returns><see cref="SyncPodStateResponse"/></returns>
        public SyncPodStateResponse SyncPodStateSync(SyncPodStateRequest req)
        {
             JsonResponseModel<SyncPodStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncPodState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncPodStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁EMR实例。此接口仅支持弹性MapReduce正式计费版本。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public async Task<TerminateInstanceResponse> TerminateInstance(TerminateInstanceRequest req)
        {
             JsonResponseModel<TerminateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁EMR实例。此接口仅支持弹性MapReduce正式计费版本。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public TerminateInstanceResponse TerminateInstanceSync(TerminateInstanceRequest req)
        {
             JsonResponseModel<TerminateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 缩容Task节点
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public async Task<TerminateTasksResponse> TerminateTasks(TerminateTasksRequest req)
        {
             JsonResponseModel<TerminateTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 缩容Task节点
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public TerminateTasksResponse TerminateTasksSync(TerminateTasksRequest req)
        {
             JsonResponseModel<TerminateTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
