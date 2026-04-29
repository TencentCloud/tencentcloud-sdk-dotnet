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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RayCluster : AbstractModel
    {
        
        /// <summary>
        /// <p>RayCluster 集群名</p>
        /// </summary>
        [JsonProperty("RayClusterName")]
        public string RayClusterName{ get; set; }

        /// <summary>
        /// <p>RayCluster 集群 id</p>
        /// </summary>
        [JsonProperty("RayClusterId")]
        public long? RayClusterId{ get; set; }

        /// <summary>
        /// <p>pod 数量</p>
        /// </summary>
        [JsonProperty("PodCount")]
        public long? PodCount{ get; set; }

        /// <summary>
        /// <p>集群创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>redis 实例数量</p>
        /// </summary>
        [JsonProperty("RedisCount")]
        public long? RedisCount{ get; set; }

        /// <summary>
        /// <p>创建类型</p><p>枚举值：</p><ul><li>1： 表单创建</li><li>2： yaml创建</li></ul>
        /// </summary>
        [JsonProperty("SubmitType")]
        public long? SubmitType{ get; set; }

        /// <summary>
        /// <p>head访问地址,也是dashboard地址</p>
        /// </summary>
        [JsonProperty("DashboardUrl")]
        public string DashboardUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RayClusterName", this.RayClusterName);
            this.SetParamSimple(map, prefix + "RayClusterId", this.RayClusterId);
            this.SetParamSimple(map, prefix + "PodCount", this.PodCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RedisCount", this.RedisCount);
            this.SetParamSimple(map, prefix + "SubmitType", this.SubmitType);
            this.SetParamSimple(map, prefix + "DashboardUrl", this.DashboardUrl);
        }
    }
}

