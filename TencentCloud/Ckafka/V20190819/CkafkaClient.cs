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
       private const string sdkVersion = "SDK_NET_3.0.1062";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CkafkaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 给实例授权token
        /// </summary>
        /// <param name="req"><see cref="AuthorizeTokenRequest"/></param>
        /// <returns><see cref="AuthorizeTokenResponse"/></returns>
        public Task<AuthorizeTokenResponse> AuthorizeToken(AuthorizeTokenRequest req)
        {
            return InternalRequestAsync<AuthorizeTokenResponse>(req, "AuthorizeToken");
        }

        /// <summary>
        /// 给实例授权token
        /// </summary>
        /// <param name="req"><see cref="AuthorizeTokenRequest"/></param>
        /// <returns><see cref="AuthorizeTokenResponse"/></returns>
        public AuthorizeTokenResponse AuthorizeTokenSync(AuthorizeTokenRequest req)
        {
            return InternalRequestAsync<AuthorizeTokenResponse>(req, "AuthorizeToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量添加ACL策略
        /// </summary>
        /// <param name="req"><see cref="BatchCreateAclRequest"/></param>
        /// <returns><see cref="BatchCreateAclResponse"/></returns>
        public Task<BatchCreateAclResponse> BatchCreateAcl(BatchCreateAclRequest req)
        {
            return InternalRequestAsync<BatchCreateAclResponse>(req, "BatchCreateAcl");
        }

        /// <summary>
        /// 批量添加ACL策略
        /// </summary>
        /// <param name="req"><see cref="BatchCreateAclRequest"/></param>
        /// <returns><see cref="BatchCreateAclResponse"/></returns>
        public BatchCreateAclResponse BatchCreateAclSync(BatchCreateAclRequest req)
        {
            return InternalRequestAsync<BatchCreateAclResponse>(req, "BatchCreateAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改消费组offset
        /// </summary>
        /// <param name="req"><see cref="BatchModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="BatchModifyGroupOffsetsResponse"/></returns>
        public Task<BatchModifyGroupOffsetsResponse> BatchModifyGroupOffsets(BatchModifyGroupOffsetsRequest req)
        {
            return InternalRequestAsync<BatchModifyGroupOffsetsResponse>(req, "BatchModifyGroupOffsets");
        }

        /// <summary>
        /// 批量修改消费组offset
        /// </summary>
        /// <param name="req"><see cref="BatchModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="BatchModifyGroupOffsetsResponse"/></returns>
        public BatchModifyGroupOffsetsResponse BatchModifyGroupOffsetsSync(BatchModifyGroupOffsetsRequest req)
        {
            return InternalRequestAsync<BatchModifyGroupOffsetsResponse>(req, "BatchModifyGroupOffsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量设置主题属性
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="BatchModifyTopicAttributesResponse"/></returns>
        public Task<BatchModifyTopicAttributesResponse> BatchModifyTopicAttributes(BatchModifyTopicAttributesRequest req)
        {
            return InternalRequestAsync<BatchModifyTopicAttributesResponse>(req, "BatchModifyTopicAttributes");
        }

        /// <summary>
        /// 批量设置主题属性
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="BatchModifyTopicAttributesResponse"/></returns>
        public BatchModifyTopicAttributesResponse BatchModifyTopicAttributesSync(BatchModifyTopicAttributesRequest req)
        {
            return InternalRequestAsync<BatchModifyTopicAttributesResponse>(req, "BatchModifyTopicAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消授权token
        /// </summary>
        /// <param name="req"><see cref="CancelAuthorizationTokenRequest"/></param>
        /// <returns><see cref="CancelAuthorizationTokenResponse"/></returns>
        public Task<CancelAuthorizationTokenResponse> CancelAuthorizationToken(CancelAuthorizationTokenRequest req)
        {
            return InternalRequestAsync<CancelAuthorizationTokenResponse>(req, "CancelAuthorizationToken");
        }

        /// <summary>
        /// 取消授权token
        /// </summary>
        /// <param name="req"><see cref="CancelAuthorizationTokenRequest"/></param>
        /// <returns><see cref="CancelAuthorizationTokenResponse"/></returns>
        public CancelAuthorizationTokenResponse CancelAuthorizationTokenSync(CancelAuthorizationTokenRequest req)
        {
            return InternalRequestAsync<CancelAuthorizationTokenResponse>(req, "CancelAuthorizationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询cdc-ckafka任务状态
        /// </summary>
        /// <param name="req"><see cref="CheckCdcClusterRequest"/></param>
        /// <returns><see cref="CheckCdcClusterResponse"/></returns>
        public Task<CheckCdcClusterResponse> CheckCdcCluster(CheckCdcClusterRequest req)
        {
            return InternalRequestAsync<CheckCdcClusterResponse>(req, "CheckCdcCluster");
        }

        /// <summary>
        /// 用于查询cdc-ckafka任务状态
        /// </summary>
        /// <param name="req"><see cref="CheckCdcClusterRequest"/></param>
        /// <returns><see cref="CheckCdcClusterResponse"/></returns>
        public CheckCdcClusterResponse CheckCdcClusterSync(CheckCdcClusterRequest req)
        {
            return InternalRequestAsync<CheckCdcClusterResponse>(req, "CheckCdcCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加 ACL 策略
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public Task<CreateAclResponse> CreateAcl(CreateAclRequest req)
        {
            return InternalRequestAsync<CreateAclResponse>(req, "CreateAcl");
        }

        /// <summary>
        /// 添加 ACL 策略
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public CreateAclResponse CreateAclSync(CreateAclRequest req)
        {
            return InternalRequestAsync<CreateAclResponse>(req, "CreateAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加 ACL 规则
        /// </summary>
        /// <param name="req"><see cref="CreateAclRuleRequest"/></param>
        /// <returns><see cref="CreateAclRuleResponse"/></returns>
        public Task<CreateAclRuleResponse> CreateAclRule(CreateAclRuleRequest req)
        {
            return InternalRequestAsync<CreateAclRuleResponse>(req, "CreateAclRule");
        }

        /// <summary>
        /// 添加 ACL 规则
        /// </summary>
        /// <param name="req"><see cref="CreateAclRuleRequest"/></param>
        /// <returns><see cref="CreateAclRuleResponse"/></returns>
        public CreateAclRuleResponse CreateAclRuleSync(CreateAclRuleRequest req)
        {
            return InternalRequestAsync<CreateAclRuleResponse>(req, "CreateAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于cdc的专用ckafka集群
        /// </summary>
        /// <param name="req"><see cref="CreateCdcClusterRequest"/></param>
        /// <returns><see cref="CreateCdcClusterResponse"/></returns>
        public Task<CreateCdcClusterResponse> CreateCdcCluster(CreateCdcClusterRequest req)
        {
            return InternalRequestAsync<CreateCdcClusterResponse>(req, "CreateCdcCluster");
        }

        /// <summary>
        /// 用于cdc的专用ckafka集群
        /// </summary>
        /// <param name="req"><see cref="CreateCdcClusterRequest"/></param>
        /// <returns><see cref="CreateCdcClusterResponse"/></returns>
        public CreateCdcClusterResponse CreateCdcClusterSync(CreateCdcClusterRequest req)
        {
            return InternalRequestAsync<CreateCdcClusterResponse>(req, "CreateCdcCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="CreateConnectResourceRequest"/></param>
        /// <returns><see cref="CreateConnectResourceResponse"/></returns>
        public Task<CreateConnectResourceResponse> CreateConnectResource(CreateConnectResourceRequest req)
        {
            return InternalRequestAsync<CreateConnectResourceResponse>(req, "CreateConnectResource");
        }

        /// <summary>
        /// 创建Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="CreateConnectResourceRequest"/></param>
        /// <returns><see cref="CreateConnectResourceResponse"/></returns>
        public CreateConnectResourceResponse CreateConnectResourceSync(CreateConnectResourceRequest req)
        {
            return InternalRequestAsync<CreateConnectResourceResponse>(req, "CreateConnectResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建消费者组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public Task<CreateConsumerResponse> CreateConsumer(CreateConsumerRequest req)
        {
            return InternalRequestAsync<CreateConsumerResponse>(req, "CreateConsumer");
        }

        /// <summary>
        /// 创建消费者组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public CreateConsumerResponse CreateConsumerSync(CreateConsumerRequest req)
        {
            return InternalRequestAsync<CreateConsumerResponse>(req, "CreateConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建DIP转储任务
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTaskRequest"/></param>
        /// <returns><see cref="CreateDatahubTaskResponse"/></returns>
        public Task<CreateDatahubTaskResponse> CreateDatahubTask(CreateDatahubTaskRequest req)
        {
            return InternalRequestAsync<CreateDatahubTaskResponse>(req, "CreateDatahubTask");
        }

        /// <summary>
        /// 创建DIP转储任务
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTaskRequest"/></param>
        /// <returns><see cref="CreateDatahubTaskResponse"/></returns>
        public CreateDatahubTaskResponse CreateDatahubTaskSync(CreateDatahubTaskRequest req)
        {
            return InternalRequestAsync<CreateDatahubTaskResponse>(req, "CreateDatahubTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建DIP主题
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTopicRequest"/></param>
        /// <returns><see cref="CreateDatahubTopicResponse"/></returns>
        public Task<CreateDatahubTopicResponse> CreateDatahubTopic(CreateDatahubTopicRequest req)
        {
            return InternalRequestAsync<CreateDatahubTopicResponse>(req, "CreateDatahubTopic");
        }

        /// <summary>
        /// 创建DIP主题
        /// </summary>
        /// <param name="req"><see cref="CreateDatahubTopicRequest"/></param>
        /// <returns><see cref="CreateDatahubTopicResponse"/></returns>
        public CreateDatahubTopicResponse CreateDatahubTopicSync(CreateDatahubTopicRequest req)
        {
            return InternalRequestAsync<CreateDatahubTopicResponse>(req, "CreateDatahubTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 由于出参需要更新，当前接口将会在未来版本中废弃，建议用户迁移使用 CreatePostPaidInstance 接口。创建按量计费实例。通常用于 SDK 或云 API 控制台调用接口，创建后付费 CKafka 实例。调用接口与在 CKafka 控制台购买按量付费实例效果相同。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePostRequest"/></param>
        /// <returns><see cref="CreateInstancePostResponse"/></returns>
        public Task<CreateInstancePostResponse> CreateInstancePost(CreateInstancePostRequest req)
        {
            return InternalRequestAsync<CreateInstancePostResponse>(req, "CreateInstancePost");
        }

        /// <summary>
        /// 由于出参需要更新，当前接口将会在未来版本中废弃，建议用户迁移使用 CreatePostPaidInstance 接口。创建按量计费实例。通常用于 SDK 或云 API 控制台调用接口，创建后付费 CKafka 实例。调用接口与在 CKafka 控制台购买按量付费实例效果相同。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePostRequest"/></param>
        /// <returns><see cref="CreateInstancePostResponse"/></returns>
        public CreateInstancePostResponse CreateInstancePostSync(CreateInstancePostRequest req)
        {
            return InternalRequestAsync<CreateInstancePostResponse>(req, "CreateInstancePost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实例(预付费包年包月),  仅支持创建专业版实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePreRequest"/></param>
        /// <returns><see cref="CreateInstancePreResponse"/></returns>
        public Task<CreateInstancePreResponse> CreateInstancePre(CreateInstancePreRequest req)
        {
            return InternalRequestAsync<CreateInstancePreResponse>(req, "CreateInstancePre");
        }

        /// <summary>
        /// 创建实例(预付费包年包月),  仅支持创建专业版实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancePreRequest"/></param>
        /// <returns><see cref="CreateInstancePreResponse"/></returns>
        public CreateInstancePreResponse CreateInstancePreSync(CreateInstancePreRequest req)
        {
            return InternalRequestAsync<CreateInstancePreResponse>(req, "CreateInstancePre")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于增加主题中的分区
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public Task<CreatePartitionResponse> CreatePartition(CreatePartitionRequest req)
        {
            return InternalRequestAsync<CreatePartitionResponse>(req, "CreatePartition");
        }

        /// <summary>
        /// 本接口用于增加主题中的分区
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public CreatePartitionResponse CreatePartitionSync(CreatePartitionRequest req)
        {
            return InternalRequestAsync<CreatePartitionResponse>(req, "CreatePartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当前接口用来替代 CreateInstancePost 接口。创建按量计费实例。通常用于 SDK 或云 API 控制台调用接口，创建后付费 CKafka 实例。调用接口与在 CKafka 控制台购买按量付费实例效果相同。
        /// </summary>
        /// <param name="req"><see cref="CreatePostPaidInstanceRequest"/></param>
        /// <returns><see cref="CreatePostPaidInstanceResponse"/></returns>
        public Task<CreatePostPaidInstanceResponse> CreatePostPaidInstance(CreatePostPaidInstanceRequest req)
        {
            return InternalRequestAsync<CreatePostPaidInstanceResponse>(req, "CreatePostPaidInstance");
        }

        /// <summary>
        /// 当前接口用来替代 CreateInstancePost 接口。创建按量计费实例。通常用于 SDK 或云 API 控制台调用接口，创建后付费 CKafka 实例。调用接口与在 CKafka 控制台购买按量付费实例效果相同。
        /// </summary>
        /// <param name="req"><see cref="CreatePostPaidInstanceRequest"/></param>
        /// <returns><see cref="CreatePostPaidInstanceResponse"/></returns>
        public CreatePostPaidInstanceResponse CreatePostPaidInstanceSync(CreatePostPaidInstanceRequest req)
        {
            return InternalRequestAsync<CreatePostPaidInstanceResponse>(req, "CreatePostPaidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加普罗米修斯监控1
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRequest"/></param>
        /// <returns><see cref="CreatePrometheusResponse"/></returns>
        public Task<CreatePrometheusResponse> CreatePrometheus(CreatePrometheusRequest req)
        {
            return InternalRequestAsync<CreatePrometheusResponse>(req, "CreatePrometheus");
        }

        /// <summary>
        /// 添加普罗米修斯监控1
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRequest"/></param>
        /// <returns><see cref="CreatePrometheusResponse"/></returns>
        public CreatePrometheusResponse CreatePrometheusSync(CreatePrometheusRequest req)
        {
            return InternalRequestAsync<CreatePrometheusResponse>(req, "CreatePrometheus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加实例路由
        /// </summary>
        /// <param name="req"><see cref="CreateRouteRequest"/></param>
        /// <returns><see cref="CreateRouteResponse"/></returns>
        public Task<CreateRouteResponse> CreateRoute(CreateRouteRequest req)
        {
            return InternalRequestAsync<CreateRouteResponse>(req, "CreateRoute");
        }

        /// <summary>
        /// 添加实例路由
        /// </summary>
        /// <param name="req"><see cref="CreateRouteRequest"/></param>
        /// <returns><see cref="CreateRouteResponse"/></returns>
        public CreateRouteResponse CreateRouteSync(CreateRouteRequest req)
        {
            return InternalRequestAsync<CreateRouteResponse>(req, "CreateRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建最高权限的token
        /// </summary>
        /// <param name="req"><see cref="CreateTokenRequest"/></param>
        /// <returns><see cref="CreateTokenResponse"/></returns>
        public Task<CreateTokenResponse> CreateToken(CreateTokenRequest req)
        {
            return InternalRequestAsync<CreateTokenResponse>(req, "CreateToken");
        }

        /// <summary>
        /// 创建最高权限的token
        /// </summary>
        /// <param name="req"><see cref="CreateTokenRequest"/></param>
        /// <returns><see cref="CreateTokenResponse"/></returns>
        public CreateTokenResponse CreateTokenSync(CreateTokenRequest req)
        {
            return InternalRequestAsync<CreateTokenResponse>(req, "CreateToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建ckafka主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// 创建ckafka主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建主题ip白名单
        /// </summary>
        /// <param name="req"><see cref="CreateTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="CreateTopicIpWhiteListResponse"/></returns>
        public Task<CreateTopicIpWhiteListResponse> CreateTopicIpWhiteList(CreateTopicIpWhiteListRequest req)
        {
            return InternalRequestAsync<CreateTopicIpWhiteListResponse>(req, "CreateTopicIpWhiteList");
        }

        /// <summary>
        /// 创建主题ip白名单
        /// </summary>
        /// <param name="req"><see cref="CreateTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="CreateTopicIpWhiteListResponse"/></returns>
        public CreateTopicIpWhiteListResponse CreateTopicIpWhiteListSync(CreateTopicIpWhiteListRequest req)
        {
            return InternalRequestAsync<CreateTopicIpWhiteListResponse>(req, "CreateTopicIpWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除ACL
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRequest"/></param>
        /// <returns><see cref="DeleteAclResponse"/></returns>
        public Task<DeleteAclResponse> DeleteAcl(DeleteAclRequest req)
        {
            return InternalRequestAsync<DeleteAclResponse>(req, "DeleteAcl");
        }

        /// <summary>
        /// 删除ACL
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRequest"/></param>
        /// <returns><see cref="DeleteAclResponse"/></returns>
        public DeleteAclResponse DeleteAclSync(DeleteAclRequest req)
        {
            return InternalRequestAsync<DeleteAclResponse>(req, "DeleteAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除ACL规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRuleRequest"/></param>
        /// <returns><see cref="DeleteAclRuleResponse"/></returns>
        public Task<DeleteAclRuleResponse> DeleteAclRule(DeleteAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteAclRuleResponse>(req, "DeleteAclRule");
        }

        /// <summary>
        /// 删除ACL规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAclRuleRequest"/></param>
        /// <returns><see cref="DeleteAclRuleResponse"/></returns>
        public DeleteAclRuleResponse DeleteAclRuleSync(DeleteAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteAclRuleResponse>(req, "DeleteAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectResourceRequest"/></param>
        /// <returns><see cref="DeleteConnectResourceResponse"/></returns>
        public Task<DeleteConnectResourceResponse> DeleteConnectResource(DeleteConnectResourceRequest req)
        {
            return InternalRequestAsync<DeleteConnectResourceResponse>(req, "DeleteConnectResource");
        }

        /// <summary>
        /// 删除Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectResourceRequest"/></param>
        /// <returns><see cref="DeleteConnectResourceResponse"/></returns>
        public DeleteConnectResourceResponse DeleteConnectResourceSync(DeleteConnectResourceRequest req)
        {
            return InternalRequestAsync<DeleteConnectResourceResponse>(req, "DeleteConnectResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Dip任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDatahubTaskRequest"/></param>
        /// <returns><see cref="DeleteDatahubTaskResponse"/></returns>
        public Task<DeleteDatahubTaskResponse> DeleteDatahubTask(DeleteDatahubTaskRequest req)
        {
            return InternalRequestAsync<DeleteDatahubTaskResponse>(req, "DeleteDatahubTask");
        }

        /// <summary>
        /// 删除Dip任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDatahubTaskRequest"/></param>
        /// <returns><see cref="DeleteDatahubTaskResponse"/></returns>
        public DeleteDatahubTaskResponse DeleteDatahubTaskSync(DeleteDatahubTaskRequest req)
        {
            return InternalRequestAsync<DeleteDatahubTaskResponse>(req, "DeleteDatahubTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Datahub主题
        /// </summary>
        /// <param name="req"><see cref="DeleteDatahubTopicRequest"/></param>
        /// <returns><see cref="DeleteDatahubTopicResponse"/></returns>
        public Task<DeleteDatahubTopicResponse> DeleteDatahubTopic(DeleteDatahubTopicRequest req)
        {
            return InternalRequestAsync<DeleteDatahubTopicResponse>(req, "DeleteDatahubTopic");
        }

        /// <summary>
        /// 删除Datahub主题
        /// </summary>
        /// <param name="req"><see cref="DeleteDatahubTopicRequest"/></param>
        /// <returns><see cref="DeleteDatahubTopicResponse"/></returns>
        public DeleteDatahubTopicResponse DeleteDatahubTopicSync(DeleteDatahubTopicRequest req)
        {
            return InternalRequestAsync<DeleteDatahubTopicResponse>(req, "DeleteDatahubTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// 删除消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除后付费实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstancePostRequest"/></param>
        /// <returns><see cref="DeleteInstancePostResponse"/></returns>
        public Task<DeleteInstancePostResponse> DeleteInstancePost(DeleteInstancePostRequest req)
        {
            return InternalRequestAsync<DeleteInstancePostResponse>(req, "DeleteInstancePost");
        }

        /// <summary>
        /// 删除后付费实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstancePostRequest"/></param>
        /// <returns><see cref="DeleteInstancePostResponse"/></returns>
        public DeleteInstancePostResponse DeleteInstancePostSync(DeleteInstancePostRequest req)
        {
            return InternalRequestAsync<DeleteInstancePostResponse>(req, "DeleteInstancePost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除预付费实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstancePreRequest"/></param>
        /// <returns><see cref="DeleteInstancePreResponse"/></returns>
        public Task<DeleteInstancePreResponse> DeleteInstancePre(DeleteInstancePreRequest req)
        {
            return InternalRequestAsync<DeleteInstancePreResponse>(req, "DeleteInstancePre");
        }

        /// <summary>
        /// 删除预付费实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstancePreRequest"/></param>
        /// <returns><see cref="DeleteInstancePreResponse"/></returns>
        public DeleteInstancePreResponse DeleteInstancePreSync(DeleteInstancePreRequest req)
        {
            return InternalRequestAsync<DeleteInstancePreResponse>(req, "DeleteInstancePre")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除路由
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteRequest"/></param>
        /// <returns><see cref="DeleteRouteResponse"/></returns>
        public Task<DeleteRouteResponse> DeleteRoute(DeleteRouteRequest req)
        {
            return InternalRequestAsync<DeleteRouteResponse>(req, "DeleteRoute");
        }

        /// <summary>
        /// 删除路由
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteRequest"/></param>
        /// <returns><see cref="DeleteRouteResponse"/></returns>
        public DeleteRouteResponse DeleteRouteSync(DeleteRouteRequest req)
        {
            return InternalRequestAsync<DeleteRouteResponse>(req, "DeleteRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改删除路由延迟触发时间
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTriggerTimeRequest"/></param>
        /// <returns><see cref="DeleteRouteTriggerTimeResponse"/></returns>
        public Task<DeleteRouteTriggerTimeResponse> DeleteRouteTriggerTime(DeleteRouteTriggerTimeRequest req)
        {
            return InternalRequestAsync<DeleteRouteTriggerTimeResponse>(req, "DeleteRouteTriggerTime");
        }

        /// <summary>
        /// 修改删除路由延迟触发时间
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTriggerTimeRequest"/></param>
        /// <returns><see cref="DeleteRouteTriggerTimeResponse"/></returns>
        public DeleteRouteTriggerTimeResponse DeleteRouteTriggerTimeSync(DeleteRouteTriggerTimeRequest req)
        {
            return InternalRequestAsync<DeleteRouteTriggerTimeResponse>(req, "DeleteRouteTriggerTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除ckafka主题
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// 删除ckafka主题
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除主题IP白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="DeleteTopicIpWhiteListResponse"/></returns>
        public Task<DeleteTopicIpWhiteListResponse> DeleteTopicIpWhiteList(DeleteTopicIpWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteTopicIpWhiteListResponse>(req, "DeleteTopicIpWhiteList");
        }

        /// <summary>
        /// 删除主题IP白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicIpWhiteListRequest"/></param>
        /// <returns><see cref="DeleteTopicIpWhiteListResponse"/></returns>
        public DeleteTopicIpWhiteListResponse DeleteTopicIpWhiteListSync(DeleteTopicIpWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteTopicIpWhiteListResponse>(req, "DeleteTopicIpWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 枚举ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeACLRequest"/></param>
        /// <returns><see cref="DescribeACLResponse"/></returns>
        public Task<DescribeACLResponse> DescribeACL(DescribeACLRequest req)
        {
            return InternalRequestAsync<DescribeACLResponse>(req, "DescribeACL");
        }

        /// <summary>
        /// 枚举ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeACLRequest"/></param>
        /// <returns><see cref="DescribeACLResponse"/></returns>
        public DescribeACLResponse DescribeACLSync(DescribeACLRequest req)
        {
            return InternalRequestAsync<DescribeACLResponse>(req, "DescribeACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询ACL规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclRuleRequest"/></param>
        /// <returns><see cref="DescribeAclRuleResponse"/></returns>
        public Task<DescribeAclRuleResponse> DescribeAclRule(DescribeAclRuleRequest req)
        {
            return InternalRequestAsync<DescribeAclRuleResponse>(req, "DescribeAclRule");
        }

        /// <summary>
        /// 查询ACL规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclRuleRequest"/></param>
        /// <returns><see cref="DescribeAclRuleResponse"/></returns>
        public DescribeAclRuleResponse DescribeAclRuleSync(DescribeAclRuleRequest req)
        {
            return InternalRequestAsync<DescribeAclRuleResponse>(req, "DescribeAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppInfoRequest"/></param>
        /// <returns><see cref="DescribeAppInfoResponse"/></returns>
        public Task<DescribeAppInfoResponse> DescribeAppInfo(DescribeAppInfoRequest req)
        {
            return InternalRequestAsync<DescribeAppInfoResponse>(req, "DescribeAppInfo");
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppInfoRequest"/></param>
        /// <returns><see cref="DescribeAppInfoResponse"/></returns>
        public DescribeAppInfoResponse DescribeAppInfoSync(DescribeAppInfoRequest req)
        {
            return InternalRequestAsync<DescribeAppInfoResponse>(req, "DescribeAppInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查看ckafka的可用区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCkafkaZoneRequest"/></param>
        /// <returns><see cref="DescribeCkafkaZoneResponse"/></returns>
        public Task<DescribeCkafkaZoneResponse> DescribeCkafkaZone(DescribeCkafkaZoneRequest req)
        {
            return InternalRequestAsync<DescribeCkafkaZoneResponse>(req, "DescribeCkafkaZone");
        }

        /// <summary>
        /// 用于查看ckafka的可用区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCkafkaZoneRequest"/></param>
        /// <returns><see cref="DescribeCkafkaZoneResponse"/></returns>
        public DescribeCkafkaZoneResponse DescribeCkafkaZoneSync(DescribeCkafkaZoneRequest req)
        {
            return InternalRequestAsync<DescribeCkafkaZoneResponse>(req, "DescribeCkafkaZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectResourceRequest"/></param>
        /// <returns><see cref="DescribeConnectResourceResponse"/></returns>
        public Task<DescribeConnectResourceResponse> DescribeConnectResource(DescribeConnectResourceRequest req)
        {
            return InternalRequestAsync<DescribeConnectResourceResponse>(req, "DescribeConnectResource");
        }

        /// <summary>
        /// 查询Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectResourceRequest"/></param>
        /// <returns><see cref="DescribeConnectResourceResponse"/></returns>
        public DescribeConnectResourceResponse DescribeConnectResourceSync(DescribeConnectResourceRequest req)
        {
            return InternalRequestAsync<DescribeConnectResourceResponse>(req, "DescribeConnectResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Datahub连接源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectResourcesRequest"/></param>
        /// <returns><see cref="DescribeConnectResourcesResponse"/></returns>
        public Task<DescribeConnectResourcesResponse> DescribeConnectResources(DescribeConnectResourcesRequest req)
        {
            return InternalRequestAsync<DescribeConnectResourcesResponse>(req, "DescribeConnectResources");
        }

        /// <summary>
        /// 查询Datahub连接源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectResourcesRequest"/></param>
        /// <returns><see cref="DescribeConnectResourcesResponse"/></returns>
        public DescribeConnectResourcesResponse DescribeConnectResourcesSync(DescribeConnectResourcesRequest req)
        {
            return InternalRequestAsync<DescribeConnectResourcesResponse>(req, "DescribeConnectResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询消费分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public Task<DescribeConsumerGroupResponse> DescribeConsumerGroup(DescribeConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupResponse>(req, "DescribeConsumerGroup");
        }

        /// <summary>
        /// 查询消费分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public DescribeConsumerGroupResponse DescribeConsumerGroupSync(DescribeConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupResponse>(req, "DescribeConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Datahub消费分组offset
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeDatahubGroupOffsetsResponse"/></returns>
        public Task<DescribeDatahubGroupOffsetsResponse> DescribeDatahubGroupOffsets(DescribeDatahubGroupOffsetsRequest req)
        {
            return InternalRequestAsync<DescribeDatahubGroupOffsetsResponse>(req, "DescribeDatahubGroupOffsets");
        }

        /// <summary>
        /// 获取Datahub消费分组offset
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeDatahubGroupOffsetsResponse"/></returns>
        public DescribeDatahubGroupOffsetsResponse DescribeDatahubGroupOffsetsSync(DescribeDatahubGroupOffsetsRequest req)
        {
            return InternalRequestAsync<DescribeDatahubGroupOffsetsResponse>(req, "DescribeDatahubGroupOffsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Datahub任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTaskRequest"/></param>
        /// <returns><see cref="DescribeDatahubTaskResponse"/></returns>
        public Task<DescribeDatahubTaskResponse> DescribeDatahubTask(DescribeDatahubTaskRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTaskResponse>(req, "DescribeDatahubTask");
        }

        /// <summary>
        /// 查询Datahub任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTaskRequest"/></param>
        /// <returns><see cref="DescribeDatahubTaskResponse"/></returns>
        public DescribeDatahubTaskResponse DescribeDatahubTaskSync(DescribeDatahubTaskRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTaskResponse>(req, "DescribeDatahubTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Datahub任务列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTasksRequest"/></param>
        /// <returns><see cref="DescribeDatahubTasksResponse"/></returns>
        public Task<DescribeDatahubTasksResponse> DescribeDatahubTasks(DescribeDatahubTasksRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTasksResponse>(req, "DescribeDatahubTasks");
        }

        /// <summary>
        /// 查询Datahub任务列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTasksRequest"/></param>
        /// <returns><see cref="DescribeDatahubTasksResponse"/></returns>
        public DescribeDatahubTasksResponse DescribeDatahubTasksSync(DescribeDatahubTasksRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTasksResponse>(req, "DescribeDatahubTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DIP主题属性
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicResponse"/></returns>
        public Task<DescribeDatahubTopicResponse> DescribeDatahubTopic(DescribeDatahubTopicRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTopicResponse>(req, "DescribeDatahubTopic");
        }

        /// <summary>
        /// 获取DIP主题属性
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicResponse"/></returns>
        public DescribeDatahubTopicResponse DescribeDatahubTopicSync(DescribeDatahubTopicRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTopicResponse>(req, "DescribeDatahubTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询DIP主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicsRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicsResponse"/></returns>
        public Task<DescribeDatahubTopicsResponse> DescribeDatahubTopics(DescribeDatahubTopicsRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTopicsResponse>(req, "DescribeDatahubTopics");
        }

        /// <summary>
        /// 查询DIP主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatahubTopicsRequest"/></param>
        /// <returns><see cref="DescribeDatahubTopicsResponse"/></returns>
        public DescribeDatahubTopicsResponse DescribeDatahubTopicsSync(DescribeDatahubTopicsRequest req)
        {
            return InternalRequestAsync<DescribeDatahubTopicsResponse>(req, "DescribeDatahubTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 枚举消费分组(精简版)
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup");
        }

        /// <summary>
        /// 枚举消费分组(精简版)
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public DescribeGroupResponse DescribeGroupSync(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取消费分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeGroupInfoResponse"/></returns>
        public Task<DescribeGroupInfoResponse> DescribeGroupInfo(DescribeGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeGroupInfoResponse>(req, "DescribeGroupInfo");
        }

        /// <summary>
        /// 获取消费分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeGroupInfoResponse"/></returns>
        public DescribeGroupInfoResponse DescribeGroupInfoSync(DescribeGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeGroupInfoResponse>(req, "DescribeGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取消费分组offset
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeGroupOffsetsResponse"/></returns>
        public Task<DescribeGroupOffsetsResponse> DescribeGroupOffsets(DescribeGroupOffsetsRequest req)
        {
            return InternalRequestAsync<DescribeGroupOffsetsResponse>(req, "DescribeGroupOffsets");
        }

        /// <summary>
        /// 获取消费分组offset
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupOffsetsRequest"/></param>
        /// <returns><see cref="DescribeGroupOffsetsResponse"/></returns>
        public DescribeGroupOffsetsResponse DescribeGroupOffsetsSync(DescribeGroupOffsetsRequest req)
        {
            return InternalRequestAsync<DescribeGroupOffsetsResponse>(req, "DescribeGroupOffsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例属性
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAttributesResponse"/></returns>
        public Task<DescribeInstanceAttributesResponse> DescribeInstanceAttributes(DescribeInstanceAttributesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAttributesResponse>(req, "DescribeInstanceAttributes");
        }

        /// <summary>
        /// 获取实例属性
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAttributesRequest"/></param>
        /// <returns><see cref="DescribeInstanceAttributesResponse"/></returns>
        public DescribeInstanceAttributesResponse DescribeInstanceAttributesSync(DescribeInstanceAttributesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAttributesResponse>(req, "DescribeInstanceAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstance）用于在用户账户下获取消息队列 CKafka 实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 本接口（DescribeInstance）用于在用户账户下获取消息队列 CKafka 实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户账户下获取实例列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDetailRequest"/></param>
        /// <returns><see cref="DescribeInstancesDetailResponse"/></returns>
        public Task<DescribeInstancesDetailResponse> DescribeInstancesDetail(DescribeInstancesDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDetailResponse>(req, "DescribeInstancesDetail");
        }

        /// <summary>
        /// 用户账户下获取实例列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDetailRequest"/></param>
        /// <returns><see cref="DescribeInstancesDetailResponse"/></returns>
        public DescribeInstancesDetailResponse DescribeInstancesDetailSync(DescribeInstancesDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDetailResponse>(req, "DescribeInstancesDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例Prometheus信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRequest"/></param>
        /// <returns><see cref="DescribePrometheusResponse"/></returns>
        public Task<DescribePrometheusResponse> DescribePrometheus(DescribePrometheusRequest req)
        {
            return InternalRequestAsync<DescribePrometheusResponse>(req, "DescribePrometheus");
        }

        /// <summary>
        /// 获取实例Prometheus信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRequest"/></param>
        /// <returns><see cref="DescribePrometheusResponse"/></returns>
        public DescribePrometheusResponse DescribePrometheusSync(DescribePrometheusRequest req)
        {
            return InternalRequestAsync<DescribePrometheusResponse>(req, "DescribePrometheus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 枚举地域,只支持广州地域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionRequest"/></param>
        /// <returns><see cref="DescribeRegionResponse"/></returns>
        public Task<DescribeRegionResponse> DescribeRegion(DescribeRegionRequest req)
        {
            return InternalRequestAsync<DescribeRegionResponse>(req, "DescribeRegion");
        }

        /// <summary>
        /// 枚举地域,只支持广州地域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionRequest"/></param>
        /// <returns><see cref="DescribeRegionResponse"/></returns>
        public DescribeRegionResponse DescribeRegionSync(DescribeRegionRequest req)
        {
            return InternalRequestAsync<DescribeRegionResponse>(req, "DescribeRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看路由信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteRequest"/></param>
        /// <returns><see cref="DescribeRouteResponse"/></returns>
        public Task<DescribeRouteResponse> DescribeRoute(DescribeRouteRequest req)
        {
            return InternalRequestAsync<DescribeRouteResponse>(req, "DescribeRoute");
        }

        /// <summary>
        /// 查看路由信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteRequest"/></param>
        /// <returns><see cref="DescribeRouteResponse"/></returns>
        public DescribeRouteResponse DescribeRouteSync(DescribeRouteRequest req)
        {
            return InternalRequestAsync<DescribeRouteResponse>(req, "DescribeRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// 查询任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口请求域名：https://ckafka.tencentcloudapi.com
        /// 本接口（DescribeTopic）用于在用户获取消息队列 CKafka 实例的主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public Task<DescribeTopicResponse> DescribeTopic(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic");
        }

        /// <summary>
        /// 接口请求域名：https://ckafka.tencentcloudapi.com
        /// 本接口（DescribeTopic）用于在用户获取消息队列 CKafka 实例的主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public DescribeTopicResponse DescribeTopicSync(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主题属性
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicAttributesRequest"/></param>
        /// <returns><see cref="DescribeTopicAttributesResponse"/></returns>
        public Task<DescribeTopicAttributesResponse> DescribeTopicAttributes(DescribeTopicAttributesRequest req)
        {
            return InternalRequestAsync<DescribeTopicAttributesResponse>(req, "DescribeTopicAttributes");
        }

        /// <summary>
        /// 获取主题属性
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicAttributesRequest"/></param>
        /// <returns><see cref="DescribeTopicAttributesResponse"/></returns>
        public DescribeTopicAttributesResponse DescribeTopicAttributesSync(DescribeTopicAttributesRequest req)
        {
            return InternalRequestAsync<DescribeTopicAttributesResponse>(req, "DescribeTopicAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主题列表详情（仅控制台调用）
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public Task<DescribeTopicDetailResponse> DescribeTopicDetail(DescribeTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeTopicDetailResponse>(req, "DescribeTopicDetail");
        }

        /// <summary>
        /// 获取主题列表详情（仅控制台调用）
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public DescribeTopicDetailResponse DescribeTopicDetailSync(DescribeTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeTopicDetailResponse>(req, "DescribeTopicDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Topic流量排行，消费者流量排行
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicFlowRankingRequest"/></param>
        /// <returns><see cref="DescribeTopicFlowRankingResponse"/></returns>
        public Task<DescribeTopicFlowRankingResponse> DescribeTopicFlowRanking(DescribeTopicFlowRankingRequest req)
        {
            return InternalRequestAsync<DescribeTopicFlowRankingResponse>(req, "DescribeTopicFlowRanking");
        }

        /// <summary>
        /// 获取Topic流量排行，消费者流量排行
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicFlowRankingRequest"/></param>
        /// <returns><see cref="DescribeTopicFlowRankingResponse"/></returns>
        public DescribeTopicFlowRankingResponse DescribeTopicFlowRankingSync(DescribeTopicFlowRankingRequest req)
        {
            return InternalRequestAsync<DescribeTopicFlowRankingResponse>(req, "DescribeTopicFlowRanking")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询topic 生产端连接信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicProduceConnectionRequest"/></param>
        /// <returns><see cref="DescribeTopicProduceConnectionResponse"/></returns>
        public Task<DescribeTopicProduceConnectionResponse> DescribeTopicProduceConnection(DescribeTopicProduceConnectionRequest req)
        {
            return InternalRequestAsync<DescribeTopicProduceConnectionResponse>(req, "DescribeTopicProduceConnection");
        }

        /// <summary>
        /// 查询topic 生产端连接信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicProduceConnectionRequest"/></param>
        /// <returns><see cref="DescribeTopicProduceConnectionResponse"/></returns>
        public DescribeTopicProduceConnectionResponse DescribeTopicProduceConnectionSync(DescribeTopicProduceConnectionRequest req)
        {
            return InternalRequestAsync<DescribeTopicProduceConnectionResponse>(req, "DescribeTopicProduceConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询订阅某主题消息分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSubscribeGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicSubscribeGroupResponse"/></returns>
        public Task<DescribeTopicSubscribeGroupResponse> DescribeTopicSubscribeGroup(DescribeTopicSubscribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeTopicSubscribeGroupResponse>(req, "DescribeTopicSubscribeGroup");
        }

        /// <summary>
        /// 查询订阅某主题消息分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSubscribeGroupRequest"/></param>
        /// <returns><see cref="DescribeTopicSubscribeGroupResponse"/></returns>
        public DescribeTopicSubscribeGroupResponse DescribeTopicSubscribeGroupSync(DescribeTopicSubscribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeTopicSubscribeGroupResponse>(req, "DescribeTopicSubscribeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Topic 副本详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSyncReplicaRequest"/></param>
        /// <returns><see cref="DescribeTopicSyncReplicaResponse"/></returns>
        public Task<DescribeTopicSyncReplicaResponse> DescribeTopicSyncReplica(DescribeTopicSyncReplicaRequest req)
        {
            return InternalRequestAsync<DescribeTopicSyncReplicaResponse>(req, "DescribeTopicSyncReplica");
        }

        /// <summary>
        /// 获取Topic 副本详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicSyncReplicaRequest"/></param>
        /// <returns><see cref="DescribeTopicSyncReplicaResponse"/></returns>
        public DescribeTopicSyncReplicaResponse DescribeTopicSyncReplicaSync(DescribeTopicSyncReplicaRequest req)
        {
            return InternalRequestAsync<DescribeTopicSyncReplicaResponse>(req, "DescribeTopicSyncReplica")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser");
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据指定offset位置的消息
        /// </summary>
        /// <param name="req"><see cref="FetchDatahubMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchDatahubMessageByOffsetResponse"/></returns>
        public Task<FetchDatahubMessageByOffsetResponse> FetchDatahubMessageByOffset(FetchDatahubMessageByOffsetRequest req)
        {
            return InternalRequestAsync<FetchDatahubMessageByOffsetResponse>(req, "FetchDatahubMessageByOffset");
        }

        /// <summary>
        /// 根据指定offset位置的消息
        /// </summary>
        /// <param name="req"><see cref="FetchDatahubMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchDatahubMessageByOffsetResponse"/></returns>
        public FetchDatahubMessageByOffsetResponse FetchDatahubMessageByOffsetSync(FetchDatahubMessageByOffsetRequest req)
        {
            return InternalRequestAsync<FetchDatahubMessageByOffsetResponse>(req, "FetchDatahubMessageByOffset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询最新消息列表
        /// </summary>
        /// <param name="req"><see cref="FetchLatestDatahubMessageListRequest"/></param>
        /// <returns><see cref="FetchLatestDatahubMessageListResponse"/></returns>
        public Task<FetchLatestDatahubMessageListResponse> FetchLatestDatahubMessageList(FetchLatestDatahubMessageListRequest req)
        {
            return InternalRequestAsync<FetchLatestDatahubMessageListResponse>(req, "FetchLatestDatahubMessageList");
        }

        /// <summary>
        /// 查询最新消息列表
        /// </summary>
        /// <param name="req"><see cref="FetchLatestDatahubMessageListRequest"/></param>
        /// <returns><see cref="FetchLatestDatahubMessageListResponse"/></returns>
        public FetchLatestDatahubMessageListResponse FetchLatestDatahubMessageListSync(FetchLatestDatahubMessageListRequest req)
        {
            return InternalRequestAsync<FetchLatestDatahubMessageListResponse>(req, "FetchLatestDatahubMessageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据指定offset位置的消息
        /// </summary>
        /// <param name="req"><see cref="FetchMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageByOffsetResponse"/></returns>
        public Task<FetchMessageByOffsetResponse> FetchMessageByOffset(FetchMessageByOffsetRequest req)
        {
            return InternalRequestAsync<FetchMessageByOffsetResponse>(req, "FetchMessageByOffset");
        }

        /// <summary>
        /// 根据指定offset位置的消息
        /// </summary>
        /// <param name="req"><see cref="FetchMessageByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageByOffsetResponse"/></returns>
        public FetchMessageByOffsetResponse FetchMessageByOffsetSync(FetchMessageByOffsetRequest req)
        {
            return InternalRequestAsync<FetchMessageByOffsetResponse>(req, "FetchMessageByOffset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据位点查询消息列表
        /// </summary>
        /// <param name="req"><see cref="FetchMessageListByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageListByOffsetResponse"/></returns>
        public Task<FetchMessageListByOffsetResponse> FetchMessageListByOffset(FetchMessageListByOffsetRequest req)
        {
            return InternalRequestAsync<FetchMessageListByOffsetResponse>(req, "FetchMessageListByOffset");
        }

        /// <summary>
        /// 根据位点查询消息列表
        /// </summary>
        /// <param name="req"><see cref="FetchMessageListByOffsetRequest"/></param>
        /// <returns><see cref="FetchMessageListByOffsetResponse"/></returns>
        public FetchMessageListByOffsetResponse FetchMessageListByOffsetSync(FetchMessageListByOffsetRequest req)
        {
            return InternalRequestAsync<FetchMessageListByOffsetResponse>(req, "FetchMessageListByOffset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Ckafka实例购买/续费询价
        /// </summary>
        /// <param name="req"><see cref="InquireCkafkaPriceRequest"/></param>
        /// <returns><see cref="InquireCkafkaPriceResponse"/></returns>
        public Task<InquireCkafkaPriceResponse> InquireCkafkaPrice(InquireCkafkaPriceRequest req)
        {
            return InternalRequestAsync<InquireCkafkaPriceResponse>(req, "InquireCkafkaPrice");
        }

        /// <summary>
        /// Ckafka实例购买/续费询价
        /// </summary>
        /// <param name="req"><see cref="InquireCkafkaPriceRequest"/></param>
        /// <returns><see cref="InquireCkafkaPriceResponse"/></returns>
        public InquireCkafkaPriceResponse InquireCkafkaPriceSync(InquireCkafkaPriceRequest req)
        {
            return InternalRequestAsync<InquireCkafkaPriceResponse>(req, "InquireCkafkaPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按量实例缩容
        /// </summary>
        /// <param name="req"><see cref="InstanceScalingDownRequest"/></param>
        /// <returns><see cref="InstanceScalingDownResponse"/></returns>
        public Task<InstanceScalingDownResponse> InstanceScalingDown(InstanceScalingDownRequest req)
        {
            return InternalRequestAsync<InstanceScalingDownResponse>(req, "InstanceScalingDown");
        }

        /// <summary>
        /// 按量实例缩容
        /// </summary>
        /// <param name="req"><see cref="InstanceScalingDownRequest"/></param>
        /// <returns><see cref="InstanceScalingDownResponse"/></returns>
        public InstanceScalingDownResponse InstanceScalingDownSync(InstanceScalingDownRequest req)
        {
            return InternalRequestAsync<InstanceScalingDownResponse>(req, "InstanceScalingDown")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改ACL策略，目前只支持预设规则的是否应用到新增topic这一项的修改
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRuleRequest"/></param>
        /// <returns><see cref="ModifyAclRuleResponse"/></returns>
        public Task<ModifyAclRuleResponse> ModifyAclRule(ModifyAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyAclRuleResponse>(req, "ModifyAclRule");
        }

        /// <summary>
        /// 修改ACL策略，目前只支持预设规则的是否应用到新增topic这一项的修改
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRuleRequest"/></param>
        /// <returns><see cref="ModifyAclRuleResponse"/></returns>
        public ModifyAclRuleResponse ModifyAclRuleSync(ModifyAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyAclRuleResponse>(req, "ModifyAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectResourceRequest"/></param>
        /// <returns><see cref="ModifyConnectResourceResponse"/></returns>
        public Task<ModifyConnectResourceResponse> ModifyConnectResource(ModifyConnectResourceRequest req)
        {
            return InternalRequestAsync<ModifyConnectResourceResponse>(req, "ModifyConnectResource");
        }

        /// <summary>
        /// 编辑Datahub连接源
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectResourceRequest"/></param>
        /// <returns><see cref="ModifyConnectResourceResponse"/></returns>
        public ModifyConnectResourceResponse ModifyConnectResourceSync(ModifyConnectResourceRequest req)
        {
            return InternalRequestAsync<ModifyConnectResourceResponse>(req, "ModifyConnectResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Datahub任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDatahubTaskRequest"/></param>
        /// <returns><see cref="ModifyDatahubTaskResponse"/></returns>
        public Task<ModifyDatahubTaskResponse> ModifyDatahubTask(ModifyDatahubTaskRequest req)
        {
            return InternalRequestAsync<ModifyDatahubTaskResponse>(req, "ModifyDatahubTask");
        }

        /// <summary>
        /// 修改Datahub任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDatahubTaskRequest"/></param>
        /// <returns><see cref="ModifyDatahubTaskResponse"/></returns>
        public ModifyDatahubTaskResponse ModifyDatahubTaskSync(ModifyDatahubTaskRequest req)
        {
            return InternalRequestAsync<ModifyDatahubTaskResponse>(req, "ModifyDatahubTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DIP主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDatahubTopicRequest"/></param>
        /// <returns><see cref="ModifyDatahubTopicResponse"/></returns>
        public Task<ModifyDatahubTopicResponse> ModifyDatahubTopic(ModifyDatahubTopicRequest req)
        {
            return InternalRequestAsync<ModifyDatahubTopicResponse>(req, "ModifyDatahubTopic");
        }

        /// <summary>
        /// 修改DIP主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDatahubTopicRequest"/></param>
        /// <returns><see cref="ModifyDatahubTopicResponse"/></returns>
        public ModifyDatahubTopicResponse ModifyDatahubTopicSync(ModifyDatahubTopicRequest req)
        {
            return InternalRequestAsync<ModifyDatahubTopicResponse>(req, "ModifyDatahubTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置Groups 消费分组offset
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="ModifyGroupOffsetsResponse"/></returns>
        public Task<ModifyGroupOffsetsResponse> ModifyGroupOffsets(ModifyGroupOffsetsRequest req)
        {
            return InternalRequestAsync<ModifyGroupOffsetsResponse>(req, "ModifyGroupOffsets");
        }

        /// <summary>
        /// 设置Groups 消费分组offset
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupOffsetsRequest"/></param>
        /// <returns><see cref="ModifyGroupOffsetsResponse"/></returns>
        public ModifyGroupOffsetsResponse ModifyGroupOffsetsSync(ModifyGroupOffsetsRequest req)
        {
            return InternalRequestAsync<ModifyGroupOffsetsResponse>(req, "ModifyGroupOffsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributesResponse"/></returns>
        public Task<ModifyInstanceAttributesResponse> ModifyInstanceAttributes(ModifyInstanceAttributesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAttributesResponse>(req, "ModifyInstanceAttributes");
        }

        /// <summary>
        /// 设置实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributesResponse"/></returns>
        public ModifyInstanceAttributesResponse ModifyInstanceAttributesSync(ModifyInstanceAttributesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAttributesResponse>(req, "ModifyInstanceAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 预付费实例变配接口，调整磁盘，带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePreRequest"/></param>
        /// <returns><see cref="ModifyInstancePreResponse"/></returns>
        public Task<ModifyInstancePreResponse> ModifyInstancePre(ModifyInstancePreRequest req)
        {
            return InternalRequestAsync<ModifyInstancePreResponse>(req, "ModifyInstancePre");
        }

        /// <summary>
        /// 预付费实例变配接口，调整磁盘，带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePreRequest"/></param>
        /// <returns><see cref="ModifyInstancePreResponse"/></returns>
        public ModifyInstancePreResponse ModifyInstancePreSync(ModifyInstancePreRequest req)
        {
            return InternalRequestAsync<ModifyInstancePreResponse>(req, "ModifyInstancePre")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="req"><see cref="ModifyPasswordRequest"/></param>
        /// <returns><see cref="ModifyPasswordResponse"/></returns>
        public Task<ModifyPasswordResponse> ModifyPassword(ModifyPasswordRequest req)
        {
            return InternalRequestAsync<ModifyPasswordResponse>(req, "ModifyPassword");
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="req"><see cref="ModifyPasswordRequest"/></param>
        /// <returns><see cref="ModifyPasswordResponse"/></returns>
        public ModifyPasswordResponse ModifyPasswordSync(ModifyPasswordRequest req)
        {
            return InternalRequestAsync<ModifyPasswordResponse>(req, "ModifyPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置自动化运维属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRoutineMaintenanceTaskRequest"/></param>
        /// <returns><see cref="ModifyRoutineMaintenanceTaskResponse"/></returns>
        public Task<ModifyRoutineMaintenanceTaskResponse> ModifyRoutineMaintenanceTask(ModifyRoutineMaintenanceTaskRequest req)
        {
            return InternalRequestAsync<ModifyRoutineMaintenanceTaskResponse>(req, "ModifyRoutineMaintenanceTask");
        }

        /// <summary>
        /// 设置自动化运维属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRoutineMaintenanceTaskRequest"/></param>
        /// <returns><see cref="ModifyRoutineMaintenanceTaskResponse"/></returns>
        public ModifyRoutineMaintenanceTaskResponse ModifyRoutineMaintenanceTaskSync(ModifyRoutineMaintenanceTaskRequest req)
        {
            return InternalRequestAsync<ModifyRoutineMaintenanceTaskResponse>(req, "ModifyRoutineMaintenanceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改主题属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributesResponse"/></returns>
        public Task<ModifyTopicAttributesResponse> ModifyTopicAttributes(ModifyTopicAttributesRequest req)
        {
            return InternalRequestAsync<ModifyTopicAttributesResponse>(req, "ModifyTopicAttributes");
        }

        /// <summary>
        /// 本接口用于修改主题属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicAttributesRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributesResponse"/></returns>
        public ModifyTopicAttributesResponse ModifyTopicAttributesSync(ModifyTopicAttributesRequest req)
        {
            return InternalRequestAsync<ModifyTopicAttributesResponse>(req, "ModifyTopicAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续费Ckafka实例, 目前只支持国内站包年包月实例续费
        /// </summary>
        /// <param name="req"><see cref="RenewCkafkaInstanceRequest"/></param>
        /// <returns><see cref="RenewCkafkaInstanceResponse"/></returns>
        public Task<RenewCkafkaInstanceResponse> RenewCkafkaInstance(RenewCkafkaInstanceRequest req)
        {
            return InternalRequestAsync<RenewCkafkaInstanceResponse>(req, "RenewCkafkaInstance");
        }

        /// <summary>
        /// 续费Ckafka实例, 目前只支持国内站包年包月实例续费
        /// </summary>
        /// <param name="req"><see cref="RenewCkafkaInstanceRequest"/></param>
        /// <returns><see cref="RenewCkafkaInstanceResponse"/></returns>
        public RenewCkafkaInstanceResponse RenewCkafkaInstanceSync(RenewCkafkaInstanceRequest req)
        {
            return InternalRequestAsync<RenewCkafkaInstanceResponse>(req, "RenewCkafkaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过HTTP接入层发送消息
        /// </summary>
        /// <param name="req"><see cref="SendMessageRequest"/></param>
        /// <returns><see cref="SendMessageResponse"/></returns>
        public Task<SendMessageResponse> SendMessage(SendMessageRequest req)
        {
            return InternalRequestAsync<SendMessageResponse>(req, "SendMessage");
        }

        /// <summary>
        /// 通过HTTP接入层发送消息
        /// </summary>
        /// <param name="req"><see cref="SendMessageRequest"/></param>
        /// <returns><see cref="SendMessageResponse"/></returns>
        public SendMessageResponse SendMessageSync(SendMessageRequest req)
        {
            return InternalRequestAsync<SendMessageResponse>(req, "SendMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
