/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NeteaseParam : AbstractModel
    {
        
        /// <summary>
        /// <p>网易云信应用 AppKey</p><p>登陆云信侧控制台或联系云信获取</p>
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// <p>频道名。</p><p>非空字符串,需要和生成token使用的Channel完全一致。</p>
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// <p>用于拉流端进房安全签名</p><p>生成方式详见文档：https://doc.yunxin.163.com/nertc/server-apis/TcxNDAxMTI?platform=server#%E8%8E%B7%E5%8F%96-token，每次请求审核需要重新生成新的token。</p>
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// <p>分配进房拉流的用户ID。</p><p>和生成Token时所用 Uid 完全一致。</p>
        /// </summary>
        [JsonProperty("Uid")]
        public ulong? Uid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
        }
    }
}

