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

namespace TencentCloud.Gs.V20191118
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gs.V20191118.Models;

   public class GsClient : AbstractClient{

       private const string endpoint = "gs.tencentcloudapi.com";
       private const string version = "2019-11-18";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

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
        /// 强制退出游戏
        /// </summary>
        /// <param name="req"><see cref="StopGameRequest"/></param>
        /// <returns><see cref="StopGameResponse"/></returns>
        public async Task<StopGameResponse> StopGame(StopGameRequest req)
        {
             JsonResponseModel<StopGameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopGame");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopGameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 强制退出游戏
        /// </summary>
        /// <param name="req"><see cref="StopGameRequest"/></param>
        /// <returns><see cref="StopGameResponse"/></returns>
        public StopGameResponse StopGameSync(StopGameRequest req)
        {
             JsonResponseModel<StopGameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopGame");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopGameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 尝试锁定机器
        /// </summary>
        /// <param name="req"><see cref="TrylockWorkerRequest"/></param>
        /// <returns><see cref="TrylockWorkerResponse"/></returns>
        public async Task<TrylockWorkerResponse> TrylockWorker(TrylockWorkerRequest req)
        {
             JsonResponseModel<TrylockWorkerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TrylockWorker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TrylockWorkerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 尝试锁定机器
        /// </summary>
        /// <param name="req"><see cref="TrylockWorkerRequest"/></param>
        /// <returns><see cref="TrylockWorkerResponse"/></returns>
        public TrylockWorkerResponse TrylockWorkerSync(TrylockWorkerRequest req)
        {
             JsonResponseModel<TrylockWorkerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TrylockWorker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TrylockWorkerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
