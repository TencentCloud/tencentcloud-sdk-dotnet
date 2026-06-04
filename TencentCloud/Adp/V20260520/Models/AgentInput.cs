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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentInput : AbstractModel
    {
        
        /// <summary>
        /// <p>输入来源类型：0 用户输入，3 自定义变量（API参数）</p>
        /// </summary>
        [JsonProperty("InputType")]
        public long? InputType{ get; set; }

        /// <summary>
        /// <p>用户手写输入</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserInputValue")]
        public AgentUserInputValue UserInputValue{ get; set; }

        /// <summary>
        /// <p>系统参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemVariable")]
        public AgentSystemVariable SystemVariable{ get; set; }

        /// <summary>
        /// <p>自定义变量（API参数）</p>
        /// </summary>
        [JsonProperty("CustomVariableId")]
        public string CustomVariableId{ get; set; }

        /// <summary>
        /// <p>环境变量参数</p>
        /// </summary>
        [JsonProperty("EnvVariableId")]
        public string EnvVariableId{ get; set; }

        /// <summary>
        /// <p>应用变量参数</p>
        /// </summary>
        [JsonProperty("AppVariableId")]
        public string AppVariableId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamObj(map, prefix + "UserInputValue.", this.UserInputValue);
            this.SetParamObj(map, prefix + "SystemVariable.", this.SystemVariable);
            this.SetParamSimple(map, prefix + "CustomVariableId", this.CustomVariableId);
            this.SetParamSimple(map, prefix + "EnvVariableId", this.EnvVariableId);
            this.SetParamSimple(map, prefix + "AppVariableId", this.AppVariableId);
        }
    }
}

