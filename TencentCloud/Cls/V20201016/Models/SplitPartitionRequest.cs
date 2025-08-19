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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SplitPartitionRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志主题Id
        /// - 通过[获取日志主题列表](https://cloud.tencent.com/document/product/614/56454)获取日志主题Id。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 待分裂分区Id
        /// - 通过[获取分区列表](https://cloud.tencent.com/document/product/614/56470)获取待分裂分区Id。
        /// </summary>
        [JsonProperty("PartitionId")]
        public long? PartitionId{ get; set; }

        /// <summary>
        /// 分区切分的哈希key的位置，只在Number=2时有意义
        /// </summary>
        [JsonProperty("SplitKey")]
        public string SplitKey{ get; set; }

        /// <summary>
        /// 分区分裂个数(可选)，默认等于2
        /// </summary>
        [JsonProperty("Number")]
        public long? Number{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "PartitionId", this.PartitionId);
            this.SetParamSimple(map, prefix + "SplitKey", this.SplitKey);
            this.SetParamSimple(map, prefix + "Number", this.Number);
        }
    }
}

