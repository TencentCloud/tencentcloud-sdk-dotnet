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

namespace TencentCloud.Bizlive.V20190313
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bizlive.V20190313.Models;

   public class BizliveClient : AbstractClient{

       private const string endpoint = "bizlive.tencentcloudapi.com";
       private const string version = "2019-03-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BizliveClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BizliveClient(Credential credential, string region, ClientProfile profile)
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
        /// 查询播放数据，支持按流名称查询详细播放数据，也可按播放域名查询详细总数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public async Task<DescribeStreamPlayInfoListResponse> DescribeStreamPlayInfoList(DescribeStreamPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询播放数据，支持按流名称查询详细播放数据，也可按播放域名查询详细总数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public DescribeStreamPlayInfoListResponse DescribeStreamPlayInfoListSync(DescribeStreamPlayInfoListRequest req)
        {
             JsonResponseModel<DescribeStreamPlayInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamPlayInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPlayInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询空闲机器数量
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkersRequest"/></param>
        /// <returns><see cref="DescribeWorkersResponse"/></returns>
        public async Task<DescribeWorkersResponse> DescribeWorkers(DescribeWorkersRequest req)
        {
             JsonResponseModel<DescribeWorkersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询空闲机器数量
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkersRequest"/></param>
        /// <returns><see cref="DescribeWorkersResponse"/></returns>
        public DescribeWorkersResponse DescribeWorkersSync(DescribeWorkersRequest req)
        {
             JsonResponseModel<DescribeWorkersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public async Task<ForbidLiveStreamResponse> ForbidLiveStream(ForbidLiveStreamRequest req)
        {
             JsonResponseModel<ForbidLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForbidLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public ForbidLiveStreamResponse ForbidLiveStreamSync(ForbidLiveStreamRequest req)
        {
             JsonResponseModel<ForbidLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForbidLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册聊天室
        /// </summary>
        /// <param name="req"><see cref="RegisterIMRequest"/></param>
        /// <returns><see cref="RegisterIMResponse"/></returns>
        public async Task<RegisterIMResponse> RegisterIM(RegisterIMRequest req)
        {
             JsonResponseModel<RegisterIMResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterIM");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterIMResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册聊天室
        /// </summary>
        /// <param name="req"><see cref="RegisterIMRequest"/></param>
        /// <returns><see cref="RegisterIMResponse"/></returns>
        public RegisterIMResponse RegisterIMSync(RegisterIMRequest req)
        {
             JsonResponseModel<RegisterIMResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterIM");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterIMResponse>>(strResp);
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

    }
}
