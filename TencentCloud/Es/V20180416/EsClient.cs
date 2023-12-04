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

namespace TencentCloud.Es.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Es.V20180416.Models;

   public class EsClient : AbstractClient{

       private const string endpoint = "es.tencentcloudapi.com";
       private const string version = "2018-04-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建索引
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public async Task<CreateIndexResponse> CreateIndex(CreateIndexRequest req)
        {
             JsonResponseModel<CreateIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建索引
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public CreateIndexResponse CreateIndexSync(CreateIndexRequest req)
        {
             JsonResponseModel<CreateIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建指定规格的ES集群实例
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
        /// 创建指定规格的ES集群实例
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
        /// 用于创建Logstash实例
        /// </summary>
        /// <param name="req"><see cref="CreateLogstashInstanceRequest"/></param>
        /// <returns><see cref="CreateLogstashInstanceResponse"/></returns>
        public async Task<CreateLogstashInstanceResponse> CreateLogstashInstance(CreateLogstashInstanceRequest req)
        {
             JsonResponseModel<CreateLogstashInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLogstashInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogstashInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建Logstash实例
        /// </summary>
        /// <param name="req"><see cref="CreateLogstashInstanceRequest"/></param>
        /// <returns><see cref="CreateLogstashInstanceResponse"/></returns>
        public CreateLogstashInstanceResponse CreateLogstashInstanceSync(CreateLogstashInstanceRequest req)
        {
             JsonResponseModel<CreateLogstashInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLogstashInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogstashInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除索引
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public async Task<DeleteIndexResponse> DeleteIndex(DeleteIndexRequest req)
        {
             JsonResponseModel<DeleteIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除索引
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public DeleteIndexResponse DeleteIndexSync(DeleteIndexRequest req)
        {
             JsonResponseModel<DeleteIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁集群实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁集群实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除Logstash实例
        /// </summary>
        /// <param name="req"><see cref="DeleteLogstashInstanceRequest"/></param>
        /// <returns><see cref="DeleteLogstashInstanceResponse"/></returns>
        public async Task<DeleteLogstashInstanceResponse> DeleteLogstashInstance(DeleteLogstashInstanceRequest req)
        {
             JsonResponseModel<DeleteLogstashInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLogstashInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogstashInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除Logstash实例
        /// </summary>
        /// <param name="req"><see cref="DeleteLogstashInstanceRequest"/></param>
        /// <returns><see cref="DeleteLogstashInstanceResponse"/></returns>
        public DeleteLogstashInstanceResponse DeleteLogstashInstanceSync(DeleteLogstashInstanceRequest req)
        {
             JsonResponseModel<DeleteLogstashInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLogstashInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogstashInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量删除Logstash管道
        /// </summary>
        /// <param name="req"><see cref="DeleteLogstashPipelinesRequest"/></param>
        /// <returns><see cref="DeleteLogstashPipelinesResponse"/></returns>
        public async Task<DeleteLogstashPipelinesResponse> DeleteLogstashPipelines(DeleteLogstashPipelinesRequest req)
        {
             JsonResponseModel<DeleteLogstashPipelinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLogstashPipelines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogstashPipelinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量删除Logstash管道
        /// </summary>
        /// <param name="req"><see cref="DeleteLogstashPipelinesRequest"/></param>
        /// <returns><see cref="DeleteLogstashPipelinesResponse"/></returns>
        public DeleteLogstashPipelinesResponse DeleteLogstashPipelinesSync(DeleteLogstashPipelinesRequest req)
        {
             JsonResponseModel<DeleteLogstashPipelinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLogstashPipelines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogstashPipelinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询智能运维诊断结果报告
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnoseRequest"/></param>
        /// <returns><see cref="DescribeDiagnoseResponse"/></returns>
        public async Task<DescribeDiagnoseResponse> DescribeDiagnose(DescribeDiagnoseRequest req)
        {
             JsonResponseModel<DescribeDiagnoseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiagnose");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiagnoseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询智能运维诊断结果报告
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnoseRequest"/></param>
        /// <returns><see cref="DescribeDiagnoseResponse"/></returns>
        public DescribeDiagnoseResponse DescribeDiagnoseSync(DescribeDiagnoseRequest req)
        {
             JsonResponseModel<DescribeDiagnoseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiagnose");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiagnoseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取索引列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public async Task<DescribeIndexListResponse> DescribeIndexList(DescribeIndexListRequest req)
        {
             JsonResponseModel<DescribeIndexListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIndexList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取索引列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public DescribeIndexListResponse DescribeIndexListSync(DescribeIndexListRequest req)
        {
             JsonResponseModel<DescribeIndexListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIndexList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取索引元数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexMetaRequest"/></param>
        /// <returns><see cref="DescribeIndexMetaResponse"/></returns>
        public async Task<DescribeIndexMetaResponse> DescribeIndexMeta(DescribeIndexMetaRequest req)
        {
             JsonResponseModel<DescribeIndexMetaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIndexMeta");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexMetaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取索引元数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexMetaRequest"/></param>
        /// <returns><see cref="DescribeIndexMetaResponse"/></returns>
        public DescribeIndexMetaResponse DescribeIndexMetaSync(DescribeIndexMetaRequest req)
        {
             JsonResponseModel<DescribeIndexMetaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIndexMeta");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexMetaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户该地域下符合条件的ES集群的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public async Task<DescribeInstanceLogsResponse> DescribeInstanceLogs(DescribeInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户该地域下符合条件的ES集群的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public DescribeInstanceLogsResponse DescribeInstanceLogsSync(DescribeInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例指定条件下的操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public async Task<DescribeInstanceOperationsResponse> DescribeInstanceOperations(DescribeInstanceOperationsRequest req)
        {
             JsonResponseModel<DescribeInstanceOperationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceOperations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceOperationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例指定条件下的操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public DescribeInstanceOperationsResponse DescribeInstanceOperationsSync(DescribeInstanceOperationsRequest req)
        {
             JsonResponseModel<DescribeInstanceOperationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceOperations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceOperationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancePluginListRequest"/></param>
        /// <returns><see cref="DescribeInstancePluginListResponse"/></returns>
        public async Task<DescribeInstancePluginListResponse> DescribeInstancePluginList(DescribeInstancePluginListRequest req)
        {
             JsonResponseModel<DescribeInstancePluginListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancePluginList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancePluginListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancePluginListRequest"/></param>
        /// <returns><see cref="DescribeInstancePluginListResponse"/></returns>
        public DescribeInstancePluginListResponse DescribeInstancePluginListSync(DescribeInstancePluginListRequest req)
        {
             JsonResponseModel<DescribeInstancePluginListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancePluginList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancePluginListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户该地域下符合条件的所有实例
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
        /// 查询用户该地域下符合条件的所有实例
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
        /// 查询用户该地域下符合条件的Logstash实例的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstanceLogsResponse"/></returns>
        public async Task<DescribeLogstashInstanceLogsResponse> DescribeLogstashInstanceLogs(DescribeLogstashInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeLogstashInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogstashInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogstashInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户该地域下符合条件的Logstash实例的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstanceLogsResponse"/></returns>
        public DescribeLogstashInstanceLogsResponse DescribeLogstashInstanceLogsSync(DescribeLogstashInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeLogstashInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogstashInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogstashInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例指定条件下的操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstanceOperationsResponse"/></returns>
        public async Task<DescribeLogstashInstanceOperationsResponse> DescribeLogstashInstanceOperations(DescribeLogstashInstanceOperationsRequest req)
        {
             JsonResponseModel<DescribeLogstashInstanceOperationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogstashInstanceOperations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogstashInstanceOperationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例指定条件下的操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstanceOperationsResponse"/></returns>
        public DescribeLogstashInstanceOperationsResponse DescribeLogstashInstanceOperationsSync(DescribeLogstashInstanceOperationsRequest req)
        {
             JsonResponseModel<DescribeLogstashInstanceOperationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogstashInstanceOperations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogstashInstanceOperationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户该地域下符合条件的所有Logstash实例
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstancesRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstancesResponse"/></returns>
        public async Task<DescribeLogstashInstancesResponse> DescribeLogstashInstances(DescribeLogstashInstancesRequest req)
        {
             JsonResponseModel<DescribeLogstashInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogstashInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogstashInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户该地域下符合条件的所有Logstash实例
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstancesRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstancesResponse"/></returns>
        public DescribeLogstashInstancesResponse DescribeLogstashInstancesSync(DescribeLogstashInstancesRequest req)
        {
             JsonResponseModel<DescribeLogstashInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogstashInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogstashInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取Logstash实例管道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashPipelinesRequest"/></param>
        /// <returns><see cref="DescribeLogstashPipelinesResponse"/></returns>
        public async Task<DescribeLogstashPipelinesResponse> DescribeLogstashPipelines(DescribeLogstashPipelinesRequest req)
        {
             JsonResponseModel<DescribeLogstashPipelinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogstashPipelines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogstashPipelinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取Logstash实例管道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashPipelinesRequest"/></param>
        /// <returns><see cref="DescribeLogstashPipelinesResponse"/></returns>
        public DescribeLogstashPipelinesResponse DescribeLogstashPipelinesSync(DescribeLogstashPipelinesRequest req)
        {
             JsonResponseModel<DescribeLogstashPipelinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogstashPipelines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogstashPipelinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群各视图数据，包括集群维度、节点维度、Kibana维度
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public async Task<DescribeViewsResponse> DescribeViews(DescribeViewsRequest req)
        {
             JsonResponseModel<DescribeViewsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeViews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeViewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群各视图数据，包括集群维度、节点维度、Kibana维度
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public DescribeViewsResponse DescribeViewsSync(DescribeViewsRequest req)
        {
             JsonResponseModel<DescribeViewsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeViews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeViewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能运维诊断集群
        /// </summary>
        /// <param name="req"><see cref="DiagnoseInstanceRequest"/></param>
        /// <returns><see cref="DiagnoseInstanceResponse"/></returns>
        public async Task<DiagnoseInstanceResponse> DiagnoseInstance(DiagnoseInstanceRequest req)
        {
             JsonResponseModel<DiagnoseInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DiagnoseInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DiagnoseInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能运维诊断集群
        /// </summary>
        /// <param name="req"><see cref="DiagnoseInstanceRequest"/></param>
        /// <returns><see cref="DiagnoseInstanceResponse"/></returns>
        public DiagnoseInstanceResponse DiagnoseInstanceSync(DiagnoseInstanceRequest req)
        {
             JsonResponseModel<DiagnoseInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DiagnoseInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DiagnoseInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看智能运维配置
        /// </summary>
        /// <param name="req"><see cref="GetDiagnoseSettingsRequest"/></param>
        /// <returns><see cref="GetDiagnoseSettingsResponse"/></returns>
        public async Task<GetDiagnoseSettingsResponse> GetDiagnoseSettings(GetDiagnoseSettingsRequest req)
        {
             JsonResponseModel<GetDiagnoseSettingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDiagnoseSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDiagnoseSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看智能运维配置
        /// </summary>
        /// <param name="req"><see cref="GetDiagnoseSettingsRequest"/></param>
        /// <returns><see cref="GetDiagnoseSettingsResponse"/></returns>
        public GetDiagnoseSettingsResponse GetDiagnoseSettingsSync(GetDiagnoseSettingsRequest req)
        {
             JsonResponseModel<GetDiagnoseSettingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDiagnoseSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDiagnoseSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取接收客户端请求的节点类型
        /// </summary>
        /// <param name="req"><see cref="GetRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="GetRequestTargetNodeTypesResponse"/></returns>
        public async Task<GetRequestTargetNodeTypesResponse> GetRequestTargetNodeTypes(GetRequestTargetNodeTypesRequest req)
        {
             JsonResponseModel<GetRequestTargetNodeTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRequestTargetNodeTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRequestTargetNodeTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取接收客户端请求的节点类型
        /// </summary>
        /// <param name="req"><see cref="GetRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="GetRequestTargetNodeTypesResponse"/></returns>
        public GetRequestTargetNodeTypesResponse GetRequestTargetNodeTypesSync(GetRequestTargetNodeTypesRequest req)
        {
             JsonResponseModel<GetRequestTargetNodeTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRequestTargetNodeTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRequestTargetNodeTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群续费询价接口，续费前通过调用该接口，可获取集群续费的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstanceResponse"/></returns>
        public async Task<InquirePriceRenewInstanceResponse> InquirePriceRenewInstance(InquirePriceRenewInstanceRequest req)
        {
             JsonResponseModel<InquirePriceRenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceRenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群续费询价接口，续费前通过调用该接口，可获取集群续费的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstanceResponse"/></returns>
        public InquirePriceRenewInstanceResponse InquirePriceRenewInstanceSync(InquirePriceRenewInstanceRequest req)
        {
             JsonResponseModel<InquirePriceRenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceRenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改绑定VIP的安全组，传安全组id列表
        /// </summary>
        /// <param name="req"><see cref="ModifyEsVipSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyEsVipSecurityGroupResponse"/></returns>
        public async Task<ModifyEsVipSecurityGroupResponse> ModifyEsVipSecurityGroup(ModifyEsVipSecurityGroupRequest req)
        {
             JsonResponseModel<ModifyEsVipSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEsVipSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEsVipSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改绑定VIP的安全组，传安全组id列表
        /// </summary>
        /// <param name="req"><see cref="ModifyEsVipSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyEsVipSecurityGroupResponse"/></returns>
        public ModifyEsVipSecurityGroupResponse ModifyEsVipSecurityGroupSync(ModifyEsVipSecurityGroupRequest req)
        {
             JsonResponseModel<ModifyEsVipSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEsVipSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEsVipSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启ES集群实例(用于系统版本更新等操作)
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public async Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest req)
        {
             JsonResponseModel<RestartInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启ES集群实例(用于系统版本更新等操作)
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public RestartInstanceResponse RestartInstanceSync(RestartInstanceRequest req)
        {
             JsonResponseModel<RestartInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启Kibana
        /// </summary>
        /// <param name="req"><see cref="RestartKibanaRequest"/></param>
        /// <returns><see cref="RestartKibanaResponse"/></returns>
        public async Task<RestartKibanaResponse> RestartKibana(RestartKibanaRequest req)
        {
             JsonResponseModel<RestartKibanaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartKibana");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartKibanaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启Kibana
        /// </summary>
        /// <param name="req"><see cref="RestartKibanaRequest"/></param>
        /// <returns><see cref="RestartKibanaResponse"/></returns>
        public RestartKibanaResponse RestartKibanaSync(RestartKibanaRequest req)
        {
             JsonResponseModel<RestartKibanaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartKibana");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartKibanaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于重启Logstash实例
        /// </summary>
        /// <param name="req"><see cref="RestartLogstashInstanceRequest"/></param>
        /// <returns><see cref="RestartLogstashInstanceResponse"/></returns>
        public async Task<RestartLogstashInstanceResponse> RestartLogstashInstance(RestartLogstashInstanceRequest req)
        {
             JsonResponseModel<RestartLogstashInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartLogstashInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartLogstashInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于重启Logstash实例
        /// </summary>
        /// <param name="req"><see cref="RestartLogstashInstanceRequest"/></param>
        /// <returns><see cref="RestartLogstashInstanceResponse"/></returns>
        public RestartLogstashInstanceResponse RestartLogstashInstanceSync(RestartLogstashInstanceRequest req)
        {
             JsonResponseModel<RestartLogstashInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartLogstashInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartLogstashInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于重启集群节点
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public async Task<RestartNodesResponse> RestartNodes(RestartNodesRequest req)
        {
             JsonResponseModel<RestartNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于重启集群节点
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public RestartNodesResponse RestartNodesSync(RestartNodesRequest req)
        {
             JsonResponseModel<RestartNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于下发并且部署管道
        /// </summary>
        /// <param name="req"><see cref="SaveAndDeployLogstashPipelineRequest"/></param>
        /// <returns><see cref="SaveAndDeployLogstashPipelineResponse"/></returns>
        public async Task<SaveAndDeployLogstashPipelineResponse> SaveAndDeployLogstashPipeline(SaveAndDeployLogstashPipelineRequest req)
        {
             JsonResponseModel<SaveAndDeployLogstashPipelineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SaveAndDeployLogstashPipeline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SaveAndDeployLogstashPipelineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于下发并且部署管道
        /// </summary>
        /// <param name="req"><see cref="SaveAndDeployLogstashPipelineRequest"/></param>
        /// <returns><see cref="SaveAndDeployLogstashPipelineResponse"/></returns>
        public SaveAndDeployLogstashPipelineResponse SaveAndDeployLogstashPipelineSync(SaveAndDeployLogstashPipelineRequest req)
        {
             JsonResponseModel<SaveAndDeployLogstashPipelineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SaveAndDeployLogstashPipeline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SaveAndDeployLogstashPipelineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于启动Logstash管道
        /// </summary>
        /// <param name="req"><see cref="StartLogstashPipelinesRequest"/></param>
        /// <returns><see cref="StartLogstashPipelinesResponse"/></returns>
        public async Task<StartLogstashPipelinesResponse> StartLogstashPipelines(StartLogstashPipelinesRequest req)
        {
             JsonResponseModel<StartLogstashPipelinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartLogstashPipelines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartLogstashPipelinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于启动Logstash管道
        /// </summary>
        /// <param name="req"><see cref="StartLogstashPipelinesRequest"/></param>
        /// <returns><see cref="StartLogstashPipelinesResponse"/></returns>
        public StartLogstashPipelinesResponse StartLogstashPipelinesSync(StartLogstashPipelinesRequest req)
        {
             JsonResponseModel<StartLogstashPipelinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartLogstashPipelines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartLogstashPipelinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量停止Logstash管道
        /// </summary>
        /// <param name="req"><see cref="StopLogstashPipelinesRequest"/></param>
        /// <returns><see cref="StopLogstashPipelinesResponse"/></returns>
        public async Task<StopLogstashPipelinesResponse> StopLogstashPipelines(StopLogstashPipelinesRequest req)
        {
             JsonResponseModel<StopLogstashPipelinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopLogstashPipelines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLogstashPipelinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量停止Logstash管道
        /// </summary>
        /// <param name="req"><see cref="StopLogstashPipelinesRequest"/></param>
        /// <returns><see cref="StopLogstashPipelinesResponse"/></returns>
        public StopLogstashPipelinesResponse StopLogstashPipelinesSync(StopLogstashPipelinesRequest req)
        {
             JsonResponseModel<StopLogstashPipelinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopLogstashPipelines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopLogstashPipelinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新智能运维配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDiagnoseSettingsRequest"/></param>
        /// <returns><see cref="UpdateDiagnoseSettingsResponse"/></returns>
        public async Task<UpdateDiagnoseSettingsResponse> UpdateDiagnoseSettings(UpdateDiagnoseSettingsRequest req)
        {
             JsonResponseModel<UpdateDiagnoseSettingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDiagnoseSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDiagnoseSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新智能运维配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDiagnoseSettingsRequest"/></param>
        /// <returns><see cref="UpdateDiagnoseSettingsResponse"/></returns>
        public UpdateDiagnoseSettingsResponse UpdateDiagnoseSettingsSync(UpdateDiagnoseSettingsRequest req)
        {
             JsonResponseModel<UpdateDiagnoseSettingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDiagnoseSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDiagnoseSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新ES集群词典
        /// </summary>
        /// <param name="req"><see cref="UpdateDictionariesRequest"/></param>
        /// <returns><see cref="UpdateDictionariesResponse"/></returns>
        public async Task<UpdateDictionariesResponse> UpdateDictionaries(UpdateDictionariesRequest req)
        {
             JsonResponseModel<UpdateDictionariesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDictionaries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDictionariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新ES集群词典
        /// </summary>
        /// <param name="req"><see cref="UpdateDictionariesRequest"/></param>
        /// <returns><see cref="UpdateDictionariesResponse"/></returns>
        public UpdateDictionariesResponse UpdateDictionariesSync(UpdateDictionariesRequest req)
        {
             JsonResponseModel<UpdateDictionariesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDictionaries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDictionariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新索引
        /// </summary>
        /// <param name="req"><see cref="UpdateIndexRequest"/></param>
        /// <returns><see cref="UpdateIndexResponse"/></returns>
        public async Task<UpdateIndexResponse> UpdateIndex(UpdateIndexRequest req)
        {
             JsonResponseModel<UpdateIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新索引
        /// </summary>
        /// <param name="req"><see cref="UpdateIndexRequest"/></param>
        /// <returns><see cref="UpdateIndexResponse"/></returns>
        public UpdateIndexResponse UpdateIndexSync(UpdateIndexRequest req)
        {
             JsonResponseModel<UpdateIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对集群进行节点规格变更，修改实例名称，修改配置，重置密码， 添加Kibana黑白名单等操作。参数中InstanceId为必传参数，ForceRestart为选填参数，剩余参数传递组合及含义如下：
        /// - InstanceName：修改实例名称(仅用于标识实例)
        /// - NodeInfoList: 修改节点配置（节点横向扩缩容，纵向扩缩容，增加主节点，增加冷节点等）
        /// - EsConfig：修改集群配置
        /// - Password：修改默认用户elastic的密码
        /// - EsAcl：修改访问控制列表
        /// - CosBackUp: 设置集群COS自动备份信息
        /// 以上参数组合只能传递一种，多传或少传均会导致请求失败
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public async Task<UpdateInstanceResponse> UpdateInstance(UpdateInstanceRequest req)
        {
             JsonResponseModel<UpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对集群进行节点规格变更，修改实例名称，修改配置，重置密码， 添加Kibana黑白名单等操作。参数中InstanceId为必传参数，ForceRestart为选填参数，剩余参数传递组合及含义如下：
        /// - InstanceName：修改实例名称(仅用于标识实例)
        /// - NodeInfoList: 修改节点配置（节点横向扩缩容，纵向扩缩容，增加主节点，增加冷节点等）
        /// - EsConfig：修改集群配置
        /// - Password：修改默认用户elastic的密码
        /// - EsAcl：修改访问控制列表
        /// - CosBackUp: 设置集群COS自动备份信息
        /// 以上参数组合只能传递一种，多传或少传均会导致请求失败
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public UpdateInstanceResponse UpdateInstanceSync(UpdateInstanceRequest req)
        {
             JsonResponseModel<UpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新实例Jdk配置
        /// </summary>
        /// <param name="req"><see cref="UpdateJdkRequest"/></param>
        /// <returns><see cref="UpdateJdkResponse"/></returns>
        public async Task<UpdateJdkResponse> UpdateJdk(UpdateJdkRequest req)
        {
             JsonResponseModel<UpdateJdkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateJdk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateJdkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新实例Jdk配置
        /// </summary>
        /// <param name="req"><see cref="UpdateJdkRequest"/></param>
        /// <returns><see cref="UpdateJdkResponse"/></returns>
        public UpdateJdkResponse UpdateJdkSync(UpdateJdkRequest req)
        {
             JsonResponseModel<UpdateJdkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateJdk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateJdkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对集群进行节点规格变更，修改实例名称，修改配置，等操作。参数中InstanceId为必传参数，参数传递组合及含义如下：
        /// - InstanceName：修改实例名称(仅用于标识实例)
        /// - NodeNum: 修改实例节点数量（节点横向扩缩容，纵向扩缩容等）
        /// - YMLConfig: 修改实例YML配置
        /// - BindedES：修改绑定的ES集群配置
        /// 以上参数组合只能传递一种，多传或少传均会导致请求失败
        /// </summary>
        /// <param name="req"><see cref="UpdateLogstashInstanceRequest"/></param>
        /// <returns><see cref="UpdateLogstashInstanceResponse"/></returns>
        public async Task<UpdateLogstashInstanceResponse> UpdateLogstashInstance(UpdateLogstashInstanceRequest req)
        {
             JsonResponseModel<UpdateLogstashInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateLogstashInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLogstashInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对集群进行节点规格变更，修改实例名称，修改配置，等操作。参数中InstanceId为必传参数，参数传递组合及含义如下：
        /// - InstanceName：修改实例名称(仅用于标识实例)
        /// - NodeNum: 修改实例节点数量（节点横向扩缩容，纵向扩缩容等）
        /// - YMLConfig: 修改实例YML配置
        /// - BindedES：修改绑定的ES集群配置
        /// 以上参数组合只能传递一种，多传或少传均会导致请求失败
        /// </summary>
        /// <param name="req"><see cref="UpdateLogstashInstanceRequest"/></param>
        /// <returns><see cref="UpdateLogstashInstanceResponse"/></returns>
        public UpdateLogstashInstanceResponse UpdateLogstashInstanceSync(UpdateLogstashInstanceRequest req)
        {
             JsonResponseModel<UpdateLogstashInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateLogstashInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLogstashInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于更新管道描述信息
        /// </summary>
        /// <param name="req"><see cref="UpdateLogstashPipelineDescRequest"/></param>
        /// <returns><see cref="UpdateLogstashPipelineDescResponse"/></returns>
        public async Task<UpdateLogstashPipelineDescResponse> UpdateLogstashPipelineDesc(UpdateLogstashPipelineDescRequest req)
        {
             JsonResponseModel<UpdateLogstashPipelineDescResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateLogstashPipelineDesc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLogstashPipelineDescResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于更新管道描述信息
        /// </summary>
        /// <param name="req"><see cref="UpdateLogstashPipelineDescRequest"/></param>
        /// <returns><see cref="UpdateLogstashPipelineDescResponse"/></returns>
        public UpdateLogstashPipelineDescResponse UpdateLogstashPipelineDescSync(UpdateLogstashPipelineDescRequest req)
        {
             JsonResponseModel<UpdateLogstashPipelineDescResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateLogstashPipelineDesc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateLogstashPipelineDescResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 变更插件列表
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public async Task<UpdatePluginsResponse> UpdatePlugins(UpdatePluginsRequest req)
        {
             JsonResponseModel<UpdatePluginsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdatePlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 变更插件列表
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public UpdatePluginsResponse UpdatePluginsSync(UpdatePluginsRequest req)
        {
             JsonResponseModel<UpdatePluginsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdatePlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新接收客户端请求的节点类型
        /// </summary>
        /// <param name="req"><see cref="UpdateRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="UpdateRequestTargetNodeTypesResponse"/></returns>
        public async Task<UpdateRequestTargetNodeTypesResponse> UpdateRequestTargetNodeTypes(UpdateRequestTargetNodeTypesRequest req)
        {
             JsonResponseModel<UpdateRequestTargetNodeTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRequestTargetNodeTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRequestTargetNodeTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新接收客户端请求的节点类型
        /// </summary>
        /// <param name="req"><see cref="UpdateRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="UpdateRequestTargetNodeTypesResponse"/></returns>
        public UpdateRequestTargetNodeTypesResponse UpdateRequestTargetNodeTypesSync(UpdateRequestTargetNodeTypesRequest req)
        {
             JsonResponseModel<UpdateRequestTargetNodeTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRequestTargetNodeTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRequestTargetNodeTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级ES集群版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public async Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级ES集群版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级ES商业特性
        /// </summary>
        /// <param name="req"><see cref="UpgradeLicenseRequest"/></param>
        /// <returns><see cref="UpgradeLicenseResponse"/></returns>
        public async Task<UpgradeLicenseResponse> UpgradeLicense(UpgradeLicenseRequest req)
        {
             JsonResponseModel<UpgradeLicenseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级ES商业特性
        /// </summary>
        /// <param name="req"><see cref="UpgradeLicenseRequest"/></param>
        /// <returns><see cref="UpgradeLicenseResponse"/></returns>
        public UpgradeLicenseResponse UpgradeLicenseSync(UpgradeLicenseRequest req)
        {
             JsonResponseModel<UpgradeLicenseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
