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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceReportSummary : AbstractModel
    {
        
        /// <summary>
        /// 总读取记录数
        /// </summary>
        [JsonProperty("TotalReadRecords")]
        public ulong? TotalReadRecords{ get; set; }

        /// <summary>
        /// 总读取字节数
        /// </summary>
        [JsonProperty("TotalReadBytes")]
        public ulong? TotalReadBytes{ get; set; }

        /// <summary>
        /// 总写入记录数
        /// </summary>
        [JsonProperty("TotalWriteRecords")]
        public ulong? TotalWriteRecords{ get; set; }

        /// <summary>
        /// 总写入字节数
        /// </summary>
        [JsonProperty("TotalWriteBytes")]
        public ulong? TotalWriteBytes{ get; set; }

        /// <summary>
        /// 速率（条/秒）
        /// </summary>
        [JsonProperty("RecordSpeed")]
        public ulong? RecordSpeed{ get; set; }

        /// <summary>
        /// 流量（Byte/秒）
        /// </summary>
        [JsonProperty("ByteSpeed")]
        public float? ByteSpeed{ get; set; }

        /// <summary>
        /// 脏数据记录数
        /// </summary>
        [JsonProperty("TotalErrorRecords")]
        public ulong? TotalErrorRecords{ get; set; }

        /// <summary>
        /// 脏数据字节数
        /// </summary>
        [JsonProperty("TotalErrorBytes")]
        public ulong? TotalErrorBytes{ get; set; }

        /// <summary>
        /// 任务运行总时长
        /// </summary>
        [JsonProperty("TotalRunDuration")]
        public ulong? TotalRunDuration{ get; set; }

        /// <summary>
        /// 任务开始运行时间
        /// </summary>
        [JsonProperty("BeginRunTime")]
        public string BeginRunTime{ get; set; }

        /// <summary>
        /// 任务结束运行时间
        /// </summary>
        [JsonProperty("EndRunTime")]
        public string EndRunTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalReadRecords", this.TotalReadRecords);
            this.SetParamSimple(map, prefix + "TotalReadBytes", this.TotalReadBytes);
            this.SetParamSimple(map, prefix + "TotalWriteRecords", this.TotalWriteRecords);
            this.SetParamSimple(map, prefix + "TotalWriteBytes", this.TotalWriteBytes);
            this.SetParamSimple(map, prefix + "RecordSpeed", this.RecordSpeed);
            this.SetParamSimple(map, prefix + "ByteSpeed", this.ByteSpeed);
            this.SetParamSimple(map, prefix + "TotalErrorRecords", this.TotalErrorRecords);
            this.SetParamSimple(map, prefix + "TotalErrorBytes", this.TotalErrorBytes);
            this.SetParamSimple(map, prefix + "TotalRunDuration", this.TotalRunDuration);
            this.SetParamSimple(map, prefix + "BeginRunTime", this.BeginRunTime);
            this.SetParamSimple(map, prefix + "EndRunTime", this.EndRunTime);
        }
    }
}

