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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalysisTaskResults : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 任务创建时间，毫秒时间戳
        /// </summary>
        [JsonProperty("InstanceStartTime")]
        public long? InstanceStartTime{ get; set; }

        /// <summary>
        /// 任务结束时间，毫秒时间戳
        /// </summary>
        [JsonProperty("InstanceCompleteTime")]
        public long? InstanceCompleteTime{ get; set; }

        /// <summary>
        /// 任务状态：0 初始化， 1 执行中， 2 执行成功，3 数据写入中，4 排队中。-1 执行失败，-3 已取消。
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 任务SQL语句
        /// </summary>
        [JsonProperty("SQL")]
        public string SQL{ get; set; }

        /// <summary>
        /// 计算资源名字
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// 单位毫秒，引擎内执行耗时
        /// </summary>
        [JsonProperty("JobTimeSum")]
        public long? JobTimeSum{ get; set; }

        /// <summary>
        /// 单位秒，统计参与计算所用 Spark Executor 每个 core 的 CPU 执行时长总和
        /// </summary>
        [JsonProperty("TaskTimeSum")]
        public long? TaskTimeSum{ get; set; }

        /// <summary>
        /// 数据扫描总行数
        /// </summary>
        [JsonProperty("InputRecordsSum")]
        public long? InputRecordsSum{ get; set; }

        /// <summary>
        /// 数据扫描总 bytes
        /// </summary>
        [JsonProperty("InputBytesSum")]
        public long? InputBytesSum{ get; set; }

        /// <summary>
        /// 输出总行数
        /// </summary>
        [JsonProperty("OutputRecordsSum")]
        public long? OutputRecordsSum{ get; set; }

        /// <summary>
        /// 输出总 bytes
        /// </summary>
        [JsonProperty("OutputBytesSum")]
        public long? OutputBytesSum{ get; set; }

        /// <summary>
        /// shuffle read 总 bytes
        /// </summary>
        [JsonProperty("ShuffleReadBytesSum")]
        public long? ShuffleReadBytesSum{ get; set; }

        /// <summary>
        /// shuffle read 总行数
        /// </summary>
        [JsonProperty("ShuffleReadRecordsSum")]
        public long? ShuffleReadRecordsSum{ get; set; }

        /// <summary>
        /// 洞察结果类型分类，一个 json 数组，有如下几种类型：SPARK-StageScheduleDelay（资源抢占）, SPARK-ShuffleFailure（Shuffle异常）, SPARK-SlowTask（慢task）, SPARK-DataSkew（数据倾斜）, SPARK-InsufficientResource（磁盘或内存不足）
        /// </summary>
        [JsonProperty("AnalysisStatus")]
        public string AnalysisStatus{ get; set; }

        /// <summary>
        /// 任务输出文件总数
        /// </summary>
        [JsonProperty("OutputFilesNum")]
        public long? OutputFilesNum{ get; set; }

        /// <summary>
        /// 任务输出小文件总数
        /// </summary>
        [JsonProperty("OutputSmallFilesNum")]
        public long? OutputSmallFilesNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceStartTime", this.InstanceStartTime);
            this.SetParamSimple(map, prefix + "InstanceCompleteTime", this.InstanceCompleteTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "SQL", this.SQL);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "JobTimeSum", this.JobTimeSum);
            this.SetParamSimple(map, prefix + "TaskTimeSum", this.TaskTimeSum);
            this.SetParamSimple(map, prefix + "InputRecordsSum", this.InputRecordsSum);
            this.SetParamSimple(map, prefix + "InputBytesSum", this.InputBytesSum);
            this.SetParamSimple(map, prefix + "OutputRecordsSum", this.OutputRecordsSum);
            this.SetParamSimple(map, prefix + "OutputBytesSum", this.OutputBytesSum);
            this.SetParamSimple(map, prefix + "ShuffleReadBytesSum", this.ShuffleReadBytesSum);
            this.SetParamSimple(map, prefix + "ShuffleReadRecordsSum", this.ShuffleReadRecordsSum);
            this.SetParamSimple(map, prefix + "AnalysisStatus", this.AnalysisStatus);
            this.SetParamSimple(map, prefix + "OutputFilesNum", this.OutputFilesNum);
            this.SetParamSimple(map, prefix + "OutputSmallFilesNum", this.OutputSmallFilesNum);
        }
    }
}

