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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OnCallForm : AbstractModel
    {
        
        /// <summary>
        /// 排班id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OnCallFormID")]
        public string OnCallFormID{ get; set; }

        /// <summary>
        /// 排班名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OnCallFormName")]
        public string OnCallFormName{ get; set; }

        /// <summary>
        /// 排班描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OnCallFormDesc")]
        public string OnCallFormDesc{ get; set; }

        /// <summary>
        /// 轮值类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RotationType")]
        public string RotationType{ get; set; }

        /// <summary>
        /// 换班时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShiftTime")]
        public string ShiftTime{ get; set; }

        /// <summary>
        /// 有效期开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EffectiveStartTime")]
        public long? EffectiveStartTime{ get; set; }

        /// <summary>
        /// 有效期结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EffectiveEndTime")]
        public long? EffectiveEndTime{ get; set; }

        /// <summary>
        /// 时区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeZone")]
        public float? TimeZone{ get; set; }

        /// <summary>
        /// 当前值班人员
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrOnCallStaffs")]
        public string[] CurrOnCallStaffs{ get; set; }

        /// <summary>
        /// 模板绑定的标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OnCallFormID", this.OnCallFormID);
            this.SetParamSimple(map, prefix + "OnCallFormName", this.OnCallFormName);
            this.SetParamSimple(map, prefix + "OnCallFormDesc", this.OnCallFormDesc);
            this.SetParamSimple(map, prefix + "RotationType", this.RotationType);
            this.SetParamSimple(map, prefix + "ShiftTime", this.ShiftTime);
            this.SetParamSimple(map, prefix + "EffectiveStartTime", this.EffectiveStartTime);
            this.SetParamSimple(map, prefix + "EffectiveEndTime", this.EffectiveEndTime);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArraySimple(map, prefix + "CurrOnCallStaffs.", this.CurrOnCallStaffs);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

