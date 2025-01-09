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
       private const string sdkVersion = "SDK_NET_3.0.1161";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CmqClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 枚举队列列表
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeQueueDetailResponse"/></returns>
        public Task<DescribeQueueDetailResponse> DescribeQueueDetail(DescribeQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeQueueDetailResponse>(req, "DescribeQueueDetail");
        }

        /// <summary>
        /// 枚举队列列表
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeQueueDetailResponse"/></returns>
        public DescribeQueueDetailResponse DescribeQueueDetailSync(DescribeQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeQueueDetailResponse>(req, "DescribeQueueDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public Task<DescribeTopicDetailResponse> DescribeTopicDetail(DescribeTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeTopicDetailResponse>(req, "DescribeTopicDetail");
        }

        /// <summary>
        /// 查询主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeTopicDetailResponse"/></returns>
        public DescribeTopicDetailResponse DescribeTopicDetailSync(DescribeTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeTopicDetailResponse>(req, "DescribeTopicDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
