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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCdcClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// cdc的id
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// vpcId,一个地域只有唯一一个vpcid用于CDC
        /// </summary>
        [JsonProperty("CdcVpcId")]
        public string CdcVpcId{ get; set; }

        /// <summary>
        /// 每个CDC集群有唯一一个子网ID
        /// </summary>
        [JsonProperty("CdcSubnetId")]
        public string CdcSubnetId{ get; set; }

        /// <summary>
        /// 所在可用区ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 实例带宽,单位MB/s; 最小值:20MB/s, 高级版最大值:360MB/s,专业版最大值:100000MB/s  标准版固定带宽规格: 40MB/s, 100MB/s, 150MB/s
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// cdc集群的总磁盘
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// ckafka集群实例磁盘类型
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 系统盘类型
        /// </summary>
        [JsonProperty("SystemDiskType")]
        public string SystemDiskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "CdcVpcId", this.CdcVpcId);
            this.SetParamSimple(map, prefix + "CdcSubnetId", this.CdcSubnetId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "SystemDiskType", this.SystemDiskType);
        }
    }
}

