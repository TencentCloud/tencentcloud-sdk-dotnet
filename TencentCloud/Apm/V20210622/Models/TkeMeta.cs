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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TkeMeta : AbstractModel
    {
        
        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// pod name
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 工作负载
        /// </summary>
        [JsonProperty("Deployment")]
        public string Deployment{ get; set; }

        /// <summary>
        /// pod ip
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// node ip
        /// </summary>
        [JsonProperty("NodeIP")]
        public string NodeIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Deployment", this.Deployment);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "NodeIP", this.NodeIP);
        }
    }
}

