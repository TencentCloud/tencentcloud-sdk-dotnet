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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganizationInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户在渠道的机构编号
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 机构在平台的编号
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 用户渠道
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 用户真实的IP
        /// </summary>
        [JsonProperty("ClientIp")]
        [System.Obsolete]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 机构的代理IP
        /// </summary>
        [JsonProperty("ProxyIp")]
        [System.Obsolete]
        public string ProxyIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ProxyIp", this.ProxyIp);
        }
    }
}

