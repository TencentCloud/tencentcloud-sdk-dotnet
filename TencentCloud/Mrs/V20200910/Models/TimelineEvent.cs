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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimelineEvent : AbstractModel
    {
        
        /// <summary>
        /// 事件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 原文本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// 事件子类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// 事件发生时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 事件值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 位置坐标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rectangle")]
        public Rectangle Rectangle{ get; set; }

        /// <summary>
        /// 事件发生地点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Place")]
        public string Place{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamObj(map, prefix + "Rectangle.", this.Rectangle);
            this.SetParamSimple(map, prefix + "Place", this.Place);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

