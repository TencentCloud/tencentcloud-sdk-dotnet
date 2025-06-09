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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// 磁盘数量
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 系统盘类型 取值范围：
        /// <li>CLOUD_SSD：表示云SSD。</li>
        /// <li>CLOUD_PREMIUM：表示高效云盘。</li>
        /// <li>CLOUD_BASIC：表示云硬盘。</li>
        /// <li>LOCAL_BASIC：表示本地盘。</li>
        /// <li>LOCAL_SSD：表示本地SSD。</li>
        /// 
        /// 数据盘类型 取值范围：
        /// <li>CLOUD_SSD：表示云SSD。</li>
        /// <li>CLOUD_PREMIUM：表示高效云盘。</li>
        /// <li>CLOUD_BASIC：表示云硬盘。</li>
        /// <li>LOCAL_BASIC：表示本地盘。</li>
        /// <li>LOCAL_SSD：表示本地SSD。</li>
        /// <li>CLOUD_HSSD：表示增强型SSD云硬盘。</li>
        /// <li>CLOUD_THROUGHPUT：表示吞吐型云硬盘。</li>
        /// <li>CLOUD_TSSD：表示极速型SSD云硬盘。</li>
        /// <li>CLOUD_BIGDATA：表示大数据型云硬盘。</li>
        /// <li>CLOUD_HIGHIO：表示高IO型云硬盘。</li>
        /// <li>CLOUD_BSSD：表示通用型SSD云硬盘。</li>
        /// <li>REMOTE_SSD：表示远端SSD盘。</li>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 数据容量，单位为GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 额外性能
        /// </summary>
        [JsonProperty("ExtraPerformance")]
        public long? ExtraPerformance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "ExtraPerformance", this.ExtraPerformance);
        }
    }
}

