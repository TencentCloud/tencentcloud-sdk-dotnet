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

namespace TencentCloud.Privatedns.V20201028
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Privatedns.V20201028.Models;

   public class PrivatednsClient : AbstractClient{

       private const string endpoint = "privatedns.tencentcloudapi.com";
       private const string version = "2020-10-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PrivatednsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PrivatednsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建私有域
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneResponse"/></returns>
        public async Task<CreatePrivateZoneResponse> CreatePrivateZone(CreatePrivateZoneRequest req)
        {
             JsonResponseModel<CreatePrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建私有域
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneResponse"/></returns>
        public CreatePrivateZoneResponse CreatePrivateZoneSync(CreatePrivateZoneRequest req)
        {
             JsonResponseModel<CreatePrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneRecordResponse"/></returns>
        public async Task<CreatePrivateZoneRecordResponse> CreatePrivateZoneRecord(CreatePrivateZoneRecordRequest req)
        {
             JsonResponseModel<CreatePrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneRecordResponse"/></returns>
        public CreatePrivateZoneRecordResponse CreatePrivateZoneRecordSync(CreatePrivateZoneRecordRequest req)
        {
             JsonResponseModel<CreatePrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除私有域并停止解析
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneResponse"/></returns>
        public async Task<DeletePrivateZoneResponse> DeletePrivateZone(DeletePrivateZoneRequest req)
        {
             JsonResponseModel<DeletePrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除私有域并停止解析
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneResponse"/></returns>
        public DeletePrivateZoneResponse DeletePrivateZoneSync(DeletePrivateZoneRequest req)
        {
             JsonResponseModel<DeletePrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneRecordResponse"/></returns>
        public async Task<DeletePrivateZoneRecordResponse> DeletePrivateZoneRecord(DeletePrivateZoneRecordRequest req)
        {
             JsonResponseModel<DeletePrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneRecordResponse"/></returns>
        public DeletePrivateZoneRecordResponse DeletePrivateZoneRecordSync(DeletePrivateZoneRecordRequest req)
        {
             JsonResponseModel<DeletePrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取操作日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogRequest"/></param>
        /// <returns><see cref="DescribeAuditLogResponse"/></returns>
        public async Task<DescribeAuditLogResponse> DescribeAuditLog(DescribeAuditLogRequest req)
        {
             JsonResponseModel<DescribeAuditLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAuditLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取操作日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogRequest"/></param>
        /// <returns><see cref="DescribeAuditLogResponse"/></returns>
        public DescribeAuditLogResponse DescribeAuditLogSync(DescribeAuditLogRequest req)
        {
             JsonResponseModel<DescribeAuditLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAuditLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域解析概览
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public async Task<DescribeDashboardResponse> DescribeDashboard(DescribeDashboardRequest req)
        {
             JsonResponseModel<DescribeDashboardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域解析概览
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public DescribeDashboardResponse DescribeDashboardSync(DescribeDashboardRequest req)
        {
             JsonResponseModel<DescribeDashboardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneResponse"/></returns>
        public async Task<DescribePrivateZoneResponse> DescribePrivateZone(DescribePrivateZoneRequest req)
        {
             JsonResponseModel<DescribePrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneResponse"/></returns>
        public DescribePrivateZoneResponse DescribePrivateZoneSync(DescribePrivateZoneRequest req)
        {
             JsonResponseModel<DescribePrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneListResponse"/></returns>
        public async Task<DescribePrivateZoneListResponse> DescribePrivateZoneList(DescribePrivateZoneListRequest req)
        {
             JsonResponseModel<DescribePrivateZoneListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateZoneList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneListResponse"/></returns>
        public DescribePrivateZoneListResponse DescribePrivateZoneListSync(DescribePrivateZoneListRequest req)
        {
             JsonResponseModel<DescribePrivateZoneListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateZoneList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRecordListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneRecordListResponse"/></returns>
        public async Task<DescribePrivateZoneRecordListResponse> DescribePrivateZoneRecordList(DescribePrivateZoneRecordListRequest req)
        {
             JsonResponseModel<DescribePrivateZoneRecordListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateZoneRecordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneRecordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRecordListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneRecordListResponse"/></returns>
        public DescribePrivateZoneRecordListResponse DescribePrivateZoneRecordListSync(DescribePrivateZoneRecordListRequest req)
        {
             JsonResponseModel<DescribePrivateZoneRecordListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateZoneRecordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneRecordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有域解析开通状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneServiceResponse"/></returns>
        public async Task<DescribePrivateZoneServiceResponse> DescribePrivateZoneService(DescribePrivateZoneServiceRequest req)
        {
             JsonResponseModel<DescribePrivateZoneServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateZoneService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有域解析开通状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneServiceResponse"/></returns>
        public DescribePrivateZoneServiceResponse DescribePrivateZoneServiceSync(DescribePrivateZoneServiceRequest req)
        {
             JsonResponseModel<DescribePrivateZoneServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateZoneService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateZoneServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域解析请求量
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestDataRequest"/></param>
        /// <returns><see cref="DescribeRequestDataResponse"/></returns>
        public async Task<DescribeRequestDataResponse> DescribeRequestData(DescribeRequestDataRequest req)
        {
             JsonResponseModel<DescribeRequestDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRequestData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRequestDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取私有域解析请求量
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestDataRequest"/></param>
        /// <returns><see cref="DescribeRequestDataResponse"/></returns>
        public DescribeRequestDataResponse DescribeRequestDataSync(DescribeRequestDataRequest req)
        {
             JsonResponseModel<DescribeRequestDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRequestData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRequestDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改私有域信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneResponse"/></returns>
        public async Task<ModifyPrivateZoneResponse> ModifyPrivateZone(ModifyPrivateZoneRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改私有域信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneResponse"/></returns>
        public ModifyPrivateZoneResponse ModifyPrivateZoneSync(ModifyPrivateZoneRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrivateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRecordRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneRecordResponse"/></returns>
        public async Task<ModifyPrivateZoneRecordResponse> ModifyPrivateZoneRecord(ModifyPrivateZoneRecordRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRecordRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneRecordResponse"/></returns>
        public ModifyPrivateZoneRecordResponse ModifyPrivateZoneRecordSync(ModifyPrivateZoneRecordRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrivateZoneRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改私有域关联的VPC
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneVpcResponse"/></returns>
        public async Task<ModifyPrivateZoneVpcResponse> ModifyPrivateZoneVpc(ModifyPrivateZoneVpcRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrivateZoneVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改私有域关联的VPC
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneVpcResponse"/></returns>
        public ModifyPrivateZoneVpcResponse ModifyPrivateZoneVpcSync(ModifyPrivateZoneVpcRequest req)
        {
             JsonResponseModel<ModifyPrivateZoneVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrivateZoneVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateZoneVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通私有域解析
        /// </summary>
        /// <param name="req"><see cref="SubscribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="SubscribePrivateZoneServiceResponse"/></returns>
        public async Task<SubscribePrivateZoneServiceResponse> SubscribePrivateZoneService(SubscribePrivateZoneServiceRequest req)
        {
             JsonResponseModel<SubscribePrivateZoneServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubscribePrivateZoneService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubscribePrivateZoneServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通私有域解析
        /// </summary>
        /// <param name="req"><see cref="SubscribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="SubscribePrivateZoneServiceResponse"/></returns>
        public SubscribePrivateZoneServiceResponse SubscribePrivateZoneServiceSync(SubscribePrivateZoneServiceRequest req)
        {
             JsonResponseModel<SubscribePrivateZoneServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubscribePrivateZoneService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubscribePrivateZoneServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
