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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParamInfo : AbstractModel
    {
        
        /// <summary>
        /// 当前值
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// 参数为enum/string/bool时，可选值列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnumValue")]
        public string[] EnumValue{ get; set; }

        /// <summary>
        /// 参数类型为float/integer时的最大值
        /// </summary>
        [JsonProperty("Max")]
        public string Max{ get; set; }

        /// <summary>
        /// 参数类型为float/integer时的最小值
        /// </summary>
        [JsonProperty("Min")]
        public string Min{ get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// 是否需要重启生效
        /// </summary>
        [JsonProperty("NeedReboot")]
        public long? NeedReboot{ get; set; }

        /// <summary>
        /// 参数类型：integer/float/string/enum/bool
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }

        /// <summary>
        /// 匹配类型，multiVal, regex在参数类型是string时使用
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// 匹配目标值，当multiVal时，各个key用;分割
        /// </summary>
        [JsonProperty("MatchValue")]
        public string MatchValue{ get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否为全局参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsGlobal")]
        public long? IsGlobal{ get; set; }

        /// <summary>
        /// 参数是否可修改
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifiableInfo")]
        public ModifiableInfo ModifiableInfo{ get; set; }

        /// <summary>
        /// 是否为函数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsFunc")]
        public bool? IsFunc{ get; set; }

        /// <summary>
        /// 函数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Func")]
        public string Func{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamArraySimple(map, prefix + "EnumValue.", this.EnumValue);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "NeedReboot", this.NeedReboot);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "MatchValue", this.MatchValue);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamObj(map, prefix + "ModifiableInfo.", this.ModifiableInfo);
            this.SetParamSimple(map, prefix + "IsFunc", this.IsFunc);
            this.SetParamSimple(map, prefix + "Func", this.Func);
        }
    }
}

