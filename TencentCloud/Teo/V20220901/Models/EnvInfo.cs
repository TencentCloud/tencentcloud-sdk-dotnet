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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvInfo : AbstractModel
    {
        
        /// <summary>
        /// 环境 ID。
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 环境类型，取值有：
        /// <li>production: 生产环境；</li><li>staging: 测试环境。</li>
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// 环境状态，取值有：
        /// <li>creating：创建中；</li>
        /// <li>running：稳定运行中，可进行版本变更；</li>
        /// <li>version_deploying：版本部署中，不能进行新的变更。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 当前环境的配置生效范围：
        /// <li>当 EnvType 取值为 production 时，该参数值为 ["ALL"]，代表全网生效；</li>
        /// <li>当 EnvType 取值为 staging 时，会返回测试节点 IP，可用于绑定 host 测试。</li>
        /// </summary>
        [JsonProperty("Scope")]
        public string[] Scope{ get; set; }

        /// <summary>
        /// 当前环境中各配置组实际生效的版本，根据 Status 的取值有以下两种情况：
        /// <li>当 Status 取值为 version_deploying 时，本字段返回的值为执行变更动作之前生效的版本，即新版本部署期间，实际生效的版本为执行变更动作之前的版本；</li>
        /// <li>当 Status 取值为 running 时，本字段返回的值即为当前实际生效的版本。</li>
        /// </summary>
        [JsonProperty("CurrentConfigGroupVersionInfos")]
        public ConfigGroupVersionInfo[] CurrentConfigGroupVersionInfos{ get; set; }

        /// <summary>
        /// 创建时间。时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间。时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Scope.", this.Scope);
            this.SetParamArrayObj(map, prefix + "CurrentConfigGroupVersionInfos.", this.CurrentConfigGroupVersionInfos);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

