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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IncrementalMigrationHttpOriginParameter : AbstractModel
    {
        
        /// <summary>
        /// HTTP 头部透传信息。
        /// </summary>
        [JsonProperty("HttpHeaderInfo")]
        public IncrementalMigrationHttpHeaderInfo HttpHeaderInfo{ get; set; }

        /// <summary>
        /// 回源协议。取值有：
        /// <li>HTTP：强制 HTTP；</li>
        /// <li>HTTPS：强制 HTTPS；</li>
        /// <li>FOLLOW：跟随请求协议。</li>若不填，默认取值 `FOLLOW`。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 请求参数透传模式。取值有：
        /// <li>FOLLOW：全部透传；</li>
        /// <li>IGNORE：忽略，全部不透传。</li> 默认取值 `FOLLOW`。
        /// </summary>
        [JsonProperty("QueryStringFollowMode")]
        public string QueryStringFollowMode{ get; set; }

        /// <summary>
        /// 重定向的 HTTP Code，目前仅支持 `301`，`302` 和 `307`。默认取值 `302`。
        /// </summary>
        [JsonProperty("HttpRedirectCode")]
        public ulong? HttpRedirectCode{ get; set; }

        /// <summary>
        /// 源站重定向跟随模式。取值有：
        /// <li>FOLLOW：跟随源站重定向；</li>
        /// <li>IGNORE：忽略源站重定向。</li> 默认取值 `FOLLOW` 跟随源站重定向，即源站返回 `3xx` 时，会默认跟随至对应源站拉取数据。
        /// </summary>
        [JsonProperty("OriginRedirectionFollowMode")]
        public string OriginRedirectionFollowMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HttpHeaderInfo.", this.HttpHeaderInfo);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "QueryStringFollowMode", this.QueryStringFollowMode);
            this.SetParamSimple(map, prefix + "HttpRedirectCode", this.HttpRedirectCode);
            this.SetParamSimple(map, prefix + "OriginRedirectionFollowMode", this.OriginRedirectionFollowMode);
        }
    }
}

