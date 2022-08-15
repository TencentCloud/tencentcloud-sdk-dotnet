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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDetailedSingleProbeDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间戳（毫秒级）
        /// </summary>
        [JsonProperty("BeginTime")]
        public ulong? BeginTime{ get; set; }

        /// <summary>
        /// 结束时间戳（毫秒级）
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 任务类型
        /// AnalyzeTaskType_Network：网络质量
        /// AnalyzeTaskType_Browse：页面性能
        /// AnalyzeTaskType_UploadDownload：文件传输（含文件上传、文件下载）
        /// AnalyzeTaskType_Transport：端口性能
        /// AnalyzeTaskType_MediaStream：音视频体验
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 待排序字段
        /// 可以填写 ProbeTime 拨测时间排序
        /// 也可填写SelectedFields 中的选中字段
        /// </summary>
        [JsonProperty("SortField")]
        public string SortField{ get; set; }

        /// <summary>
        /// true表示升序
        /// </summary>
        [JsonProperty("Ascending")]
        public bool? Ascending{ get; set; }

        /// <summary>
        /// 选中字段
        /// </summary>
        [JsonProperty("SelectedFields")]
        public string[] SelectedFields{ get; set; }

        /// <summary>
        /// 起始取数位置
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 取数数量
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskID")]
        public string[] TaskID{ get; set; }

        /// <summary>
        /// 拨测点运营商
        /// 	
        /// 这里实际按拨测结果中的运营商来填写即可
        /// 
        /// 电信：中国电信
        /// 移动：中国移动
        /// 联通：中国联通
        /// </summary>
        [JsonProperty("Operators")]
        public string[] Operators{ get; set; }

        /// <summary>
        /// 拨测点地区
        /// 	
        /// 这里实际按拨测结果中的地区来填写即可
        /// 
        /// 国内一般是省级单位，如广东、广西、中国香港、新疆；直辖市则填北京、上海
        /// 
        /// 境外一般是国家名，如澳大利亚、新加坡
        /// </summary>
        [JsonProperty("Districts")]
        public string[] Districts{ get; set; }

        /// <summary>
        /// 错误类型
        /// </summary>
        [JsonProperty("ErrorTypes")]
        public string[] ErrorTypes{ get; set; }

        /// <summary>
        /// 城市
        /// 这里实际按拨测结果中的城市来填写即可
        /// 
        /// 示例：
        /// 
        /// 深圳市
        /// 武汉市
        /// 首尔
        /// 多伦多
        /// </summary>
        [JsonProperty("City")]
        public string[] City{ get; set; }


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
        }
    }
}

