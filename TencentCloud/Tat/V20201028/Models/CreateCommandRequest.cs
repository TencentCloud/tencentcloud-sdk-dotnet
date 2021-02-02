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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// 命令名称。名称仅支持中文、英文、数字、下划线、分隔符"-"、小数点，最大长度不能超60个字节。
        /// </summary>
        [JsonProperty("CommandName")]
        public string CommandName{ get; set; }

        /// <summary>
        /// Base64编码后的命令内容，长度不可超过64KB。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 命令描述。不超过120字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 命令类型，目前仅支持取值：SHELL。默认：SHELL。
        /// </summary>
        [JsonProperty("CommandType")]
        public string CommandType{ get; set; }

        /// <summary>
        /// 命令执行路径，默认：/root。
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// 命令超时时间，默认60秒。取值范围[1, 86400]。
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommandName", this.CommandName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CommandType", this.CommandType);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
        }
    }
}

