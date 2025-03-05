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

namespace TencentCloud.Tms.V20200713
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tms.V20200713.Models;

   public class TmsClient : AbstractClient{

       private const string endpoint = "tms.tencentcloudapi.com";
       private const string version = "2020-07-13";
       private const string sdkVersion = "SDK_NET_3.0.1193";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 举报恶意账号
        /// </summary>
        /// <param name="req"><see cref="AccountTipoffAccessRequest"/></param>
        /// <returns><see cref="AccountTipoffAccessResponse"/></returns>
        public Task<AccountTipoffAccessResponse> AccountTipoffAccess(AccountTipoffAccessRequest req)
        {
            return InternalRequestAsync<AccountTipoffAccessResponse>(req, "AccountTipoffAccess");
        }

        /// <summary>
        /// 举报恶意账号
        /// </summary>
        /// <param name="req"><see cref="AccountTipoffAccessRequest"/></param>
        /// <returns><see cref="AccountTipoffAccessResponse"/></returns>
        public AccountTipoffAccessResponse AccountTipoffAccessSync(AccountTipoffAccessRequest req)
        {
            return InternalRequestAsync<AccountTipoffAccessResponse>(req, "AccountTipoffAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 控制台获取用户词库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTextLibRequest"/></param>
        /// <returns><see cref="DescribeTextLibResponse"/></returns>
        public Task<DescribeTextLibResponse> DescribeTextLib(DescribeTextLibRequest req)
        {
            return InternalRequestAsync<DescribeTextLibResponse>(req, "DescribeTextLib");
        }

        /// <summary>
        /// 控制台获取用户词库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTextLibRequest"/></param>
        /// <returns><see cref="DescribeTextLibResponse"/></returns>
        public DescribeTextLibResponse DescribeTextLibSync(DescribeTextLibRequest req)
        {
            return InternalRequestAsync<DescribeTextLibResponse>(req, "DescribeTextLib")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeTextStatRequest"/></param>
        /// <returns><see cref="DescribeTextStatResponse"/></returns>
        public Task<DescribeTextStatResponse> DescribeTextStat(DescribeTextStatRequest req)
        {
            return InternalRequestAsync<DescribeTextStatResponse>(req, "DescribeTextStat");
        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeTextStatRequest"/></param>
        /// <returns><see cref="DescribeTextStatResponse"/></returns>
        public DescribeTextStatResponse DescribeTextStatSync(DescribeTextStatRequest req)
        {
            return InternalRequestAsync<DescribeTextStatResponse>(req, "DescribeTextStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文本内容检测（Text Moderation）服务使用了深度学习技术，识别可能令人反感、不安全或不适宜的文本内容，同时支持用户配置词库黑白名单，打击自定义识别类型的图片。
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public Task<TextModerationResponse> TextModeration(TextModerationRequest req)
        {
            return InternalRequestAsync<TextModerationResponse>(req, "TextModeration");
        }

        /// <summary>
        /// 文本内容检测（Text Moderation）服务使用了深度学习技术，识别可能令人反感、不安全或不适宜的文本内容，同时支持用户配置词库黑白名单，打击自定义识别类型的图片。
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public TextModerationResponse TextModerationSync(TextModerationRequest req)
        {
            return InternalRequestAsync<TextModerationResponse>(req, "TextModeration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
