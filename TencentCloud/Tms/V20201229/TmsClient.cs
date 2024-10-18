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

namespace TencentCloud.Tms.V20201229
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tms.V20201229.Models;

   public class TmsClient : AbstractClient{

       private const string endpoint = "tms.tencentcloudapi.com";
       private const string version = "2020-12-29";
       private const string sdkVersion = "SDK_NET_3.0.1108";

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
        /// 天御文本内容安全定制标签文本审核接口为定制接口，会按照客户定制标签输出审核结果，如需使用请联系商务经理或[在线客服](https://cloud.tencent.com/online-service?from=doc_1125)咨询。
        /// </summary>
        /// <param name="req"><see cref="ModerateTextRequest"/></param>
        /// <returns><see cref="ModerateTextResponse"/></returns>
        public Task<ModerateTextResponse> ModerateText(ModerateTextRequest req)
        {
            return InternalRequestAsync<ModerateTextResponse>(req, "ModerateText");
        }

        /// <summary>
        /// 天御文本内容安全定制标签文本审核接口为定制接口，会按照客户定制标签输出审核结果，如需使用请联系商务经理或[在线客服](https://cloud.tencent.com/online-service?from=doc_1125)咨询。
        /// </summary>
        /// <param name="req"><see cref="ModerateTextRequest"/></param>
        /// <returns><see cref="ModerateTextResponse"/></returns>
        public ModerateTextResponse ModerateTextSync(ModerateTextRequest req)
        {
            return InternalRequestAsync<ModerateTextResponse>(req, "ModerateText")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（Text Moderation）用于提交文本内容进行智能审核任务。使用前请您使用腾讯云主账号登录控制台 [开通文本内容安全服务](https://console.cloud.tencent.com/cms) 并调整好对应的业务配置。
        /// 
        /// ### 接口使用说明
        /// - 前往“[内容安全控制台-文本内容安全](https://console.cloud.tencent.com/cms)”开启使用文本内容安全服务，首次开通服务的用户可免费领用试用套餐包，包含**3000条**文本识别额度，有效期为15天。
        /// - 该接口为收费接口，计费方式敬请参见 [腾讯云文本内容安全定价](https://cloud.tencent.com/product/tms/pricing)。
        /// 
        /// ### 接口功能说明：
        /// - 支持对文本文件进行检测，通过深度学习技术，识别可能令人反感、不安全或不适宜的违规文本内容；
        /// - 支持识别多种违规场景，包括：低俗、谩骂、色情、广告等场景；
        /// - 支持根据不同的业务场景配置自定义的审核策略，可在控制台文本内容安全-策略管理中配置；
        /// - 支持用户自定义配置词库黑白名单，打击自定义识别类型的违规文本（目前仅支持黑名单配置）；
        /// - 支持在审核文本内容时同时关联账号或设备信息，可识别违规风险账号或设备。
        /// 
        /// ### 接口调用说明：
        /// - 文本内容大小支持：文本原文长度不能超过unicode编码长度10000个字符；
        /// - 文本审核语言支持：目前支持中文、英文、阿拉伯数字的检测；
        /// - 默认接口请求频率限制：**1000次/秒**，超过该频率限制则接口会报错。
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public Task<TextModerationResponse> TextModeration(TextModerationRequest req)
        {
            return InternalRequestAsync<TextModerationResponse>(req, "TextModeration");
        }

        /// <summary>
        /// 本接口（Text Moderation）用于提交文本内容进行智能审核任务。使用前请您使用腾讯云主账号登录控制台 [开通文本内容安全服务](https://console.cloud.tencent.com/cms) 并调整好对应的业务配置。
        /// 
        /// ### 接口使用说明
        /// - 前往“[内容安全控制台-文本内容安全](https://console.cloud.tencent.com/cms)”开启使用文本内容安全服务，首次开通服务的用户可免费领用试用套餐包，包含**3000条**文本识别额度，有效期为15天。
        /// - 该接口为收费接口，计费方式敬请参见 [腾讯云文本内容安全定价](https://cloud.tencent.com/product/tms/pricing)。
        /// 
        /// ### 接口功能说明：
        /// - 支持对文本文件进行检测，通过深度学习技术，识别可能令人反感、不安全或不适宜的违规文本内容；
        /// - 支持识别多种违规场景，包括：低俗、谩骂、色情、广告等场景；
        /// - 支持根据不同的业务场景配置自定义的审核策略，可在控制台文本内容安全-策略管理中配置；
        /// - 支持用户自定义配置词库黑白名单，打击自定义识别类型的违规文本（目前仅支持黑名单配置）；
        /// - 支持在审核文本内容时同时关联账号或设备信息，可识别违规风险账号或设备。
        /// 
        /// ### 接口调用说明：
        /// - 文本内容大小支持：文本原文长度不能超过unicode编码长度10000个字符；
        /// - 文本审核语言支持：目前支持中文、英文、阿拉伯数字的检测；
        /// - 默认接口请求频率限制：**1000次/秒**，超过该频率限制则接口会报错。
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
