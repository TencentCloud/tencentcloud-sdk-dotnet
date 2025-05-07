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

namespace TencentCloud.Tbp.V20190627
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tbp.V20190627.Models;

   public class TbpClient : AbstractClient{

       private const string endpoint = "tbp.tencentcloudapi.com";
       private const string version = "2019-06-27";
       private const string sdkVersion = "SDK_NET_3.0.1234";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TbpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TbpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 接收调用侧的文本输入，返回应答文本。
        /// </summary>
        /// <param name="req"><see cref="TextProcessRequest"/></param>
        /// <returns><see cref="TextProcessResponse"/></returns>
        public Task<TextProcessResponse> TextProcess(TextProcessRequest req)
        {
            return InternalRequestAsync<TextProcessResponse>(req, "TextProcess");
        }

        /// <summary>
        /// 接收调用侧的文本输入，返回应答文本。
        /// </summary>
        /// <param name="req"><see cref="TextProcessRequest"/></param>
        /// <returns><see cref="TextProcessResponse"/></returns>
        public TextProcessResponse TextProcessSync(TextProcessRequest req)
        {
            return InternalRequestAsync<TextProcessResponse>(req, "TextProcess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会话重置接口。
        /// </summary>
        /// <param name="req"><see cref="TextResetRequest"/></param>
        /// <returns><see cref="TextResetResponse"/></returns>
        public Task<TextResetResponse> TextReset(TextResetRequest req)
        {
            return InternalRequestAsync<TextResetResponse>(req, "TextReset");
        }

        /// <summary>
        /// 会话重置接口。
        /// </summary>
        /// <param name="req"><see cref="TextResetRequest"/></param>
        /// <returns><see cref="TextResetResponse"/></returns>
        public TextResetResponse TextResetSync(TextResetRequest req)
        {
            return InternalRequestAsync<TextResetResponse>(req, "TextReset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
