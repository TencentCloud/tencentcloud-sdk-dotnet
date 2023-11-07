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
        /// 本接口用于申请并发。接口超时时间：20秒。
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
        /// 本接口用于申请并发。接口超时时间：20秒。
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
        /// 本接口用于创建会话。接口超时时间：5秒。
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
        /// 本接口用于创建会话。接口超时时间：5秒。
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
        /// 销毁会话。如果该会话开启了云端推流，那么销毁会话时会结束云端推流。
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
        /// 销毁会话。如果该会话开启了云端推流，那么销毁会话时会结束云端推流。
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
        /// 开始云端推流到指定URL。该推流方式需要单独计费，详细计费方式请查看[指定地址推流费用说明](https://cloud.tencent.com/document/product/1547/72168#98ac188a-d122-4caf-88be-05268ecefdf6)
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamWithURLRequest"/></param>
        /// <returns><see cref="StartPublishStreamWithURLResponse"/></returns>
        public async Task<StartPublishStreamWithURLResponse> StartPublishStreamWithURL(StartPublishStreamWithURLRequest req)
        {
             JsonResponseModel<StartPublishStreamWithURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartPublishStreamWithURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartPublishStreamWithURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开始云端推流到指定URL。该推流方式需要单独计费，详细计费方式请查看[指定地址推流费用说明](https://cloud.tencent.com/document/product/1547/72168#98ac188a-d122-4caf-88be-05268ecefdf6)
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamWithURLRequest"/></param>
        /// <returns><see cref="StartPublishStreamWithURLResponse"/></returns>
        public StartPublishStreamWithURLResponse StartPublishStreamWithURLSync(StartPublishStreamWithURLRequest req)
        {
             JsonResponseModel<StartPublishStreamWithURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartPublishStreamWithURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartPublishStreamWithURLResponse>>(strResp);
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
