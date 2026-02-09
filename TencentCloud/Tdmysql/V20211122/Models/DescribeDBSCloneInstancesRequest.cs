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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBSCloneInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>源实例ID</p>
        /// </summary>
        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId{ get; set; }

        /// <summary>
        /// <p>引擎类型</p>
        /// </summary>
        [JsonProperty("DBType")]
        public string DBType{ get; set; }

        /// <summary>
        /// <p>结束创建时间</p>
        /// </summary>
        [JsonProperty("EndCreateTime")]
        public string EndCreateTime{ get; set; }

        /// <summary>
        /// <p>克隆类型: PITR 时间点 BackupSet 备份集</p>
        /// </summary>
        [JsonProperty("FilterCloneType")]
        public string FilterCloneType{ get; set; }

        /// <summary>
        /// <p>查询数量[0,200]</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>查询偏移量[0,INF]</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>排序字段: CloneTime,CreateTime</p>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// <p>排序类型:ASC,DESC</p>
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// <p>开始创建时间</p>
        /// </summary>
        [JsonProperty("StartCreateTime")]
        public string StartCreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceInstanceId", this.SourceInstanceId);
            this.SetParamSimple(map, prefix + "DBType", this.DBType);
            this.SetParamSimple(map, prefix + "EndCreateTime", this.EndCreateTime);
            this.SetParamSimple(map, prefix + "FilterCloneType", this.FilterCloneType);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "StartCreateTime", this.StartCreateTime);
        }
    }
}

