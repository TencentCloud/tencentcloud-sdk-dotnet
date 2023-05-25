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

    public class ParamDetail : AbstractModel
    {
        
        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// 参数类型：integer，enum，float，string，func
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }

        /// <summary>
        /// true-支持"func"，false-不支持公式
        /// </summary>
        [JsonProperty("SupportFunc")]
        public bool? SupportFunc{ get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 参数当前值
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// 修改参数后，是否需要重启数据库以使参数生效。0-不需要重启，1-需要重启。
        /// </summary>
        [JsonProperty("NeedReboot")]
        public long? NeedReboot{ get; set; }

        /// <summary>
        /// 参数容许的最大值
        /// </summary>
        [JsonProperty("Max")]
        public string Max{ get; set; }

        /// <summary>
        /// 参数容许的最小值
        /// </summary>
        [JsonProperty("Min")]
        public string Min{ get; set; }

        /// <summary>
        /// 参数的可选枚举值。如果为非枚举值，则为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnumValue")]
        public string[] EnumValue{ get; set; }

        /// <summary>
        /// 1：全局参数，0：非全局参数
        /// </summary>
        [JsonProperty("IsGlobal")]
        public long? IsGlobal{ get; set; }

        /// <summary>
        /// 匹配类型，multiVal
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// 匹配目标值，当multiVal时，各个key用，分割
        /// </summary>
        [JsonProperty("MatchValue")]
        public string MatchValue{ get; set; }

        /// <summary>
        /// true-为公式，false-非公式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsFunc")]
        public bool? IsFunc{ get; set; }

        /// <summary>
        /// 参数设置为公式时，Func返回设置的公式内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Func")]
        public string Func{ get; set; }

        /// <summary>
        /// 参数是否可修改
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifiableInfo")]
        public ModifiableInfo ModifiableInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamSimple(map, prefix + "SupportFunc", this.SupportFunc);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "NeedReboot", this.NeedReboot);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamArraySimple(map, prefix + "EnumValue.", this.EnumValue);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "MatchValue", this.MatchValue);
            this.SetParamSimple(map, prefix + "IsFunc", this.IsFunc);
            this.SetParamSimple(map, prefix + "Func", this.Func);
            this.SetParamObj(map, prefix + "ModifiableInfo.", this.ModifiableInfo);
        }
    }
}

