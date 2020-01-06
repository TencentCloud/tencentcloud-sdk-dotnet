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

    public class SellConfig : AbstractModel
    {
        
        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("Device")]
        public string Device{ get; set; }

        /// <summary>
        /// 售卖规格描述
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("CdbType")]
        public string CdbType{ get; set; }

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
        /// 链接数
        /// </summary>
        [JsonProperty("Connection")]
        public long? Connection{ get; set; }

        /// <summary>
        /// 每秒查询数量
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

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
        /// 状态值
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Device", this.Device);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CdbType", this.CdbType);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "VolumeMin", this.VolumeMin);
            this.SetParamSimple(map, prefix + "VolumeMax", this.VolumeMax);
            this.SetParamSimple(map, prefix + "VolumeStep", this.VolumeStep);
            this.SetParamSimple(map, prefix + "Connection", this.Connection);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Iops", this.Iops);
            this.SetParamSimple(map, prefix + "Info", this.Info);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

