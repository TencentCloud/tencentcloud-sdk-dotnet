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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDomainErrorPageInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>监听器ID</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>原始错误码</p>
        /// </summary>
        [JsonProperty("ErrorNos")]
        public long?[] ErrorNos{ get; set; }

        /// <summary>
        /// <p>新的响应包体</p>
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// <p>新错误码</p>
        /// </summary>
        [JsonProperty("NewErrorNo")]
        public long? NewErrorNo{ get; set; }

        /// <summary>
        /// <p>需要删除的响应头</p>
        /// </summary>
        [JsonProperty("ClearHeaders")]
        public string[] ClearHeaders{ get; set; }

        /// <summary>
        /// <p>需要设置的响应头</p>
        /// </summary>
        [JsonProperty("SetHeaders")]
        public HttpHeaderParam[] SetHeaders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "ErrorNos.", this.ErrorNos);
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamSimple(map, prefix + "NewErrorNo", this.NewErrorNo);
            this.SetParamArraySimple(map, prefix + "ClearHeaders.", this.ClearHeaders);
            this.SetParamArrayObj(map, prefix + "SetHeaders.", this.SetHeaders);
        }
    }
}

