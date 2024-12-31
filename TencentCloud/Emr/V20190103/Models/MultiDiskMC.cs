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

    public class MultiDiskMC : AbstractModel
    {
        
        /// <summary>
        /// 该类型云盘个数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 磁盘类型
        /// 1  :本地盘
        /// 2  :云硬盘
        /// 3  : 本地SSD
        /// 4  : 云SSD
        /// 5  : 高效云盘
        /// 6  : 增强型SSD云硬盘
        /// 11 : 吞吐型云硬盘
        /// 12 : 极速型SSD云硬盘
        /// 13 : 通用型SSD云硬盘
        /// 14 : 大数据型云硬盘
        /// 15 : 高IO型云硬盘
        /// 16 : 远端SSD盘
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 磁盘大小
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// 云盘大小,单位b
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
        }
    }
}

