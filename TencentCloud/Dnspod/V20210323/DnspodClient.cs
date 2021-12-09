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

namespace TencentCloud.Dnspod.V20210323
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dnspod.V20210323.Models;

   public class DnspodClient : AbstractClient{

       private const string endpoint = "dnspod.tencentcloudapi.com";
       private const string version = "2021-03-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DnspodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DnspodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加域名
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public async Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
             JsonResponseModel<CreateDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加域名
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public CreateDomainResponse CreateDomainSync(CreateDomainRequest req)
        {
             JsonResponseModel<CreateDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建域名别名
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAliasRequest"/></param>
        /// <returns><see cref="CreateDomainAliasResponse"/></returns>
        public async Task<CreateDomainAliasResponse> CreateDomainAlias(CreateDomainAliasRequest req)
        {
             JsonResponseModel<CreateDomainAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomainAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建域名别名
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAliasRequest"/></param>
        /// <returns><see cref="CreateDomainAliasResponse"/></returns>
        public CreateDomainAliasResponse CreateDomainAliasSync(CreateDomainAliasRequest req)
        {
             JsonResponseModel<CreateDomainAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomainAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加域名
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public async Task<CreateDomainBatchResponse> CreateDomainBatch(CreateDomainBatchRequest req)
        {
             JsonResponseModel<CreateDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加域名
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public CreateDomainBatchResponse CreateDomainBatchSync(CreateDomainBatchRequest req)
        {
             JsonResponseModel<CreateDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建域名分组
        /// </summary>
        /// <param name="req"><see cref="CreateDomainGroupRequest"/></param>
        /// <returns><see cref="CreateDomainGroupResponse"/></returns>
        public async Task<CreateDomainGroupResponse> CreateDomainGroup(CreateDomainGroupRequest req)
        {
             JsonResponseModel<CreateDomainGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomainGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建域名分组
        /// </summary>
        /// <param name="req"><see cref="CreateDomainGroupRequest"/></param>
        /// <returns><see cref="CreateDomainGroupResponse"/></returns>
        public CreateDomainGroupResponse CreateDomainGroupSync(CreateDomainGroupRequest req)
        {
             JsonResponseModel<CreateDomainGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomainGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="req"><see cref="CreateRecordRequest"/></param>
        /// <returns><see cref="CreateRecordResponse"/></returns>
        public async Task<CreateRecordResponse> CreateRecord(CreateRecordRequest req)
        {
             JsonResponseModel<CreateRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="req"><see cref="CreateRecordRequest"/></param>
        /// <returns><see cref="CreateRecordResponse"/></returns>
        public CreateRecordResponse CreateRecordSync(CreateRecordRequest req)
        {
             JsonResponseModel<CreateRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加记录
        /// </summary>
        /// <param name="req"><see cref="CreateRecordBatchRequest"/></param>
        /// <returns><see cref="CreateRecordBatchResponse"/></returns>
        public async Task<CreateRecordBatchResponse> CreateRecordBatch(CreateRecordBatchRequest req)
        {
             JsonResponseModel<CreateRecordBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecordBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加记录
        /// </summary>
        /// <param name="req"><see cref="CreateRecordBatchRequest"/></param>
        /// <returns><see cref="CreateRecordBatchResponse"/></returns>
        public CreateRecordBatchResponse CreateRecordBatchSync(CreateRecordBatchRequest req)
        {
             JsonResponseModel<CreateRecordBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecordBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public async Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名别名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAliasRequest"/></param>
        /// <returns><see cref="DeleteDomainAliasResponse"/></returns>
        public async Task<DeleteDomainAliasResponse> DeleteDomainAlias(DeleteDomainAliasRequest req)
        {
             JsonResponseModel<DeleteDomainAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomainAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名别名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAliasRequest"/></param>
        /// <returns><see cref="DeleteDomainAliasResponse"/></returns>
        public DeleteDomainAliasResponse DeleteDomainAliasSync(DeleteDomainAliasRequest req)
        {
             JsonResponseModel<DeleteDomainAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDomainAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public async Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest req)
        {
             JsonResponseModel<DeleteRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public DeleteRecordResponse DeleteRecordSync(DeleteRecordRequest req)
        {
             JsonResponseModel<DeleteRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名共享
        /// </summary>
        /// <param name="req"><see cref="DeleteShareDomainRequest"/></param>
        /// <returns><see cref="DeleteShareDomainResponse"/></returns>
        public async Task<DeleteShareDomainResponse> DeleteShareDomain(DeleteShareDomainRequest req)
        {
             JsonResponseModel<DeleteShareDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteShareDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShareDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名共享
        /// </summary>
        /// <param name="req"><see cref="DeleteShareDomainRequest"/></param>
        /// <returns><see cref="DeleteShareDomainResponse"/></returns>
        public DeleteShareDomainResponse DeleteShareDomainSync(DeleteShareDomainRequest req)
        {
             JsonResponseModel<DeleteShareDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteShareDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShareDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskResponse"/></returns>
        public async Task<DescribeBatchTaskResponse> DescribeBatchTask(DescribeBatchTaskRequest req)
        {
             JsonResponseModel<DescribeBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskResponse"/></returns>
        public DescribeBatchTaskResponse DescribeBatchTaskSync(DescribeBatchTaskRequest req)
        {
             JsonResponseModel<DescribeBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public async Task<DescribeDomainResponse> DescribeDomain(DescribeDomainRequest req)
        {
             JsonResponseModel<DescribeDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public DescribeDomainResponse DescribeDomainSync(DescribeDomainRequest req)
        {
             JsonResponseModel<DescribeDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名别名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAliasListRequest"/></param>
        /// <returns><see cref="DescribeDomainAliasListResponse"/></returns>
        public async Task<DescribeDomainAliasListResponse> DescribeDomainAliasList(DescribeDomainAliasListRequest req)
        {
             JsonResponseModel<DescribeDomainAliasListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainAliasList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainAliasListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名别名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAliasListRequest"/></param>
        /// <returns><see cref="DescribeDomainAliasListResponse"/></returns>
        public DescribeDomainAliasListResponse DescribeDomainAliasListSync(DescribeDomainAliasListRequest req)
        {
             JsonResponseModel<DescribeDomainAliasListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainAliasList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainAliasListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainListRequest"/></param>
        /// <returns><see cref="DescribeDomainListResponse"/></returns>
        public async Task<DescribeDomainListResponse> DescribeDomainList(DescribeDomainListRequest req)
        {
             JsonResponseModel<DescribeDomainListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainListRequest"/></param>
        /// <returns><see cref="DescribeDomainListResponse"/></returns>
        public DescribeDomainListResponse DescribeDomainListSync(DescribeDomainListRequest req)
        {
             JsonResponseModel<DescribeDomainListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainLogListRequest"/></param>
        /// <returns><see cref="DescribeDomainLogListResponse"/></returns>
        public async Task<DescribeDomainLogListResponse> DescribeDomainLogList(DescribeDomainLogListRequest req)
        {
             JsonResponseModel<DescribeDomainLogListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainLogListRequest"/></param>
        /// <returns><see cref="DescribeDomainLogListResponse"/></returns>
        public DescribeDomainLogListResponse DescribeDomainLogListSync(DescribeDomainLogListRequest req)
        {
             JsonResponseModel<DescribeDomainLogListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名权限
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPurviewRequest"/></param>
        /// <returns><see cref="DescribeDomainPurviewResponse"/></returns>
        public async Task<DescribeDomainPurviewResponse> DescribeDomainPurview(DescribeDomainPurviewRequest req)
        {
             JsonResponseModel<DescribeDomainPurviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainPurview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainPurviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名权限
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPurviewRequest"/></param>
        /// <returns><see cref="DescribeDomainPurviewResponse"/></returns>
        public DescribeDomainPurviewResponse DescribeDomainPurviewSync(DescribeDomainPurviewRequest req)
        {
             JsonResponseModel<DescribeDomainPurviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainPurview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainPurviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名共享信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainShareInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainShareInfoResponse"/></returns>
        public async Task<DescribeDomainShareInfoResponse> DescribeDomainShareInfo(DescribeDomainShareInfoRequest req)
        {
             JsonResponseModel<DescribeDomainShareInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainShareInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainShareInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名共享信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainShareInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainShareInfoResponse"/></returns>
        public DescribeDomainShareInfoResponse DescribeDomainShareInfoSync(DescribeDomainShareInfoRequest req)
        {
             JsonResponseModel<DescribeDomainShareInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainShareInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainShareInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取记录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRequest"/></param>
        /// <returns><see cref="DescribeRecordResponse"/></returns>
        public async Task<DescribeRecordResponse> DescribeRecord(DescribeRecordRequest req)
        {
             JsonResponseModel<DescribeRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取记录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRequest"/></param>
        /// <returns><see cref="DescribeRecordResponse"/></returns>
        public DescribeRecordResponse DescribeRecordSync(DescribeRecordRequest req)
        {
             JsonResponseModel<DescribeRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取等级允许的线路
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordLineListRequest"/></param>
        /// <returns><see cref="DescribeRecordLineListResponse"/></returns>
        public async Task<DescribeRecordLineListResponse> DescribeRecordLineList(DescribeRecordLineListRequest req)
        {
             JsonResponseModel<DescribeRecordLineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordLineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordLineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取等级允许的线路
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordLineListRequest"/></param>
        /// <returns><see cref="DescribeRecordLineListResponse"/></returns>
        public DescribeRecordLineListResponse DescribeRecordLineListSync(DescribeRecordLineListRequest req)
        {
             JsonResponseModel<DescribeRecordLineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordLineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordLineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个域名下的解析记录
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordListRequest"/></param>
        /// <returns><see cref="DescribeRecordListResponse"/></returns>
        public async Task<DescribeRecordListResponse> DescribeRecordList(DescribeRecordListRequest req)
        {
             JsonResponseModel<DescribeRecordListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个域名下的解析记录
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordListRequest"/></param>
        /// <returns><see cref="DescribeRecordListResponse"/></returns>
        public DescribeRecordListResponse DescribeRecordListSync(DescribeRecordListRequest req)
        {
             JsonResponseModel<DescribeRecordListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取等级允许的记录类型
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTypeRequest"/></param>
        /// <returns><see cref="DescribeRecordTypeResponse"/></returns>
        public async Task<DescribeRecordTypeResponse> DescribeRecordType(DescribeRecordTypeRequest req)
        {
             JsonResponseModel<DescribeRecordTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取等级允许的记录类型
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTypeRequest"/></param>
        /// <returns><see cref="DescribeRecordTypeResponse"/></returns>
        public DescribeRecordTypeResponse DescribeRecordTypeSync(DescribeRecordTypeRequest req)
        {
             JsonResponseModel<DescribeRecordTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取帐户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDetailRequest"/></param>
        /// <returns><see cref="DescribeUserDetailResponse"/></returns>
        public async Task<DescribeUserDetailResponse> DescribeUserDetail(DescribeUserDetailRequest req)
        {
             JsonResponseModel<DescribeUserDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取帐户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDetailRequest"/></param>
        /// <returns><see cref="DescribeUserDetailResponse"/></returns>
        public DescribeUserDetailResponse DescribeUserDetailSync(DescribeUserDetailRequest req)
        {
             JsonResponseModel<DescribeUserDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 锁定域名
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainLockRequest"/></param>
        /// <returns><see cref="ModifyDomainLockResponse"/></returns>
        public async Task<ModifyDomainLockResponse> ModifyDomainLock(ModifyDomainLockRequest req)
        {
             JsonResponseModel<ModifyDomainLockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainLock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainLockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 锁定域名
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainLockRequest"/></param>
        /// <returns><see cref="ModifyDomainLockResponse"/></returns>
        public ModifyDomainLockResponse ModifyDomainLockSync(ModifyDomainLockRequest req)
        {
             JsonResponseModel<ModifyDomainLockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainLock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainLockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 域名过户
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerResponse"/></returns>
        public async Task<ModifyDomainOwnerResponse> ModifyDomainOwner(ModifyDomainOwnerRequest req)
        {
             JsonResponseModel<ModifyDomainOwnerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainOwner");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainOwnerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 域名过户
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerResponse"/></returns>
        public ModifyDomainOwnerResponse ModifyDomainOwnerSync(ModifyDomainOwnerRequest req)
        {
             JsonResponseModel<ModifyDomainOwnerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainOwner");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainOwnerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置域名备注
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRemarkRequest"/></param>
        /// <returns><see cref="ModifyDomainRemarkResponse"/></returns>
        public async Task<ModifyDomainRemarkResponse> ModifyDomainRemark(ModifyDomainRemarkRequest req)
        {
             JsonResponseModel<ModifyDomainRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置域名备注
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRemarkRequest"/></param>
        /// <returns><see cref="ModifyDomainRemarkResponse"/></returns>
        public ModifyDomainRemarkResponse ModifyDomainRemarkSync(ModifyDomainRemarkRequest req)
        {
             JsonResponseModel<ModifyDomainRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainStatusResponse"/></returns>
        public async Task<ModifyDomainStatusResponse> ModifyDomainStatus(ModifyDomainStatusRequest req)
        {
             JsonResponseModel<ModifyDomainStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainStatusResponse"/></returns>
        public ModifyDomainStatusResponse ModifyDomainStatusSync(ModifyDomainStatusRequest req)
        {
             JsonResponseModel<ModifyDomainStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 域名锁定解锁
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUnlockRequest"/></param>
        /// <returns><see cref="ModifyDomainUnlockResponse"/></returns>
        public async Task<ModifyDomainUnlockResponse> ModifyDomainUnlock(ModifyDomainUnlockRequest req)
        {
             JsonResponseModel<ModifyDomainUnlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainUnlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainUnlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 域名锁定解锁
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainUnlockRequest"/></param>
        /// <returns><see cref="ModifyDomainUnlockResponse"/></returns>
        public ModifyDomainUnlockResponse ModifyDomainUnlockSync(ModifyDomainUnlockRequest req)
        {
             JsonResponseModel<ModifyDomainUnlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainUnlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainUnlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新动态 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="ModifyDynamicDNSRequest"/></param>
        /// <returns><see cref="ModifyDynamicDNSResponse"/></returns>
        public async Task<ModifyDynamicDNSResponse> ModifyDynamicDNS(ModifyDynamicDNSRequest req)
        {
             JsonResponseModel<ModifyDynamicDNSResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDynamicDNS");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDynamicDNSResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新动态 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="ModifyDynamicDNSRequest"/></param>
        /// <returns><see cref="ModifyDynamicDNSResponse"/></returns>
        public ModifyDynamicDNSResponse ModifyDynamicDNSSync(ModifyDynamicDNSRequest req)
        {
             JsonResponseModel<ModifyDynamicDNSResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDynamicDNS");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDynamicDNSResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改记录
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRequest"/></param>
        /// <returns><see cref="ModifyRecordResponse"/></returns>
        public async Task<ModifyRecordResponse> ModifyRecord(ModifyRecordRequest req)
        {
             JsonResponseModel<ModifyRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改记录
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRequest"/></param>
        /// <returns><see cref="ModifyRecordResponse"/></returns>
        public ModifyRecordResponse ModifyRecordSync(ModifyRecordRequest req)
        {
             JsonResponseModel<ModifyRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改记录
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordBatchRequest"/></param>
        /// <returns><see cref="ModifyRecordBatchResponse"/></returns>
        public async Task<ModifyRecordBatchResponse> ModifyRecordBatch(ModifyRecordBatchRequest req)
        {
             JsonResponseModel<ModifyRecordBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecordBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改记录
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordBatchRequest"/></param>
        /// <returns><see cref="ModifyRecordBatchResponse"/></returns>
        public ModifyRecordBatchResponse ModifyRecordBatchSync(ModifyRecordBatchRequest req)
        {
             JsonResponseModel<ModifyRecordBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecordBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置记录备注
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRemarkRequest"/></param>
        /// <returns><see cref="ModifyRecordRemarkResponse"/></returns>
        public async Task<ModifyRecordRemarkResponse> ModifyRecordRemark(ModifyRecordRemarkRequest req)
        {
             JsonResponseModel<ModifyRecordRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecordRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置记录备注
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRemarkRequest"/></param>
        /// <returns><see cref="ModifyRecordRemarkResponse"/></returns>
        public ModifyRecordRemarkResponse ModifyRecordRemarkSync(ModifyRecordRemarkRequest req)
        {
             JsonResponseModel<ModifyRecordRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecordRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改解析记录的状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordStatusResponse"/></returns>
        public async Task<ModifyRecordStatusResponse> ModifyRecordStatus(ModifyRecordStatusRequest req)
        {
             JsonResponseModel<ModifyRecordStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecordStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改解析记录的状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordStatusResponse"/></returns>
        public ModifyRecordStatusResponse ModifyRecordStatusSync(ModifyRecordStatusRequest req)
        {
             JsonResponseModel<ModifyRecordStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecordStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停子域名的解析记录
        /// </summary>
        /// <param name="req"><see cref="ModifySubdomainStatusRequest"/></param>
        /// <returns><see cref="ModifySubdomainStatusResponse"/></returns>
        public async Task<ModifySubdomainStatusResponse> ModifySubdomainStatus(ModifySubdomainStatusRequest req)
        {
             JsonResponseModel<ModifySubdomainStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubdomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubdomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停子域名的解析记录
        /// </summary>
        /// <param name="req"><see cref="ModifySubdomainStatusRequest"/></param>
        /// <returns><see cref="ModifySubdomainStatusResponse"/></returns>
        public ModifySubdomainStatusResponse ModifySubdomainStatusSync(ModifySubdomainStatusRequest req)
        {
             JsonResponseModel<ModifySubdomainStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubdomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubdomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
