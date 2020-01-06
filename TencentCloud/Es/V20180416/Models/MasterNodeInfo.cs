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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MasterNodeInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否启用了专用主节点
        /// </summary>
        [JsonProperty("EnableDedicatedMaster")]
        public bool? EnableDedicatedMaster{ get; set; }

        /// <summary>
        /// 专用主节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE32：16核32G</li><li>ES.S1.4XLARGE64：16核64G</li>
        /// </summary>
        [JsonProperty("MasterNodeType")]
        public string MasterNodeType{ get; set; }

        /// <summary>
        /// 专用主节点个数
        /// </summary>
        [JsonProperty("MasterNodeNum")]
        public ulong? MasterNodeNum{ get; set; }

        /// <summary>
        /// 专用主节点CPU核数
        /// </summary>
        [JsonProperty("MasterNodeCpuNum")]
        public ulong? MasterNodeCpuNum{ get; set; }

        /// <summary>
        /// 专用主节点内存大小，单位GB
        /// </summary>
        [JsonProperty("MasterNodeMemSize")]
        public ulong? MasterNodeMemSize{ get; set; }

        /// <summary>
        /// 专用主节点磁盘大小，单位GB
        /// </summary>
        [JsonProperty("MasterNodeDiskSize")]
        public ulong? MasterNodeDiskSize{ get; set; }

        /// <summary>
        /// 专用主节点磁盘类型
        /// </summary>
        [JsonProperty("MasterNodeDiskType")]
        public string MasterNodeDiskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableDedicatedMaster", this.EnableDedicatedMaster);
            this.SetParamSimple(map, prefix + "MasterNodeType", this.MasterNodeType);
            this.SetParamSimple(map, prefix + "MasterNodeNum", this.MasterNodeNum);
            this.SetParamSimple(map, prefix + "MasterNodeCpuNum", this.MasterNodeCpuNum);
            this.SetParamSimple(map, prefix + "MasterNodeMemSize", this.MasterNodeMemSize);
            this.SetParamSimple(map, prefix + "MasterNodeDiskSize", this.MasterNodeDiskSize);
            this.SetParamSimple(map, prefix + "MasterNodeDiskType", this.MasterNodeDiskType);
        }
    }
}

