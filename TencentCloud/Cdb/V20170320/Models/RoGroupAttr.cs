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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoGroupAttr : AbstractModel
    {
        
        /// <summary>
        /// RO 组名称。
        /// </summary>
        [JsonProperty("RoGroupName")]
        public string RoGroupName{ get; set; }

        /// <summary>
        /// RO 实例最大延迟阈值。单位为秒，最小值为 1。注意，RO 组必须设置了开启实例延迟剔除策略，该值才有效。
        /// </summary>
        [JsonProperty("RoMaxDelayTime")]
        public long? RoMaxDelayTime{ get; set; }

        /// <summary>
        /// 是否开启实例延迟剔除。支持的值包括：1 - 开启；0 - 不开启。注意，若设置开启实例延迟剔除，则必须设置延迟阈值（RoMaxDelayTime）参数。
        /// </summary>
        [JsonProperty("RoOfflineDelay")]
        public long? RoOfflineDelay{ get; set; }

        /// <summary>
        /// 最少保留实例数。可设置为小于或等于该 RO 组下 RO 实例个数的任意值。注意，若设置值大于 RO 实例数量将不做剔除；若设置为 0，所有实例延迟超限都会被剔除。
        /// </summary>
        [JsonProperty("MinRoInGroup")]
        public long? MinRoInGroup{ get; set; }

        /// <summary>
        /// 权重模式。支持值包括："system" - 系统自动分配； "custom" - 用户自定义设置。注意，若设置 "custom" 模式，则必须设置 RO 实例权重配置（RoWeightValues）参数。
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// 延迟复制时间。
        /// </summary>
        [JsonProperty("ReplicationDelayTime")]
        public long? ReplicationDelayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoGroupName", this.RoGroupName);
            this.SetParamSimple(map, prefix + "RoMaxDelayTime", this.RoMaxDelayTime);
            this.SetParamSimple(map, prefix + "RoOfflineDelay", this.RoOfflineDelay);
            this.SetParamSimple(map, prefix + "MinRoInGroup", this.MinRoInGroup);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "ReplicationDelayTime", this.ReplicationDelayTime);
        }
    }
}

