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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskConfig : AbstractModel
    {
        
        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 云硬盘类型。
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 云硬盘可售卖状态。
        /// </summary>
        [JsonProperty("DiskSalesState")]
        public string DiskSalesState{ get; set; }

        /// <summary>
        /// 最大云硬盘大小。
        /// </summary>
        [JsonProperty("MaxDiskSize")]
        public long? MaxDiskSize{ get; set; }

        /// <summary>
        /// 最小云硬盘大小。
        /// </summary>
        [JsonProperty("MinDiskSize")]
        public long? MinDiskSize{ get; set; }

        /// <summary>
        /// 云硬盘步长。
        /// </summary>
        [JsonProperty("DiskStepSize")]
        public long? DiskStepSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSalesState", this.DiskSalesState);
            this.SetParamSimple(map, prefix + "MaxDiskSize", this.MaxDiskSize);
            this.SetParamSimple(map, prefix + "MinDiskSize", this.MinDiskSize);
            this.SetParamSimple(map, prefix + "DiskStepSize", this.DiskStepSize);
        }
    }
}

