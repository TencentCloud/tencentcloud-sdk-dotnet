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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TLogInfo : AbstractModel
    {
        
        /// <summary>
        /// 封禁列表
        /// </summary>
        [JsonProperty("BanNum")]
        public long? BanNum{ get; set; }

        /// <summary>
        /// 暴力破解
        /// </summary>
        [JsonProperty("BruteForceNum")]
        public long? BruteForceNum{ get; set; }

        /// <summary>
        /// 待处置告警
        /// </summary>
        [JsonProperty("HandleNum")]
        public long? HandleNum{ get; set; }

        /// <summary>
        /// 网络探测
        /// </summary>
        [JsonProperty("NetworkNum")]
        public long? NetworkNum{ get; set; }

        /// <summary>
        /// 失陷主机
        /// </summary>
        [JsonProperty("OutNum")]
        public long? OutNum{ get; set; }

        /// <summary>
        /// 漏洞攻击
        /// </summary>
        [JsonProperty("VulNum")]
        public long? VulNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BanNum", this.BanNum);
            this.SetParamSimple(map, prefix + "BruteForceNum", this.BruteForceNum);
            this.SetParamSimple(map, prefix + "HandleNum", this.HandleNum);
            this.SetParamSimple(map, prefix + "NetworkNum", this.NetworkNum);
            this.SetParamSimple(map, prefix + "OutNum", this.OutNum);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
        }
    }
}

