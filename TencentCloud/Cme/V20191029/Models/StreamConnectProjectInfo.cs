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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamConnectProjectInfo : AbstractModel
    {
        
        /// <summary>
        /// 转推项目状态，取值有：
        /// <li>Working ：转推中；</li>
        /// <li>Idle ：空闲中。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 当前转推输入源，取值有：
        /// <li>Main ：主输入源；</li>
        /// <li>Backup ：备输入源。</li>
        /// </summary>
        [JsonProperty("CurrentInputEndpoint")]
        public string CurrentInputEndpoint{ get; set; }

        /// <summary>
        /// 当前转推开始时间， 采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。仅 Status 取值 Working 时有效。
        /// </summary>
        [JsonProperty("CurrentStartTime")]
        public string CurrentStartTime{ get; set; }

        /// <summary>
        /// 当前转推计划结束时间， 采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。仅 Status 取值 Working 时有效。
        /// </summary>
        [JsonProperty("CurrentStopTime")]
        public string CurrentStopTime{ get; set; }

        /// <summary>
        /// 上一次转推结束时间， 采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。仅 Status 取值 Idle 时有效。
        /// </summary>
        [JsonProperty("LastStopTime")]
        public string LastStopTime{ get; set; }

        /// <summary>
        /// 云转推主输入源。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MainInput")]
        public StreamInputInfo MainInput{ get; set; }

        /// <summary>
        /// 云转推备输入源。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupInput")]
        public StreamInputInfo BackupInput{ get; set; }

        /// <summary>
        /// 云转推输出源。
        /// </summary>
        [JsonProperty("OutputSet")]
        public StreamConnectOutputInfo[] OutputSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CurrentInputEndpoint", this.CurrentInputEndpoint);
            this.SetParamSimple(map, prefix + "CurrentStartTime", this.CurrentStartTime);
            this.SetParamSimple(map, prefix + "CurrentStopTime", this.CurrentStopTime);
            this.SetParamSimple(map, prefix + "LastStopTime", this.LastStopTime);
            this.SetParamObj(map, prefix + "MainInput.", this.MainInput);
            this.SetParamObj(map, prefix + "BackupInput.", this.BackupInput);
            this.SetParamArrayObj(map, prefix + "OutputSet.", this.OutputSet);
        }
    }
}

