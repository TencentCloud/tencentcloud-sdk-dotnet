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

    public class DescribeTaskReportResponse : AbstractModel
    {
        
        /// <summary>
        /// 总读取条数
        /// </summary>
        [JsonProperty("TotalReadRecords")]
        public ulong? TotalReadRecords{ get; set; }

        /// <summary>
        /// 总读取字节数，单位为Byte
        /// </summary>
        [JsonProperty("TotalReadBytes")]
        public ulong? TotalReadBytes{ get; set; }

        /// <summary>
        /// 总写入条数
        /// </summary>
        [JsonProperty("TotalWriteRecords")]
        public ulong? TotalWriteRecords{ get; set; }

        /// <summary>
        /// 总写入字节数，单位为Byte
        /// </summary>
        [JsonProperty("TotalWriteBytes")]
        public ulong? TotalWriteBytes{ get; set; }

        /// <summary>
        /// 总脏数据条数
        /// </summary>
        [JsonProperty("TotalErrorRecords")]
        public ulong? TotalErrorRecords{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalReadRecords", this.TotalReadRecords);
            this.SetParamSimple(map, prefix + "TotalReadBytes", this.TotalReadBytes);
            this.SetParamSimple(map, prefix + "TotalWriteRecords", this.TotalWriteRecords);
            this.SetParamSimple(map, prefix + "TotalWriteBytes", this.TotalWriteBytes);
            this.SetParamSimple(map, prefix + "TotalErrorRecords", this.TotalErrorRecords);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

