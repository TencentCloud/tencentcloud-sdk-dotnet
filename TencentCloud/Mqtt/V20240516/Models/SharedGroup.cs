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

    public class SharedGroup : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云MQTT实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 共享订阅组名
        /// </summary>
        [JsonProperty("SharedName")]
        public string SharedName{ get; set; }

        /// <summary>
        /// 共享组消费负载均衡策略 1.RANDOM 2.HASH_PARTITION
        /// </summary>
        [JsonProperty("LbStrategy")]
        public long? LbStrategy{ get; set; }

        /// <summary>
        /// HASH_PARTITION 策略下生效，表示Client掉线或新Client上线加入共享订阅组消费的延迟时间。
        /// 范围：0～600秒
        /// </summary>
        [JsonProperty("ExpiryInterval")]
        public long? ExpiryInterval{ get; set; }

        /// <summary>
        /// 备注，长度不超过128个字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 创建时间，毫秒级时间戳 。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 上次更新时间，毫秒级时间戳 。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SharedName", this.SharedName);
            this.SetParamSimple(map, prefix + "LbStrategy", this.LbStrategy);
            this.SetParamSimple(map, prefix + "ExpiryInterval", this.ExpiryInterval);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

