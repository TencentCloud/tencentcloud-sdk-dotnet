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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentToolRspParam : AbstractModel
    {
        
        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 参数类型，0:string, 1:int, 2:float，3:bool 4:object 5:array_string, 6:array_int, 7:array_float, 8:array_bool, 9:array_object
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 子参数,ParamType 是OBJECT 或 ARRAY<>类型有用
        /// </summary>
        [JsonProperty("SubParams")]
        public AgentToolRspParam[] SubParams{ get; set; }

        /// <summary>
        /// agent模式下模型是否可见
        /// </summary>
        [JsonProperty("AgentHidden")]
        public bool? AgentHidden{ get; set; }

        /// <summary>
        /// 是否隐藏不可见
        /// </summary>
        [JsonProperty("GlobalHidden")]
        public bool? GlobalHidden{ get; set; }

        /// <summary>
        /// COVER: 覆盖解析 INCREMENT:增量解析
        /// </summary>
        [JsonProperty("AnalysisMethod")]
        public string AnalysisMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "SubParams.", this.SubParams);
            this.SetParamSimple(map, prefix + "AgentHidden", this.AgentHidden);
            this.SetParamSimple(map, prefix + "GlobalHidden", this.GlobalHidden);
            this.SetParamSimple(map, prefix + "AnalysisMethod", this.AnalysisMethod);
        }
    }
}

