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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProbeMetricTagValuesRequest : AbstractModel
    {
        
        /// <summary>
        /// 分析任务类型，支持以下几种类型：
        /// AnalyzeTaskType_Network：网络质量
        /// AnalyzeTaskType_Browse：页面性能 
        /// AnalyzeTaskType_Transport：端口性能
        /// AnalyzeTaskType_UploadDownload：文件传输
        /// AnalyzeTaskType_MediaStream：音视频体验
        /// </summary>
        [JsonProperty("AnalyzeTaskType")]
        public string AnalyzeTaskType{ get; set; }

        /// <summary>
        /// 维度标签值，参考：
        /// host：任务域名
        /// errorInfo：状态类型
        /// area：拨测点地区
        /// operator：拨测点运营商
        /// taskId：任务ID
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 过滤条件，可以传单个过滤条件也可以拼接多个参数，支持正则匹配
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// 过滤条件数组
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }

        /// <summary>
        /// 时间范围
        /// </summary>
        [JsonProperty("TimeRange")]
        public string TimeRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnalyzeTaskType", this.AnalyzeTaskType);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "TimeRange", this.TimeRange);
        }
    }
}

