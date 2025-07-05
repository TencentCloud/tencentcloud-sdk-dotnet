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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusInstanceGrantInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否有计费操作权限(1=有，2=无)
        /// </summary>
        [JsonProperty("HasChargeOperation")]
        public long? HasChargeOperation{ get; set; }

        /// <summary>
        /// 是否显示VPC信息的权限(1=有，2=无)
        /// </summary>
        [JsonProperty("HasVpcDisplay")]
        public long? HasVpcDisplay{ get; set; }

        /// <summary>
        /// 是否可修改Grafana的状态(1=有，2=无)
        /// </summary>
        [JsonProperty("HasGrafanaStatusChange")]
        public long? HasGrafanaStatusChange{ get; set; }

        /// <summary>
        /// 是否有管理agent的权限(1=有，2=无)
        /// </summary>
        [JsonProperty("HasAgentManage")]
        public long? HasAgentManage{ get; set; }

        /// <summary>
        /// 是否有管理TKE集成的权限(1=有，2=无)
        /// </summary>
        [JsonProperty("HasTkeManage")]
        public long? HasTkeManage{ get; set; }

        /// <summary>
        /// 是否显示API等信息(1=有, 2=无)
        /// </summary>
        [JsonProperty("HasApiOperation")]
        public long? HasApiOperation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HasChargeOperation", this.HasChargeOperation);
            this.SetParamSimple(map, prefix + "HasVpcDisplay", this.HasVpcDisplay);
            this.SetParamSimple(map, prefix + "HasGrafanaStatusChange", this.HasGrafanaStatusChange);
            this.SetParamSimple(map, prefix + "HasAgentManage", this.HasAgentManage);
            this.SetParamSimple(map, prefix + "HasTkeManage", this.HasTkeManage);
            this.SetParamSimple(map, prefix + "HasApiOperation", this.HasApiOperation);
        }
    }
}

