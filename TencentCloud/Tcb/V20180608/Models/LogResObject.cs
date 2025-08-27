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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogResObject : AbstractModel
    {
        
        /// <summary>
        /// 获取更多检索结果的游标
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 搜索结果是否已经全部返回
        /// </summary>
        [JsonProperty("ListOver")]
        public bool? ListOver{ get; set; }

        /// <summary>
        /// 日志内容信息
        /// </summary>
        [JsonProperty("Results")]
        public LogObject[] Results{ get; set; }

        /// <summary>
        /// 日志聚合结果
        /// </summary>
        [JsonProperty("AnalysisRecords")]
        public string[] AnalysisRecords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "ListOver", this.ListOver);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamArraySimple(map, prefix + "AnalysisRecords.", this.AnalysisRecords);
        }
    }
}

