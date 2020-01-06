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

namespace TencentCloud.Tia.V20180226.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstallAgentRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }

        /// <summary>
        /// Agent版本, 用于私有集群的agent安装，默认为“private-training”
        /// </summary>
        [JsonProperty("TiaVersion")]
        public string TiaVersion{ get; set; }

        /// <summary>
        /// 是否允许更新Agent
        /// </summary>
        [JsonProperty("Update")]
        public bool? Update{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
            this.SetParamSimple(map, prefix + "TiaVersion", this.TiaVersion);
            this.SetParamSimple(map, prefix + "Update", this.Update);
        }
    }
}

