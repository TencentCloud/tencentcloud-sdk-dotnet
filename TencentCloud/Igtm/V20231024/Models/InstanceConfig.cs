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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceConfig : AbstractModel
    {
        
        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 业务域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// CUSTOM: 自定义接入域名
        /// SYSTEM: 系统接入域名
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 全局记录过期时间	
        /// </summary>
        [JsonProperty("GlobalTtl")]
        public long? GlobalTtl{ get; set; }

        /// <summary>
        /// 接入主域名，自定义接入域名时必填
        /// </summary>
        [JsonProperty("AccessDomain")]
        public string AccessDomain{ get; set; }

        /// <summary>
        /// 接入子域名，自定义接入域名时必填
        /// </summary>
        [JsonProperty("AccessSubDomain")]
        public string AccessSubDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "GlobalTtl", this.GlobalTtl);
            this.SetParamSimple(map, prefix + "AccessDomain", this.AccessDomain);
            this.SetParamSimple(map, prefix + "AccessSubDomain", this.AccessSubDomain);
        }
    }
}

