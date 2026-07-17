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

    public class DescribeDetailedSingleProbeDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>开始时间戳（毫秒级）</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public ulong? BeginTime{ get; set; }

        /// <summary>
        /// <p>结束时间戳（毫秒级）</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// <p>任务类型<br>AnalyzeTaskType_Network：网络质量<br>AnalyzeTaskType_Browse：页面性能<br>AnalyzeTaskType_UploadDownload：文件传输（含文件上传、文件下载）<br>AnalyzeTaskType_Transport：端口性能<br>AnalyzeTaskType_MediaStream：音视频体验</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>待排序字段<br>可以填写 ProbeTime 拨测时间排序<br>也可填写SelectedFields 中的选中字段</p>
        /// </summary>
        [JsonProperty("SortField")]
        public string SortField{ get; set; }

        /// <summary>
        /// <p>true表示升序</p>
        /// </summary>
        [JsonProperty("Ascending")]
        public bool? Ascending{ get; set; }

        /// <summary>
        /// <p>选中字段，如ProbeTime、TransferTime、TransferSize等。</p>
        /// </summary>
        [JsonProperty("SelectedFields")]
        public string[] SelectedFields{ get; set; }

        /// <summary>
        /// <p>起始取数位置</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>取数数量</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskID")]
        public string[] TaskID{ get; set; }

        /// <summary>
        /// <p>拨测点运营商</p><p>这里实际按拨测结果中的运营商来填写即可</p><p>电信：中国电信<br>移动：中国移动<br>联通：中国联通</p>
        /// </summary>
        [JsonProperty("Operators")]
        public string[] Operators{ get; set; }

        /// <summary>
        /// <p>拨测点地区</p><p>这里实际按拨测结果中的地区来填写即可</p><p>国内一般是省级单位，如广东、广西、中国香港；直辖市则填北京、上海</p><p>境外一般是国家名，如澳大利亚、新加坡</p>
        /// </summary>
        [JsonProperty("Districts")]
        public string[] Districts{ get; set; }

        /// <summary>
        /// <p>错误类型</p>
        /// </summary>
        [JsonProperty("ErrorTypes")]
        public string[] ErrorTypes{ get; set; }

        /// <summary>
        /// <p>城市<br>这里实际按拨测结果中的城市来填写即可</p><p>示例：</p><p>深圳市<br>武汉市<br>首尔<br>多伦多</p>
        /// </summary>
        [JsonProperty("City")]
        public string[] City{ get; set; }

        /// <summary>
        /// <p>es scroll查询id</p>
        /// </summary>
        [JsonProperty("ScrollID")]
        public string ScrollID{ get; set; }

        /// <summary>
        /// <p>详情数据下载</p>
        /// </summary>
        [JsonProperty("QueryFlag")]
        public string QueryFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "SortField", this.SortField);
            this.SetParamSimple(map, prefix + "Ascending", this.Ascending);
            this.SetParamArraySimple(map, prefix + "SelectedFields.", this.SelectedFields);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "TaskID.", this.TaskID);
            this.SetParamArraySimple(map, prefix + "Operators.", this.Operators);
            this.SetParamArraySimple(map, prefix + "Districts.", this.Districts);
            this.SetParamArraySimple(map, prefix + "ErrorTypes.", this.ErrorTypes);
            this.SetParamArraySimple(map, prefix + "City.", this.City);
            this.SetParamSimple(map, prefix + "ScrollID", this.ScrollID);
            this.SetParamSimple(map, prefix + "QueryFlag", this.QueryFlag);
        }
    }
}

