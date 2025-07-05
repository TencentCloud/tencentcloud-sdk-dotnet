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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployRecord : AbstractModel
    {
        
        /// <summary>
        /// 发布版本的详细信息。
        /// </summary>
        [JsonProperty("ConfigGroupVersionInfos")]
        public ConfigGroupVersionInfo[] ConfigGroupVersionInfos{ get; set; }

        /// <summary>
        /// 发布时间。时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("DeployTime")]
        public string DeployTime{ get; set; }

        /// <summary>
        /// 发布状态，取值有：
        /// <li> deploying ：发布中；</li>
        /// <li>failure ：发布失败；</li>
        /// <li>success： 发布成功。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 发布结果信息。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 发布记录 ID。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 变更说明。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ConfigGroupVersionInfos.", this.ConfigGroupVersionInfos);
            this.SetParamSimple(map, prefix + "DeployTime", this.DeployTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

