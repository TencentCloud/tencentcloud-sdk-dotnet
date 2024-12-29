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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StageInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// 步骤
        /// </summary>
        [JsonProperty("Stage")]
        public string Stage{ get; set; }

        /// <summary>
        /// 步骤名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否展示
        /// </summary>
        [JsonProperty("IsShow")]
        public bool? IsShow{ get; set; }

        /// <summary>
        /// 是否子流程
        /// </summary>
        [JsonProperty("IsSubFlow")]
        public bool? IsSubFlow{ get; set; }

        /// <summary>
        /// 子流程标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubFlowFlag")]
        public string SubFlowFlag{ get; set; }

        /// <summary>
        /// 步骤运行状态：0:未开始 1:进行中 2:已完成 3:部分完成  -1:失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 步骤运行状态描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 运行进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Starttime")]
        public string Starttime{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Endtime")]
        public string Endtime{ get; set; }

        /// <summary>
        /// 是否有详情信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HadWoodDetail")]
        public bool? HadWoodDetail{ get; set; }

        /// <summary>
        /// Wood子流程Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WoodJobId")]
        public ulong? WoodJobId{ get; set; }

        /// <summary>
        /// 多语言版本Key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LanguageKey")]
        public string LanguageKey{ get; set; }

        /// <summary>
        /// 如果stage失败，失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedReason")]
        public string FailedReason{ get; set; }

        /// <summary>
        /// 步骤耗时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeConsuming")]
        public string TimeConsuming{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsShow", this.IsShow);
            this.SetParamSimple(map, prefix + "IsSubFlow", this.IsSubFlow);
            this.SetParamSimple(map, prefix + "SubFlowFlag", this.SubFlowFlag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "Starttime", this.Starttime);
            this.SetParamSimple(map, prefix + "Endtime", this.Endtime);
            this.SetParamSimple(map, prefix + "HadWoodDetail", this.HadWoodDetail);
            this.SetParamSimple(map, prefix + "WoodJobId", this.WoodJobId);
            this.SetParamSimple(map, prefix + "LanguageKey", this.LanguageKey);
            this.SetParamSimple(map, prefix + "FailedReason", this.FailedReason);
            this.SetParamSimple(map, prefix + "TimeConsuming", this.TimeConsuming);
        }
    }
}

