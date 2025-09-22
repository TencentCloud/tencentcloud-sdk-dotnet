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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SystemDisk : AbstractModel
    {
        
        /// <summary>
        /// 系统盘类型。系统盘类型限制详见[存储概述](https://cloud.tencent.com/document/product/213/4952)。取值范围：<br>
        /// <li>LOCAL_BASIC：本地硬盘</li>
        /// <li>LOCAL_SSD：本地SSD硬盘</li>
        /// <li>CLOUD_BASIC：普通云硬盘</li>
        /// <li>CLOUD_SSD：SSD云硬盘</li>
        /// <li>CLOUD_PREMIUM：高性能云硬盘</li>
        /// <li>CLOUD_BSSD：通用型SSD云硬盘</li>
        /// <li>CLOUD_HSSD：增强型SSD云硬盘</li>
        /// <li>CLOUD_TSSD：极速型SSD云硬盘</li><br>
        /// 默认取值：当前有库存的硬盘类型。
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 系统盘ID。
        /// 该参数目前仅用于 [DescribeInstances](https://cloud.tencent.com/document/product/213/15728) 等查询类接口的返回参数，不可用于 [RunInstances](https://cloud.tencent.com/document/product/213/15730) 等写接口的入参。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 系统盘大小，单位：GiB。默认值为 50
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 所属的独享集群ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// 磁盘名称，长度不超过128 个字符。
        /// </summary>
        [JsonProperty("DiskName")]
        public string DiskName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "DiskName", this.DiskName);
        }
    }
}

