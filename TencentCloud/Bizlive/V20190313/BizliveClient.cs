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
       private const string sdkVersion = "SDK_NET_3.0.1100";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BizliveClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建会话
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public Task<CreateSessionResponse> CreateSession(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession");
        }

        /// <summary>
        /// 创建会话
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public CreateSessionResponse CreateSessionSync(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询播放数据，支持按流名称查询详细播放数据，也可按播放域名查询详细总数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public Task<DescribeStreamPlayInfoListResponse> DescribeStreamPlayInfoList(DescribeStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPlayInfoListResponse>(req, "DescribeStreamPlayInfoList");
        }

        /// <summary>
        /// 查询播放数据，支持按流名称查询详细播放数据，也可按播放域名查询详细总数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPlayInfoListRequest"/></param>
        /// <returns><see cref="DescribeStreamPlayInfoListResponse"/></returns>
        public DescribeStreamPlayInfoListResponse DescribeStreamPlayInfoListSync(DescribeStreamPlayInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStreamPlayInfoListResponse>(req, "DescribeStreamPlayInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询空闲机器数量
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkersRequest"/></param>
        /// <returns><see cref="DescribeWorkersResponse"/></returns>
        public Task<DescribeWorkersResponse> DescribeWorkers(DescribeWorkersRequest req)
        {
            return InternalRequestAsync<DescribeWorkersResponse>(req, "DescribeWorkers");
        }

        /// <summary>
        /// 查询空闲机器数量
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkersRequest"/></param>
        /// <returns><see cref="DescribeWorkersResponse"/></returns>
        public DescribeWorkersResponse DescribeWorkersSync(DescribeWorkersRequest req)
        {
            return InternalRequestAsync<DescribeWorkersResponse>(req, "DescribeWorkers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public Task<ForbidLiveStreamResponse> ForbidLiveStream(ForbidLiveStreamRequest req)
        {
            return InternalRequestAsync<ForbidLiveStreamResponse>(req, "ForbidLiveStream");
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复。
        /// </summary>
        /// <param name="req"><see cref="ForbidLiveStreamRequest"/></param>
        /// <returns><see cref="ForbidLiveStreamResponse"/></returns>
        public ForbidLiveStreamResponse ForbidLiveStreamSync(ForbidLiveStreamRequest req)
        {
            return InternalRequestAsync<ForbidLiveStreamResponse>(req, "ForbidLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册聊天室
        /// </summary>
        /// <param name="req"><see cref="RegisterIMRequest"/></param>
        /// <returns><see cref="RegisterIMResponse"/></returns>
        public Task<RegisterIMResponse> RegisterIM(RegisterIMRequest req)
        {
            return InternalRequestAsync<RegisterIMResponse>(req, "RegisterIM");
        }

        /// <summary>
        /// 注册聊天室
        /// </summary>
        /// <param name="req"><see cref="RegisterIMRequest"/></param>
        /// <returns><see cref="RegisterIMResponse"/></returns>
        public RegisterIMResponse RegisterIMSync(RegisterIMRequest req)
        {
            return InternalRequestAsync<RegisterIMResponse>(req, "RegisterIM")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 强制退出游戏
        /// </summary>
        /// <param name="req"><see cref="StopGameRequest"/></param>
        /// <returns><see cref="StopGameResponse"/></returns>
        public Task<StopGameResponse> StopGame(StopGameRequest req)
        {
            return InternalRequestAsync<StopGameResponse>(req, "StopGame");
        }

        /// <summary>
        /// 强制退出游戏
        /// </summary>
        /// <param name="req"><see cref="StopGameRequest"/></param>
        /// <returns><see cref="StopGameResponse"/></returns>
        public StopGameResponse StopGameSync(StopGameRequest req)
        {
            return InternalRequestAsync<StopGameResponse>(req, "StopGame")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
