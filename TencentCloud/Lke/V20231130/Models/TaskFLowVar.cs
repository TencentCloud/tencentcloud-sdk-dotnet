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

    public class TaskFLowVar : AbstractModel
    {
        
        /// <summary>
        /// 变量ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VarId")]
        public string VarId{ get; set; }

        /// <summary>
        /// 变量名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VarName")]
        public string VarName{ get; set; }

        /// <summary>
        /// 变量描述（默认为"-"）
        /// </summary>
        [JsonProperty("VarDesc")]
        public string VarDesc{ get; set; }

        /// <summary>
        /// 变量类型 (STRING,INT,FLOAT,BOOL,OBJECT,ARRAY_STRING,ARRAY_INT,ARRAY_FLOAT,ARRAY_BOOL,ARRAY_OBJECT,FILE,DOCUMENT,IMAGE,AUDIO)
        /// </summary>
        [JsonProperty("VarType")]
        public string VarType{ get; set; }

        /// <summary>
        /// 自定义变量默认值
        /// </summary>
        [JsonProperty("VarDefaultValue")]
        public string VarDefaultValue{ get; set; }

        /// <summary>
        /// 自定义变量文件默认名称
        /// </summary>
        [JsonProperty("VarDefaultFileName")]
        public string VarDefaultFileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VarId", this.VarId);
            this.SetParamSimple(map, prefix + "VarName", this.VarName);
            this.SetParamSimple(map, prefix + "VarDesc", this.VarDesc);
            this.SetParamSimple(map, prefix + "VarType", this.VarType);
            this.SetParamSimple(map, prefix + "VarDefaultValue", this.VarDefaultValue);
            this.SetParamSimple(map, prefix + "VarDefaultFileName", this.VarDefaultFileName);
        }
    }
}

