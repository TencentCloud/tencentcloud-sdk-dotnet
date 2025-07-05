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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquirePriceCreateRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区,每个地域提供最佳实践
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 购买计算节点个数
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// 实例购买类型，可选值为：PREPAID, POSTPAID, SERVERLESS
        /// </summary>
        [JsonProperty("InstancePayMode")]
        public string InstancePayMode{ get; set; }

        /// <summary>
        /// 存储购买类型，可选值为：PREPAID, POSTPAID
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public string StoragePayMode{ get; set; }

        /// <summary>
        /// 实例设备类型
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// CPU核数，PREPAID与POSTPAID实例类型必传
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存大小，单位G，PREPAID与POSTPAID实例类型必传
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Ccu大小，serverless类型必传
        /// </summary>
        [JsonProperty("Ccu")]
        public float? Ccu{ get; set; }

        /// <summary>
        /// 存储大小，PREPAID存储类型必传
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// 购买时长，PREPAID购买类型必传
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 时长单位，可选值为：m,d。PREPAID购买类型必传
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "InstancePayMode", this.InstancePayMode);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Ccu", this.Ccu);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
        }
    }
}

