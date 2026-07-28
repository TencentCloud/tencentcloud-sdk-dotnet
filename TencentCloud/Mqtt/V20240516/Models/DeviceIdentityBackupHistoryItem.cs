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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceIdentityBackupHistoryItem : AbstractModel
    {
        
        /// <summary>
        /// <p>设备id</p>
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// <p>1:ENABLED-可用2:DISABLE-不可用</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>主要签名key（Base64编码）</p>
        /// </summary>
        [JsonProperty("PrimaryKey")]
        public string PrimaryKey{ get; set; }

        /// <summary>
        /// <p>次要签名key（Base64编码）</p>
        /// </summary>
        [JsonProperty("SecondaryKey")]
        public string SecondaryKey{ get; set; }

        /// <summary>
        /// <p>传播属性列表</p>
        /// </summary>
        [JsonProperty("PropagatingProperties")]
        public PropagatingProperty[] PropagatingProperties{ get; set; }

        /// <summary>
        /// <p>数据来源</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>修改时间</p><p>单位：毫秒级时间戳</p>
        /// </summary>
        [JsonProperty("ModificationTime")]
        public long? ModificationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PrimaryKey", this.PrimaryKey);
            this.SetParamSimple(map, prefix + "SecondaryKey", this.SecondaryKey);
            this.SetParamArrayObj(map, prefix + "PropagatingProperties.", this.PropagatingProperties);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "ModificationTime", this.ModificationTime);
        }
    }
}

