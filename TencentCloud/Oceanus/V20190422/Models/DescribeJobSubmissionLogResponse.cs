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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobSubmissionLogResponse : AbstractModel
    {
        
        /// <summary>
        /// 日志搜索的游标，需要搜索更多时透传这个值
        /// </summary>
        [JsonProperty("Cursor")]
        public string Cursor{ get; set; }

        /// <summary>
        /// 是否返回了所有的日志记录
        /// </summary>
        [JsonProperty("ListOver")]
        public bool? ListOver{ get; set; }

        /// <summary>
        /// 作业启动的requestId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobRequestId")]
        public string JobRequestId{ get; set; }

        /// <summary>
        /// 该时间段内符合关键字的所有的作业实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobInstanceList")]
        public JobInstanceForSubmissionLog[] JobInstanceList{ get; set; }

        /// <summary>
        /// 废弃，请使用LogContentList
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogList")]
        public string[] LogList{ get; set; }

        /// <summary>
        /// 日志列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogContentList")]
        public LogContent[] LogContentList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cursor", this.Cursor);
            this.SetParamSimple(map, prefix + "ListOver", this.ListOver);
            this.SetParamSimple(map, prefix + "JobRequestId", this.JobRequestId);
            this.SetParamArrayObj(map, prefix + "JobInstanceList.", this.JobInstanceList);
            this.SetParamArraySimple(map, prefix + "LogList.", this.LogList);
            this.SetParamArrayObj(map, prefix + "LogContentList.", this.LogContentList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

