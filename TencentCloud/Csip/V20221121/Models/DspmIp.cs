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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmIp : AbstractModel
    {
        
        /// <summary>
        /// ip地址
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// ip类型。public-公网 private-内网
        /// </summary>
        [JsonProperty("IpType")]
        public string IpType{ get; set; }

        /// <summary>
        /// ip标记信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否已经标记信息
        /// </summary>
        [JsonProperty("IsRemarked")]
        public long? IsRemarked{ get; set; }

        /// <summary>
        /// ip归属实例id
        /// </summary>
        [JsonProperty("ResourceInstanceId")]
        public string ResourceInstanceId{ get; set; }

        /// <summary>
        /// ip所属产品
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// ip所属地域
        /// </summary>
        [JsonProperty("Area")]
        public DspmArea Area{ get; set; }

        /// <summary>
        /// 是否新ip地址
        /// </summary>
        [JsonProperty("IsNewIp")]
        public long? IsNewIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "IpType", this.IpType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "IsRemarked", this.IsRemarked);
            this.SetParamSimple(map, prefix + "ResourceInstanceId", this.ResourceInstanceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamObj(map, prefix + "Area.", this.Area);
            this.SetParamSimple(map, prefix + "IsNewIp", this.IsNewIp);
        }
    }
}

