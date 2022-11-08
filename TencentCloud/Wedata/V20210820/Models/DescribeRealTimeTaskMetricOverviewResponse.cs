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

    public class DescribeRealTimeTaskMetricOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 总读取记录数
        /// </summary>
        [JsonProperty("TotalRecordNumOfRead")]
        public ulong? TotalRecordNumOfRead{ get; set; }

        /// <summary>
        /// 总读取字节数
        /// </summary>
        [JsonProperty("TotalRecordByteNumOfRead")]
        public ulong? TotalRecordByteNumOfRead{ get; set; }

        /// <summary>
        /// 总写入记录数
        /// </summary>
        [JsonProperty("TotalRecordNumOfWrite")]
        public ulong? TotalRecordNumOfWrite{ get; set; }

        /// <summary>
        /// 总写入字节数 单位字节
        /// </summary>
        [JsonProperty("TotalRecordByteNumOfWrite")]
        public ulong? TotalRecordByteNumOfWrite{ get; set; }

        /// <summary>
        /// 总的脏记录数据
        /// </summary>
        [JsonProperty("TotalDirtyRecordNum")]
        public ulong? TotalDirtyRecordNum{ get; set; }

        /// <summary>
        /// 总的脏字节数 单位字节
        /// </summary>
        [JsonProperty("TotalDirtyRecordByte")]
        public ulong? TotalDirtyRecordByte{ get; set; }

        /// <summary>
        /// 运行时长 单位s
        /// </summary>
        [JsonProperty("TotalDuration")]
        public ulong? TotalDuration{ get; set; }

        /// <summary>
        /// 开始运行时间
        /// </summary>
        [JsonProperty("BeginRunTime")]
        public string BeginRunTime{ get; set; }

        /// <summary>
        /// 目前运行到的时间
        /// </summary>
        [JsonProperty("EndRunTime")]
        public string EndRunTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalRecordNumOfRead", this.TotalRecordNumOfRead);
            this.SetParamSimple(map, prefix + "TotalRecordByteNumOfRead", this.TotalRecordByteNumOfRead);
            this.SetParamSimple(map, prefix + "TotalRecordNumOfWrite", this.TotalRecordNumOfWrite);
            this.SetParamSimple(map, prefix + "TotalRecordByteNumOfWrite", this.TotalRecordByteNumOfWrite);
            this.SetParamSimple(map, prefix + "TotalDirtyRecordNum", this.TotalDirtyRecordNum);
            this.SetParamSimple(map, prefix + "TotalDirtyRecordByte", this.TotalDirtyRecordByte);
            this.SetParamSimple(map, prefix + "TotalDuration", this.TotalDuration);
            this.SetParamSimple(map, prefix + "BeginRunTime", this.BeginRunTime);
            this.SetParamSimple(map, prefix + "EndRunTime", this.EndRunTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

