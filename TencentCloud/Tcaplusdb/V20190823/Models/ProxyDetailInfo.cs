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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// proxy的唯一id
        /// </summary>
        [JsonProperty("ProxyUid")]
        public string ProxyUid{ get; set; }

        /// <summary>
        /// 机器类型
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 请求包速度
        /// </summary>
        [JsonProperty("ProcessSpeed")]
        public long? ProcessSpeed{ get; set; }

        /// <summary>
        /// 请求包时延
        /// </summary>
        [JsonProperty("AverageProcessDelay")]
        public long? AverageProcessDelay{ get; set; }

        /// <summary>
        /// 慢处理包速度
        /// </summary>
        [JsonProperty("SlowProcessSpeed")]
        public long? SlowProcessSpeed{ get; set; }

        /// <summary>
        /// 版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyUid", this.ProxyUid);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "ProcessSpeed", this.ProcessSpeed);
            this.SetParamSimple(map, prefix + "AverageProcessDelay", this.AverageProcessDelay);
            this.SetParamSimple(map, prefix + "SlowProcessSpeed", this.SlowProcessSpeed);
            this.SetParamSimple(map, prefix + "Version", this.Version);
        }
    }
}

