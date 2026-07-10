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

namespace TencentCloud.Tmt.V20180321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tmt.V20180321.Models;

   public class TmtClient : AbstractClient{

       private const string endpoint = "tmt.tencentcloudapi.com";
       private const string version = "2018-03-21";
       private const string sdkVersion = "SDK_NET_3.0.1459";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TmtClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TmtClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 提供18种语言的图片翻译服务，可自动识别图片中的文本内容并翻译成目标语言，识别后的文本按行翻译，后续会提供可按段落翻译的版本。
        /// 
        /// - 输入图片格式：png、jpg、jpeg等常用图片格式，不支持gif动图。
        /// - 输出图片格式：jpg。
        /// 
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源 部分。
        /// </summary>
        /// <param name="req"><see cref="ImageTranslateLLMRequest"/></param>
        /// <returns><see cref="ImageTranslateLLMResponse"/></returns>
        public Task<ImageTranslateLLMResponse> ImageTranslateLLM(ImageTranslateLLMRequest req)
        {
            return InternalRequestAsync<ImageTranslateLLMResponse>(req, "ImageTranslateLLM");
        }

        /// <summary>
        /// 提供18种语言的图片翻译服务，可自动识别图片中的文本内容并翻译成目标语言，识别后的文本按行翻译，后续会提供可按段落翻译的版本。
        /// 
        /// - 输入图片格式：png、jpg、jpeg等常用图片格式，不支持gif动图。
        /// - 输出图片格式：jpg。
        /// 
        /// 提示：对于一般开发者，我们建议优先使用SDK接入简化开发。SDK使用介绍请直接查看 5. 开发者资源 部分。
        /// </summary>
        /// <param name="req"><see cref="ImageTranslateLLMRequest"/></param>
        /// <returns><see cref="ImageTranslateLLMResponse"/></returns>
        public ImageTranslateLLMResponse ImageTranslateLLMSync(ImageTranslateLLMRequest req)
        {
            return InternalRequestAsync<ImageTranslateLLMResponse>(req, "ImageTranslateLLM")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
