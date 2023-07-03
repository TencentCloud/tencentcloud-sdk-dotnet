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
        /// 回滚前检查单条记录
        /// </summary>
        /// <param name="req"><see cref="CheckRecordSnapshotRollbackRequest"/></param>
        /// <returns><see cref="CheckRecordSnapshotRollbackResponse"/></returns>
        public async Task<CheckRecordSnapshotRollbackResponse> CheckRecordSnapshotRollback(CheckRecordSnapshotRollbackRequest req)
        {
             JsonResponseModel<CheckRecordSnapshotRollbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckRecordSnapshotRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckRecordSnapshotRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回滚前检查单条记录
        /// </summary>
        /// <param name="req"><see cref="CheckRecordSnapshotRollbackRequest"/></param>
        /// <returns><see cref="CheckRecordSnapshotRollbackResponse"/></returns>
        public CheckRecordSnapshotRollbackResponse CheckRecordSnapshotRollbackSync(CheckRecordSnapshotRollbackRequest req)
        {
             JsonResponseModel<CheckRecordSnapshotRollbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckRecordSnapshotRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckRecordSnapshotRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 快照回滚前检查
        /// </summary>
        /// <param name="req"><see cref="CheckSnapshotRollbackRequest"/></param>
        /// <returns><see cref="CheckSnapshotRollbackResponse"/></returns>
        public async Task<CheckSnapshotRollbackResponse> CheckSnapshotRollback(CheckSnapshotRollbackRequest req)
        {
             JsonResponseModel<CheckSnapshotRollbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckSnapshotRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckSnapshotRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 快照回滚前检查
        /// </summary>
        /// <param name="req"><see cref="CheckSnapshotRollbackRequest"/></param>
        /// <returns><see cref="CheckSnapshotRollbackResponse"/></returns>
        public CheckSnapshotRollbackResponse CheckSnapshotRollbackSync(CheckSnapshotRollbackRequest req)
        {
             JsonResponseModel<CheckSnapshotRollbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckSnapshotRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckSnapshotRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DNSPod商品下单
        /// </summary>
        /// <param name="req"><see cref="CreateDealRequest"/></param>
        /// <returns><see cref="CreateDealResponse"/></returns>
        public async Task<CreateDealResponse> CreateDeal(CreateDealRequest req)
        {
             JsonResponseModel<CreateDealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DNSPod商品下单
        /// </summary>
        /// <param name="req"><see cref="CreateDealRequest"/></param>
        /// <returns><see cref="CreateDealResponse"/></returns>
        public CreateDealResponse CreateDealSync(CreateDealRequest req)
        {
             JsonResponseModel<CreateDealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDealResponse>>(strResp);
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
        /// 添加记录分组
        /// </summary>
        /// <param name="req"><see cref="CreateRecordGroupRequest"/></param>
        /// <returns><see cref="CreateRecordGroupResponse"/></returns>
        public async Task<CreateRecordGroupResponse> CreateRecordGroup(CreateRecordGroupRequest req)
        {
             JsonResponseModel<CreateRecordGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecordGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加记录分组
        /// </summary>
        /// <param name="req"><see cref="CreateRecordGroupRequest"/></param>
        /// <returns><see cref="CreateRecordGroupResponse"/></returns>
        public CreateRecordGroupResponse CreateRecordGroupSync(CreateRecordGroupRequest req)
        {
             JsonResponseModel<CreateRecordGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecordGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建快照
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotRequest"/></param>
        /// <returns><see cref="CreateSnapshotResponse"/></returns>
        public async Task<CreateSnapshotResponse> CreateSnapshot(CreateSnapshotRequest req)
        {
             JsonResponseModel<CreateSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建快照
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotRequest"/></param>
        /// <returns><see cref="CreateSnapshotResponse"/></returns>
        public CreateSnapshotResponse CreateSnapshotSync(CreateSnapshotRequest req)
        {
             JsonResponseModel<CreateSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotResponse>>(strResp);
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
        /// 批量删除域名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainBatchRequest"/></param>
        /// <returns><see cref="DeleteDomainBatchResponse"/></returns>
        public async Task<DeleteDomainBatchResponse> DeleteDomainBatch(DeleteDomainBatchRequest req)
        {
             JsonResponseModel<DeleteDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除域名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainBatchRequest"/></param>
        /// <returns><see cref="DeleteDomainBatchResponse"/></returns>
        public DeleteDomainBatchResponse DeleteDomainBatchSync(DeleteDomainBatchRequest req)
        {
             JsonResponseModel<DeleteDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainBatchResponse>>(strResp);
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
        /// 批量删除解析记录
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBatchRequest"/></param>
        /// <returns><see cref="DeleteRecordBatchResponse"/></returns>
        public async Task<DeleteRecordBatchResponse> DeleteRecordBatch(DeleteRecordBatchRequest req)
        {
             JsonResponseModel<DeleteRecordBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除解析记录
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBatchRequest"/></param>
        /// <returns><see cref="DeleteRecordBatchResponse"/></returns>
        public DeleteRecordBatchResponse DeleteRecordBatchSync(DeleteRecordBatchRequest req)
        {
             JsonResponseModel<DeleteRecordBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除记录分组
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordGroupRequest"/></param>
        /// <returns><see cref="DeleteRecordGroupResponse"/></returns>
        public async Task<DeleteRecordGroupResponse> DeleteRecordGroup(DeleteRecordGroupRequest req)
        {
             JsonResponseModel<DeleteRecordGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除记录分组
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordGroupRequest"/></param>
        /// <returns><see cref="DeleteRecordGroupResponse"/></returns>
        public DeleteRecordGroupResponse DeleteRecordGroupSync(DeleteRecordGroupRequest req)
        {
             JsonResponseModel<DeleteRecordGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordGroupResponse>>(strResp);
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
        /// 删除快照
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotRequest"/></param>
        /// <returns><see cref="DeleteSnapshotResponse"/></returns>
        public async Task<DeleteSnapshotResponse> DeleteSnapshot(DeleteSnapshotRequest req)
        {
             JsonResponseModel<DeleteSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除快照
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotRequest"/></param>
        /// <returns><see cref="DeleteSnapshotResponse"/></returns>
        public DeleteSnapshotResponse DeleteSnapshotSync(DeleteSnapshotRequest req)
        {
             JsonResponseModel<DeleteSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotResponse>>(strResp);
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
        /// 统计各个域名的解析量，帮助您了解流量情况、时间段分布。支持查看近 3 个月内的统计情况
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAnalyticsRequest"/></param>
        /// <returns><see cref="DescribeDomainAnalyticsResponse"/></returns>
        public async Task<DescribeDomainAnalyticsResponse> DescribeDomainAnalytics(DescribeDomainAnalyticsRequest req)
        {
             JsonResponseModel<DescribeDomainAnalyticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainAnalytics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainAnalyticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计各个域名的解析量，帮助您了解流量情况、时间段分布。支持查看近 3 个月内的统计情况
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAnalyticsRequest"/></param>
        /// <returns><see cref="DescribeDomainAnalyticsResponse"/></returns>
        public DescribeDomainAnalyticsResponse DescribeDomainAnalyticsSync(DescribeDomainAnalyticsRequest req)
        {
             JsonResponseModel<DescribeDomainAnalyticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainAnalytics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainAnalyticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名筛选列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainFilterListRequest"/></param>
        /// <returns><see cref="DescribeDomainFilterListResponse"/></returns>
        public async Task<DescribeDomainFilterListResponse> DescribeDomainFilterList(DescribeDomainFilterListRequest req)
        {
             JsonResponseModel<DescribeDomainFilterListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainFilterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainFilterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名筛选列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainFilterListRequest"/></param>
        /// <returns><see cref="DescribeDomainFilterListResponse"/></returns>
        public DescribeDomainFilterListResponse DescribeDomainFilterListSync(DescribeDomainFilterListRequest req)
        {
             JsonResponseModel<DescribeDomainFilterListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainFilterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainFilterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名分组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainGroupListRequest"/></param>
        /// <returns><see cref="DescribeDomainGroupListResponse"/></returns>
        public async Task<DescribeDomainGroupListResponse> DescribeDomainGroupList(DescribeDomainGroupListRequest req)
        {
             JsonResponseModel<DescribeDomainGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名分组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainGroupListRequest"/></param>
        /// <returns><see cref="DescribeDomainGroupListResponse"/></returns>
        public DescribeDomainGroupListResponse DescribeDomainGroupListSync(DescribeDomainGroupListRequest req)
        {
             JsonResponseModel<DescribeDomainGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainGroupListResponse>>(strResp);
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
        /// 获取域名概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPreviewRequest"/></param>
        /// <returns><see cref="DescribeDomainPreviewResponse"/></returns>
        public async Task<DescribeDomainPreviewResponse> DescribeDomainPreview(DescribeDomainPreviewRequest req)
        {
             JsonResponseModel<DescribeDomainPreviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainPreview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainPreviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPreviewRequest"/></param>
        /// <returns><see cref="DescribeDomainPreviewResponse"/></returns>
        public DescribeDomainPreviewResponse DescribeDomainPreviewSync(DescribeDomainPreviewRequest req)
        {
             JsonResponseModel<DescribeDomainPreviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainPreview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainPreviewResponse>>(strResp);
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
        /// 获取域名Whois信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainWhoisRequest"/></param>
        /// <returns><see cref="DescribeDomainWhoisResponse"/></returns>
        public async Task<DescribeDomainWhoisResponse> DescribeDomainWhois(DescribeDomainWhoisRequest req)
        {
             JsonResponseModel<DescribeDomainWhoisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainWhois");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainWhoisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名Whois信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainWhoisRequest"/></param>
        /// <returns><see cref="DescribeDomainWhoisResponse"/></returns>
        public DescribeDomainWhoisResponse DescribeDomainWhoisSync(DescribeDomainWhoisRequest req)
        {
             JsonResponseModel<DescribeDomainWhoisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainWhois");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainWhoisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各套餐配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribePackageDetailRequest"/></param>
        /// <returns><see cref="DescribePackageDetailResponse"/></returns>
        public async Task<DescribePackageDetailResponse> DescribePackageDetail(DescribePackageDetailRequest req)
        {
             JsonResponseModel<DescribePackageDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePackageDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackageDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各套餐配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribePackageDetailRequest"/></param>
        /// <returns><see cref="DescribePackageDetailResponse"/></returns>
        public DescribePackageDetailResponse DescribePackageDetailSync(DescribePackageDetailRequest req)
        {
             JsonResponseModel<DescribePackageDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePackageDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackageDetailResponse>>(strResp);
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
        /// 判断是否有除系统默认的@-NS记录之外的记录存在
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordExistExceptDefaultNSRequest"/></param>
        /// <returns><see cref="DescribeRecordExistExceptDefaultNSResponse"/></returns>
        public async Task<DescribeRecordExistExceptDefaultNSResponse> DescribeRecordExistExceptDefaultNS(DescribeRecordExistExceptDefaultNSRequest req)
        {
             JsonResponseModel<DescribeRecordExistExceptDefaultNSResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordExistExceptDefaultNS");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordExistExceptDefaultNSResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断是否有除系统默认的@-NS记录之外的记录存在
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordExistExceptDefaultNSRequest"/></param>
        /// <returns><see cref="DescribeRecordExistExceptDefaultNSResponse"/></returns>
        public DescribeRecordExistExceptDefaultNSResponse DescribeRecordExistExceptDefaultNSSync(DescribeRecordExistExceptDefaultNSRequest req)
        {
             JsonResponseModel<DescribeRecordExistExceptDefaultNSResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordExistExceptDefaultNS");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordExistExceptDefaultNSResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询解析记录分组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordGroupListRequest"/></param>
        /// <returns><see cref="DescribeRecordGroupListResponse"/></returns>
        public async Task<DescribeRecordGroupListResponse> DescribeRecordGroupList(DescribeRecordGroupListRequest req)
        {
             JsonResponseModel<DescribeRecordGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询解析记录分组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordGroupListRequest"/></param>
        /// <returns><see cref="DescribeRecordGroupListResponse"/></returns>
        public DescribeRecordGroupListResponse DescribeRecordGroupListSync(DescribeRecordGroupListRequest req)
        {
             JsonResponseModel<DescribeRecordGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordGroupListResponse>>(strResp);
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
        /// 获取某个域名下的解析记录列表
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
        /// 获取某个域名下的解析记录列表
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
        /// 查询解析记录重新回滚的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSnapshotRollbackResultRequest"/></param>
        /// <returns><see cref="DescribeRecordSnapshotRollbackResultResponse"/></returns>
        public async Task<DescribeRecordSnapshotRollbackResultResponse> DescribeRecordSnapshotRollbackResult(DescribeRecordSnapshotRollbackResultRequest req)
        {
             JsonResponseModel<DescribeRecordSnapshotRollbackResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordSnapshotRollbackResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordSnapshotRollbackResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询解析记录重新回滚的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSnapshotRollbackResultRequest"/></param>
        /// <returns><see cref="DescribeRecordSnapshotRollbackResultResponse"/></returns>
        public DescribeRecordSnapshotRollbackResultResponse DescribeRecordSnapshotRollbackResultSync(DescribeRecordSnapshotRollbackResultRequest req)
        {
             JsonResponseModel<DescribeRecordSnapshotRollbackResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordSnapshotRollbackResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordSnapshotRollbackResultResponse>>(strResp);
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
        /// 查询解析快照配置
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotConfigRequest"/></param>
        /// <returns><see cref="DescribeSnapshotConfigResponse"/></returns>
        public async Task<DescribeSnapshotConfigResponse> DescribeSnapshotConfig(DescribeSnapshotConfigRequest req)
        {
             JsonResponseModel<DescribeSnapshotConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询解析快照配置
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotConfigRequest"/></param>
        /// <returns><see cref="DescribeSnapshotConfigResponse"/></returns>
        public DescribeSnapshotConfigResponse DescribeSnapshotConfigSync(DescribeSnapshotConfigRequest req)
        {
             JsonResponseModel<DescribeSnapshotConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotListRequest"/></param>
        /// <returns><see cref="DescribeSnapshotListResponse"/></returns>
        public async Task<DescribeSnapshotListResponse> DescribeSnapshotList(DescribeSnapshotListRequest req)
        {
             JsonResponseModel<DescribeSnapshotListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotListRequest"/></param>
        /// <returns><see cref="DescribeSnapshotListResponse"/></returns>
        public DescribeSnapshotListResponse DescribeSnapshotListSync(DescribeSnapshotListRequest req)
        {
             JsonResponseModel<DescribeSnapshotListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询快照回滚结果
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotRollbackResultRequest"/></param>
        /// <returns><see cref="DescribeSnapshotRollbackResultResponse"/></returns>
        public async Task<DescribeSnapshotRollbackResultResponse> DescribeSnapshotRollbackResult(DescribeSnapshotRollbackResultRequest req)
        {
             JsonResponseModel<DescribeSnapshotRollbackResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotRollbackResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotRollbackResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询快照回滚结果
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotRollbackResultRequest"/></param>
        /// <returns><see cref="DescribeSnapshotRollbackResultResponse"/></returns>
        public DescribeSnapshotRollbackResultResponse DescribeSnapshotRollbackResultSync(DescribeSnapshotRollbackResultRequest req)
        {
             JsonResponseModel<DescribeSnapshotRollbackResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotRollbackResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotRollbackResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近一次回滚
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotRollbackTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotRollbackTaskResponse"/></returns>
        public async Task<DescribeSnapshotRollbackTaskResponse> DescribeSnapshotRollbackTask(DescribeSnapshotRollbackTaskRequest req)
        {
             JsonResponseModel<DescribeSnapshotRollbackTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotRollbackTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotRollbackTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近一次回滚
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotRollbackTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotRollbackTaskResponse"/></returns>
        public DescribeSnapshotRollbackTaskResponse DescribeSnapshotRollbackTaskSync(DescribeSnapshotRollbackTaskRequest req)
        {
             JsonResponseModel<DescribeSnapshotRollbackTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotRollbackTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotRollbackTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计子域名的解析量，帮助您了解流量情况、时间段分布。支持查看近 3 个月内的统计情况。仅付费套餐域名可用。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubdomainAnalyticsRequest"/></param>
        /// <returns><see cref="DescribeSubdomainAnalyticsResponse"/></returns>
        public async Task<DescribeSubdomainAnalyticsResponse> DescribeSubdomainAnalytics(DescribeSubdomainAnalyticsRequest req)
        {
             JsonResponseModel<DescribeSubdomainAnalyticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubdomainAnalytics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubdomainAnalyticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计子域名的解析量，帮助您了解流量情况、时间段分布。支持查看近 3 个月内的统计情况。仅付费套餐域名可用。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubdomainAnalyticsRequest"/></param>
        /// <returns><see cref="DescribeSubdomainAnalyticsResponse"/></returns>
        public DescribeSubdomainAnalyticsResponse DescribeSubdomainAnalyticsSync(DescribeSubdomainAnalyticsRequest req)
        {
             JsonResponseModel<DescribeSubdomainAnalyticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubdomainAnalytics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubdomainAnalyticsResponse>>(strResp);
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
        /// 获取域名增值服务用量
        /// </summary>
        /// <param name="req"><see cref="DescribeVASStatisticRequest"/></param>
        /// <returns><see cref="DescribeVASStatisticResponse"/></returns>
        public async Task<DescribeVASStatisticResponse> DescribeVASStatistic(DescribeVASStatisticRequest req)
        {
             JsonResponseModel<DescribeVASStatisticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVASStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVASStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名增值服务用量
        /// </summary>
        /// <param name="req"><see cref="DescribeVASStatisticRequest"/></param>
        /// <returns><see cref="DescribeVASStatisticResponse"/></returns>
        public DescribeVASStatisticResponse DescribeVASStatisticSync(DescribeVASStatisticRequest req)
        {
             JsonResponseModel<DescribeVASStatisticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVASStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVASStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载快照
        /// </summary>
        /// <param name="req"><see cref="DownloadSnapshotRequest"/></param>
        /// <returns><see cref="DownloadSnapshotResponse"/></returns>
        public async Task<DownloadSnapshotResponse> DownloadSnapshot(DownloadSnapshotRequest req)
        {
             JsonResponseModel<DownloadSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载快照
        /// </summary>
        /// <param name="req"><see cref="DownloadSnapshotRequest"/></param>
        /// <returns><see cref="DownloadSnapshotResponse"/></returns>
        public DownloadSnapshotResponse DownloadSnapshotSync(DownloadSnapshotRequest req)
        {
             JsonResponseModel<DownloadSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadSnapshotResponse>>(strResp);
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
        /// DNS 解析套餐自动续费设置
        /// </summary>
        /// <param name="req"><see cref="ModifyPackageAutoRenewRequest"/></param>
        /// <returns><see cref="ModifyPackageAutoRenewResponse"/></returns>
        public async Task<ModifyPackageAutoRenewResponse> ModifyPackageAutoRenew(ModifyPackageAutoRenewRequest req)
        {
             JsonResponseModel<ModifyPackageAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPackageAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPackageAutoRenewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DNS 解析套餐自动续费设置
        /// </summary>
        /// <param name="req"><see cref="ModifyPackageAutoRenewRequest"/></param>
        /// <returns><see cref="ModifyPackageAutoRenewResponse"/></returns>
        public ModifyPackageAutoRenewResponse ModifyPackageAutoRenewSync(ModifyPackageAutoRenewRequest req)
        {
             JsonResponseModel<ModifyPackageAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPackageAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPackageAutoRenewResponse>>(strResp);
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
        /// 修改记录可选字段
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordFieldsRequest"/></param>
        /// <returns><see cref="ModifyRecordFieldsResponse"/></returns>
        public async Task<ModifyRecordFieldsResponse> ModifyRecordFields(ModifyRecordFieldsRequest req)
        {
             JsonResponseModel<ModifyRecordFieldsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecordFields");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordFieldsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改记录可选字段
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordFieldsRequest"/></param>
        /// <returns><see cref="ModifyRecordFieldsResponse"/></returns>
        public ModifyRecordFieldsResponse ModifyRecordFieldsSync(ModifyRecordFieldsRequest req)
        {
             JsonResponseModel<ModifyRecordFieldsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecordFields");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordFieldsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改记录分组
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordGroupRequest"/></param>
        /// <returns><see cref="ModifyRecordGroupResponse"/></returns>
        public async Task<ModifyRecordGroupResponse> ModifyRecordGroup(ModifyRecordGroupRequest req)
        {
             JsonResponseModel<ModifyRecordGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecordGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改记录分组
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordGroupRequest"/></param>
        /// <returns><see cref="ModifyRecordGroupResponse"/></returns>
        public ModifyRecordGroupResponse ModifyRecordGroupSync(ModifyRecordGroupRequest req)
        {
             JsonResponseModel<ModifyRecordGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecordGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordGroupResponse>>(strResp);
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
        /// 将记录添加到分组
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordToGroupRequest"/></param>
        /// <returns><see cref="ModifyRecordToGroupResponse"/></returns>
        public async Task<ModifyRecordToGroupResponse> ModifyRecordToGroup(ModifyRecordToGroupRequest req)
        {
             JsonResponseModel<ModifyRecordToGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecordToGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordToGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将记录添加到分组
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordToGroupRequest"/></param>
        /// <returns><see cref="ModifyRecordToGroupResponse"/></returns>
        public ModifyRecordToGroupResponse ModifyRecordToGroupSync(ModifyRecordToGroupRequest req)
        {
             JsonResponseModel<ModifyRecordToGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecordToGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordToGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改快照配置
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotConfigRequest"/></param>
        /// <returns><see cref="ModifySnapshotConfigResponse"/></returns>
        public async Task<ModifySnapshotConfigResponse> ModifySnapshotConfig(ModifySnapshotConfigRequest req)
        {
             JsonResponseModel<ModifySnapshotConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改快照配置
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotConfigRequest"/></param>
        /// <returns><see cref="ModifySnapshotConfigResponse"/></returns>
        public ModifySnapshotConfigResponse ModifySnapshotConfigSync(ModifySnapshotConfigRequest req)
        {
             JsonResponseModel<ModifySnapshotConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotConfigResponse>>(strResp);
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

        /// <summary>
        /// 增值服务自动续费设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVasAutoRenewStatusRequest"/></param>
        /// <returns><see cref="ModifyVasAutoRenewStatusResponse"/></returns>
        public async Task<ModifyVasAutoRenewStatusResponse> ModifyVasAutoRenewStatus(ModifyVasAutoRenewStatusRequest req)
        {
             JsonResponseModel<ModifyVasAutoRenewStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVasAutoRenewStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVasAutoRenewStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增值服务自动续费设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVasAutoRenewStatusRequest"/></param>
        /// <returns><see cref="ModifyVasAutoRenewStatusResponse"/></returns>
        public ModifyVasAutoRenewStatusResponse ModifyVasAutoRenewStatusSync(ModifyVasAutoRenewStatusRequest req)
        {
             JsonResponseModel<ModifyVasAutoRenewStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVasAutoRenewStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVasAutoRenewStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DNSPod商品余额支付
        /// </summary>
        /// <param name="req"><see cref="PayOrderWithBalanceRequest"/></param>
        /// <returns><see cref="PayOrderWithBalanceResponse"/></returns>
        public async Task<PayOrderWithBalanceResponse> PayOrderWithBalance(PayOrderWithBalanceRequest req)
        {
             JsonResponseModel<PayOrderWithBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PayOrderWithBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PayOrderWithBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DNSPod商品余额支付
        /// </summary>
        /// <param name="req"><see cref="PayOrderWithBalanceRequest"/></param>
        /// <returns><see cref="PayOrderWithBalanceResponse"/></returns>
        public PayOrderWithBalanceResponse PayOrderWithBalanceSync(PayOrderWithBalanceRequest req)
        {
             JsonResponseModel<PayOrderWithBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PayOrderWithBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PayOrderWithBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新回滚指定解析记录快照
        /// </summary>
        /// <param name="req"><see cref="RollbackRecordSnapshotRequest"/></param>
        /// <returns><see cref="RollbackRecordSnapshotResponse"/></returns>
        public async Task<RollbackRecordSnapshotResponse> RollbackRecordSnapshot(RollbackRecordSnapshotRequest req)
        {
             JsonResponseModel<RollbackRecordSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollbackRecordSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackRecordSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新回滚指定解析记录快照
        /// </summary>
        /// <param name="req"><see cref="RollbackRecordSnapshotRequest"/></param>
        /// <returns><see cref="RollbackRecordSnapshotResponse"/></returns>
        public RollbackRecordSnapshotResponse RollbackRecordSnapshotSync(RollbackRecordSnapshotRequest req)
        {
             JsonResponseModel<RollbackRecordSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollbackRecordSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackRecordSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回滚快照
        /// </summary>
        /// <param name="req"><see cref="RollbackSnapshotRequest"/></param>
        /// <returns><see cref="RollbackSnapshotResponse"/></returns>
        public async Task<RollbackSnapshotResponse> RollbackSnapshot(RollbackSnapshotRequest req)
        {
             JsonResponseModel<RollbackSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollbackSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回滚快照
        /// </summary>
        /// <param name="req"><see cref="RollbackSnapshotRequest"/></param>
        /// <returns><see cref="RollbackSnapshotResponse"/></returns>
        public RollbackSnapshotResponse RollbackSnapshotSync(RollbackSnapshotRequest req)
        {
             JsonResponseModel<RollbackSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollbackSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
