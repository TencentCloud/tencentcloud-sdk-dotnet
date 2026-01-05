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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanVulAgainRequest : AbstractModel
    {
        
        /// <summary>
        /// 漏洞事件id串，多个用英文逗号分隔
        /// </summary>
        [JsonProperty("EventIds")]
        public string EventIds{ get; set; }

        /// <summary>
        /// 重新检查的机器uuid,多个逗号分隔
        /// </summary>
        [JsonProperty("Uuids")]
        public string Uuids{ get; set; }

        /// <summary>
        /// 0漏洞,1windows 补丁
        /// </summary>
        [JsonProperty("EventType")]
        public ulong? EventType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventIds", this.EventIds);
            this.SetParamSimple(map, prefix + "Uuids", this.Uuids);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
        }
    }
}

