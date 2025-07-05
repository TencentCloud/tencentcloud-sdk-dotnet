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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PreviewReplacedCommandContentRequest : AbstractModel
    {
        
        /// <summary>
        /// 本次预览采用的自定义参数。字段类型为 json encoded string，如：{"varA": "222"}。
        /// 仅在命令的 EnableParameter 为 true 时，才允许设置此参数。可通过 [DescribeCommands(查询命令详情)](https://cloud.tencent.com/document/api/1340/52681) 接口获取命令的 EnableParameter 设置。
        /// 如果有设置过 DefaultParameters 或 DefaultParameterConfs，会与 Parameters 进行叠加，优先使用 Parameters 的值。
        /// 
        /// key 为自定义参数名称，value 为该参数的取值。kv 均为字符串型。
        /// 自定义参数最多 20 个。
        /// 自定义参数名称需符合以下规范：字符数目上限 64，可选范围【a-zA-Z0-9-_】。
        /// 如果将预览的 CommandId 设置过 DefaultParameters，本参数可以为空。
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// 要进行替换预览的命令。
        /// 可通过 [DescribeCommands(查询命令详情)](https://cloud.tencent.com/document/api/1340/52681) 接口获取。
        /// CommandId 与 Content，必须且只能提供一个。
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// 要预览的命令内容，经 Base64 编码，长度不可超过 64KB。
        /// CommandId 与 Content，必须且只能提供一个。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
        }
    }
}

