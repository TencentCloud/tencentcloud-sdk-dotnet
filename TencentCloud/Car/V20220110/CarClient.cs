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

namespace TencentCloud.Car.V20220110
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Car.V20220110.Models;

   public class CarClient : AbstractClient{

       private const string endpoint = "car.tencentcloudapi.com";
       private const string version = "2022-01-10";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CarClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CarClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请并发
        /// </summary>
        /// <param name="req"><see cref="ApplyConcurrentRequest"/></param>
        /// <returns><see cref="ApplyConcurrentResponse"/></returns>
        public async Task<ApplyConcurrentResponse> ApplyConcurrent(ApplyConcurrentRequest req)
        {
             JsonResponseModel<ApplyConcurrentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyConcurrent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyConcurrentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请并发
        /// </summary>
        /// <param name="req"><see cref="ApplyConcurrentRequest"/></param>
        /// <returns><see cref="ApplyConcurrentResponse"/></returns>
        public ApplyConcurrentResponse ApplyConcurrentSync(ApplyConcurrentRequest req)
        {
             JsonResponseModel<ApplyConcurrentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyConcurrent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyConcurrentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建会话
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public async Task<CreateSessionResponse> CreateSession(CreateSessionRequest req)
        {
             JsonResponseModel<CreateSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建会话
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public CreateSessionResponse CreateSessionSync(CreateSessionRequest req)
        {
             JsonResponseModel<CreateSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁会话
        /// </summary>
        /// <param name="req"><see cref="DestroySessionRequest"/></param>
        /// <returns><see cref="DestroySessionResponse"/></returns>
        public async Task<DestroySessionResponse> DestroySession(DestroySessionRequest req)
        {
             JsonResponseModel<DestroySessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroySession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroySessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁会话
        /// </summary>
        /// <param name="req"><see cref="DestroySessionRequest"/></param>
        /// <returns><see cref="DestroySessionResponse"/></returns>
        public DestroySessionResponse DestroySessionSync(DestroySessionRequest req)
        {
             JsonResponseModel<DestroySessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroySession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroySessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public async Task<StartPublishStreamResponse> StartPublishStream(StartPublishStreamRequest req)
        {
             JsonResponseModel<StartPublishStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartPublishStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartPublishStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public StartPublishStreamResponse StartPublishStreamSync(StartPublishStreamRequest req)
        {
             JsonResponseModel<StartPublishStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartPublishStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartPublishStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止云端推流
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public async Task<StopPublishStreamResponse> StopPublishStream(StopPublishStreamRequest req)
        {
             JsonResponseModel<StopPublishStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopPublishStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopPublishStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止云端推流
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public StopPublishStreamResponse StopPublishStreamSync(StopPublishStreamRequest req)
        {
             JsonResponseModel<StopPublishStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopPublishStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopPublishStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
