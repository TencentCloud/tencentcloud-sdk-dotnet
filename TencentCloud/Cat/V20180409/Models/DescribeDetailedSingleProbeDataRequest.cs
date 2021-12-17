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
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 待排序字段
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
        /// </summary>
        [JsonProperty("Operators")]
        public string[] Operators{ get; set; }

        /// <summary>
        /// 拨测点地区
        /// </summary>
        [JsonProperty("Districts")]
        public string[] Districts{ get; set; }

        /// <summary>
        /// 错误类型
        /// </summary>
        [JsonProperty("ErrorTypes")]
        public string[] ErrorTypes{ get; set; }


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
        }
    }
}

