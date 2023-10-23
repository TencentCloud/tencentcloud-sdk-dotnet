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
        /// AddCLSTopicDomains 用于新增域名到某日志主题下
        /// </summary>
        /// <param name="req"><see cref="AddCLSTopicDomainsRequest"/></param>
        /// <returns><see cref="AddCLSTopicDomainsResponse"/></returns>
        public async Task<AddCLSTopicDomainsResponse> AddCLSTopicDomains(AddCLSTopicDomainsRequest req)
        {
             JsonResponseModel<AddCLSTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCLSTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCLSTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AddCLSTopicDomains 用于新增域名到某日志主题下
        /// </summary>
        /// <param name="req"><see cref="AddCLSTopicDomainsRequest"/></param>
        /// <returns><see cref="AddCLSTopicDomainsResponse"/></returns>
        public AddCLSTopicDomainsResponse AddCLSTopicDomainsSync(AddCLSTopicDomainsRequest req)
        {
             JsonResponseModel<AddCLSTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCLSTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCLSTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AddCdnDomain 用于新增内容分发网络加速域名。1分钟内最多可新增100个域名。
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
        /// AddCdnDomain 用于新增内容分发网络加速域名。1分钟内最多可新增100个域名。
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// CreateDiagnoseUrl 用于添加域名诊断任务URL。
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// CreateDiagnoseUrl 用于添加域名诊断任务URL。
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
        /// CreateScdnDomain 用于创建 SCDN 加速域名
        /// </summary>
        /// <param name="req"><see cref="CreateScdnDomainRequest"/></param>
        /// <returns><see cref="CreateScdnDomainResponse"/></returns>
        public async Task<CreateScdnDomainResponse> CreateScdnDomain(CreateScdnDomainRequest req)
        {
             JsonResponseModel<CreateScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateScdnDomain 用于创建 SCDN 加速域名
        /// </summary>
        /// <param name="req"><see cref="CreateScdnDomainRequest"/></param>
        /// <returns><see cref="CreateScdnDomainResponse"/></returns>
        public CreateScdnDomainResponse CreateScdnDomainSync(CreateScdnDomainRequest req)
        {
             JsonResponseModel<CreateScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateScdnFailedLogTask 用于重试创建失败的事件日志任务
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public async Task<CreateScdnFailedLogTaskResponse> CreateScdnFailedLogTask(CreateScdnFailedLogTaskRequest req)
        {
             JsonResponseModel<CreateScdnFailedLogTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScdnFailedLogTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnFailedLogTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateScdnFailedLogTask 用于重试创建失败的事件日志任务
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public CreateScdnFailedLogTaskResponse CreateScdnFailedLogTaskSync(CreateScdnFailedLogTaskRequest req)
        {
             JsonResponseModel<CreateScdnFailedLogTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScdnFailedLogTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnFailedLogTaskResponse>>(strResp);
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
        /// CreateVerifyRecord 用于生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权。
        /// 生成的解析记录可通过 [VerifyDomainRecord](https://cloud.tencent.com/document/product/228/48117) 完成归属权校验。
        /// 注意：生成的解析记录有效期为24小时，超过24小时后，需重新生成。
        /// 具体流程可参考：[使用API接口进行域名归属校验](https://cloud.tencent.com/document/product/228/61702#.E6.96.B9.E6.B3.95.E4.B8.89.EF.BC.9Aapi-.E6.8E.A5.E5.8F.A3.E6.93.8D.E4.BD.9C)
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
        /// CreateVerifyRecord 用于生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权。
        /// 生成的解析记录可通过 [VerifyDomainRecord](https://cloud.tencent.com/document/product/228/48117) 完成归属权校验。
        /// 注意：生成的解析记录有效期为24小时，超过24小时后，需重新生成。
        /// 具体流程可参考：[使用API接口进行域名归属校验](https://cloud.tencent.com/document/product/228/61702#.E6.96.B9.E6.B3.95.E4.B8.89.EF.BC.9Aapi-.E6.8E.A5.E5.8F.A3.E6.93.8D.E4.BD.9C)
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
        /// CC统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCcDataRequest"/></param>
        /// <returns><see cref="DescribeCcDataResponse"/></returns>
        public async Task<DescribeCcDataResponse> DescribeCcData(DescribeCcDataRequest req)
        {
             JsonResponseModel<DescribeCcDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CC统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCcDataRequest"/></param>
        /// <returns><see cref="DescribeCcDataResponse"/></returns>
        public DescribeCcDataResponse DescribeCcDataSync(DescribeCcDataRequest req)
        {
             JsonResponseModel<DescribeCcDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcDataResponse>>(strResp);
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
        /// + 命中请求数（单位为 次）
        /// + 请求命中率（单位为 %）
        /// + 命中流量（单位为 byte）
        /// + 流量命中率（单位为 %）
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
        /// + 命中请求数（单位为 次）
        /// + 请求命中率（单位为 %）
        /// + 命中流量（单位为 byte）
        /// + 流量命中率（单位为 %）
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// 本接口（DescribeCdnOriginIp）用于查询 CDN 回源节点的IP信息。（注：替换接口为DescribeIpStatus）
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// 本接口（DescribeCdnOriginIp）用于查询 CDN 回源节点的IP信息。（注：替换接口为DescribeIpStatus）
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
        /// DDoS统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSDataResponse"/></returns>
        public async Task<DescribeDDoSDataResponse> DescribeDDoSData(DescribeDDoSDataRequest req)
        {
             JsonResponseModel<DescribeDDoSDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DDoS统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSDataResponse"/></returns>
        public DescribeDDoSDataResponse DescribeDDoSDataSync(DescribeDDoSDataRequest req)
        {
             JsonResponseModel<DescribeDDoSDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// DescribeDiagnoseReport 用于获取指定报告id的内容。
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// DescribeDiagnoseReport 用于获取指定报告id的内容。
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
        /// 注意事项：接口尚未全面开放，未在内测名单中的账号不支持调用
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
        /// 注意事项：接口尚未全面开放，未在内测名单中的账号不支持调用
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
        /// DescribeEdgePackTaskStatus 用于查询动态打包任务状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgePackTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeEdgePackTaskStatusResponse"/></returns>
        public async Task<DescribeEdgePackTaskStatusResponse> DescribeEdgePackTaskStatus(DescribeEdgePackTaskStatusRequest req)
        {
             JsonResponseModel<DescribeEdgePackTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgePackTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgePackTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEdgePackTaskStatus 用于查询动态打包任务状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgePackTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeEdgePackTaskStatusResponse"/></returns>
        public DescribeEdgePackTaskStatusResponse DescribeEdgePackTaskStatusSync(DescribeEdgePackTaskStatusRequest req)
        {
             JsonResponseModel<DescribeEdgePackTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgePackTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgePackTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEventLogData 用于查询事件日志统计曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeEventLogDataRequest"/></param>
        /// <returns><see cref="DescribeEventLogDataResponse"/></returns>
        public async Task<DescribeEventLogDataResponse> DescribeEventLogData(DescribeEventLogDataRequest req)
        {
             JsonResponseModel<DescribeEventLogDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEventLogData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventLogDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEventLogData 用于查询事件日志统计曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeEventLogDataRequest"/></param>
        /// <returns><see cref="DescribeEventLogDataResponse"/></returns>
        public DescribeEventLogDataResponse DescribeEventLogDataSync(DescribeEventLogDataRequest req)
        {
             JsonResponseModel<DescribeEventLogDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEventLogData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventLogDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeHttpsPackages 用于查询 CDN HTTPS请求包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpsPackagesRequest"/></param>
        /// <returns><see cref="DescribeHttpsPackagesResponse"/></returns>
        public async Task<DescribeHttpsPackagesResponse> DescribeHttpsPackages(DescribeHttpsPackagesRequest req)
        {
             JsonResponseModel<DescribeHttpsPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHttpsPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHttpsPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeHttpsPackages 用于查询 CDN HTTPS请求包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpsPackagesRequest"/></param>
        /// <returns><see cref="DescribeHttpsPackagesResponse"/></returns>
        public DescribeHttpsPackagesResponse DescribeHttpsPackagesSync(DescribeHttpsPackagesRequest req)
        {
             JsonResponseModel<DescribeHttpsPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHttpsPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHttpsPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImageConfig 用于获取域名图片优化的当前配置，支持Webp、TPG、 Guetzli 和 Avif。 
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
        /// DescribeImageConfig 用于获取域名图片优化的当前配置，支持Webp、TPG、 Guetzli 和 Avif。 
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
        /// DescribeIpStatus 用于查询域名所在加速平台的边缘节点、回源节点明细。注意事项：暂不支持查询边缘节点信息并且数据会存在一定延迟。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41954"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
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
        /// DescribeIpStatus 用于查询域名所在加速平台的边缘节点、回源节点明细。注意事项：暂不支持查询边缘节点信息并且数据会存在一定延迟。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41954"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
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
        /// 获取BOT统计数据列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnBotDataRequest"/></param>
        /// <returns><see cref="DescribeScdnBotDataResponse"/></returns>
        public async Task<DescribeScdnBotDataResponse> DescribeScdnBotData(DescribeScdnBotDataRequest req)
        {
             JsonResponseModel<DescribeScdnBotDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScdnBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取BOT统计数据列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnBotDataRequest"/></param>
        /// <returns><see cref="DescribeScdnBotDataResponse"/></returns>
        public DescribeScdnBotDataResponse DescribeScdnBotDataSync(DescribeScdnBotDataRequest req)
        {
             JsonResponseModel<DescribeScdnBotDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScdnBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询BOT会话记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnBotRecordsRequest"/></param>
        /// <returns><see cref="DescribeScdnBotRecordsResponse"/></returns>
        public async Task<DescribeScdnBotRecordsResponse> DescribeScdnBotRecords(DescribeScdnBotRecordsRequest req)
        {
             JsonResponseModel<DescribeScdnBotRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScdnBotRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnBotRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询BOT会话记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnBotRecordsRequest"/></param>
        /// <returns><see cref="DescribeScdnBotRecordsResponse"/></returns>
        public DescribeScdnBotRecordsResponse DescribeScdnBotRecordsSync(DescribeScdnBotRecordsRequest req)
        {
             JsonResponseModel<DescribeScdnBotRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScdnBotRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnBotRecordsResponse>>(strResp);
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
        /// 查询在SCDN IP安全策略
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnIpStrategyRequest"/></param>
        /// <returns><see cref="DescribeScdnIpStrategyResponse"/></returns>
        public async Task<DescribeScdnIpStrategyResponse> DescribeScdnIpStrategy(DescribeScdnIpStrategyRequest req)
        {
             JsonResponseModel<DescribeScdnIpStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScdnIpStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnIpStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询在SCDN IP安全策略
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnIpStrategyRequest"/></param>
        /// <returns><see cref="DescribeScdnIpStrategyResponse"/></returns>
        public DescribeScdnIpStrategyResponse DescribeScdnIpStrategySync(DescribeScdnIpStrategyRequest req)
        {
             JsonResponseModel<DescribeScdnIpStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScdnIpStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScdnIpStrategyResponse>>(strResp);
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
        /// DescribeTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 IP 排序，从大至小返回 TOP 100 IP
        /// + 依据总流量、总请求数对访问 Refer 排序，从大至小返回 TOP 100 Refer
        /// + 依据总流量、总请求数对访问 设备 排序，从大至小返回 设备类型
        /// + 依据总流量、总请求数对访问 操作系统 排序，从大至小返回 操作系统
        /// + 依据总流量、总请求数对访问 浏览器 排序，从大至小返回 浏览器
        /// 
        /// 注意：
        /// + 仅支持 90 天内数据查询，且从2021年09月20日开始有数据
        /// + 本接口为beta版，尚未正式全量发布
        /// </summary>
        /// <param name="req"><see cref="DescribeTopDataRequest"/></param>
        /// <returns><see cref="DescribeTopDataResponse"/></returns>
        public async Task<DescribeTopDataResponse> DescribeTopData(DescribeTopDataRequest req)
        {
             JsonResponseModel<DescribeTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 IP 排序，从大至小返回 TOP 100 IP
        /// + 依据总流量、总请求数对访问 Refer 排序，从大至小返回 TOP 100 Refer
        /// + 依据总流量、总请求数对访问 设备 排序，从大至小返回 设备类型
        /// + 依据总流量、总请求数对访问 操作系统 排序，从大至小返回 操作系统
        /// + 依据总流量、总请求数对访问 浏览器 排序，从大至小返回 浏览器
        /// 
        /// 注意：
        /// + 仅支持 90 天内数据查询，且从2021年09月20日开始有数据
        /// + 本接口为beta版，尚未正式全量发布
        /// </summary>
        /// <param name="req"><see cref="DescribeTopDataRequest"/></param>
        /// <returns><see cref="DescribeTopDataResponse"/></returns>
        public DescribeTopDataResponse DescribeTopDataSync(DescribeTopDataRequest req)
        {
             JsonResponseModel<DescribeTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrafficPackages 用于查询 CDN 流量包详情。
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
        /// DescribeTrafficPackages 用于查询 CDN 流量包详情。
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
        /// Waf统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeWafDataRequest"/></param>
        /// <returns><see cref="DescribeWafDataResponse"/></returns>
        public async Task<DescribeWafDataResponse> DescribeWafData(DescribeWafDataRequest req)
        {
             JsonResponseModel<DescribeWafDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWafData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeWafDataRequest"/></param>
        /// <returns><see cref="DescribeWafDataResponse"/></returns>
        public DescribeWafDataResponse DescribeWafDataSync(DescribeWafDataRequest req)
        {
             JsonResponseModel<DescribeWafDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWafData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// DisableCaches 用于禁用 CDN 上指定 URL 的访问，禁用完成后，中国境内访问会直接返回 403。
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// DisableCaches 用于禁用 CDN 上指定 URL 的访问，禁用完成后，中国境内访问会直接返回 403。
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// EnableCaches 用于解禁手工封禁的 URL，解禁成功后，全网生效时间约 5~10 分钟。
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// EnableCaches 用于解禁手工封禁的 URL，解禁成功后，全网生效时间约 5~10 分钟。
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// GetDisableRecords 用于查询资源禁用历史，及 URL 当前状态。
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
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// GetDisableRecords 用于查询资源禁用历史，及 URL 当前状态。
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
        /// ### <font color=red>**该接口已废弃** </font><br>
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
        /// ### <font color=red>**该接口已废弃** </font><br>
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
        /// 获取Bot攻击的Top数据列表
        /// </summary>
        /// <param name="req"><see cref="ListScdnTopBotDataRequest"/></param>
        /// <returns><see cref="ListScdnTopBotDataResponse"/></returns>
        public async Task<ListScdnTopBotDataResponse> ListScdnTopBotData(ListScdnTopBotDataRequest req)
        {
             JsonResponseModel<ListScdnTopBotDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListScdnTopBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListScdnTopBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Bot攻击的Top数据列表
        /// </summary>
        /// <param name="req"><see cref="ListScdnTopBotDataRequest"/></param>
        /// <returns><see cref="ListScdnTopBotDataResponse"/></returns>
        public ListScdnTopBotDataResponse ListScdnTopBotDataSync(ListScdnTopBotDataRequest req)
        {
             JsonResponseModel<ListScdnTopBotDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListScdnTopBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListScdnTopBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Bot攻击的Top信息
        /// </summary>
        /// <param name="req"><see cref="ListTopBotDataRequest"/></param>
        /// <returns><see cref="ListTopBotDataResponse"/></returns>
        public async Task<ListTopBotDataResponse> ListTopBotData(ListTopBotDataRequest req)
        {
             JsonResponseModel<ListTopBotDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTopBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Bot攻击的Top信息
        /// </summary>
        /// <param name="req"><see cref="ListTopBotDataRequest"/></param>
        /// <returns><see cref="ListTopBotDataResponse"/></returns>
        public ListTopBotDataResponse ListTopBotDataSync(ListTopBotDataRequest req)
        {
             JsonResponseModel<ListTopBotDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTopBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopCcDataRequest"/></param>
        /// <returns><see cref="ListTopCcDataResponse"/></returns>
        public async Task<ListTopCcDataResponse> ListTopCcData(ListTopCcDataRequest req)
        {
             JsonResponseModel<ListTopCcDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTopCcData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopCcDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopCcDataRequest"/></param>
        /// <returns><see cref="ListTopCcDataResponse"/></returns>
        public ListTopCcDataResponse ListTopCcDataSync(ListTopCcDataRequest req)
        {
             JsonResponseModel<ListTopCcDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTopCcData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopCcDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过CLS日志计算Top信息。支持近7天的日志数据。
        /// </summary>
        /// <param name="req"><see cref="ListTopClsLogDataRequest"/></param>
        /// <returns><see cref="ListTopClsLogDataResponse"/></returns>
        public async Task<ListTopClsLogDataResponse> ListTopClsLogData(ListTopClsLogDataRequest req)
        {
             JsonResponseModel<ListTopClsLogDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTopClsLogData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopClsLogDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过CLS日志计算Top信息。支持近7天的日志数据。
        /// </summary>
        /// <param name="req"><see cref="ListTopClsLogDataRequest"/></param>
        /// <returns><see cref="ListTopClsLogDataResponse"/></returns>
        public ListTopClsLogDataResponse ListTopClsLogDataSync(ListTopClsLogDataRequest req)
        {
             JsonResponseModel<ListTopClsLogDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTopClsLogData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopClsLogDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopDDoSDataRequest"/></param>
        /// <returns><see cref="ListTopDDoSDataResponse"/></returns>
        public async Task<ListTopDDoSDataResponse> ListTopDDoSData(ListTopDDoSDataRequest req)
        {
             JsonResponseModel<ListTopDDoSDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTopDDoSData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopDDoSDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopDDoSDataRequest"/></param>
        /// <returns><see cref="ListTopDDoSDataResponse"/></returns>
        public ListTopDDoSDataResponse ListTopDDoSDataSync(ListTopDDoSDataRequest req)
        {
             JsonResponseModel<ListTopDDoSDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTopDDoSData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopDDoSDataResponse>>(strResp);
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
        /// 获取Waf攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopWafDataRequest"/></param>
        /// <returns><see cref="ListTopWafDataResponse"/></returns>
        public async Task<ListTopWafDataResponse> ListTopWafData(ListTopWafDataRequest req)
        {
             JsonResponseModel<ListTopWafDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTopWafData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopWafDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Waf攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopWafDataRequest"/></param>
        /// <returns><see cref="ListTopWafDataResponse"/></returns>
        public ListTopWafDataResponse ListTopWafDataSync(ListTopWafDataRequest req)
        {
             JsonResponseModel<ListTopWafDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTopWafData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopWafDataResponse>>(strResp);
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
        /// ModifyDomainConfig 用于修改内容分发网络加速域名配置信息
        /// 注意：
        /// Route 字段，使用点分隔，最后一段称为叶子节点，非叶子节点配置保持不变；
        /// Value 字段，使用 json 进行序列化，其中固定 update 作为 key，配置路径值参考 https://cloud.tencent.com/document/product/228/41116 接口各配置项复杂类型，为配置路径对应复杂类型下的节点。
        /// 云审计相关：接口的入参可能包含密钥等敏感信息，所以此接口的入参不会上报到云审计。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyDomainConfigResponse"/></returns>
        public async Task<ModifyDomainConfigResponse> ModifyDomainConfig(ModifyDomainConfigRequest req)
        {
             JsonResponseModel<ModifyDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDomainConfig 用于修改内容分发网络加速域名配置信息
        /// 注意：
        /// Route 字段，使用点分隔，最后一段称为叶子节点，非叶子节点配置保持不变；
        /// Value 字段，使用 json 进行序列化，其中固定 update 作为 key，配置路径值参考 https://cloud.tencent.com/document/product/228/41116 接口各配置项复杂类型，为配置路径对应复杂类型下的节点。
        /// 云审计相关：接口的入参可能包含密钥等敏感信息，所以此接口的入参不会上报到云审计。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyDomainConfigResponse"/></returns>
        public ModifyDomainConfigResponse ModifyDomainConfigSync(ModifyDomainConfigRequest req)
        {
             JsonResponseModel<ModifyDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPurgeFetchTaskStatus 用于上报定时刷新预热任务执行状态
        /// </summary>
        /// <param name="req"><see cref="ModifyPurgeFetchTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyPurgeFetchTaskStatusResponse"/></returns>
        public async Task<ModifyPurgeFetchTaskStatusResponse> ModifyPurgeFetchTaskStatus(ModifyPurgeFetchTaskStatusRequest req)
        {
             JsonResponseModel<ModifyPurgeFetchTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPurgeFetchTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPurgeFetchTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPurgeFetchTaskStatus 用于上报定时刷新预热任务执行状态
        /// </summary>
        /// <param name="req"><see cref="ModifyPurgeFetchTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyPurgeFetchTaskStatusResponse"/></returns>
        public ModifyPurgeFetchTaskStatusResponse ModifyPurgeFetchTaskStatusSync(ModifyPurgeFetchTaskStatusRequest req)
        {
             JsonResponseModel<ModifyPurgeFetchTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPurgeFetchTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPurgeFetchTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgePathCache 用于批量提交目录刷新，根据域名的加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日目录刷新额度为各 100 条，每次最多可提交 500 条。
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
        /// 默认情况下境内、境外加速区域每日目录刷新额度为各 100 条，每次最多可提交 500 条。
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
        /// 默认情况下境内、境外每日预热 URL 限额为各 1000 条，每次最多可提交 500 条。注意：中国境外区域预热，资源默认加载至中国境外边缘节点，所产生的边缘层流量会计入计费流量。
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
        /// 默认情况下境内、境外每日预热 URL 限额为各 1000 条，每次最多可提交 500 条。注意：中国境外区域预热，资源默认加载至中国境外边缘节点，所产生的边缘层流量会计入计费流量。
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
        /// UpdateDomainConfig 用于修改内容分发网络加速域名配置信息。
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值，建议通过查询接口获取配置属性后，直接修改后传递给本接口。
        /// 云审计相关：接口的入参可能包含密钥等敏感信息，所以此接口的入参不会上报到云审计。
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
        /// UpdateDomainConfig 用于修改内容分发网络加速域名配置信息。
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值，建议通过查询接口获取配置属性后，直接修改后传递给本接口。
        /// 云审计相关：接口的入参可能包含密钥等敏感信息，所以此接口的入参不会上报到云审计。
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
        /// UpdateImageConfig 用于更新控制台图片优化的相关配置，支持Webp、TPG、 Guetzli 和 Avif。 
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
        /// UpdateImageConfig 用于更新控制台图片优化的相关配置，支持Webp、TPG、 Guetzli 和 Avif。 
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
        /// VerifyDomainRecord 用于验证域名解析值。
        /// 验证域名解析记录值前，您需要通过 [CreateVerifyRecord](https://cloud.tencent.com/document/product/228/48118) 生成校验解析值，验证通过后，24小时有效。
        /// 具体流程可参考：[使用API接口进行域名归属校验](https://cloud.tencent.com/document/product/228/61702#.E6.96.B9.E6.B3.95.E4.B8.89.EF.BC.9Aapi-.E6.8E.A5.E5.8F.A3.E6.93.8D.E4.BD.9C)
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
        /// VerifyDomainRecord 用于验证域名解析值。
        /// 验证域名解析记录值前，您需要通过 [CreateVerifyRecord](https://cloud.tencent.com/document/product/228/48118) 生成校验解析值，验证通过后，24小时有效。
        /// 具体流程可参考：[使用API接口进行域名归属校验](https://cloud.tencent.com/document/product/228/61702#.E6.96.B9.E6.B3.95.E4.B8.89.EF.BC.9Aapi-.E6.8E.A5.E5.8F.A3.E6.93.8D.E4.BD.9C)
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
