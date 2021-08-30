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

    }
}
