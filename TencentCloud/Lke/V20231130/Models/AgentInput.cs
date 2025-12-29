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

    public class AgentInput : AbstractModel
    {
        
        /// <summary>
        /// 输入来源类型：0 用户输入，3 自定义变量（API参数）
        /// </summary>
        [JsonProperty("InputType")]
        public ulong? InputType{ get; set; }

        /// <summary>
        /// 用户手写输入
        /// </summary>
        [JsonProperty("UserInputValue")]
        public AgentInputUserInputValue UserInputValue{ get; set; }

        /// <summary>
        /// 自定义变量（API参数）
        /// </summary>
        [JsonProperty("CustomVarId")]
        public string CustomVarId{ get; set; }

        /// <summary>
        /// 环境变量参数
        /// </summary>
        [JsonProperty("EnvVarId")]
        public string EnvVarId{ get; set; }

        /// <summary>
        /// 应用变量参数
        /// </summary>
        [JsonProperty("AppVarId")]
        public string AppVarId{ get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        [JsonProperty("SystemVariable")]
        public AgentInputSystemVariable SystemVariable{ get; set; }

        /// <summary>
        /// 工具参数
        /// </summary>
        [JsonProperty("ToolParam")]
        public string ToolParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamObj(map, prefix + "UserInputValue.", this.UserInputValue);
            this.SetParamSimple(map, prefix + "CustomVarId", this.CustomVarId);
            this.SetParamSimple(map, prefix + "EnvVarId", this.EnvVarId);
            this.SetParamSimple(map, prefix + "AppVarId", this.AppVarId);
            this.SetParamObj(map, prefix + "SystemVariable.", this.SystemVariable);
            this.SetParamSimple(map, prefix + "ToolParam", this.ToolParam);
        }
    }
}

