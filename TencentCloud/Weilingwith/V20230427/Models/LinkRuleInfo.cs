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

    public class LinkRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 联动id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 联动名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 事件列表
        /// </summary>
        [JsonProperty("EventSet")]
        public Event[] EventSet{ get; set; }

        /// <summary>
        /// 动作列表
        /// </summary>
        [JsonProperty("ActionSet")]
        public Action[] ActionSet{ get; set; }

        /// <summary>
        /// 状态：0开，-1关
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("BeginDate")]
        public string BeginDate{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 有效周期内容,有效字段为x-json后的字段
        /// </summary>
        [JsonProperty("ValidPeriod")]
        public string ValidPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "EventSet.", this.EventSet);
            this.SetParamArrayObj(map, prefix + "ActionSet.", this.ActionSet);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BeginDate", this.BeginDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "ValidPeriod", this.ValidPeriod);
        }
    }
}

