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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventDetail : AbstractModel
    {
        
        /// <summary>
        /// 事件id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 事件名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 事件触发类型
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// 事件触发条件，返回为x-json后的字段
        /// </summary>
        [JsonProperty("TriggerCondition")]
        public string TriggerCondition{ get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty("ValidPeriod")]
        public string ValidPeriod{ get; set; }

        /// <summary>
        /// 关联规则列表
        /// </summary>
        [JsonProperty("LinkRuleSet")]
        public LinkRule[] LinkRuleSet{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 设备类型，当触发类型为deviceType时返回
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 设备的wid，当触发类型是device返回
        /// </summary>
        [JsonProperty("WID")]
        public string WID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "TriggerCondition", this.TriggerCondition);
            this.SetParamSimple(map, prefix + "ValidPeriod", this.ValidPeriod);
            this.SetParamArrayObj(map, prefix + "LinkRuleSet.", this.LinkRuleSet);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "WID", this.WID);
        }
    }
}

