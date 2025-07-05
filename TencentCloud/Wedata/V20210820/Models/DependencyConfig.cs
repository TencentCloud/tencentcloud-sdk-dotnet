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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DependencyConfig : AbstractModel
    {
        
        /// <summary>
        /// 周期运行依赖配置： HOUR,DAY,WEEK,MONTH,YEAR,CRONTAB,MINUTE,RANGE_DAY,RANGE_HOUR,RANGE_MINUTE,LIST_DAY,LIST_HOUR,LIST_MINUTE;
        /// </summary>
        [JsonProperty("DependConfType")]
        public string DependConfType{ get; set; }

        /// <summary>
        /// 依赖配置从属周期类型，CURRENT_HOUR，PREVIOUS_HOUR，CURRENT_DAY，PREVIOUS_DAY，PREVIOUS_WEEK，PREVIOUS_FRIDAY，PREVIOUS_WEEKEND，CURRENT_MONTH，PREVIOUS_MONTH，PREVIOUS_END_OF_MONTH，PREVIOUS_BEGIN_OF_MONTH，ALL_MONTH_OF_YEAR，ALL_DAY_OF_YEAR，CURRENT_YEAR，CURRENT，CURRENT_MINUTE，PREVIOUS_MINUTE_CYCLE，PREVIOUS_HOUR_CYCLE
        /// </summary>
        [JsonProperty("SubordinateCyclicType")]
        public string SubordinateCyclicType{ get; set; }

        /// <summary>
        /// WAITING，等待（默认策略）EXECUTING:执行
        /// </summary>
        [JsonProperty("DependencyStrategy")]
        public string DependencyStrategy{ get; set; }

        /// <summary>
        /// 父任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentTask")]
        public TaskInnerInfo ParentTask{ get; set; }

        /// <summary>
        /// 子任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SonTask")]
        public TaskInnerInfo SonTask{ get; set; }

        /// <summary>
        /// 偏移量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DependConfType", this.DependConfType);
            this.SetParamSimple(map, prefix + "SubordinateCyclicType", this.SubordinateCyclicType);
            this.SetParamSimple(map, prefix + "DependencyStrategy", this.DependencyStrategy);
            this.SetParamObj(map, prefix + "ParentTask.", this.ParentTask);
            this.SetParamObj(map, prefix + "SonTask.", this.SonTask);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

