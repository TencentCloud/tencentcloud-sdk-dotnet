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

namespace TencentCloud.Cmq.V20190304
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cmq.V20190304.Models;

   public class CmqClient : AbstractClient{

       private const string endpoint = "cmq.tencentcloudapi.com";
       private const string version = "2019-03-04";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CmqClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CmqClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 清除queue中的所有消息
        /// </summary>
        /// <param name="req"><see cref="ClearQueueRequest"/></param>
        /// <returns><see cref="ClearQueueResponse"/></returns>
        public async Task<ClearQueueResponse> ClearQueue(ClearQueueRequest req)
        {
             JsonResponseModel<ClearQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清除queue中的所有消息
        /// </summary>
        /// <param name="req"><see cref="ClearQueueRequest"/></param>
        /// <returns><see cref="ClearQueueResponse"/></returns>
        public ClearQueueResponse ClearQueueSync(ClearQueueRequest req)
        {
             JsonResponseModel<ClearQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清空订阅者消息标签
        /// </summary>
        /// <param name="req"><see cref="ClearSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearSubscriptionFilterTagsResponse"/></returns>
        public async Task<ClearSubscriptionFilterTagsResponse> ClearSubscriptionFilterTags(ClearSubscriptionFilterTagsRequest req)
        {
             JsonResponseModel<ClearSubscriptionFilterTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearSubscriptionFilterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearSubscriptionFilterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清空订阅者消息标签
        /// </summary>
        /// <param name="req"><see cref="ClearSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearSubscriptionFilterTagsResponse"/></returns>
        public ClearSubscriptionFilterTagsResponse ClearSubscriptionFilterTagsSync(ClearSubscriptionFilterTagsRequest req)
        {
             JsonResponseModel<ClearSubscriptionFilterTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearSubscriptionFilterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearSubscriptionFilterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建队列接口
        /// </summary>
        /// <param name="req"><see cref="CreateQueueRequest"/></param>
        /// <returns><see cref="CreateQueueResponse"/></returns>
        public async Task<CreateQueueResponse> CreateQueue(CreateQueueRequest req)
        {
             JsonResponseModel<CreateQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建队列接口
        /// </summary>
        /// <param name="req"><see cref="CreateQueueRequest"/></param>
        /// <returns><see cref="CreateQueueResponse"/></returns>
        public CreateQueueResponse CreateQueueSync(CreateQueueRequest req)
        {
             JsonResponseModel<CreateQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建订阅接口
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public async Task<CreateSubscribeResponse> CreateSubscribe(CreateSubscribeRequest req)
        {
             JsonResponseModel<CreateSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建订阅接口
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public CreateSubscribeResponse CreateSubscribeSync(CreateSubscribeRequest req)
        {
             JsonResponseModel<CreateSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubscribeResponse>>(strResp);
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
        /// DeleteQueue
        /// </summary>
        /// <param name="req"><see cref="DeleteQueueRequest"/></param>
        /// <returns><see cref="DeleteQueueResponse"/></returns>
        public async Task<DeleteQueueResponse> DeleteQueue(DeleteQueueRequest req)
        {
             JsonResponseModel<DeleteQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteQueue
        /// </summary>
        /// <param name="req"><see cref="DeleteQueueRequest"/></param>
        /// <returns><see cref="DeleteQueueResponse"/></returns>
        public DeleteQueueResponse DeleteQueueSync(DeleteQueueRequest req)
        {
             JsonResponseModel<DeleteQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscribeRequest"/></param>
        /// <returns><see cref="DeleteSubscribeResponse"/></returns>
        public async Task<DeleteSubscribeResponse> DeleteSubscribe(DeleteSubscribeRequest req)
        {
             JsonResponseModel<DeleteSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscribeRequest"/></param>
        /// <returns><see cref="DeleteSubscribeResponse"/></returns>
        public DeleteSubscribeResponse DeleteSubscribeSync(DeleteSubscribeRequest req)
        {
             JsonResponseModel<DeleteSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSubscribeResponse>>(strResp);
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
        /// 枚举死信队列源队列
        /// </summary>
        /// <param name="req"><see cref="DescribeDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeDeadLetterSourceQueuesResponse"/></returns>
        public async Task<DescribeDeadLetterSourceQueuesResponse> DescribeDeadLetterSourceQueues(DescribeDeadLetterSourceQueuesRequest req)
        {
             JsonResponseModel<DescribeDeadLetterSourceQueuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeadLetterSourceQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeadLetterSourceQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举死信队列源队列
        /// </summary>
        /// <param name="req"><see cref="DescribeDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeDeadLetterSourceQueuesResponse"/></returns>
        public DescribeDeadLetterSourceQueuesResponse DescribeDeadLetterSourceQueuesSync(DescribeDeadLetterSourceQueuesRequest req)
        {
             JsonResponseModel<DescribeDeadLetterSourceQueuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeadLetterSourceQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeadLetterSourceQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举队列
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeQueueDetailResponse"/></returns>
        public async Task<DescribeQueueDetailResponse> DescribeQueueDetail(DescribeQueueDetailRequest req)
        {
             JsonResponseModel<DescribeQueueDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQueueDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQueueDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举队列
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeQueueDetailResponse"/></returns>
        public DescribeQueueDetailResponse DescribeQueueDetailSync(DescribeQueueDetailRequest req)
        {
             JsonResponseModel<DescribeQueueDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQueueDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQueueDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订阅详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionDetailResponse"/></returns>
        public async Task<DescribeSubscriptionDetailResponse> DescribeSubscriptionDetail(DescribeSubscriptionDetailRequest req)
        {
             JsonResponseModel<DescribeSubscriptionDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubscriptionDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscriptionDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订阅详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionDetailResponse"/></returns>
        public DescribeSubscriptionDetailResponse DescribeSubscriptionDetailSync(DescribeSubscriptionDetailRequest req)
        {
             JsonResponseModel<DescribeSubscriptionDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubscriptionDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscriptionDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主题详情 
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
        /// 查询主题详情 
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
        /// 修改队列属性
        /// </summary>
        /// <param name="req"><see cref="ModifyQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyQueueAttributeResponse"/></returns>
        public async Task<ModifyQueueAttributeResponse> ModifyQueueAttribute(ModifyQueueAttributeRequest req)
        {
             JsonResponseModel<ModifyQueueAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyQueueAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyQueueAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改队列属性
        /// </summary>
        /// <param name="req"><see cref="ModifyQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyQueueAttributeResponse"/></returns>
        public ModifyQueueAttributeResponse ModifyQueueAttributeSync(ModifyQueueAttributeRequest req)
        {
             JsonResponseModel<ModifyQueueAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyQueueAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyQueueAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改订阅属性
        /// </summary>
        /// <param name="req"><see cref="ModifySubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifySubscriptionAttributeResponse"/></returns>
        public async Task<ModifySubscriptionAttributeResponse> ModifySubscriptionAttribute(ModifySubscriptionAttributeRequest req)
        {
             JsonResponseModel<ModifySubscriptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubscriptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscriptionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改订阅属性
        /// </summary>
        /// <param name="req"><see cref="ModifySubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifySubscriptionAttributeResponse"/></returns>
        public ModifySubscriptionAttributeResponse ModifySubscriptionAttributeSync(ModifySubscriptionAttributeRequest req)
        {
             JsonResponseModel<ModifySubscriptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubscriptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscriptionAttributeResponse>>(strResp);
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
        /// <param name="req"><see cref="ModifyTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributeResponse"/></returns>
        public async Task<ModifyTopicAttributeResponse> ModifyTopicAttribute(ModifyTopicAttributeRequest req)
        {
             JsonResponseModel<ModifyTopicAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopicAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicAttributeResponse>>(strResp);
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
        /// <param name="req"><see cref="ModifyTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyTopicAttributeResponse"/></returns>
        public ModifyTopicAttributeResponse ModifyTopicAttributeSync(ModifyTopicAttributeRequest req)
        {
             JsonResponseModel<ModifyTopicAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopicAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回溯队列
        /// </summary>
        /// <param name="req"><see cref="RewindQueueRequest"/></param>
        /// <returns><see cref="RewindQueueResponse"/></returns>
        public async Task<RewindQueueResponse> RewindQueue(RewindQueueRequest req)
        {
             JsonResponseModel<RewindQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RewindQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RewindQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回溯队列
        /// </summary>
        /// <param name="req"><see cref="RewindQueueRequest"/></param>
        /// <returns><see cref="RewindQueueResponse"/></returns>
        public RewindQueueResponse RewindQueueSync(RewindQueueRequest req)
        {
             JsonResponseModel<RewindQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RewindQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RewindQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑死信队列
        /// </summary>
        /// <param name="req"><see cref="UnbindDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindDeadLetterResponse"/></returns>
        public async Task<UnbindDeadLetterResponse> UnbindDeadLetter(UnbindDeadLetterRequest req)
        {
             JsonResponseModel<UnbindDeadLetterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindDeadLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDeadLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑死信队列
        /// </summary>
        /// <param name="req"><see cref="UnbindDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindDeadLetterResponse"/></returns>
        public UnbindDeadLetterResponse UnbindDeadLetterSync(UnbindDeadLetterRequest req)
        {
             JsonResponseModel<UnbindDeadLetterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindDeadLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDeadLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
