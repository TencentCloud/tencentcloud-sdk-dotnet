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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBPriceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例时长，单位：月，最小值 1，最大值为 36；查询按量计费价格时，该字段无效。</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>可用区信息，格式如 &quot;ap-guangzhou-2&quot;。具体能设置的值请通过 <a href="https://cloud.tencent.com/document/api/236/17229">DescribeDBZoneConfig</a> 接口查询。InstanceId为空时该参数为必填项。</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>实例数量，默认值为 1，最小值 1，最大值为 100。InstanceId为空时该参数为必填项。</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// <p>实例内存大小，单位：MB。InstanceId 为空时该参数为必填项。为保证传入值有效，请使用 <a href="https://cloud.tencent.com/document/product/236/17229">获取云数据库可售卖规格</a> 接口获取可售卖的实例内存大小范围。</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>实例硬盘大小，单位：GB。InstanceId 为空时该参数为必填项。为保证传入值有效，请使用 <a href="https://cloud.tencent.com/document/product/236/17229">获取云数据库可售卖规格</a> 接口获取可售卖的硬盘大小范围。</p>
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// <p>实例类型，默认为 master，支持值包括：master - 表示主实例，ro - 表示只读实例，dr - 表示灾备实例。InstanceId为空时该参数为必填项。</p>
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// <p>付费类型，支持值包括：PRE_PAID - 包年包月，HOUR_PAID - 按量计费。InstanceId为空时该参数为必填项。</p>
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// <p>数据复制方式，默认为 0，支持值包括：0 - 表示异步复制，1 - 表示半同步复制，2 - 表示强同步复制。</p>
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// <p>实例隔离类型。</p><p>枚举值：</p><ul><li>UNIVERSAL： 通用型实例</li><li>EXCLUSIVE： 独享型实例</li><li>CLOUD_NATIVE_CLUSTER： 云盘版标准型</li><li>CLOUD_NATIVE_CLUSTER_EXCLUSIVE： 云盘版加强型</li><li>CLOUD_NATIVE_CLUSTER_ULTRA： 云盘版旗舰型</li></ul><p>默认值：UNIVERSAL</p><p>如需查询单节点云盘版实例的价格，请设置此参数为 CLOUD_NATIVE_CLUSTER，并且指定参数 InstanceNodes 为1。</p>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>实例节点数。<br>1.查询 RO 实例或者单节点实例价格时，此字段值为1。<br>2.查询双节点实例价格时，此字段值为2。<br>3.查询三节点实例价格时，此字段值为3。<br>4.查询云盘版实例价格时，此字段值范围可输入2 - 6，取值为2表示云盘版实例下对应有1个读写节点 + 1个只读节点；取值为6表示云盘版实例下对应有1个读写节点 + 5个只读节点；其余取值（3 - 5）按1个读写节点 +（取值数 - 1）个只读节点规则类推。</p>
        /// </summary>
        [JsonProperty("InstanceNodes")]
        public long? InstanceNodes{ get; set; }

        /// <summary>
        /// <p>询价实例的CPU核心数目，单位：核，为保证传入 CPU 值有效，请使用 <a href="https://cloud.tencent.com/document/product/236/17229">获取云数据库可售卖规格</a> 接口获取可售卖的核心数目，当未指定该值时，将按照 Memory 大小补全一个默认值。</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>询价续费实例ID。如需查询实例续费价格，填写InstanceId和Period即可。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>按量计费阶梯。仅PayType=HOUR_PAID有效，支持值包括：1，2，3。阶梯时长见https://cloud.tencent.com/document/product/236/18335。</p>
        /// </summary>
        [JsonProperty("Ladder")]
        public ulong? Ladder{ get; set; }

        /// <summary>
        /// <p>磁盘类型，查询云盘版、单节点云盘版实例价格可以指定该参数。默认值为 SSD 云硬盘。<br>支持值包括：<br>&quot;CLOUD_SSD&quot; - SSD 云硬盘。<br>&quot;CLOUD_HSSD&quot; - 增强型 SSD 云硬盘。<br>&quot;CLOUD_PREMIUM&quot; - 高性能云硬盘。</p>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "InstanceNodes", this.InstanceNodes);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Ladder", this.Ladder);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
        }
    }
}

