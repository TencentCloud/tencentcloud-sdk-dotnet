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
       private const string sdkVersion = "SDK_NET_3.0.1153";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
        /// 获取并发总数和运行数
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesCountRequest"/></param>
        /// <returns><see cref="DescribeInstancesCountResponse"/></returns>
        public Task<DescribeInstancesCountResponse> DescribeInstancesCount(DescribeInstancesCountRequest req)
        {
            return InternalRequestAsync<DescribeInstancesCountResponse>(req, "DescribeInstancesCount");
        }

        /// <summary>
        /// 获取并发总数和运行数
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesCountRequest"/></param>
        /// <returns><see cref="DescribeInstancesCountResponse"/></returns>
        public DescribeInstancesCountResponse DescribeInstancesCountSync(DescribeInstancesCountRequest req)
        {
            return InternalRequestAsync<DescribeInstancesCountResponse>(req, "DescribeInstancesCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 保存游戏存档
        /// </summary>
        /// <param name="req"><see cref="SaveGameArchiveRequest"/></param>
        /// <returns><see cref="SaveGameArchiveResponse"/></returns>
        public Task<SaveGameArchiveResponse> SaveGameArchive(SaveGameArchiveRequest req)
        {
            return InternalRequestAsync<SaveGameArchiveResponse>(req, "SaveGameArchive");
        }

        /// <summary>
        /// 保存游戏存档
        /// </summary>
        /// <param name="req"><see cref="SaveGameArchiveRequest"/></param>
        /// <returns><see cref="SaveGameArchiveResponse"/></returns>
        public SaveGameArchiveResponse SaveGameArchiveSync(SaveGameArchiveRequest req)
        {
            return InternalRequestAsync<SaveGameArchiveResponse>(req, "SaveGameArchive")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public Task<StartPublishStreamResponse> StartPublishStream(StartPublishStreamRequest req)
        {
            return InternalRequestAsync<StartPublishStreamResponse>(req, "StartPublishStream");
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public StartPublishStreamResponse StartPublishStreamSync(StartPublishStreamRequest req)
        {
            return InternalRequestAsync<StartPublishStreamResponse>(req, "StartPublishStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamToCSSRequest"/></param>
        /// <returns><see cref="StartPublishStreamToCSSResponse"/></returns>
        public Task<StartPublishStreamToCSSResponse> StartPublishStreamToCSS(StartPublishStreamToCSSRequest req)
        {
            return InternalRequestAsync<StartPublishStreamToCSSResponse>(req, "StartPublishStreamToCSS");
        }

        /// <summary>
        /// 开始云端推流
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamToCSSRequest"/></param>
        /// <returns><see cref="StartPublishStreamToCSSResponse"/></returns>
        public StartPublishStreamToCSSResponse StartPublishStreamToCSSSync(StartPublishStreamToCSSRequest req)
        {
            return InternalRequestAsync<StartPublishStreamToCSSResponse>(req, "StartPublishStreamToCSS")
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

        /// <summary>
        /// 停止云端推流
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public Task<StopPublishStreamResponse> StopPublishStream(StopPublishStreamRequest req)
        {
            return InternalRequestAsync<StopPublishStreamResponse>(req, "StopPublishStream");
        }

        /// <summary>
        /// 停止云端推流
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public StopPublishStreamResponse StopPublishStreamSync(StopPublishStreamRequest req)
        {
            return InternalRequestAsync<StopPublishStreamResponse>(req, "StopPublishStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换游戏存档
        /// </summary>
        /// <param name="req"><see cref="SwitchGameArchiveRequest"/></param>
        /// <returns><see cref="SwitchGameArchiveResponse"/></returns>
        public Task<SwitchGameArchiveResponse> SwitchGameArchive(SwitchGameArchiveRequest req)
        {
            return InternalRequestAsync<SwitchGameArchiveResponse>(req, "SwitchGameArchive");
        }

        /// <summary>
        /// 切换游戏存档
        /// </summary>
        /// <param name="req"><see cref="SwitchGameArchiveRequest"/></param>
        /// <returns><see cref="SwitchGameArchiveResponse"/></returns>
        public SwitchGameArchiveResponse SwitchGameArchiveSync(SwitchGameArchiveRequest req)
        {
            return InternalRequestAsync<SwitchGameArchiveResponse>(req, "SwitchGameArchive")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 尝试锁定机器
        /// </summary>
        /// <param name="req"><see cref="TrylockWorkerRequest"/></param>
        /// <returns><see cref="TrylockWorkerResponse"/></returns>
        public Task<TrylockWorkerResponse> TrylockWorker(TrylockWorkerRequest req)
        {
            return InternalRequestAsync<TrylockWorkerResponse>(req, "TrylockWorker");
        }

        /// <summary>
        /// 尝试锁定机器
        /// </summary>
        /// <param name="req"><see cref="TrylockWorkerRequest"/></param>
        /// <returns><see cref="TrylockWorkerResponse"/></returns>
        public TrylockWorkerResponse TrylockWorkerSync(TrylockWorkerRequest req)
        {
            return InternalRequestAsync<TrylockWorkerResponse>(req, "TrylockWorker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
