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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBSlowLogsResponse : AbstractModel
    {
        
        /// <summary>
        /// 慢查询日志数据
        /// </summary>
        [JsonProperty("Data")]
        public SlowLogData[] Data{ get; set; }

        /// <summary>
        /// 所有语句锁时间总和
        /// </summary>
        [JsonProperty("LockTimeSum")]
        public float? LockTimeSum{ get; set; }

        /// <summary>
        /// 所有语句查询总次数
        /// </summary>
        [JsonProperty("QueryCount")]
        public long? QueryCount{ get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 所有语句查询时间总和
        /// </summary>
        [JsonProperty("QueryTimeSum")]
        public float? QueryTimeSum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "LockTimeSum", this.LockTimeSum);
            this.SetParamSimple(map, prefix + "QueryCount", this.QueryCount);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "QueryTimeSum", this.QueryTimeSum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

