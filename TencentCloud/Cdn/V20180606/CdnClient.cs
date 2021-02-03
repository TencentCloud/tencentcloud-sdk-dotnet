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

namespace TencentCloud.Cdn.V20180606
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdn.V20180606.Models;

   public class CdnClient : AbstractClient{

       private const string endpoint = "cdn.tencentcloudapi.com";
       private const string version = "2018-06-06";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdnClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// AddCdnDomain 用于新增内容分发网络加速域名。
        /// </summary>
        /// <param name="req"><see cref="AddCdnDomainRequest"/></param>
        /// <returns><see cref="AddCdnDomainResponse"/></returns>
        public async Task<AddCdnDomainResponse> AddCdnDomain(AddCdnDomainRequest req)
        {
             JsonResponseModel<AddCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AddCdnDomain 用于新增内容分发网络加速域名。
        /// </summary>
        /// <param name="req"><see cref="AddCdnDomainRequest"/></param>
        /// <returns><see cref="AddCdnDomainResponse"/></returns>
        public AddCdnDomainResponse AddCdnDomainSync(AddCdnDomainRequest req)
        {
             JsonResponseModel<AddCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateClsLogTopic 用于创建日志主题。注意：一个日志集下至多可创建10个日志主题。
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogTopicRequest"/></param>
        /// <returns><see cref="CreateClsLogTopicResponse"/></returns>
        public async Task<CreateClsLogTopicResponse> CreateClsLogTopic(CreateClsLogTopicRequest req)
        {
             JsonResponseModel<CreateClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateClsLogTopic 用于创建日志主题。注意：一个日志集下至多可创建10个日志主题。
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogTopicRequest"/></param>
        /// <returns><see cref="CreateClsLogTopicResponse"/></returns>
        public CreateClsLogTopicResponse CreateClsLogTopicSync(CreateClsLogTopicRequest req)
        {
             JsonResponseModel<CreateClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateDiagnoseUrl 用于添加域名诊断任务URL
        /// </summary>
        /// <param name="req"><see cref="CreateDiagnoseUrlRequest"/></param>
        /// <returns><see cref="CreateDiagnoseUrlResponse"/></returns>
        public async Task<CreateDiagnoseUrlResponse> CreateDiagnoseUrl(CreateDiagnoseUrlRequest req)
        {
             JsonResponseModel<CreateDiagnoseUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDiagnoseUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDiagnoseUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateDiagnoseUrl 用于添加域名诊断任务URL
        /// </summary>
        /// <param name="req"><see cref="CreateDiagnoseUrlRequest"/></param>
        /// <returns><see cref="CreateDiagnoseUrlResponse"/></returns>
        public CreateDiagnoseUrlResponse CreateDiagnoseUrlSync(CreateDiagnoseUrlRequest req)
        {
             JsonResponseModel<CreateDiagnoseUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDiagnoseUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDiagnoseUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 动态打包任务提交接口
        /// </summary>
        /// <param name="req"><see cref="CreateEdgePackTaskRequest"/></param>
        /// <returns><see cref="CreateEdgePackTaskResponse"/></returns>
        public async Task<CreateEdgePackTaskResponse> CreateEdgePackTask(CreateEdgePackTaskRequest req)
        {
             JsonResponseModel<CreateEdgePackTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEdgePackTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgePackTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 动态打包任务提交接口
        /// </summary>
        /// <param name="req"><see cref="CreateEdgePackTaskRequest"/></param>
        /// <returns><see cref="CreateEdgePackTaskResponse"/></returns>
        public CreateEdgePackTaskResponse CreateEdgePackTaskSync(CreateEdgePackTaskRequest req)
        {
             JsonResponseModel<CreateEdgePackTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEdgePackTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgePackTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateScdnLogTask 用于创建事件日志任务
        /// </summary>
        /// <param name="req"><see cref="CreateScdnLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnLogTaskResponse"/></returns>
        public async Task<CreateScdnLogTaskResponse> CreateScdnLogTask(CreateScdnLogTaskRequest req)
        {
             JsonResponseModel<CreateScdnLogTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScdnLogTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnLogTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateScdnLogTask 用于创建事件日志任务
        /// </summary>
        /// <param name="req"><see cref="CreateScdnLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnLogTaskResponse"/></returns>
        public CreateScdnLogTaskResponse CreateScdnLogTaskSync(CreateScdnLogTaskRequest req)
        {
             JsonResponseModel<CreateScdnLogTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScdnLogTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnLogTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权
        /// </summary>
        /// <param name="req"><see cref="CreateVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateVerifyRecordResponse"/></returns>
        public async Task<CreateVerifyRecordResponse> CreateVerifyRecord(CreateVerifyRecordRequest req)
        {
             JsonResponseModel<CreateVerifyRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVerifyRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVerifyRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权
        /// </summary>
        /// <param name="req"><see cref="CreateVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateVerifyRecordResponse"/></returns>
        public CreateVerifyRecordResponse CreateVerifyRecordSync(CreateVerifyRecordRequest req)
        {
             JsonResponseModel<CreateVerifyRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVerifyRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVerifyRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteCdnDomain 用于删除指定加速域名
        /// </summary>
        /// <param name="req"><see cref="DeleteCdnDomainRequest"/></param>
        /// <returns><see cref="DeleteCdnDomainResponse"/></returns>
        public async Task<DeleteCdnDomainResponse> DeleteCdnDomain(DeleteCdnDomainRequest req)
        {
             JsonResponseModel<DeleteCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteCdnDomain 用于删除指定加速域名
        /// </summary>
        /// <param name="req"><see cref="DeleteCdnDomainRequest"/></param>
        /// <returns><see cref="DeleteCdnDomainResponse"/></returns>
        public DeleteCdnDomainResponse DeleteCdnDomainSync(DeleteCdnDomainRequest req)
        {
             JsonResponseModel<DeleteCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteClsLogTopic 用于删除日志主题。注意：删除后，所有该日志主题下绑定域名的日志将不再继续投递至该主题，已经投递的日志将会被全部清空。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="DeleteClsLogTopicRequest"/></param>
        /// <returns><see cref="DeleteClsLogTopicResponse"/></returns>
        public async Task<DeleteClsLogTopicResponse> DeleteClsLogTopic(DeleteClsLogTopicRequest req)
        {
             JsonResponseModel<DeleteClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteClsLogTopic 用于删除日志主题。注意：删除后，所有该日志主题下绑定域名的日志将不再继续投递至该主题，已经投递的日志将会被全部清空。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="DeleteClsLogTopicRequest"/></param>
        /// <returns><see cref="DeleteClsLogTopicResponse"/></returns>
        public DeleteClsLogTopicResponse DeleteClsLogTopicSync(DeleteClsLogTopicRequest req)
        {
             JsonResponseModel<DeleteClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除SCDN域名
        /// </summary>
        /// <param name="req"><see cref="DeleteScdnDomainRequest"/></param>
        /// <returns><see cref="DeleteScdnDomainResponse"/></returns>
        public async Task<DeleteScdnDomainResponse> DeleteScdnDomain(DeleteScdnDomainRequest req)
        {
             JsonResponseModel<DeleteScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除SCDN域名
        /// </summary>
        /// <param name="req"><see cref="DeleteScdnDomainRequest"/></param>
        /// <returns><see cref="DeleteScdnDomainResponse"/></returns>
        public DeleteScdnDomainResponse DeleteScdnDomainSync(DeleteScdnDomainRequest req)
        {
             JsonResponseModel<DeleteScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBillingData 用于查询实际计费数据明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public async Task<DescribeBillingDataResponse> DescribeBillingData(DescribeBillingDataRequest req)
        {
             JsonResponseModel<DescribeBillingDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillingData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBillingData 用于查询实际计费数据明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public DescribeBillingDataResponse DescribeBillingDataSync(DescribeBillingDataRequest req)
        {
             JsonResponseModel<DescribeBillingDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillingData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnData 用于查询 CDN 实时访问监控数据，支持以下指标查询：
        /// 
        /// + 流量（单位为 byte）
        /// + 带宽（单位为 bps）
        /// + 请求数（单位为 次）
        /// + 流量命中率（单位为 %，小数点后保留两位）
        /// + 状态码 2xx 汇总及各 2 开头状态码明细（单位为 个）
        /// + 状态码 3xx 汇总及各 3 开头状态码明细（单位为 个）
        /// + 状态码 4xx 汇总及各 4 开头状态码明细（单位为 个）
        /// + 状态码 5xx 汇总及各 5 开头状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDataRequest"/></param>
        /// <returns><see cref="DescribeCdnDataResponse"/></returns>
        public async Task<DescribeCdnDataResponse> DescribeCdnData(DescribeCdnDataRequest req)
        {
             JsonResponseModel<DescribeCdnDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnData 用于查询 CDN 实时访问监控数据，支持以下指标查询：
        /// 
        /// + 流量（单位为 byte）
        /// + 带宽（单位为 bps）
        /// + 请求数（单位为 次）
        /// + 流量命中率（单位为 %，小数点后保留两位）
        /// + 状态码 2xx 汇总及各 2 开头状态码明细（单位为 个）
        /// + 状态码 3xx 汇总及各 3 开头状态码明细（单位为 个）
        /// + 状态码 4xx 汇总及各 4 开头状态码明细（单位为 个）
        /// + 状态码 5xx 汇总及各 5 开头状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDataRequest"/></param>
        /// <returns><see cref="DescribeCdnDataResponse"/></returns>
        public DescribeCdnDataResponse DescribeCdnDataSync(DescribeCdnDataRequest req)
        {
             JsonResponseModel<DescribeCdnDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnDomainLogs 用于查询访问日志下载地址，仅支持 30 天以内的境内、境外访问日志下载链接查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnDomainLogsResponse"/></returns>
        public async Task<DescribeCdnDomainLogsResponse> DescribeCdnDomainLogs(DescribeCdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeCdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnDomainLogs 用于查询访问日志下载地址，仅支持 30 天以内的境内、境外访问日志下载链接查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnDomainLogsResponse"/></returns>
        public DescribeCdnDomainLogsResponse DescribeCdnDomainLogsSync(DescribeCdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeCdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnIp 用于查询 CDN IP 归属。
        /// （注意：此接口请求频率限制以 CDN 侧限制为准：200次/10分钟）  
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnIpRequest"/></param>
        /// <returns><see cref="DescribeCdnIpResponse"/></returns>
        public async Task<DescribeCdnIpResponse> DescribeCdnIp(DescribeCdnIpRequest req)
        {
             JsonResponseModel<DescribeCdnIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnIp 用于查询 CDN IP 归属。
        /// （注意：此接口请求频率限制以 CDN 侧限制为准：200次/10分钟）  
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnIpRequest"/></param>
        /// <returns><see cref="DescribeCdnIpResponse"/></returns>
        public DescribeCdnIpResponse DescribeCdnIpSync(DescribeCdnIpRequest req)
        {
             JsonResponseModel<DescribeCdnIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCdnOriginIp）用于查询 CDN 回源节点的IP信息。（注：使用此接口需开启对应白名单）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnOriginIpRequest"/></param>
        /// <returns><see cref="DescribeCdnOriginIpResponse"/></returns>
        public async Task<DescribeCdnOriginIpResponse> DescribeCdnOriginIp(DescribeCdnOriginIpRequest req)
        {
             JsonResponseModel<DescribeCdnOriginIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnOriginIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnOriginIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCdnOriginIp）用于查询 CDN 回源节点的IP信息。（注：使用此接口需开启对应白名单）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnOriginIpRequest"/></param>
        /// <returns><see cref="DescribeCdnOriginIpResponse"/></returns>
        public DescribeCdnOriginIpResponse DescribeCdnOriginIpSync(DescribeCdnOriginIpRequest req)
        {
             JsonResponseModel<DescribeCdnOriginIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnOriginIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnOriginIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCertDomains 用于校验SSL证书并提取证书中包含的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDomainsRequest"/></param>
        /// <returns><see cref="DescribeCertDomainsResponse"/></returns>
        public async Task<DescribeCertDomainsResponse> DescribeCertDomains(DescribeCertDomainsRequest req)
        {
             JsonResponseModel<DescribeCertDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCertDomains 用于校验SSL证书并提取证书中包含的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDomainsRequest"/></param>
        /// <returns><see cref="DescribeCertDomainsResponse"/></returns>
        public DescribeCertDomainsResponse DescribeCertDomainsSync(DescribeCertDomainsRequest req)
        {
             JsonResponseModel<DescribeCertDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDiagnoseReport 用于获取指定报告id的内容
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnoseReportRequest"/></param>
        /// <returns><see cref="DescribeDiagnoseReportResponse"/></returns>
        public async Task<DescribeDiagnoseReportResponse> DescribeDiagnoseReport(DescribeDiagnoseReportRequest req)
        {
             JsonResponseModel<DescribeDiagnoseReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiagnoseReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiagnoseReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDiagnoseReport 用于获取指定报告id的内容
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnoseReportRequest"/></param>
        /// <returns><see cref="DescribeDiagnoseReportResponse"/></returns>
        public DescribeDiagnoseReportResponse DescribeDiagnoseReportSync(DescribeDiagnoseReportRequest req)
        {
             JsonResponseModel<DescribeDiagnoseReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiagnoseReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiagnoseReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定域名的区域、运营商明细数据
        /// 注意事项：接口尚未全量开放，未在内测名单中的账号不支持调用
        /// </summary>
        /// <param name="req"><see cref="DescribeDistrictIspDataRequest"/></param>
        /// <returns><see cref="DescribeDistrictIspDataResponse"/></returns>
        public async Task<DescribeDistrictIspDataResponse> DescribeDistrictIspData(DescribeDistrictIspDataRequest req)
        {
             JsonResponseModel<DescribeDistrictIspDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDistrictIspData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDistrictIspDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定域名的区域、运营商明细数据
        /// 注意事项：接口尚未全量开放，未在内测名单中的账号不支持调用
        /// </summary>
        /// <param name="req"><see cref="DescribeDistrictIspDataRequest"/></param>
        /// <returns><see cref="DescribeDistrictIspDataResponse"/></returns>
        public DescribeDistrictIspDataResponse DescribeDistrictIspDataSync(DescribeDistrictIspDataRequest req)
        {
             JsonResponseModel<DescribeDistrictIspDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDistrictIspData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDistrictIspDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDomains 用于查询内容分发网络加速域名（含境内、境外）基本配置信息，包括项目ID、服务状态，业务类型、创建时间、更新时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public async Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDomains 用于查询内容分发网络加速域名（含境内、境外）基本配置信息，包括项目ID、服务状态，业务类型、创建时间、更新时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDomainsConfig 用于查询内容分发网络加速域名（含境内、境外）的所有配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public async Task<DescribeDomainsConfigResponse> DescribeDomainsConfig(DescribeDomainsConfigRequest req)
        {
             JsonResponseModel<DescribeDomainsConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainsConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDomainsConfig 用于查询内容分发网络加速域名（含境内、境外）的所有配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public DescribeDomainsConfigResponse DescribeDomainsConfigSync(DescribeDomainsConfigRequest req)
        {
             JsonResponseModel<DescribeDomainsConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainsConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImageConfig 用于获取域名图片优化的当前配置，支持Webp、TPG 和 Guetzli。 
        /// </summary>
        /// <param name="req"><see cref="DescribeImageConfigRequest"/></param>
        /// <returns><see cref="DescribeImageConfigResponse"/></returns>
        public async Task<DescribeImageConfigResponse> DescribeImageConfig(DescribeImageConfigRequest req)
        {
             JsonResponseModel<DescribeImageConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImageConfig 用于获取域名图片优化的当前配置，支持Webp、TPG 和 Guetzli。 
        /// </summary>
        /// <param name="req"><see cref="DescribeImageConfigRequest"/></param>
        /// <returns><see cref="DescribeImageConfigResponse"/></returns>
        public DescribeImageConfigResponse DescribeImageConfigSync(DescribeImageConfigRequest req)
        {
             JsonResponseModel<DescribeImageConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpStatus 用于查询域名所在加速平台的边缘节点、回源节点明细。注意事项：边缘节点（edge）尚未全量开放，未在内测名单中的账号不支持调用
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public async Task<DescribeIpStatusResponse> DescribeIpStatus(DescribeIpStatusRequest req)
        {
             JsonResponseModel<DescribeIpStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpStatus 用于查询域名所在加速平台的边缘节点、回源节点明细。注意事项：边缘节点（edge）尚未全量开放，未在内测名单中的账号不支持调用
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public DescribeIpStatusResponse DescribeIpStatusSync(DescribeIpStatusRequest req)
        {
             JsonResponseModel<DescribeIpStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpVisit 用于查询 5 分钟活跃用户数，及日活跃用户数明细
        /// 
        /// + 5 分钟活跃用户数：根据日志中客户端 IP，5 分钟粒度去重统计
        /// + 日活跃用户数：根据日志中客户端 IP，按天粒度去重统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIpVisitRequest"/></param>
        /// <returns><see cref="DescribeIpVisitResponse"/></returns>
        public async Task<DescribeIpVisitResponse> DescribeIpVisit(DescribeIpVisitRequest req)
        {
             JsonResponseModel<DescribeIpVisitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpVisit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpVisitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpVisit 用于查询 5 分钟活跃用户数，及日活跃用户数明细
        /// 
        /// + 5 分钟活跃用户数：根据日志中客户端 IP，5 分钟粒度去重统计
        /// + 日活跃用户数：根据日志中客户端 IP，按天粒度去重统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIpVisitRequest"/></param>
        /// <returns><see cref="DescribeIpVisitResponse"/></returns>
        public DescribeIpVisitResponse DescribeIpVisitSync(DescribeIpVisitRequest req)
        {
             JsonResponseModel<DescribeIpVisitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpVisit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpVisitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeMapInfo 用于查询省份对应的 ID，运营商对应的 ID 信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMapInfoRequest"/></param>
        /// <returns><see cref="DescribeMapInfoResponse"/></returns>
        public async Task<DescribeMapInfoResponse> DescribeMapInfo(DescribeMapInfoRequest req)
        {
             JsonResponseModel<DescribeMapInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMapInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMapInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeMapInfo 用于查询省份对应的 ID，运营商对应的 ID 信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMapInfoRequest"/></param>
        /// <returns><see cref="DescribeMapInfoResponse"/></returns>
        public DescribeMapInfoResponse DescribeMapInfoSync(DescribeMapInfoRequest req)
        {
             JsonResponseModel<DescribeMapInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMapInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMapInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeOriginData 用于查询 CDN 实时回源监控数据，支持以下指标查询：
        /// 
        /// + 回源流量（单位为 byte）
        /// + 回源带宽（单位为 bps）
        /// + 回源请求数（单位为 次）
        /// + 回源失败请求数（单位为 次）
        /// + 回源失败率（单位为 %，小数点后保留两位）
        /// + 回源状态码 2xx 汇总及各 2 开头回源状态码明细（单位为 个）
        /// + 回源状态码 3xx 汇总及各 3 开头回源状态码明细（单位为 个）
        /// + 回源状态码 4xx 汇总及各 4 开头回源状态码明细（单位为 个）
        /// + 回源状态码 5xx 汇总及各 5 开头回源状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginDataRequest"/></param>
        /// <returns><see cref="DescribeOriginDataResponse"/></returns>
        public async Task<DescribeOriginDataResponse> DescribeOriginData(DescribeOriginDataRequest req)
        {
             JsonResponseModel<DescribeOriginDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOriginData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeOriginData 用于查询 CDN 实时回源监控数据，支持以下指标查询：
        /// 
        /// + 回源流量（单位为 byte）
        /// + 回源带宽（单位为 bps）
        /// + 回源请求数（单位为 次）
        /// + 回源失败请求数（单位为 次）
        /// + 回源失败率（单位为 %，小数点后保留两位）
        /// + 回源状态码 2xx 汇总及各 2 开头回源状态码明细（单位为 个）
        /// + 回源状态码 3xx 汇总及各 3 开头回源状态码明细（单位为 个）
        /// + 回源状态码 4xx 汇总及各 4 开头回源状态码明细（单位为 个）
        /// + 回源状态码 5xx 汇总及各 5 开头回源状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginDataRequest"/></param>
        /// <returns><see cref="DescribeOriginDataResponse"/></returns>
        public DescribeOriginDataResponse DescribeOriginDataSync(DescribeOriginDataRequest req)
        {
             JsonResponseModel<DescribeOriginDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOriginData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePayType 用于查询用户的计费类型，计费周期等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePayTypeRequest"/></param>
        /// <returns><see cref="DescribePayTypeResponse"/></returns>
        public async Task<DescribePayTypeResponse> DescribePayType(DescribePayTypeRequest req)
        {
             JsonResponseModel<DescribePayTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePayType 用于查询用户的计费类型，计费周期等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePayTypeRequest"/></param>
        /// <returns><see cref="DescribePayTypeResponse"/></returns>
        public DescribePayTypeResponse DescribePayTypeSync(DescribePayTypeRequest req)
        {
             JsonResponseModel<DescribePayTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePurgeQuota 用于查询账户刷新配额和每日可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public async Task<DescribePurgeQuotaResponse> DescribePurgeQuota(DescribePurgeQuotaRequest req)
        {
             JsonResponseModel<DescribePurgeQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePurgeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePurgeQuota 用于查询账户刷新配额和每日可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public DescribePurgeQuotaResponse DescribePurgeQuotaSync(DescribePurgeQuotaRequest req)
        {
             JsonResponseModel<DescribePurgeQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePurgeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询提交的 URL 刷新、目录刷新记录及执行进度，通过 PurgePathCache 与 PurgeUrlsCache 接口提交的任务均可通过此接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public async Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询提交的 URL 刷新、目录刷新记录及执行进度，通过 PurgePathCache 与 PurgeUrlsCache 接口提交的任务均可通过此接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePushQuota  用于查询预热配额和每日可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribePushQuotaRequest"/></param>
        /// <returns><see cref="DescribePushQuotaResponse"/></returns>
        public async Task<DescribePushQuotaResponse> DescribePushQuota(DescribePushQuotaRequest req)
        {
             JsonResponseModel<DescribePushQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePushQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePushQuota  用于查询预热配额和每日可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribePushQuotaRequest"/></param>
        /// <returns><see cref="DescribePushQuotaResponse"/></returns>
        public DescribePushQuotaResponse DescribePushQuotaSync(DescribePushQuotaRequest req)
        {
             JsonResponseModel<DescribePushQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePushQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePushTasks  用于查询预热任务提交历史记录及执行进度。
        /// 接口灰度中，暂未全量开放，敬请期待。
        /// </summary>
        /// <param name="req"><see cref="DescribePushTasksRequest"/></param>
        /// <returns><see cref="DescribePushTasksResponse"/></returns>
        public async Task<DescribePushTasksResponse> DescribePushTasks(DescribePushTasksRequest req)
        {
             JsonResponseModel<DescribePushTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePushTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePushTasks  用于查询预热任务提交历史记录及执行进度。
        /// 接口灰度中，暂未全量开放，敬请期待。
        /// </summary>
        /// <param name="req"><see cref="DescribePushTasksRequest"/></param>
        /// <returns><see cref="DescribePushTasksResponse"/></returns>
        public DescribePushTasksResponse DescribePushTasksSync(DescribePushTasksRequest req)
        {
             JsonResponseModel<DescribePushTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePushTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeReportData 用于查询域名/项目维度的日/周/月报表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeReportDataRequest"/></param>
        /// <returns><see cref="DescribeReportDataResponse"/></returns>
        public async Task<DescribeReportDataResponse> DescribeReportData(DescribeReportDataRequest req)
        {
             JsonResponseModel<DescribeReportDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReportData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeReportData 用于查询域名/项目维度的日/周/月报表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeReportDataRequest"/></param>
        /// <returns><see cref="DescribeReportDataResponse"/></returns>
        public DescribeReportDataResponse DescribeReportDataSync(DescribeReportDataRequest req)
        {
             JsonResponseModel<DescribeReportDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReportData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeScdnConfig 用于查询指定 SCDN 加速域名的安全相关配置
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnConfigRequest"/></param>
        /// <returns><see cref="DescribeScdnConfigResponse"/></returns>
        public async Task<DescribeScdnConfigResponse> DescribeScdnConfig(DescribeScdnConfigRequest req)
        {
             JsonResponseModel<DescribeScdnConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScdnConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeScdnConfig 用于查询指定 SCDN 加速域名的安全相关配置
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnConfigRequest"/></param>
        /// <returns><see cref="DescribeScdnConfigResponse"/></returns>
        public DescribeScdnConfigResponse DescribeScdnConfigSync(DescribeScdnConfigRequest req)
        {
             JsonResponseModel<DescribeScdnConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScdnConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取SCDN的Top数据
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnTopDataRequest"/></param>
        /// <returns><see cref="DescribeScdnTopDataResponse"/></returns>
        public async Task<DescribeScdnTopDataResponse> DescribeScdnTopData(DescribeScdnTopDataRequest req)
        {
             JsonResponseModel<DescribeScdnTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScdnTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取SCDN的Top数据
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnTopDataRequest"/></param>
        /// <returns><see cref="DescribeScdnTopDataResponse"/></returns>
        public DescribeScdnTopDataResponse DescribeScdnTopDataSync(DescribeScdnTopDataRequest req)
        {
             JsonResponseModel<DescribeScdnTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScdnTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrafficPackages 用于查询中国境内 CDN 流量包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public async Task<DescribeTrafficPackagesResponse> DescribeTrafficPackages(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrafficPackages 用于查询中国境内 CDN 流量包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public DescribeTrafficPackagesResponse DescribeTrafficPackagesSync(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUrlViolations 用于查询被 CDN 系统扫描到的域名违规 URL 列表及当前状态。
        /// 对应内容分发网络控制台【图片鉴黄】页面。
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlViolationsRequest"/></param>
        /// <returns><see cref="DescribeUrlViolationsResponse"/></returns>
        public async Task<DescribeUrlViolationsResponse> DescribeUrlViolations(DescribeUrlViolationsRequest req)
        {
             JsonResponseModel<DescribeUrlViolationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUrlViolations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUrlViolationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUrlViolations 用于查询被 CDN 系统扫描到的域名违规 URL 列表及当前状态。
        /// 对应内容分发网络控制台【图片鉴黄】页面。
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlViolationsRequest"/></param>
        /// <returns><see cref="DescribeUrlViolationsResponse"/></returns>
        public DescribeUrlViolationsResponse DescribeUrlViolationsSync(DescribeUrlViolationsRequest req)
        {
             JsonResponseModel<DescribeUrlViolationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUrlViolations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUrlViolationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableCaches 用于禁用 CDN 上指定 URL 的访问，禁用完成后，中国境内访问会直接返回 403。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req"><see cref="DisableCachesRequest"/></param>
        /// <returns><see cref="DisableCachesResponse"/></returns>
        public async Task<DisableCachesResponse> DisableCaches(DisableCachesRequest req)
        {
             JsonResponseModel<DisableCachesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableCaches 用于禁用 CDN 上指定 URL 的访问，禁用完成后，中国境内访问会直接返回 403。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req"><see cref="DisableCachesRequest"/></param>
        /// <returns><see cref="DisableCachesResponse"/></returns>
        public DisableCachesResponse DisableCachesSync(DisableCachesRequest req)
        {
             JsonResponseModel<DisableCachesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableClsLogTopic 用于停止日志主题投递。注意：停止后，所有绑定该日志主题域名的日志将不再继续投递至该主题，已经投递的日志将会继续保留。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="DisableClsLogTopicRequest"/></param>
        /// <returns><see cref="DisableClsLogTopicResponse"/></returns>
        public async Task<DisableClsLogTopicResponse> DisableClsLogTopic(DisableClsLogTopicRequest req)
        {
             JsonResponseModel<DisableClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableClsLogTopic 用于停止日志主题投递。注意：停止后，所有绑定该日志主题域名的日志将不再继续投递至该主题，已经投递的日志将会继续保留。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="DisableClsLogTopicRequest"/></param>
        /// <returns><see cref="DisableClsLogTopicResponse"/></returns>
        public DisableClsLogTopicResponse DisableClsLogTopicSync(DisableClsLogTopicRequest req)
        {
             JsonResponseModel<DisableClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拷贝参考域名的配置至新域名。暂不支持自有证书以及定制化配置
        /// </summary>
        /// <param name="req"><see cref="DuplicateDomainConfigRequest"/></param>
        /// <returns><see cref="DuplicateDomainConfigResponse"/></returns>
        public async Task<DuplicateDomainConfigResponse> DuplicateDomainConfig(DuplicateDomainConfigRequest req)
        {
             JsonResponseModel<DuplicateDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DuplicateDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DuplicateDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拷贝参考域名的配置至新域名。暂不支持自有证书以及定制化配置
        /// </summary>
        /// <param name="req"><see cref="DuplicateDomainConfigRequest"/></param>
        /// <returns><see cref="DuplicateDomainConfigResponse"/></returns>
        public DuplicateDomainConfigResponse DuplicateDomainConfigSync(DuplicateDomainConfigRequest req)
        {
             JsonResponseModel<DuplicateDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DuplicateDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DuplicateDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableCaches 用于解禁手工封禁的 URL，解禁成功后，全网生效时间约 5~10 分钟。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req"><see cref="EnableCachesRequest"/></param>
        /// <returns><see cref="EnableCachesResponse"/></returns>
        public async Task<EnableCachesResponse> EnableCaches(EnableCachesRequest req)
        {
             JsonResponseModel<EnableCachesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableCaches 用于解禁手工封禁的 URL，解禁成功后，全网生效时间约 5~10 分钟。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req"><see cref="EnableCachesRequest"/></param>
        /// <returns><see cref="EnableCachesResponse"/></returns>
        public EnableCachesResponse EnableCachesSync(EnableCachesRequest req)
        {
             JsonResponseModel<EnableCachesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableClsLogTopic 用于启动日志主题投递。注意：启动后，所有绑定该日志主题域名的日志将继续投递至该主题。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="EnableClsLogTopicRequest"/></param>
        /// <returns><see cref="EnableClsLogTopicResponse"/></returns>
        public async Task<EnableClsLogTopicResponse> EnableClsLogTopic(EnableClsLogTopicRequest req)
        {
             JsonResponseModel<EnableClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableClsLogTopic 用于启动日志主题投递。注意：启动后，所有绑定该日志主题域名的日志将继续投递至该主题。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="EnableClsLogTopicRequest"/></param>
        /// <returns><see cref="EnableClsLogTopicResponse"/></returns>
        public EnableClsLogTopicResponse EnableClsLogTopicSync(EnableClsLogTopicRequest req)
        {
             JsonResponseModel<EnableClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetDisableRecords 用于查询资源禁用历史，及 URL 当前状态。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req"><see cref="GetDisableRecordsRequest"/></param>
        /// <returns><see cref="GetDisableRecordsResponse"/></returns>
        public async Task<GetDisableRecordsResponse> GetDisableRecords(GetDisableRecordsRequest req)
        {
             JsonResponseModel<GetDisableRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDisableRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDisableRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetDisableRecords 用于查询资源禁用历史，及 URL 当前状态。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req"><see cref="GetDisableRecordsRequest"/></param>
        /// <returns><see cref="GetDisableRecordsResponse"/></returns>
        public GetDisableRecordsResponse GetDisableRecordsSync(GetDisableRecordsRequest req)
        {
             JsonResponseModel<GetDisableRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDisableRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDisableRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListClsLogTopics 用于显示日志主题列表。注意：一个日志集下至多含10个日志主题。
        /// </summary>
        /// <param name="req"><see cref="ListClsLogTopicsRequest"/></param>
        /// <returns><see cref="ListClsLogTopicsResponse"/></returns>
        public async Task<ListClsLogTopicsResponse> ListClsLogTopics(ListClsLogTopicsRequest req)
        {
             JsonResponseModel<ListClsLogTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListClsLogTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClsLogTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListClsLogTopics 用于显示日志主题列表。注意：一个日志集下至多含10个日志主题。
        /// </summary>
        /// <param name="req"><see cref="ListClsLogTopicsRequest"/></param>
        /// <returns><see cref="ListClsLogTopicsResponse"/></returns>
        public ListClsLogTopicsResponse ListClsLogTopicsSync(ListClsLogTopicsRequest req)
        {
             JsonResponseModel<ListClsLogTopicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListClsLogTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClsLogTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListClsTopicDomains 用于获取某日志主题下绑定的域名列表。
        /// </summary>
        /// <param name="req"><see cref="ListClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ListClsTopicDomainsResponse"/></returns>
        public async Task<ListClsTopicDomainsResponse> ListClsTopicDomains(ListClsTopicDomainsRequest req)
        {
             JsonResponseModel<ListClsTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListClsTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClsTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListClsTopicDomains 用于获取某日志主题下绑定的域名列表。
        /// </summary>
        /// <param name="req"><see cref="ListClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ListClsTopicDomainsResponse"/></returns>
        public ListClsTopicDomainsResponse ListClsTopicDomainsSync(ListClsTopicDomainsRequest req)
        {
             JsonResponseModel<ListClsTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListClsTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClsTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListDiagnoseReport 用于获取用户诊断URL访问后各个子任务的简要详情。
        /// </summary>
        /// <param name="req"><see cref="ListDiagnoseReportRequest"/></param>
        /// <returns><see cref="ListDiagnoseReportResponse"/></returns>
        public async Task<ListDiagnoseReportResponse> ListDiagnoseReport(ListDiagnoseReportRequest req)
        {
             JsonResponseModel<ListDiagnoseReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListDiagnoseReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDiagnoseReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListDiagnoseReport 用于获取用户诊断URL访问后各个子任务的简要详情。
        /// </summary>
        /// <param name="req"><see cref="ListDiagnoseReportRequest"/></param>
        /// <returns><see cref="ListDiagnoseReportResponse"/></returns>
        public ListDiagnoseReportResponse ListDiagnoseReportSync(ListDiagnoseReportRequest req)
        {
             JsonResponseModel<ListDiagnoseReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListDiagnoseReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDiagnoseReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListScdnDomains 用于查询 SCDN 安全加速域名列表，及域名基本配置信息
        /// </summary>
        /// <param name="req"><see cref="ListScdnDomainsRequest"/></param>
        /// <returns><see cref="ListScdnDomainsResponse"/></returns>
        public async Task<ListScdnDomainsResponse> ListScdnDomains(ListScdnDomainsRequest req)
        {
             JsonResponseModel<ListScdnDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListScdnDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListScdnDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListScdnDomains 用于查询 SCDN 安全加速域名列表，及域名基本配置信息
        /// </summary>
        /// <param name="req"><see cref="ListScdnDomainsRequest"/></param>
        /// <returns><see cref="ListScdnDomainsResponse"/></returns>
        public ListScdnDomainsResponse ListScdnDomainsSync(ListScdnDomainsRequest req)
        {
             JsonResponseModel<ListScdnDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListScdnDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListScdnDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListScdnLogTasks 用于查询SCDN日志下载任务列表,以及展示下载任务基本信息
        /// </summary>
        /// <param name="req"><see cref="ListScdnLogTasksRequest"/></param>
        /// <returns><see cref="ListScdnLogTasksResponse"/></returns>
        public async Task<ListScdnLogTasksResponse> ListScdnLogTasks(ListScdnLogTasksRequest req)
        {
             JsonResponseModel<ListScdnLogTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListScdnLogTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListScdnLogTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListScdnLogTasks 用于查询SCDN日志下载任务列表,以及展示下载任务基本信息
        /// </summary>
        /// <param name="req"><see cref="ListScdnLogTasksRequest"/></param>
        /// <returns><see cref="ListScdnLogTasksResponse"/></returns>
        public ListScdnLogTasksResponse ListScdnLogTasksSync(ListScdnLogTasksRequest req)
        {
             JsonResponseModel<ListScdnLogTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListScdnLogTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListScdnLogTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 URL 排序，从大至小返回 TOP 1000 URL
        /// + 依据总流量、总请求数对客户端省份排序，从大至小返回省份列表
        /// + 依据总流量、总请求数对客户端运营商排序，从大至小返回运营商列表
        /// + 依据总流量、峰值带宽、总请求数、平均命中率、2XX/3XX/4XX/5XX 状态码对域名排序，从大至小返回域名列表
        /// + 依据总回源流量、回源峰值带宽、总回源请求数、平均回源失败率、2XX/3XX/4XX/5XX 回源状态码对域名排序，从大至小返回域名列表
        /// 
        /// 注意：仅支持 90 天内数据查询
        /// </summary>
        /// <param name="req"><see cref="ListTopDataRequest"/></param>
        /// <returns><see cref="ListTopDataResponse"/></returns>
        public async Task<ListTopDataResponse> ListTopData(ListTopDataRequest req)
        {
             JsonResponseModel<ListTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 URL 排序，从大至小返回 TOP 1000 URL
        /// + 依据总流量、总请求数对客户端省份排序，从大至小返回省份列表
        /// + 依据总流量、总请求数对客户端运营商排序，从大至小返回运营商列表
        /// + 依据总流量、峰值带宽、总请求数、平均命中率、2XX/3XX/4XX/5XX 状态码对域名排序，从大至小返回域名列表
        /// + 依据总回源流量、回源峰值带宽、总回源请求数、平均回源失败率、2XX/3XX/4XX/5XX 回源状态码对域名排序，从大至小返回域名列表
        /// 
        /// 注意：仅支持 90 天内数据查询
        /// </summary>
        /// <param name="req"><see cref="ListTopDataRequest"/></param>
        /// <returns><see cref="ListTopDataResponse"/></returns>
        public ListTopDataResponse ListTopDataSync(ListTopDataRequest req)
        {
             JsonResponseModel<ListTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ManageClsTopicDomains 用于管理某日志主题下绑定的域名列表。
        /// </summary>
        /// <param name="req"><see cref="ManageClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ManageClsTopicDomainsResponse"/></returns>
        public async Task<ManageClsTopicDomainsResponse> ManageClsTopicDomains(ManageClsTopicDomainsRequest req)
        {
             JsonResponseModel<ManageClsTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageClsTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageClsTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ManageClsTopicDomains 用于管理某日志主题下绑定的域名列表。
        /// </summary>
        /// <param name="req"><see cref="ManageClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ManageClsTopicDomainsResponse"/></returns>
        public ManageClsTopicDomainsResponse ManageClsTopicDomainsSync(ManageClsTopicDomainsRequest req)
        {
             JsonResponseModel<ManageClsTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageClsTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageClsTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgePathCache 用于批量提交目录刷新，根据域名的加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日目录刷新额度为各 100 条，每次最多可提交 20 条。
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public async Task<PurgePathCacheResponse> PurgePathCache(PurgePathCacheRequest req)
        {
             JsonResponseModel<PurgePathCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PurgePathCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgePathCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgePathCache 用于批量提交目录刷新，根据域名的加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日目录刷新额度为各 100 条，每次最多可提交 20 条。
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public PurgePathCacheResponse PurgePathCacheSync(PurgePathCacheRequest req)
        {
             JsonResponseModel<PurgePathCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PurgePathCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgePathCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgeUrlsCache 用于批量提交 URL 进行刷新，根据 URL 中域名的当前加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日 URL 刷新额度各为 10000 条，每次最多可提交 1000 条。
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public async Task<PurgeUrlsCacheResponse> PurgeUrlsCache(PurgeUrlsCacheRequest req)
        {
             JsonResponseModel<PurgeUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PurgeUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgeUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgeUrlsCache 用于批量提交 URL 进行刷新，根据 URL 中域名的当前加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日 URL 刷新额度各为 10000 条，每次最多可提交 1000 条。
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public PurgeUrlsCacheResponse PurgeUrlsCacheSync(PurgeUrlsCacheRequest req)
        {
             JsonResponseModel<PurgeUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PurgeUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgeUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PushUrlsCache 用于将指定 URL 资源列表加载至 CDN 节点，支持指定加速区域预热。
        /// 默认情况下境内、境外每日预热 URL 限额为各 1000 条，每次最多可提交 20 条。
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public async Task<PushUrlsCacheResponse> PushUrlsCache(PushUrlsCacheRequest req)
        {
             JsonResponseModel<PushUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PushUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PushUrlsCache 用于将指定 URL 资源列表加载至 CDN 节点，支持指定加速区域预热。
        /// 默认情况下境内、境外每日预热 URL 限额为各 1000 条，每次最多可提交 20 条。
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public PushUrlsCacheResponse PushUrlsCacheSync(PushUrlsCacheRequest req)
        {
             JsonResponseModel<PushUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PushUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SearchClsLog 用于 CLS 日志检索。支持检索今天，24小时（可选近7中的某一天），近7天的日志数据。
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public async Task<SearchClsLogResponse> SearchClsLog(SearchClsLogRequest req)
        {
             JsonResponseModel<SearchClsLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchClsLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchClsLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SearchClsLog 用于 CLS 日志检索。支持检索今天，24小时（可选近7中的某一天），近7天的日志数据。
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public SearchClsLogResponse SearchClsLogSync(SearchClsLogRequest req)
        {
             JsonResponseModel<SearchClsLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchClsLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchClsLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartCdnDomain 用于启用已停用域名的加速服务
        /// </summary>
        /// <param name="req"><see cref="StartCdnDomainRequest"/></param>
        /// <returns><see cref="StartCdnDomainResponse"/></returns>
        public async Task<StartCdnDomainResponse> StartCdnDomain(StartCdnDomainRequest req)
        {
             JsonResponseModel<StartCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartCdnDomain 用于启用已停用域名的加速服务
        /// </summary>
        /// <param name="req"><see cref="StartCdnDomainRequest"/></param>
        /// <returns><see cref="StartCdnDomainResponse"/></returns>
        public StartCdnDomainResponse StartCdnDomainSync(StartCdnDomainRequest req)
        {
             JsonResponseModel<StartCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartScdnDomain 用于开启域名的安全防护配置
        /// </summary>
        /// <param name="req"><see cref="StartScdnDomainRequest"/></param>
        /// <returns><see cref="StartScdnDomainResponse"/></returns>
        public async Task<StartScdnDomainResponse> StartScdnDomain(StartScdnDomainRequest req)
        {
             JsonResponseModel<StartScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartScdnDomain 用于开启域名的安全防护配置
        /// </summary>
        /// <param name="req"><see cref="StartScdnDomainRequest"/></param>
        /// <returns><see cref="StartScdnDomainResponse"/></returns>
        public StartScdnDomainResponse StartScdnDomainSync(StartScdnDomainRequest req)
        {
             JsonResponseModel<StartScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StopCdnDomain 用于停止域名的加速服务。
        /// 注意：停止加速服务后，访问至加速节点的请求将会直接返回 404。为避免对您的业务造成影响，请在停止加速服务前将解析切走。
        /// </summary>
        /// <param name="req"><see cref="StopCdnDomainRequest"/></param>
        /// <returns><see cref="StopCdnDomainResponse"/></returns>
        public async Task<StopCdnDomainResponse> StopCdnDomain(StopCdnDomainRequest req)
        {
             JsonResponseModel<StopCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StopCdnDomain 用于停止域名的加速服务。
        /// 注意：停止加速服务后，访问至加速节点的请求将会直接返回 404。为避免对您的业务造成影响，请在停止加速服务前将解析切走。
        /// </summary>
        /// <param name="req"><see cref="StopCdnDomainRequest"/></param>
        /// <returns><see cref="StopCdnDomainResponse"/></returns>
        public StopCdnDomainResponse StopCdnDomainSync(StopCdnDomainRequest req)
        {
             JsonResponseModel<StopCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StopScdnDomain 用于关闭域名的安全防护配置
        /// </summary>
        /// <param name="req"><see cref="StopScdnDomainRequest"/></param>
        /// <returns><see cref="StopScdnDomainResponse"/></returns>
        public async Task<StopScdnDomainResponse> StopScdnDomain(StopScdnDomainRequest req)
        {
             JsonResponseModel<StopScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StopScdnDomain 用于关闭域名的安全防护配置
        /// </summary>
        /// <param name="req"><see cref="StopScdnDomainRequest"/></param>
        /// <returns><see cref="StopScdnDomainResponse"/></returns>
        public StopScdnDomainResponse StopScdnDomainSync(StopScdnDomainRequest req)
        {
             JsonResponseModel<StopScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateDomainConfig 用于修改内容分发网络加速域名配置信息
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值，建议通过查询接口获取配置属性后，直接修改后传递给本接口。Https配置由于证书的特殊性，更新时不用传递证书和密钥字段。
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public async Task<UpdateDomainConfigResponse> UpdateDomainConfig(UpdateDomainConfigRequest req)
        {
             JsonResponseModel<UpdateDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateDomainConfig 用于修改内容分发网络加速域名配置信息
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值，建议通过查询接口获取配置属性后，直接修改后传递给本接口。Https配置由于证书的特殊性，更新时不用传递证书和密钥字段。
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public UpdateDomainConfigResponse UpdateDomainConfigSync(UpdateDomainConfigRequest req)
        {
             JsonResponseModel<UpdateDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateImageConfig 用于更新控制台图片优化的相关配置，支持Webp、TPG 和 Guetzli。 
        /// </summary>
        /// <param name="req"><see cref="UpdateImageConfigRequest"/></param>
        /// <returns><see cref="UpdateImageConfigResponse"/></returns>
        public async Task<UpdateImageConfigResponse> UpdateImageConfig(UpdateImageConfigRequest req)
        {
             JsonResponseModel<UpdateImageConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateImageConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateImageConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateImageConfig 用于更新控制台图片优化的相关配置，支持Webp、TPG 和 Guetzli。 
        /// </summary>
        /// <param name="req"><see cref="UpdateImageConfigRequest"/></param>
        /// <returns><see cref="UpdateImageConfigResponse"/></returns>
        public UpdateImageConfigResponse UpdateImageConfigSync(UpdateImageConfigRequest req)
        {
             JsonResponseModel<UpdateImageConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateImageConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateImageConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpdatePayType)用于修改账号计费类型，暂不支持月结用户或子账号修改。
        /// </summary>
        /// <param name="req"><see cref="UpdatePayTypeRequest"/></param>
        /// <returns><see cref="UpdatePayTypeResponse"/></returns>
        public async Task<UpdatePayTypeResponse> UpdatePayType(UpdatePayTypeRequest req)
        {
             JsonResponseModel<UpdatePayTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdatePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpdatePayType)用于修改账号计费类型，暂不支持月结用户或子账号修改。
        /// </summary>
        /// <param name="req"><see cref="UpdatePayTypeRequest"/></param>
        /// <returns><see cref="UpdatePayTypeResponse"/></returns>
        public UpdatePayTypeResponse UpdatePayTypeSync(UpdatePayTypeRequest req)
        {
             JsonResponseModel<UpdatePayTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdatePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateScdnDomain 用于修改 SCDN 加速域名安全相关配置
        /// </summary>
        /// <param name="req"><see cref="UpdateScdnDomainRequest"/></param>
        /// <returns><see cref="UpdateScdnDomainResponse"/></returns>
        public async Task<UpdateScdnDomainResponse> UpdateScdnDomain(UpdateScdnDomainRequest req)
        {
             JsonResponseModel<UpdateScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateScdnDomain 用于修改 SCDN 加速域名安全相关配置
        /// </summary>
        /// <param name="req"><see cref="UpdateScdnDomainRequest"/></param>
        /// <returns><see cref="UpdateScdnDomainResponse"/></returns>
        public UpdateScdnDomainResponse UpdateScdnDomainSync(UpdateScdnDomainRequest req)
        {
             JsonResponseModel<UpdateScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证域名解析值
        /// </summary>
        /// <param name="req"><see cref="VerifyDomainRecordRequest"/></param>
        /// <returns><see cref="VerifyDomainRecordResponse"/></returns>
        public async Task<VerifyDomainRecordResponse> VerifyDomainRecord(VerifyDomainRecordRequest req)
        {
             JsonResponseModel<VerifyDomainRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyDomainRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyDomainRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证域名解析值
        /// </summary>
        /// <param name="req"><see cref="VerifyDomainRecordRequest"/></param>
        /// <returns><see cref="VerifyDomainRecordResponse"/></returns>
        public VerifyDomainRecordResponse VerifyDomainRecordSync(VerifyDomainRecordRequest req)
        {
             JsonResponseModel<VerifyDomainRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyDomainRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyDomainRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
