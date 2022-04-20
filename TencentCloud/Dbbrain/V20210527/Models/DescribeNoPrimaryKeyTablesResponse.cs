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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNoPrimaryKeyTablesResponse : AbstractModel
    {
        
        /// <summary>
        /// 无主键表总数。
        /// </summary>
        [JsonProperty("NoPrimaryKeyTableCount")]
        public long? NoPrimaryKeyTableCount{ get; set; }

        /// <summary>
        /// 与昨日扫描无主键表的差值，正数为增加，负数为减少，0为无变化。
        /// </summary>
        [JsonProperty("NoPrimaryKeyTableCountDiff")]
        public long? NoPrimaryKeyTableCountDiff{ get; set; }

        /// <summary>
        /// 记录的无主键表总数（不超过无主键表总数），可用于分页查询。
        /// </summary>
        [JsonProperty("NoPrimaryKeyTableRecordCount")]
        public long? NoPrimaryKeyTableRecordCount{ get; set; }

        /// <summary>
        /// 无主键表列表。
        /// </summary>
        [JsonProperty("NoPrimaryKeyTables")]
        public Table[] NoPrimaryKeyTables{ get; set; }

        /// <summary>
        /// 采集时间戳（秒）。
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoPrimaryKeyTableCount", this.NoPrimaryKeyTableCount);
            this.SetParamSimple(map, prefix + "NoPrimaryKeyTableCountDiff", this.NoPrimaryKeyTableCountDiff);
            this.SetParamSimple(map, prefix + "NoPrimaryKeyTableRecordCount", this.NoPrimaryKeyTableRecordCount);
            this.SetParamArrayObj(map, prefix + "NoPrimaryKeyTables.", this.NoPrimaryKeyTables);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

