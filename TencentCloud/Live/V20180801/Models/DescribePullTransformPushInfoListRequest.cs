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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePullTransformPushInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// utc开始时间，格式为：yyyy-mm-ddTHH:MM:SSZ，参考https://cloud.tencent.com/document/product/266/11732#I，
        /// 例如：北京时间2019-01-08 10:00:00，对应utc时间为：2019-01-08T10:00:00+08:00。
        /// 支持最近一个月的查询。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// utc结束时间，格式为：yyyy-mm-ddTHH:MM:SSZ，参考https://cloud.tencent.com/document/product/266/11732#I，
        /// 例如：北京时间2019-01-08 10:00:00，对应utc时间为：2019-01-08T10:00:00+08:00。
        /// 支持最近一个月的查询，时间跨度为一个月。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 拉流转推任务Id。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

