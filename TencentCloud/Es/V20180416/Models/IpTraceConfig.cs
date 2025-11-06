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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpTraceConfig : AbstractModel
    {
        
        /// <summary>
        /// 请求溯源开关
        /// </summary>
        [JsonProperty("EnableRequest")]
        public bool? EnableRequest{ get; set; }

        /// <summary>
        /// 返回溯源开关
        /// </summary>
        [JsonProperty("EnableResponse")]
        public bool? EnableResponse{ get; set; }

        /// <summary>
        /// 请求消息体溯源开关
        /// </summary>
        [JsonProperty("EnableRequestBody")]
        public bool? EnableRequestBody{ get; set; }

        /// <summary>
        /// 返回消息体溯源开关
        /// </summary>
        [JsonProperty("EnableResponseBody")]
        public bool? EnableResponseBody{ get; set; }

        /// <summary>
        /// 排除IP
        /// </summary>
        [JsonProperty("RemoteIpInclude")]
        public string[] RemoteIpInclude{ get; set; }

        /// <summary>
        /// 包含IP
        /// </summary>
        [JsonProperty("RemoteIpExclude")]
        public string[] RemoteIpExclude{ get; set; }

        /// <summary>
        /// 排除uri
        /// </summary>
        [JsonProperty("UriInclude")]
        public string[] UriInclude{ get; set; }

        /// <summary>
        /// 包含uri
        /// </summary>
        [JsonProperty("UriExclude")]
        public string[] UriExclude{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableRequest", this.EnableRequest);
            this.SetParamSimple(map, prefix + "EnableResponse", this.EnableResponse);
            this.SetParamSimple(map, prefix + "EnableRequestBody", this.EnableRequestBody);
            this.SetParamSimple(map, prefix + "EnableResponseBody", this.EnableResponseBody);
            this.SetParamArraySimple(map, prefix + "RemoteIpInclude.", this.RemoteIpInclude);
            this.SetParamArraySimple(map, prefix + "RemoteIpExclude.", this.RemoteIpExclude);
            this.SetParamArraySimple(map, prefix + "UriInclude.", this.UriInclude);
            this.SetParamArraySimple(map, prefix + "UriExclude.", this.UriExclude);
        }
    }
}

