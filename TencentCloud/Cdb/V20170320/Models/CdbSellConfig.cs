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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CdbSellConfig : AbstractModel
    {
        
        /// <summary>
        /// 内存大小，单位为MB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// CPU核心数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 磁盘最小规格，单位为GB
        /// </summary>
        [JsonProperty("VolumeMin")]
        public long? VolumeMin{ get; set; }

        /// <summary>
        /// 磁盘最大规格，单位为GB
        /// </summary>
        [JsonProperty("VolumeMax")]
        public long? VolumeMax{ get; set; }

        /// <summary>
        /// 磁盘步长，单位为GB
        /// </summary>
        [JsonProperty("VolumeStep")]
        public long? VolumeStep{ get; set; }

        /// <summary>
        /// 每秒IO数量
        /// </summary>
        [JsonProperty("Iops")]
        public long? Iops{ get; set; }

        /// <summary>
        /// 应用场景描述
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }

        /// <summary>
        /// 状态值，0 表示该规格对外售卖
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例类型，可能的取值范围有：UNIVERSAL (通用型), EXCLUSIVE (独享型), BASIC (基础型), BASIC_V2 (基础型v2)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 引擎类型描述，可能的取值范围有：Innodb，RocksDB
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// 售卖规格Id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "VolumeMin", this.VolumeMin);
            this.SetParamSimple(map, prefix + "VolumeMax", this.VolumeMax);
            this.SetParamSimple(map, prefix + "VolumeStep", this.VolumeStep);
            this.SetParamSimple(map, prefix + "Iops", this.Iops);
            this.SetParamSimple(map, prefix + "Info", this.Info);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

