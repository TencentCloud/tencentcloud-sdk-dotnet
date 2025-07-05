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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ObjectTypeJsonParse : AbstractModel
    {
        
        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("NameSpace")]
        public string NameSpace{ get; set; }

        /// <summary>
        /// 工作负载名称
        /// </summary>
        [JsonProperty("WorkloadName")]
        public string WorkloadName{ get; set; }

        /// <summary>
        /// 节点IP
        /// </summary>
        [JsonProperty("LanIP")]
        public string LanIP{ get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
            this.SetParamSimple(map, prefix + "WorkloadName", this.WorkloadName);
            this.SetParamSimple(map, prefix + "LanIP", this.LanIP);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

