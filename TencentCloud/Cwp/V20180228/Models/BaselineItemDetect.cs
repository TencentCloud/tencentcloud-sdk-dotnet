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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineItemDetect : AbstractModel
    {
        
        /// <summary>
        /// 项Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemId")]
        public long? ItemId{ get; set; }

        /// <summary>
        /// 项名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemName")]
        public string ItemName{ get; set; }

        /// <summary>
        /// 项描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemDesc")]
        public string ItemDesc{ get; set; }

        /// <summary>
        /// 修复方法
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixMethod")]
        public string FixMethod{ get; set; }

        /// <summary>
        /// 所属规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 0:未通过 1:忽略 3:通过 5:检测中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectStatus")]
        public long? DetectStatus{ get; set; }

        /// <summary>
        /// 风险等级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 影响服务器数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// 首次检测时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 最后检测时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 检测结果,Json字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectResult")]
        public string DetectResult{ get; set; }

        /// <summary>
        /// 所属规则ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 通过的服务器数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PassedHostCount")]
        public long? PassedHostCount{ get; set; }

        /// <summary>
        /// 未通过的服务器数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotPassedHostCount")]
        public long? NotPassedHostCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "ItemName", this.ItemName);
            this.SetParamSimple(map, prefix + "ItemDesc", this.ItemDesc);
            this.SetParamSimple(map, prefix + "FixMethod", this.FixMethod);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "DetectStatus", this.DetectStatus);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "DetectResult", this.DetectResult);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "PassedHostCount", this.PassedHostCount);
            this.SetParamSimple(map, prefix + "NotPassedHostCount", this.NotPassedHostCount);
        }
    }
}

