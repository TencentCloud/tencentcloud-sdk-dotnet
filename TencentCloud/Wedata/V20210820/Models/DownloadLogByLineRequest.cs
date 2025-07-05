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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DownloadLogByLineRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始行
        /// </summary>
        [JsonProperty("StartLine")]
        public long? StartLine{ get; set; }

        /// <summary>
        /// 读取行
        /// </summary>
        [JsonProperty("LineCount")]
        public long? LineCount{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 实例运行时间
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// 任务详情id，用于读取切分的日志文件
        /// </summary>
        [JsonProperty("DetailId")]
        public string DetailId{ get; set; }

        /// <summary>
        /// base64编码的文件路径
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 任务记录id
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 子job id
        /// </summary>
        [JsonProperty("SubJobId")]
        public string SubJobId{ get; set; }

        /// <summary>
        /// hiveSql:34,sparkSql:36 dlcSql: 32
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// true:解析错误信息。false:不解析错误信息
        /// </summary>
        [JsonProperty("ParseErrorTip")]
        public bool? ParseErrorTip{ get; set; }

        /// <summary>
        /// log 0 code 1 result 2 custo 3
        /// </summary>
        [JsonProperty("FileType")]
        public long? FileType{ get; set; }

        /// <summary>
        /// 查询文件标志：0: 从执行机获取，1: 从cos获取，获取不到会再从执行机获取
        /// </summary>
        [JsonProperty("QueryFileFlag")]
        public long? QueryFileFlag{ get; set; }

        /// <summary>
        /// 透传字段，如果queryFileFlag为1，则ext回作为上一页的分页标识offset
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartLine", this.StartLine);
            this.SetParamSimple(map, prefix + "LineCount", this.LineCount);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "DetailId", this.DetailId);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "SubJobId", this.SubJobId);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "ParseErrorTip", this.ParseErrorTip);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "QueryFileFlag", this.QueryFileFlag);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

