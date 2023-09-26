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

namespace TencentCloud.Trocket.V20230308
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trocket.V20230308.Models;

   public class TrocketClient : AbstractClient{

       private const string endpoint = "trocket.tencentcloudapi.com";
       private const string version = "2023-03-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrocketClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrocketClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建消费组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroup(CreateConsumerGroupRequest req)
        {
             JsonResponseModel<CreateConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsumerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建消费组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public CreateConsumerGroupResponse CreateConsumerGroupSync(CreateConsumerGroupRequest req)
        {
             JsonResponseModel<CreateConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsumerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买新实例
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
        /// 购买新实例
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
        /// 添加角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public async Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
             JsonResponseModel<CreateRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
             JsonResponseModel<CreateRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建主题
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
        /// 创建主题
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
        /// 删除消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroup(DeleteConsumerGroupRequest req)
        {
             JsonResponseModel<DeleteConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConsumerGroupResponse>>(strResp);
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
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public DeleteConsumerGroupResponse DeleteConsumerGroupSync(DeleteConsumerGroupRequest req)
        {
             JsonResponseModel<DeleteConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConsumerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例
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
        /// 删除实例
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
        /// 删除角色
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public async Task<DeleteRoleResponse> DeleteRole(DeleteRoleRequest req)
        {
             JsonResponseModel<DeleteRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public DeleteRoleResponse DeleteRoleSync(DeleteRoleRequest req)
        {
             JsonResponseModel<DeleteRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除主题
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
        /// 删除主题
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
        /// 查询消费组详情
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
        /// 查询消费组详情
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
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public async Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
             JsonResponseModel<DescribeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
             JsonResponseModel<DescribeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例列表，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，实例ID查询
        /// 3. InstanceType, 实例类型查询，支持多选
        /// 3. InstanceStatus，实例状态查询，支持多选
        /// 
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public async Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
             JsonResponseModel<DescribeInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例列表，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，实例ID查询
        /// 3. InstanceType, 实例类型查询，支持多选
        /// 3. InstanceStatus，实例状态查询，支持多选
        /// 
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
             JsonResponseModel<DescribeInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询角色列表，Filter参数使用说明如下：
        /// 
        /// 1. RoleName，角色名称模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public async Task<DescribeRoleListResponse> DescribeRoleList(DescribeRoleListRequest req)
        {
             JsonResponseModel<DescribeRoleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询角色列表，Filter参数使用说明如下：
        /// 
        /// 1. RoleName，角色名称模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public DescribeRoleListResponse DescribeRoleListSync(DescribeRoleListRequest req)
        {
             JsonResponseModel<DescribeRoleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主题详情，Offset和Limit参数是指订阅该主题的消费组查询分页参数，Filter参数使用说明如下：
        /// 
        /// ConsumerGroup，消费组名称过滤
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
        /// 查询主题详情，Offset和Limit参数是指订阅该主题的消费组查询分页参数，Filter参数使用说明如下：
        /// 
        /// ConsumerGroup，消费组名称过滤
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
        /// 获取主题列表，Filter参数使用说明如下：
        /// 
        /// 1. TopicName，主题名称模糊搜索
        /// 2. TopicType，主题类型查询，支持多选，可选值：Normal,Order,Transaction,DelayScheduled
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListRequest"/></param>
        /// <returns><see cref="DescribeTopicListResponse"/></returns>
        public async Task<DescribeTopicListResponse> DescribeTopicList(DescribeTopicListRequest req)
        {
             JsonResponseModel<DescribeTopicListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主题列表，Filter参数使用说明如下：
        /// 
        /// 1. TopicName，主题名称模糊搜索
        /// 2. TopicType，主题类型查询，支持多选，可选值：Normal,Order,Transaction,DelayScheduled
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListRequest"/></param>
        /// <returns><see cref="DescribeTopicListResponse"/></returns>
        public DescribeTopicListResponse DescribeTopicListSync(DescribeTopicListRequest req)
        {
             JsonResponseModel<DescribeTopicListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运营端查询topicStata
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicStatsOpRequest"/></param>
        /// <returns><see cref="DescribeTopicStatsOpResponse"/></returns>
        public async Task<DescribeTopicStatsOpResponse> DescribeTopicStatsOp(DescribeTopicStatsOpRequest req)
        {
             JsonResponseModel<DescribeTopicStatsOpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicStatsOp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicStatsOpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运营端查询topicStata
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicStatsOpRequest"/></param>
        /// <returns><see cref="DescribeTopicStatsOpResponse"/></returns>
        public DescribeTopicStatsOpResponse DescribeTopicStatsOpSync(DescribeTopicStatsOpRequest req)
        {
             JsonResponseModel<DescribeTopicStatsOpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicStatsOp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicStatsOpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改消费组属性
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupResponse"/></returns>
        public async Task<ModifyConsumerGroupResponse> ModifyConsumerGroup(ModifyConsumerGroupRequest req)
        {
             JsonResponseModel<ModifyConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConsumerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改消费组属性
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupResponse"/></returns>
        public ModifyConsumerGroupResponse ModifyConsumerGroupSync(ModifyConsumerGroupRequest req)
        {
             JsonResponseModel<ModifyConsumerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyConsumerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConsumerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public async Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public async Task<ModifyRoleResponse> ModifyRole(ModifyRoleRequest req)
        {
             JsonResponseModel<ModifyRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public ModifyRoleResponse ModifyRoleSync(ModifyRoleRequest req)
        {
             JsonResponseModel<ModifyRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public async Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
