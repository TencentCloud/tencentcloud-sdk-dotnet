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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRsgAsGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源组 ID
        /// </summary>
        [JsonProperty("RsgId")]
        public string RsgId{ get; set; }

        /// <summary>
        /// 伸缩组允许的最大节点数
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// 伸缩组允许的最小节点数
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// 伸缩组的节点规格
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 资源组所在的集群名
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }

        /// <summary>
        /// 伸缩组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 伸缩组期望的节点数
        /// </summary>
        [JsonProperty("DesiredSize")]
        public ulong? DesiredSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RsgId", this.RsgId);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DesiredSize", this.DesiredSize);
        }
    }
}

