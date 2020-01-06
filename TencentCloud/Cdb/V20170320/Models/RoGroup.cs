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

    public class RoGroup : AbstractModel
    {
        
        /// <summary>
        /// 只读组模式，可选值为：alone-系统自动分配只读组；allinone-新建只读组；join-使用现有只读组
        /// </summary>
        [JsonProperty("RoGroupMode")]
        public string RoGroupMode{ get; set; }

        /// <summary>
        /// 只读组ID
        /// </summary>
        [JsonProperty("RoGroupId")]
        public string RoGroupId{ get; set; }

        /// <summary>
        /// 只读组名称
        /// </summary>
        [JsonProperty("RoGroupName")]
        public string RoGroupName{ get; set; }

        /// <summary>
        /// 是否启用延迟超限剔除功能，启用该功能后，只读实例与主实例的延迟超过延迟阈值，只读实例将被隔离。可选值：1-启用；0-不启用
        /// </summary>
        [JsonProperty("RoOfflineDelay")]
        public long? RoOfflineDelay{ get; set; }

        /// <summary>
        /// 延迟阈值
        /// </summary>
        [JsonProperty("RoMaxDelayTime")]
        public long? RoMaxDelayTime{ get; set; }

        /// <summary>
        /// 最少实例保留个数，若购买只读实例数量小于设置数量将不做剔除
        /// </summary>
        [JsonProperty("MinRoInGroup")]
        public long? MinRoInGroup{ get; set; }

        /// <summary>
        /// 读写权重分配模式，可选值：system-系统自动分配；custom-自定义
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// 权重值
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 只读组中的只读实例详情
        /// </summary>
        [JsonProperty("RoInstances")]
        public RoInstanceInfo[] RoInstances{ get; set; }

        /// <summary>
        /// 只读组的内网IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 只读组的内网端口号
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoGroupMode", this.RoGroupMode);
            this.SetParamSimple(map, prefix + "RoGroupId", this.RoGroupId);
            this.SetParamSimple(map, prefix + "RoGroupName", this.RoGroupName);
            this.SetParamSimple(map, prefix + "RoOfflineDelay", this.RoOfflineDelay);
            this.SetParamSimple(map, prefix + "RoMaxDelayTime", this.RoMaxDelayTime);
            this.SetParamSimple(map, prefix + "MinRoInGroup", this.MinRoInGroup);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamArrayObj(map, prefix + "RoInstances.", this.RoInstances);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
        }
    }
}

