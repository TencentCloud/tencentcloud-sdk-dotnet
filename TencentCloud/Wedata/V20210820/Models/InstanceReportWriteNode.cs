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

    public class InstanceReportWriteNode : AbstractModel
    {
        
        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("TotalWriteRecords")]
        public ulong? TotalWriteRecords{ get; set; }

        /// <summary>
        /// 总字节数
        /// </summary>
        [JsonProperty("TotalWriteBytes")]
        public ulong? TotalWriteBytes{ get; set; }

        /// <summary>
        /// 速度（条/秒）
        /// </summary>
        [JsonProperty("RecordSpeed")]
        public ulong? RecordSpeed{ get; set; }

        /// <summary>
        /// 吞吐（Byte/秒）
        /// </summary>
        [JsonProperty("ByteSpeed")]
        public float? ByteSpeed{ get; set; }

        /// <summary>
        /// 脏数据条数
        /// </summary>
        [JsonProperty("TotalErrorRecords")]
        public ulong? TotalErrorRecords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "TotalWriteRecords", this.TotalWriteRecords);
            this.SetParamSimple(map, prefix + "TotalWriteBytes", this.TotalWriteBytes);
            this.SetParamSimple(map, prefix + "RecordSpeed", this.RecordSpeed);
            this.SetParamSimple(map, prefix + "ByteSpeed", this.ByteSpeed);
            this.SetParamSimple(map, prefix + "TotalErrorRecords", this.TotalErrorRecords);
        }
    }
}

