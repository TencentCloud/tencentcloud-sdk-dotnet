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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LocalDiskType : AbstractModel
    {
        
        /// <summary>
        /// 本地磁盘类型。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 本地磁盘属性。
        /// </summary>
        [JsonProperty("PartitionType")]
        public string PartitionType{ get; set; }

        /// <summary>
        /// 本地磁盘最小值。
        /// </summary>
        [JsonProperty("MinSize")]
        public long? MinSize{ get; set; }

        /// <summary>
        /// 本地磁盘最大值。
        /// </summary>
        [JsonProperty("MaxSize")]
        public long? MaxSize{ get; set; }

        /// <summary>
        /// 购买时本地盘是否为必选。取值范围：<br><li>REQUIRED：表示必选<br><li>OPTIONAL：表示可选。
        /// </summary>
        [JsonProperty("Required")]
        public string Required{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "PartitionType", this.PartitionType);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "Required", this.Required);
        }
    }
}

