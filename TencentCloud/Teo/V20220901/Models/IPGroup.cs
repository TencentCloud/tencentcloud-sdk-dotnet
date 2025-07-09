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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPGroup : AbstractModel
    {
        
        /// <summary>
        /// 组 Id，创建时填 0 即可。
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// 组名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// IP 组内容，仅支持 IP 及 IP 网段。
        /// </summary>
        [JsonProperty("Content")]
        public string[] Content{ get; set; }

        /// <summary>
        /// IP 组中正在生效的 IP 或网段个数。作为出参时有效，作为入参时无需填写该字段。
        /// </summary>
        [JsonProperty("IPTotalCount")]
        public long? IPTotalCount{ get; set; }

        /// <summary>
        /// IP 定时过期信息。
        /// 作为入参，用于为指定的 IP 地址或网段配置定时过期时间。
        /// 作为出参，包含以下两类信息：
        /// <li>当前未到期的定时过期信息：尚未触发的过期配置。</li>
        /// <li>一周内已到期的定时过期信息：已触发的过期配置。</li>
        /// </summary>
        [JsonProperty("IPExpireInfo")]
        public IPExpireInfo[] IPExpireInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "IPTotalCount", this.IPTotalCount);
            this.SetParamArrayObj(map, prefix + "IPExpireInfo.", this.IPExpireInfo);
        }
    }
}

