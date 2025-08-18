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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// svr唯一id
        /// </summary>
        [JsonProperty("ServerUid")]
        public string ServerUid{ get; set; }

        /// <summary>
        /// 机器类型
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 内存占用量
        /// </summary>
        [JsonProperty("MemoryRate")]
        public long? MemoryRate{ get; set; }

        /// <summary>
        /// 磁盘占用量
        /// </summary>
        [JsonProperty("DiskRate")]
        public long? DiskRate{ get; set; }

        /// <summary>
        /// 读次数
        /// </summary>
        [JsonProperty("ReadNum")]
        public long? ReadNum{ get; set; }

        /// <summary>
        /// 写次数
        /// </summary>
        [JsonProperty("WriteNum")]
        public long? WriteNum{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServerUid", this.ServerUid);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MemoryRate", this.MemoryRate);
            this.SetParamSimple(map, prefix + "DiskRate", this.DiskRate);
            this.SetParamSimple(map, prefix + "ReadNum", this.ReadNum);
            this.SetParamSimple(map, prefix + "WriteNum", this.WriteNum);
            this.SetParamSimple(map, prefix + "Version", this.Version);
        }
    }
}

