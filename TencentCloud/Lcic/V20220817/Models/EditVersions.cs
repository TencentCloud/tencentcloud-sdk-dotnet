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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EditVersions : AbstractModel
    {
        
        /// <summary>
        /// <p>版本号</p><p>取值范围：[0, 100]</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("Version")]
        public ulong? Version{ get; set; }

        /// <summary>
        /// <p>版本状态</p><p>枚举值：</p><ul><li>READY： 已完成</li><li>FAILED： 失败</li><li>PROCESSING： 进行中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>是否是主版本</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// </summary>
        [JsonProperty("IsMain")]
        public bool? IsMain{ get; set; }

        /// <summary>
        /// <p>是否源头版本</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// </summary>
        [JsonProperty("IsSource")]
        public bool? IsSource{ get; set; }

        /// <summary>
        /// <p>版本时长</p><p>取值范围：[0, 1000000]</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("KeepDurationSec")]
        public ulong? KeepDurationSec{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>取值范围：[0, 10000000]</p>
        /// </summary>
        [JsonProperty("CreatedAtMs")]
        public ulong? CreatedAtMs{ get; set; }

        /// <summary>
        /// <p>创建用户id</p>
        /// </summary>
        [JsonProperty("CreatorUserId")]
        public string CreatorUserId{ get; set; }

        /// <summary>
        /// <p>失败原因</p><p>默认值：空</p><p>仅失败才会有原因</p>
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// <p>更新时间</p><p>取值范围：[0, 100000]</p>
        /// </summary>
        [JsonProperty("UpdatedAtMs")]
        public ulong? UpdatedAtMs{ get; set; }

        /// <summary>
        /// <p>版本名字</p>
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsMain", this.IsMain);
            this.SetParamSimple(map, prefix + "IsSource", this.IsSource);
            this.SetParamSimple(map, prefix + "KeepDurationSec", this.KeepDurationSec);
            this.SetParamSimple(map, prefix + "CreatedAtMs", this.CreatedAtMs);
            this.SetParamSimple(map, prefix + "CreatorUserId", this.CreatorUserId);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "UpdatedAtMs", this.UpdatedAtMs);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
        }
    }
}

