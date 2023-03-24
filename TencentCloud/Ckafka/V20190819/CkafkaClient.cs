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

namespace TencentCloud.Ckafka.V20190819
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ckafka.V20190819.Models;

   public class CkafkaClient : AbstractClient{

       private const string endpoint = "ckafka.tencentcloudapi.com";
       private const string version = "2019-08-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CkafkaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CkafkaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 给实例授权token
        /// </summary>
        /// <param name="req"><see cref="AuthorizeTokenRequest"/></param>
        /// <returns><see cref="AuthorizeTokenResponse"/></returns>
        public async Task<AuthorizeTokenResponse> AuthorizeToken(AuthorizeTokenRequest req)
        {
             JsonResponseModel<AuthorizeTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AuthorizeToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuthorizeTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给实例授权token
        /// </summary>
        /// <param name="req"><see cref="AuthorizeTokenRequest"/></param>
        /// <returns><see cref="AuthorizeTokenResponse"/></returns>
        public AuthorizeTokenResponse AuthorizeTokenSync(AuthorizeTokenRequest req)
        {
             JsonResponseModel<AuthorizeTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AuthorizeToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuthorizeTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加ACL策略
        /// </summary>
        /// <param name="req"><see cref="BatchCreateAclRequest"/></param>
        /// <returns><see cref="BatchCreateAclResponse"/></returns>
        public async Task<BatchCreateAclResponse> BatchCreateAcl(BatchCreateAclRequest req)
        {
             JsonResponseModel<BatchCreateAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchCreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加ACL策略
        /// </summary>
        /// <param name="req"><see cref="BatchCreateAclRequest"/></param>
        /// <returns><see cref="BatchCreateAclResponse"/></returns>
        public BatchCreateAclResponse BatchCreateAclSync(BatchCreateAclRequest req)
        {
             JsonResponseModel<BatchCreateAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchCreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改消费组offset
        /// </summary>
        /// <param name="req"><see cref="BatchModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="BatchModifyGroupOffsetsResponse"/></returns>
        public async Task<BatchModifyGroupOffsetsResponse> BatchModifyGroupOffsets(BatchModifyGroupOffsetsRequest req)
        {
             JsonResponseModel<BatchModifyGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改消费组offset
        /// </summary>
        /// <param name="req"><see cref="BatchModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="BatchModifyGroupOffsetsResponse"/></returns>
        public BatchModifyGroupOffsetsResponse BatchModifyGroupOffsetsSync(BatchModifyGroupOffsetsRequest req)
        {
             JsonResponseModel<BatchModifyGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量设置主题属性
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="BatchModifyTopicAttributesResponse"/></returns>
        public async Task<BatchModifyTopicAttributesResponse> BatchModifyTopicAttributes(BatchModifyTopicAttributesRequest req)
        {
             JsonResponseModel<BatchModifyTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量设置主题属性
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="BatchModifyTopicAttributesResponse"/></returns>
        public BatchModifyTopicAttributesResponse BatchModifyTopicAttributesSync(BatchModifyTopicAttributesRequest req)
        {
             JsonResponseModel<BatchModifyTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消授权token
        /// </summary>
        /// <param name="req"><see cref="CancelAuthorizationTokenRequest"/></param>
        /// <returns><see cref="CancelAuthorizationTokenResponse"/></returns>
        public async Task<CancelAuthorizationTokenResponse> CancelAuthorizationToken(CancelAuthorizationTokenRequest req)
        {
             JsonResponseModel<CancelAuthorizationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelAuthorizationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelAuthorizationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消授权token
        /// </summary>
        /// <param name="req"><see cref="CancelAuthorizationTokenRequest"/></param>
        /// <returns><see cref="CancelAuthorizationTokenResponse"/></returns>
        public CancelAuthorizationTokenResponse CancelAuthorizationTokenSync(CancelAuthorizationTokenRequest req)
        {
             JsonResponseModel<CancelAuthorizationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelAuthorizationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelAuthorizationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询cdc-ckafka任务状态
        /// </summary>
        /// <param name="req"><see cref="CheckCdcClusterRequest"/></param>
        /// <returns><see cref="CheckCdcClusterResponse"/></returns>
        public async Task<CheckCdcClusterResponse> CheckCdcCluster(CheckCdcClusterRequest req)
        {
             JsonResponseModel<CheckCdcClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckCdcCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCdcClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询cdc-ckafka任务状态
        /// </summary>
        /// <param name="req"><see cref="CheckCdcClusterRequest"/></param>
        /// <returns><see cref="CheckCdcClusterResponse"/></returns>
        public CheckCdcClusterResponse CheckCdcClusterSync(CheckCdcClusterRequest req)
        {
             JsonResponseModel<CheckCdcClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckCdcCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCdcClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加 ACL 策略
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public async Task<CreateAclResponse> CreateAcl(CreateAclRequest req)
        {
             JsonResponseModel<CreateAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加 ACL 策略
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public CreateAclResponse CreateAclSync(CreateAclRequest req)
        {
             JsonResponseModel<CreateAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加 ACL 规则
        /// </summary>
        /// <param name="req"><see cref="CreateAclRuleRequest"/></param>
        /// <returns><see cref="CreateAclRuleResponse"/></returns>
        public async Task<CreateAclRuleResponse> CreateAclRule(CreateAclRuleRequest req)
        {
             JsonResponseModel<CreateAclRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAclRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加 ACL 规则
        /// </summary>
        /// <param name="req"><see cref="CreateAclRuleRequest"/></param>
        /// <returns><see cref="CreateAclRuleResponse"/></returns>
        public CreateAclRuleResponse CreateAclRuleSync(CreateAclRuleRequest req)
        {
             JsonResponseModel<CreateAclRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAclRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于cdc的专用ckafka集群
        /// </summary>
        /// <param name="req"><see cref="CreateCdcClusterRequest"/></param>
        /// <returns><see cref="CreateCdcClusterResponse"/></returns>
        public async Task<CreateCdcClusterResponse> CreateCdcCluster(CreateCdcClusterRequest req)
        {
             JsonResponseModel<CreateCdcClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCdcCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCdcClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于cdc的专用ckafka集群
        /// </summary>
        /// <param name="req"><see cref="CreateCdcClusterRequest"/></param>
        /// <returns><see cref="CreateCdcClusterResponse"/></returns>
        public CreateCdcClusterResponse CreateCdcClusterSync(CreateCdcClusterRequest req)
        {
             JsonResponseModel<CreateCdcClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCdcCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCdcClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="CreateConnectResourceRequest"/></param>
        /// <returns><see cref="CreateConnectResourceResponse"/></returns>
        public async Task<CreateConnectResourceResponse> CreateConnectResource(CreateConnectResourceRequest req)
        {
             JsonResponseModel<CreateConnectResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConnectResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConnectResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="CreateConnectResourceRequest"/></param>
        /// <returns><see cref="CreateConnectResourceResponse"/></returns>
        public CreateConnectResourceResponse CreateConnectResourceSync(CreateConnectResourceRequest req)
        {
             JsonResponseModel<CreateConnectResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConnectResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConnectResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建消费者组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public async Task<CreateConsumerResponse> CreateConsumer(CreateConsumerRequest req)
        {
             JsonResponseModel<CreateConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建消费者组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public CreateConsumerResponse CreateConsumerSync(CreateConsumerRequest req)
        {
             JsonResponseModel<CreateConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建DIP转储任务
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTaskRequest"/></param>
        /// <returns><see cref="CreateDatahubTaskResponse"/></returns>
        public async Task<CreateDatahubTaskResponse> CreateDatahubTask(CreateDatahubTaskRequest req)
        {
             JsonResponseModel<CreateDatahubTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDatahubTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatahubTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建DIP转储任务
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTaskRequest"/></param>
        /// <returns><see cref="CreateDatahubTaskResponse"/></returns>
        public CreateDatahubTaskResponse CreateDatahubTaskSync(CreateDatahubTaskRequest req)
        {
             JsonResponseModel<CreateDatahubTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDatahubTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatahubTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Datahub主题
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTopicRequest"/></param>
        /// <returns><see cref="CreateDatahubTopicResponse"/></returns>
        public async Task<CreateDatahubTopicResponse> CreateDatahubTopic(CreateDatahubTopicRequest req)
        {
             JsonResponseModel<CreateDatahubTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDatahubTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatahubTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Datahub主题
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTopicRequest"/></param>
        /// <returns><see cref="CreateDatahubTopicResponse"/></returns>
        public CreateDatahubTopicResponse CreateDatahubTopicSync(CreateDatahubTopicRequest req)
        {
             JsonResponseModel<CreateDatahubTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDatahubTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatahubTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建按量计费实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePostRequest"/></param>
        /// <returns><see cref="CreateInstancePostResponse"/></returns>
        public async Task<CreateInstancePostResponse> CreateInstancePost(CreateInstancePostRequest req)
        {
             JsonResponseModel<CreateInstancePostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstancePost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancePostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建按量计费实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePostRequest"/></param>
        /// <returns><see cref="CreateInstancePostResponse"/></returns>
        public CreateInstancePostResponse CreateInstancePostSync(CreateInstancePostRequest req)
        {
             JsonResponseModel<CreateInstancePostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstancePost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancePostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例(预付费包年包月)
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePreRequest"/></param>
        /// <returns><see cref="CreateInstancePreResponse"/></returns>
        public async Task<CreateInstancePreResponse> CreateInstancePre(CreateInstancePreRequest req)
        {
             JsonResponseModel<CreateInstancePreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstancePre");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancePreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例(预付费包年包月)
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePreRequest"/></param>
        /// <returns><see cref="CreateInstancePreResponse"/></returns>
        public CreateInstancePreResponse CreateInstancePreSync(CreateInstancePreRequest req)
        {
             JsonResponseModel<CreateInstancePreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstancePre");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancePreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于增加主题中的分区
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public async Task<CreatePartitionResponse> CreatePartition(CreatePartitionRequest req)
        {
             JsonResponseModel<CreatePartitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于增加主题中的分区
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public CreatePartitionResponse CreatePartitionSync(CreatePartitionRequest req)
        {
             JsonResponseModel<CreatePartitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加实例路由
        /// </summary>
        /// <param name="req"><see cref="CreateRouteRequest"/></param>
        /// <returns><see cref="CreateRouteResponse"/></returns>
        public async Task<CreateRouteResponse> CreateRoute(CreateRouteRequest req)
        {
             JsonResponseModel<CreateRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加实例路由
        /// </summary>
        /// <param name="req"><see cref="CreateRouteRequest"/></param>
        /// <returns><see cref="CreateRouteResponse"/></returns>
        public CreateRouteResponse CreateRouteSync(CreateRouteRequest req)
        {
             JsonResponseModel<CreateRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建最高权限的token
        /// </summary>
        /// <param name="req"><see cref="CreateTokenRequest"/></param>
        /// <returns><see cref="CreateTokenResponse"/></returns>
        public async Task<CreateTokenResponse> CreateToken(CreateTokenRequest req)
        {
             JsonResponseModel<CreateTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建最高权限的token
        /// </summary>
        /// <param name="req"><see cref="CreateTokenRequest"/></param>
        /// <returns><see cref="CreateTokenResponse"/></returns>
        public CreateTokenResponse CreateTokenSync(CreateTokenRequest req)
        {
             JsonResponseModel<CreateTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建ckafka主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public async Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建ckafka主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建主题ip白名单
        /// </summary>
        /// <param name="req"><see cref="CreateTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="CreateTopicIpWhiteListResponse"/></returns>
        public async Task<CreateTopicIpWhiteListResponse> CreateTopicIpWhiteList(CreateTopicIpWhiteListRequest req)
        {
             JsonResponseModel<CreateTopicIpWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopicIpWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicIpWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建主题ip白名单
        /// </summary>
        /// <param name="req"><see cref="CreateTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="CreateTopicIpWhiteListResponse"/></returns>
        public CreateTopicIpWhiteListResponse CreateTopicIpWhiteListSync(CreateTopicIpWhiteListRequest req)
        {
             JsonResponseModel<CreateTopicIpWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopicIpWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicIpWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public async Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ACL
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRequest"/></param>
        /// <returns><see cref="DeleteAclResponse"/></returns>
        public async Task<DeleteAclResponse> DeleteAcl(DeleteAclRequest req)
        {
             JsonResponseModel<DeleteAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ACL
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRequest"/></param>
        /// <returns><see cref="DeleteAclResponse"/></returns>
        public DeleteAclResponse DeleteAclSync(DeleteAclRequest req)
        {
             JsonResponseModel<DeleteAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ACL规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRuleRequest"/></param>
        /// <returns><see cref="DeleteAclRuleResponse"/></returns>
        public async Task<DeleteAclRuleResponse> DeleteAclRule(DeleteAclRuleRequest req)
        {
             JsonResponseModel<DeleteAclRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAclRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ACL规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRuleRequest"/></param>
        /// <returns><see cref="DeleteAclRuleResponse"/></returns>
        public DeleteAclRuleResponse DeleteAclRuleSync(DeleteAclRuleRequest req)
        {
             JsonResponseModel<DeleteAclRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAclRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectResourceRequest"/></param>
        /// <returns><see cref="DeleteConnectResourceResponse"/></returns>
        public async Task<DeleteConnectResourceResponse> DeleteConnectResource(DeleteConnectResourceRequest req)
        {
             JsonResponseModel<DeleteConnectResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConnectResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConnectResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectResourceRequest"/></param>
        /// <returns><see cref="DeleteConnectResourceResponse"/></returns>
        public DeleteConnectResourceResponse DeleteConnectResourceSync(DeleteConnectResourceRequest req)
        {
             JsonResponseModel<DeleteConnectResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConnectResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConnectResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Datahub任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDatahubTaskRequest"/></param>
        /// <returns><see cref="DeleteDatahubTaskResponse"/></returns>
        public async Task<DeleteDatahubTaskResponse> DeleteDatahubTask(DeleteDatahubTaskRequest req)
        {
             JsonResponseModel<DeleteDatahubTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDatahubTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatahubTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Datahub任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDatahubTaskRequest"/></param>
        /// <returns><see cref="DeleteDatahubTaskResponse"/></returns>
        public DeleteDatahubTaskResponse DeleteDatahubTaskSync(DeleteDatahubTaskRequest req)
        {
             JsonResponseModel<DeleteDatahubTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDatahubTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatahubTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Datahub主题
        /// </summary>
        /// <param name="req"><see cref="DeleteDatahubTopicRequest"/></param>
        /// <returns><see cref="DeleteDatahubTopicResponse"/></returns>
        public async Task<DeleteDatahubTopicResponse> DeleteDatahubTopic(DeleteDatahubTopicRequest req)
        {
             JsonResponseModel<DeleteDatahubTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDatahubTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatahubTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Datahub主题
        /// </summary>
        /// <param name="req"><see cref="DeleteDatahubTopicRequest"/></param>
        /// <returns><see cref="DeleteDatahubTopicResponse"/></returns>
        public DeleteDatahubTopicResponse DeleteDatahubTopicSync(DeleteDatahubTopicRequest req)
        {
             JsonResponseModel<DeleteDatahubTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDatahubTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatahubTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public async Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除预付费实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstancePreRequest"/></param>
        /// <returns><see cref="DeleteInstancePreResponse"/></returns>
        public async Task<DeleteInstancePreResponse> DeleteInstancePre(DeleteInstancePreRequest req)
        {
             JsonResponseModel<DeleteInstancePreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstancePre");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstancePreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除预付费实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstancePreRequest"/></param>
        /// <returns><see cref="DeleteInstancePreResponse"/></returns>
        public DeleteInstancePreResponse DeleteInstancePreSync(DeleteInstancePreRequest req)
        {
             JsonResponseModel<DeleteInstancePreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstancePre");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstancePreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除路由
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteRequest"/></param>
        /// <returns><see cref="DeleteRouteResponse"/></returns>
        public async Task<DeleteRouteResponse> DeleteRoute(DeleteRouteRequest req)
        {
             JsonResponseModel<DeleteRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除路由
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteRequest"/></param>
        /// <returns><see cref="DeleteRouteResponse"/></returns>
        public DeleteRouteResponse DeleteRouteSync(DeleteRouteRequest req)
        {
             JsonResponseModel<DeleteRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改删除路由延迟触发时间
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTriggerTimeRequest"/></param>
        /// <returns><see cref="DeleteRouteTriggerTimeResponse"/></returns>
        public async Task<DeleteRouteTriggerTimeResponse> DeleteRouteTriggerTime(DeleteRouteTriggerTimeRequest req)
        {
             JsonResponseModel<DeleteRouteTriggerTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRouteTriggerTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteTriggerTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改删除路由延迟触发时间
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTriggerTimeRequest"/></param>
        /// <returns><see cref="DeleteRouteTriggerTimeResponse"/></returns>
        public DeleteRouteTriggerTimeResponse DeleteRouteTriggerTimeSync(DeleteRouteTriggerTimeRequest req)
        {
             JsonResponseModel<DeleteRouteTriggerTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRouteTriggerTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteTriggerTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ckafka主题
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public async Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
             JsonResponseModel<DeleteTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ckafka主题
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
             JsonResponseModel<DeleteTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除主题IP白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="DeleteTopicIpWhiteListResponse"/></returns>
        public async Task<DeleteTopicIpWhiteListResponse> DeleteTopicIpWhiteList(DeleteTopicIpWhiteListRequest req)
        {
             JsonResponseModel<DeleteTopicIpWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopicIpWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicIpWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除主题IP白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="DeleteTopicIpWhiteListResponse"/></returns>
        public DeleteTopicIpWhiteListResponse DeleteTopicIpWhiteListSync(DeleteTopicIpWhiteListRequest req)
        {
             JsonResponseModel<DeleteTopicIpWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopicIpWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicIpWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public async Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeACLRequest"/></param>
        /// <returns><see cref="DescribeACLResponse"/></returns>
        public async Task<DescribeACLResponse> DescribeACL(DescribeACLRequest req)
        {
             JsonResponseModel<DescribeACLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeACLRequest"/></param>
        /// <returns><see cref="DescribeACLResponse"/></returns>
        public DescribeACLResponse DescribeACLSync(DescribeACLRequest req)
        {
             JsonResponseModel<DescribeACLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询ACL规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclRuleRequest"/></param>
        /// <returns><see cref="DescribeAclRuleResponse"/></returns>
        public async Task<DescribeAclRuleResponse> DescribeAclRule(DescribeAclRuleRequest req)
        {
             JsonResponseModel<DescribeAclRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAclRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAclRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询ACL规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclRuleRequest"/></param>
        /// <returns><see cref="DescribeAclRuleResponse"/></returns>
        public DescribeAclRuleResponse DescribeAclRuleSync(DescribeAclRuleRequest req)
        {
             JsonResponseModel<DescribeAclRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAclRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAclRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppInfoRequest"/></param>
        /// <returns><see cref="DescribeAppInfoResponse"/></returns>
        public async Task<DescribeAppInfoResponse> DescribeAppInfo(DescribeAppInfoRequest req)
        {
             JsonResponseModel<DescribeAppInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAppInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppInfoRequest"/></param>
        /// <returns><see cref="DescribeAppInfoResponse"/></returns>
        public DescribeAppInfoResponse DescribeAppInfoSync(DescribeAppInfoRequest req)
        {
             JsonResponseModel<DescribeAppInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAppInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查看ckafka的可用区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCkafkaZoneRequest"/></param>
        /// <returns><see cref="DescribeCkafkaZoneResponse"/></returns>
        public async Task<DescribeCkafkaZoneResponse> DescribeCkafkaZone(DescribeCkafkaZoneRequest req)
        {
             JsonResponseModel<DescribeCkafkaZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCkafkaZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCkafkaZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查看ckafka的可用区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCkafkaZoneRequest"/></param>
        /// <returns><see cref="DescribeCkafkaZoneResponse"/></returns>
        public DescribeCkafkaZoneResponse DescribeCkafkaZoneSync(DescribeCkafkaZoneRequest req)
        {
             JsonResponseModel<DescribeCkafkaZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCkafkaZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCkafkaZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectResourceRequest"/></param>
        /// <returns><see cref="DescribeConnectResourceResponse"/></returns>
        public async Task<DescribeConnectResourceResponse> DescribeConnectResource(DescribeConnectResourceRequest req)
        {
             JsonResponseModel<DescribeConnectResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConnectResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConnectResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectResourceRequest"/></param>
        /// <returns><see cref="DescribeConnectResourceResponse"/></returns>
        public DescribeConnectResourceResponse DescribeConnectResourceSync(DescribeConnectResourceRequest req)
        {
             JsonResponseModel<DescribeConnectResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConnectResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConnectResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Datahub连接源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectResourcesRequest"/></param>
        /// <returns><see cref="DescribeConnectResourcesResponse"/></returns>
        public async Task<DescribeConnectResourcesResponse> DescribeConnectResources(DescribeConnectResourcesRequest req)
        {
             JsonResponseModel<DescribeConnectResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConnectResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConnectResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Datahub连接源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectResourcesRequest"/></param>
        /// <returns><see cref="DescribeConnectResourcesResponse"/></returns>
        public DescribeConnectResourcesResponse DescribeConnectResourcesSync(DescribeConnectResourcesRequest req)
        {
             JsonResponseModel<DescribeConnectResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConnectResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConnectResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询消费分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public async Task<DescribeConsumerGroupResponse> DescribeConsumerGroup(DescribeConsumerGroupRequest req)
        {
             JsonResponseModel<DescribeConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConsumerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询消费分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public DescribeConsumerGroupResponse DescribeConsumerGroupSync(DescribeConsumerGroupRequest req)
        {
             JsonResponseModel<DescribeConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConsumerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Datahub消费分组offset
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeDatahubGroupOffsetsResponse"/></returns>
        public async Task<DescribeDatahubGroupOffsetsResponse> DescribeDatahubGroupOffsets(DescribeDatahubGroupOffsetsRequest req)
        {
             JsonResponseModel<DescribeDatahubGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatahubGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Datahub消费分组offset
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeDatahubGroupOffsetsResponse"/></returns>
        public DescribeDatahubGroupOffsetsResponse DescribeDatahubGroupOffsetsSync(DescribeDatahubGroupOffsetsRequest req)
        {
             JsonResponseModel<DescribeDatahubGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatahubGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Datahub任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTaskRequest"/></param>
        /// <returns><see cref="DescribeDatahubTaskResponse"/></returns>
        public async Task<DescribeDatahubTaskResponse> DescribeDatahubTask(DescribeDatahubTaskRequest req)
        {
             JsonResponseModel<DescribeDatahubTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatahubTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Datahub任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTaskRequest"/></param>
        /// <returns><see cref="DescribeDatahubTaskResponse"/></returns>
        public DescribeDatahubTaskResponse DescribeDatahubTaskSync(DescribeDatahubTaskRequest req)
        {
             JsonResponseModel<DescribeDatahubTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatahubTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Datahub任务列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTasksRequest"/></param>
        /// <returns><see cref="DescribeDatahubTasksResponse"/></returns>
        public async Task<DescribeDatahubTasksResponse> DescribeDatahubTasks(DescribeDatahubTasksRequest req)
        {
             JsonResponseModel<DescribeDatahubTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatahubTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Datahub任务列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTasksRequest"/></param>
        /// <returns><see cref="DescribeDatahubTasksResponse"/></returns>
        public DescribeDatahubTasksResponse DescribeDatahubTasksSync(DescribeDatahubTasksRequest req)
        {
             JsonResponseModel<DescribeDatahubTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatahubTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Datahub主题属性
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicResponse"/></returns>
        public async Task<DescribeDatahubTopicResponse> DescribeDatahubTopic(DescribeDatahubTopicRequest req)
        {
             JsonResponseModel<DescribeDatahubTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatahubTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Datahub主题属性
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicResponse"/></returns>
        public DescribeDatahubTopicResponse DescribeDatahubTopicSync(DescribeDatahubTopicRequest req)
        {
             JsonResponseModel<DescribeDatahubTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatahubTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询DIP主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicsRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicsResponse"/></returns>
        public async Task<DescribeDatahubTopicsResponse> DescribeDatahubTopics(DescribeDatahubTopicsRequest req)
        {
             JsonResponseModel<DescribeDatahubTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatahubTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询DIP主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicsRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicsResponse"/></returns>
        public DescribeDatahubTopicsResponse DescribeDatahubTopicsSync(DescribeDatahubTopicsRequest req)
        {
             JsonResponseModel<DescribeDatahubTopicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatahubTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatahubTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举消费分组(精简版)
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public async Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
             JsonResponseModel<DescribeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举消费分组(精简版)
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public DescribeGroupResponse DescribeGroupSync(DescribeGroupRequest req)
        {
             JsonResponseModel<DescribeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取消费分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeGroupInfoResponse"/></returns>
        public async Task<DescribeGroupInfoResponse> DescribeGroupInfo(DescribeGroupInfoRequest req)
        {
             JsonResponseModel<DescribeGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取消费分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeGroupInfoResponse"/></returns>
        public DescribeGroupInfoResponse DescribeGroupInfoSync(DescribeGroupInfoRequest req)
        {
             JsonResponseModel<DescribeGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取消费分组offset
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeGroupOffsetsResponse"/></returns>
        public async Task<DescribeGroupOffsetsResponse> DescribeGroupOffsets(DescribeGroupOffsetsRequest req)
        {
             JsonResponseModel<DescribeGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取消费分组offset
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeGroupOffsetsResponse"/></returns>
        public DescribeGroupOffsetsResponse DescribeGroupOffsetsSync(DescribeGroupOffsetsRequest req)
        {
             JsonResponseModel<DescribeGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例属性 
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAttributesResponse"/></returns>
        public async Task<DescribeInstanceAttributesResponse> DescribeInstanceAttributes(DescribeInstanceAttributesRequest req)
        {
             JsonResponseModel<DescribeInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例属性 
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAttributesResponse"/></returns>
        public DescribeInstanceAttributesResponse DescribeInstanceAttributesSync(DescribeInstanceAttributesRequest req)
        {
             JsonResponseModel<DescribeInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstance）用于在用户账户下获取消息队列 CKafka 实例列表
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
        /// 本接口（DescribeInstance）用于在用户账户下获取消息队列 CKafka 实例列表
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
        /// 用户账户下获取实例列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDetailRequest"/></param>
        /// <returns><see cref="DescribeInstancesDetailResponse"/></returns>
        public async Task<DescribeInstancesDetailResponse> DescribeInstancesDetail(DescribeInstancesDetailRequest req)
        {
             JsonResponseModel<DescribeInstancesDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户账户下获取实例列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDetailRequest"/></param>
        /// <returns><see cref="DescribeInstancesDetailResponse"/></returns>
        public DescribeInstancesDetailResponse DescribeInstancesDetailSync(DescribeInstancesDetailRequest req)
        {
             JsonResponseModel<DescribeInstancesDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举地域,只支持广州地域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionRequest"/></param>
        /// <returns><see cref="DescribeRegionResponse"/></returns>
        public async Task<DescribeRegionResponse> DescribeRegion(DescribeRegionRequest req)
        {
             JsonResponseModel<DescribeRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举地域,只支持广州地域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionRequest"/></param>
        /// <returns><see cref="DescribeRegionResponse"/></returns>
        public DescribeRegionResponse DescribeRegionSync(DescribeRegionRequest req)
        {
             JsonResponseModel<DescribeRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看路由信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteRequest"/></param>
        /// <returns><see cref="DescribeRouteResponse"/></returns>
        public async Task<DescribeRouteResponse> DescribeRoute(DescribeRouteRequest req)
        {
             JsonResponseModel<DescribeRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看路由信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteRequest"/></param>
        /// <returns><see cref="DescribeRouteResponse"/></returns>
        public DescribeRouteResponse DescribeRouteSync(DescribeRouteRequest req)
        {
             JsonResponseModel<DescribeRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口请求域名：https://ckafka.tencentcloudapi.com
        /// 本接口（DescribeTopic）用于在用户获取消息队列 CKafka 实例的主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public async Task<DescribeTopicResponse> DescribeTopic(DescribeTopicRequest req)
        {
             JsonResponseModel<DescribeTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口请求域名：https://ckafka.tencentcloudapi.com
        /// 本接口（DescribeTopic）用于在用户获取消息队列 CKafka 实例的主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public DescribeTopicResponse DescribeTopicSync(DescribeTopicRequest req)
        {
             JsonResponseModel<DescribeTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主题属性
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicAttributesRequest"/></param>
        /// <returns><see cref="DescribeTopicAttributesResponse"/></returns>
        public async Task<DescribeTopicAttributesResponse> DescribeTopicAttributes(DescribeTopicAttributesRequest req)
        {
             JsonResponseModel<DescribeTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主题属性
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicAttributesRequest"/></param>
        /// <returns><see cref="DescribeTopicAttributesResponse"/></returns>
        public DescribeTopicAttributesResponse DescribeTopicAttributesSync(DescribeTopicAttributesRequest req)
        {
             JsonResponseModel<DescribeTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主题列表详情（仅控制台调用）
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public async Task<DescribeTopicDetailResponse> DescribeTopicDetail(DescribeTopicDetailRequest req)
        {
             JsonResponseModel<DescribeTopicDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主题列表详情（仅控制台调用）
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public DescribeTopicDetailResponse DescribeTopicDetailSync(DescribeTopicDetailRequest req)
        {
             JsonResponseModel<DescribeTopicDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询topic 生产端连接信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicProduceConnectionRequest"/></param>
        /// <returns><see cref="DescribeTopicProduceConnectionResponse"/></returns>
        public async Task<DescribeTopicProduceConnectionResponse> DescribeTopicProduceConnection(DescribeTopicProduceConnectionRequest req)
        {
             JsonResponseModel<DescribeTopicProduceConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicProduceConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicProduceConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询topic 生产端连接信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicProduceConnectionRequest"/></param>
        /// <returns><see cref="DescribeTopicProduceConnectionResponse"/></returns>
        public DescribeTopicProduceConnectionResponse DescribeTopicProduceConnectionSync(DescribeTopicProduceConnectionRequest req)
        {
             JsonResponseModel<DescribeTopicProduceConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicProduceConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicProduceConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订阅某主题消息分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSubscribeGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicSubscribeGroupResponse"/></returns>
        public async Task<DescribeTopicSubscribeGroupResponse> DescribeTopicSubscribeGroup(DescribeTopicSubscribeGroupRequest req)
        {
             JsonResponseModel<DescribeTopicSubscribeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicSubscribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicSubscribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订阅某主题消息分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSubscribeGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicSubscribeGroupResponse"/></returns>
        public DescribeTopicSubscribeGroupResponse DescribeTopicSubscribeGroupSync(DescribeTopicSubscribeGroupRequest req)
        {
             JsonResponseModel<DescribeTopicSubscribeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicSubscribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicSubscribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Topic 副本详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSyncReplicaRequest"/></param>
        /// <returns><see cref="DescribeTopicSyncReplicaResponse"/></returns>
        public async Task<DescribeTopicSyncReplicaResponse> DescribeTopicSyncReplica(DescribeTopicSyncReplicaRequest req)
        {
             JsonResponseModel<DescribeTopicSyncReplicaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicSyncReplica");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicSyncReplicaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Topic 副本详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSyncReplicaRequest"/></param>
        /// <returns><see cref="DescribeTopicSyncReplicaResponse"/></returns>
        public DescribeTopicSyncReplicaResponse DescribeTopicSyncReplicaSync(DescribeTopicSyncReplicaRequest req)
        {
             JsonResponseModel<DescribeTopicSyncReplicaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicSyncReplica");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicSyncReplicaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public async Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定offset位置的消息
        /// </summary>
        /// <param name="req"><see cref="FetchDatahubMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchDatahubMessageByOffsetResponse"/></returns>
        public async Task<FetchDatahubMessageByOffsetResponse> FetchDatahubMessageByOffset(FetchDatahubMessageByOffsetRequest req)
        {
             JsonResponseModel<FetchDatahubMessageByOffsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FetchDatahubMessageByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchDatahubMessageByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定offset位置的消息
        /// </summary>
        /// <param name="req"><see cref="FetchDatahubMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchDatahubMessageByOffsetResponse"/></returns>
        public FetchDatahubMessageByOffsetResponse FetchDatahubMessageByOffsetSync(FetchDatahubMessageByOffsetRequest req)
        {
             JsonResponseModel<FetchDatahubMessageByOffsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FetchDatahubMessageByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchDatahubMessageByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最新消息列表
        /// </summary>
        /// <param name="req"><see cref="FetchLatestDatahubMessageListRequest"/></param>
        /// <returns><see cref="FetchLatestDatahubMessageListResponse"/></returns>
        public async Task<FetchLatestDatahubMessageListResponse> FetchLatestDatahubMessageList(FetchLatestDatahubMessageListRequest req)
        {
             JsonResponseModel<FetchLatestDatahubMessageListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FetchLatestDatahubMessageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchLatestDatahubMessageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最新消息列表
        /// </summary>
        /// <param name="req"><see cref="FetchLatestDatahubMessageListRequest"/></param>
        /// <returns><see cref="FetchLatestDatahubMessageListResponse"/></returns>
        public FetchLatestDatahubMessageListResponse FetchLatestDatahubMessageListSync(FetchLatestDatahubMessageListRequest req)
        {
             JsonResponseModel<FetchLatestDatahubMessageListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FetchLatestDatahubMessageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchLatestDatahubMessageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定offset位置的消息
        /// </summary>
        /// <param name="req"><see cref="FetchMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageByOffsetResponse"/></returns>
        public async Task<FetchMessageByOffsetResponse> FetchMessageByOffset(FetchMessageByOffsetRequest req)
        {
             JsonResponseModel<FetchMessageByOffsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FetchMessageByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchMessageByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定offset位置的消息
        /// </summary>
        /// <param name="req"><see cref="FetchMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageByOffsetResponse"/></returns>
        public FetchMessageByOffsetResponse FetchMessageByOffsetSync(FetchMessageByOffsetRequest req)
        {
             JsonResponseModel<FetchMessageByOffsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FetchMessageByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchMessageByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据位点查询消息列表
        /// </summary>
        /// <param name="req"><see cref="FetchMessageListByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageListByOffsetResponse"/></returns>
        public async Task<FetchMessageListByOffsetResponse> FetchMessageListByOffset(FetchMessageListByOffsetRequest req)
        {
             JsonResponseModel<FetchMessageListByOffsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FetchMessageListByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchMessageListByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据位点查询消息列表
        /// </summary>
        /// <param name="req"><see cref="FetchMessageListByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageListByOffsetResponse"/></returns>
        public FetchMessageListByOffsetResponse FetchMessageListByOffsetSync(FetchMessageListByOffsetRequest req)
        {
             JsonResponseModel<FetchMessageListByOffsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FetchMessageListByOffset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FetchMessageListByOffsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Ckafka实例购买/续费询价
        /// </summary>
        /// <param name="req"><see cref="InquireCkafkaPriceRequest"/></param>
        /// <returns><see cref="InquireCkafkaPriceResponse"/></returns>
        public async Task<InquireCkafkaPriceResponse> InquireCkafkaPrice(InquireCkafkaPriceRequest req)
        {
             JsonResponseModel<InquireCkafkaPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquireCkafkaPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquireCkafkaPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Ckafka实例购买/续费询价
        /// </summary>
        /// <param name="req"><see cref="InquireCkafkaPriceRequest"/></param>
        /// <returns><see cref="InquireCkafkaPriceResponse"/></returns>
        public InquireCkafkaPriceResponse InquireCkafkaPriceSync(InquireCkafkaPriceRequest req)
        {
             JsonResponseModel<InquireCkafkaPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquireCkafkaPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquireCkafkaPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改AC策略，目前只支持预设规则的是否应用到新增topic这一项的修改
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRuleRequest"/></param>
        /// <returns><see cref="ModifyAclRuleResponse"/></returns>
        public async Task<ModifyAclRuleResponse> ModifyAclRule(ModifyAclRuleRequest req)
        {
             JsonResponseModel<ModifyAclRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAclRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAclRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改AC策略，目前只支持预设规则的是否应用到新增topic这一项的修改
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRuleRequest"/></param>
        /// <returns><see cref="ModifyAclRuleResponse"/></returns>
        public ModifyAclRuleResponse ModifyAclRuleSync(ModifyAclRuleRequest req)
        {
             JsonResponseModel<ModifyAclRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAclRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAclRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectResourceRequest"/></param>
        /// <returns><see cref="ModifyConnectResourceResponse"/></returns>
        public async Task<ModifyConnectResourceResponse> ModifyConnectResource(ModifyConnectResourceRequest req)
        {
             JsonResponseModel<ModifyConnectResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConnectResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConnectResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectResourceRequest"/></param>
        /// <returns><see cref="ModifyConnectResourceResponse"/></returns>
        public ModifyConnectResourceResponse ModifyConnectResourceSync(ModifyConnectResourceRequest req)
        {
             JsonResponseModel<ModifyConnectResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyConnectResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConnectResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Datahub任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDatahubTaskRequest"/></param>
        /// <returns><see cref="ModifyDatahubTaskResponse"/></returns>
        public async Task<ModifyDatahubTaskResponse> ModifyDatahubTask(ModifyDatahubTaskRequest req)
        {
             JsonResponseModel<ModifyDatahubTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDatahubTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatahubTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Datahub任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDatahubTaskRequest"/></param>
        /// <returns><see cref="ModifyDatahubTaskResponse"/></returns>
        public ModifyDatahubTaskResponse ModifyDatahubTaskSync(ModifyDatahubTaskRequest req)
        {
             JsonResponseModel<ModifyDatahubTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDatahubTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatahubTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置Groups 消费分组offset
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="ModifyGroupOffsetsResponse"/></returns>
        public async Task<ModifyGroupOffsetsResponse> ModifyGroupOffsets(ModifyGroupOffsetsRequest req)
        {
             JsonResponseModel<ModifyGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置Groups 消费分组offset
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="ModifyGroupOffsetsResponse"/></returns>
        public ModifyGroupOffsetsResponse ModifyGroupOffsetsSync(ModifyGroupOffsetsRequest req)
        {
             JsonResponseModel<ModifyGroupOffsetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGroupOffsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupOffsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributesResponse"/></returns>
        public async Task<ModifyInstanceAttributesResponse> ModifyInstanceAttributes(ModifyInstanceAttributesRequest req)
        {
             JsonResponseModel<ModifyInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributesResponse"/></returns>
        public ModifyInstanceAttributesResponse ModifyInstanceAttributesSync(ModifyInstanceAttributesRequest req)
        {
             JsonResponseModel<ModifyInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 预付费实例变配接口，调整磁盘，带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePreRequest"/></param>
        /// <returns><see cref="ModifyInstancePreResponse"/></returns>
        public async Task<ModifyInstancePreResponse> ModifyInstancePre(ModifyInstancePreRequest req)
        {
             JsonResponseModel<ModifyInstancePreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancePre");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancePreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 预付费实例变配接口，调整磁盘，带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePreRequest"/></param>
        /// <returns><see cref="ModifyInstancePreResponse"/></returns>
        public ModifyInstancePreResponse ModifyInstancePreSync(ModifyInstancePreRequest req)
        {
             JsonResponseModel<ModifyInstancePreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancePre");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancePreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="req"><see cref="ModifyPasswordRequest"/></param>
        /// <returns><see cref="ModifyPasswordResponse"/></returns>
        public async Task<ModifyPasswordResponse> ModifyPassword(ModifyPasswordRequest req)
        {
             JsonResponseModel<ModifyPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="req"><see cref="ModifyPasswordRequest"/></param>
        /// <returns><see cref="ModifyPasswordResponse"/></returns>
        public ModifyPasswordResponse ModifyPasswordSync(ModifyPasswordRequest req)
        {
             JsonResponseModel<ModifyPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改主题属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributesResponse"/></returns>
        public async Task<ModifyTopicAttributesResponse> ModifyTopicAttributes(ModifyTopicAttributesRequest req)
        {
             JsonResponseModel<ModifyTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改主题属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributesResponse"/></returns>
        public ModifyTopicAttributesResponse ModifyTopicAttributesSync(ModifyTopicAttributesRequest req)
        {
             JsonResponseModel<ModifyTopicAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopicAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过HTTP接入层发送消息
        /// </summary>
        /// <param name="req"><see cref="SendMessageRequest"/></param>
        /// <returns><see cref="SendMessageResponse"/></returns>
        public async Task<SendMessageResponse> SendMessage(SendMessageRequest req)
        {
             JsonResponseModel<SendMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过HTTP接入层发送消息
        /// </summary>
        /// <param name="req"><see cref="SendMessageRequest"/></param>
        /// <returns><see cref="SendMessageResponse"/></returns>
        public SendMessageResponse SendMessageSync(SendMessageRequest req)
        {
             JsonResponseModel<SendMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
