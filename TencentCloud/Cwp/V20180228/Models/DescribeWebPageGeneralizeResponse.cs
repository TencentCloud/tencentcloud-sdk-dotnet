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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWebPageGeneralizeResponse : AbstractModel
    {
        
        /// <summary>
        /// 防护监测 0 未开启 1 已开启 2 异常
        /// </summary>
        [JsonProperty("ProtectMonitor")]
        public ulong? ProtectMonitor{ get; set; }

        /// <summary>
        /// 防护目录数
        /// </summary>
        [JsonProperty("ProtectDirNum")]
        public ulong? ProtectDirNum{ get; set; }

        /// <summary>
        /// 防护文件数
        /// </summary>
        [JsonProperty("ProtectFileNum")]
        public ulong? ProtectFileNum{ get; set; }

        /// <summary>
        /// 篡改文件数
        /// </summary>
        [JsonProperty("TamperFileNum")]
        public ulong? TamperFileNum{ get; set; }

        /// <summary>
        /// 篡改数
        /// </summary>
        [JsonProperty("TamperNum")]
        public ulong? TamperNum{ get; set; }

        /// <summary>
        /// 今日防护数
        /// </summary>
        [JsonProperty("ProtectToday")]
        public ulong? ProtectToday{ get; set; }

        /// <summary>
        /// 防护主机数
        /// </summary>
        [JsonProperty("ProtectHostNum")]
        public ulong? ProtectHostNum{ get; set; }

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
            this.SetParamSimple(map, prefix + "ProtectMonitor", this.ProtectMonitor);
            this.SetParamSimple(map, prefix + "ProtectDirNum", this.ProtectDirNum);
            this.SetParamSimple(map, prefix + "ProtectFileNum", this.ProtectFileNum);
            this.SetParamSimple(map, prefix + "TamperFileNum", this.TamperFileNum);
            this.SetParamSimple(map, prefix + "TamperNum", this.TamperNum);
            this.SetParamSimple(map, prefix + "ProtectToday", this.ProtectToday);
            this.SetParamSimple(map, prefix + "ProtectHostNum", this.ProtectHostNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

