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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMCPTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Token 过期时间</p><p>取值范围：[0, 2592000]</p><p>单位：秒</p><p>默认值：86400</p><p>不填的话，默认为 1 天超时；过期时间为当前时间 + 超时时间</p>
        /// </summary>
        [JsonProperty("ExpireSeconds")]
        public long? ExpireSeconds{ get; set; }

        /// <summary>
        /// <p>Token 名称（注释）</p><p>参数格式：只支持：中英文、数字、连字符 &quot;-&quot; 的组合</p><p>长度不得超过 16 个字符</p>
        /// </summary>
        [JsonProperty("TokenName")]
        public string TokenName{ get; set; }

        /// <summary>
        /// <p>用户 Id</p><p>参数格式：只支持：字母（A-Za-z）、数字（0-9）、下划线（_）的组合</p><p>固定使用这个 UserId  来操作云渲染并发资源，长度不能超过 64 个字符</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpireSeconds", this.ExpireSeconds);
            this.SetParamSimple(map, prefix + "TokenName", this.TokenName);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

