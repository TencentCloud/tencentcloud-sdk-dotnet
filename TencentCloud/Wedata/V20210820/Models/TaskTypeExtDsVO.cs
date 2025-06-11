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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskTypeExtDsVO : AbstractModel
    {
        
        /// <summary>
        /// 类型ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeId")]
        public long? TypeId{ get; set; }

        /// <summary>
        /// 属性名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PropName")]
        public string PropName{ get; set; }

        /// <summary>
        /// 属性标签(ui展示用)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PropLabel")]
        public string PropLabel{ get; set; }

        /// <summary>
        /// 缺省标志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultFlag")]
        public long? DefaultFlag{ get; set; }

        /// <summary>
        /// 可视标志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VisibleFlag")]
        public long? VisibleFlag{ get; set; }

        /// <summary>
        /// 属性描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PropDesc")]
        public string PropDesc{ get; set; }

        /// <summary>
        /// 排列id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RankId")]
        public long? RankId{ get; set; }

        /// <summary>
        /// 控件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 值类型(integer，string)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// 缺省值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 候选值列表(，分隔)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CandidateValues")]
        public string CandidateValues{ get; set; }

        /// <summary>
        /// 是否必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsMandatory")]
        public long? IsMandatory{ get; set; }

        /// <summary>
        /// 最大值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxValue")]
        public long? MaxValue{ get; set; }

        /// <summary>
        /// 最小值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinValue")]
        public long? MinValue{ get; set; }

        /// <summary>
        /// 配置等级(1-普通，2-高级，3-管理员)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfLevel")]
        public long? ConfLevel{ get; set; }

        /// <summary>
        /// 候选文本列表(，分隔)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CandidateTexts")]
        public string CandidateTexts{ get; set; }

        /// <summary>
        /// 复制时是否需要修改
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CopyKey")]
        public long? CopyKey{ get; set; }

        /// <summary>
        /// 字段正则表达式校验
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Regex")]
        public string Regex{ get; set; }

        /// <summary>
        /// 字段正则表达式校验证提示tip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tip")]
        public string Tip{ get; set; }

        /// <summary>
        /// 可选值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Candidates")]
        public CandidateDsDTo[] Candidates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "PropName", this.PropName);
            this.SetParamSimple(map, prefix + "PropLabel", this.PropLabel);
            this.SetParamSimple(map, prefix + "DefaultFlag", this.DefaultFlag);
            this.SetParamSimple(map, prefix + "VisibleFlag", this.VisibleFlag);
            this.SetParamSimple(map, prefix + "PropDesc", this.PropDesc);
            this.SetParamSimple(map, prefix + "RankId", this.RankId);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "CandidateValues", this.CandidateValues);
            this.SetParamSimple(map, prefix + "IsMandatory", this.IsMandatory);
            this.SetParamSimple(map, prefix + "MaxValue", this.MaxValue);
            this.SetParamSimple(map, prefix + "MinValue", this.MinValue);
            this.SetParamSimple(map, prefix + "ConfLevel", this.ConfLevel);
            this.SetParamSimple(map, prefix + "CandidateTexts", this.CandidateTexts);
            this.SetParamSimple(map, prefix + "CopyKey", this.CopyKey);
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
            this.SetParamSimple(map, prefix + "Tip", this.Tip);
            this.SetParamArrayObj(map, prefix + "Candidates.", this.Candidates);
        }
    }
}

