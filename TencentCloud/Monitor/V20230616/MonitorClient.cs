/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Monitor.V20230616
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Monitor.V20230616.Models;

   public class MonitorClient : AbstractClient{

       private const string endpoint = "monitor.tencentcloudapi.com";
       private const string version = "2023-06-16";
       private const string sdkVersion = "SDK_NET_3.0.1331";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MonitorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 按需查询告警的通知历史
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNotifyHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNotifyHistoriesResponse"/></returns>
        public Task<DescribeAlarmNotifyHistoriesResponse> DescribeAlarmNotifyHistories(DescribeAlarmNotifyHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNotifyHistoriesResponse>(req, "DescribeAlarmNotifyHistories");
        }

        /// <summary>
        /// 按需查询告警的通知历史
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNotifyHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNotifyHistoriesResponse"/></returns>
        public DescribeAlarmNotifyHistoriesResponse DescribeAlarmNotifyHistoriesSync(DescribeAlarmNotifyHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNotifyHistoriesResponse>(req, "DescribeAlarmNotifyHistories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
