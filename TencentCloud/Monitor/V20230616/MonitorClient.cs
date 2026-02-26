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
       private const string sdkVersion = "SDK_NET_3.0.1378";

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
        /// 创建自定义通知内容模板
        /// </summary>
        /// <param name="req"><see cref="CreateNoticeContentTmplRequest"/></param>
        /// <returns><see cref="CreateNoticeContentTmplResponse"/></returns>
        public Task<CreateNoticeContentTmplResponse> CreateNoticeContentTmpl(CreateNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<CreateNoticeContentTmplResponse>(req, "CreateNoticeContentTmpl");
        }

        /// <summary>
        /// 创建自定义通知内容模板
        /// </summary>
        /// <param name="req"><see cref="CreateNoticeContentTmplRequest"/></param>
        /// <returns><see cref="CreateNoticeContentTmplResponse"/></returns>
        public CreateNoticeContentTmplResponse CreateNoticeContentTmplSync(CreateNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<CreateNoticeContentTmplResponse>(req, "CreateNoticeContentTmpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除通知内容模板
        /// </summary>
        /// <param name="req"><see cref="DeleteNoticeContentTmplsRequest"/></param>
        /// <returns><see cref="DeleteNoticeContentTmplsResponse"/></returns>
        public Task<DeleteNoticeContentTmplsResponse> DeleteNoticeContentTmpls(DeleteNoticeContentTmplsRequest req)
        {
            return InternalRequestAsync<DeleteNoticeContentTmplsResponse>(req, "DeleteNoticeContentTmpls");
        }

        /// <summary>
        /// 删除通知内容模板
        /// </summary>
        /// <param name="req"><see cref="DeleteNoticeContentTmplsRequest"/></param>
        /// <returns><see cref="DeleteNoticeContentTmplsResponse"/></returns>
        public DeleteNoticeContentTmplsResponse DeleteNoticeContentTmplsSync(DeleteNoticeContentTmplsRequest req)
        {
            return InternalRequestAsync<DeleteNoticeContentTmplsResponse>(req, "DeleteNoticeContentTmpls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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

        /// <summary>
        /// 根据查询条件获取自定义通知内容模板，若所有查询条件空，则获取账号下所有模板
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeContentTmplRequest"/></param>
        /// <returns><see cref="DescribeNoticeContentTmplResponse"/></returns>
        public Task<DescribeNoticeContentTmplResponse> DescribeNoticeContentTmpl(DescribeNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<DescribeNoticeContentTmplResponse>(req, "DescribeNoticeContentTmpl");
        }

        /// <summary>
        /// 根据查询条件获取自定义通知内容模板，若所有查询条件空，则获取账号下所有模板
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeContentTmplRequest"/></param>
        /// <returns><see cref="DescribeNoticeContentTmplResponse"/></returns>
        public DescribeNoticeContentTmplResponse DescribeNoticeContentTmplSync(DescribeNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<DescribeNoticeContentTmplResponse>(req, "DescribeNoticeContentTmpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改通知内容模板
        /// </summary>
        /// <param name="req"><see cref="ModifyNoticeContentTmplRequest"/></param>
        /// <returns><see cref="ModifyNoticeContentTmplResponse"/></returns>
        public Task<ModifyNoticeContentTmplResponse> ModifyNoticeContentTmpl(ModifyNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<ModifyNoticeContentTmplResponse>(req, "ModifyNoticeContentTmpl");
        }

        /// <summary>
        /// 修改通知内容模板
        /// </summary>
        /// <param name="req"><see cref="ModifyNoticeContentTmplRequest"/></param>
        /// <returns><see cref="ModifyNoticeContentTmplResponse"/></returns>
        public ModifyNoticeContentTmplResponse ModifyNoticeContentTmplSync(ModifyNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<ModifyNoticeContentTmplResponse>(req, "ModifyNoticeContentTmpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
