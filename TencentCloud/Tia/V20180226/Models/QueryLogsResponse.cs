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

namespace TencentCloud.Tia.V20180226.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryLogsResponse : AbstractModel
    {
        
        /// <summary>
        /// 日志查询上下文，用于加载更多日志
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 日志内容列表
        /// </summary>
        [JsonProperty("Logs")]
        public LogInfo[] Logs{ get; set; }

        /// <summary>
        /// 是否已经返回所有符合条件的日志
        /// </summary>
        [JsonProperty("Listover")]
        public bool? Listover{ get; set; }

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
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamArrayObj(map, prefix + "Logs.", this.Logs);
            this.SetParamSimple(map, prefix + "Listover", this.Listover);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

