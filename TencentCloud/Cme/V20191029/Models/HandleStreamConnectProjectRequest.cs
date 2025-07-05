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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HandleStreamConnectProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 云转推项目 Id 。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 请参考 [操作类型](#Operation)
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 转推输入源操作参数。具体操作方式详见 [操作类型](#Operation) 及下文示例。
        /// </summary>
        [JsonProperty("InputInfo")]
        public StreamInputInfo InputInfo{ get; set; }

        /// <summary>
        /// 主备输入源标识，取值有：
        /// <li> Main ：主源；</li>
        /// <li> Backup ：备源。</li>
        /// </summary>
        [JsonProperty("InputEndpoint")]
        public string InputEndpoint{ get; set; }

        /// <summary>
        /// 转推输出源操作参数。具体操作方式详见 [操作类型](#Operation) 及下文示例。
        /// </summary>
        [JsonProperty("OutputInfo")]
        public StreamConnectOutput OutputInfo{ get; set; }

        /// <summary>
        /// 云转推当前预计结束时间，采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。具体操作方式详见 [操作类型](#Operation) 及下文示例。
        /// </summary>
        [JsonProperty("CurrentStopTime")]
        public string CurrentStopTime{ get; set; }

        /// <summary>
        /// 操作者。如不填，默认为 `cmeid_system`，表示平台管理员操作，可以操作所有云转推项目。如果指定操作者，则操作者必须为项目所有者。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamSimple(map, prefix + "InputEndpoint", this.InputEndpoint);
            this.SetParamObj(map, prefix + "OutputInfo.", this.OutputInfo);
            this.SetParamSimple(map, prefix + "CurrentStopTime", this.CurrentStopTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

