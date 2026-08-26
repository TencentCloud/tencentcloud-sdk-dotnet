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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVulFixTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>修复项列表，每项指定一个漏洞/KB补丁及其需要修复的主机<br>入参限制：最多100项，总实例数不超过5000</p>
        /// </summary>
        [JsonProperty("FixItems")]
        public VulFixItem[] FixItems{ get; set; }

        /// <summary>
        /// <p>最大修复时间<br>单位：秒<br>默认值：3600</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>是否在修复前创建磁盘快照<br>默认值：false</p>
        /// </summary>
        [JsonProperty("CreateSnapshot")]
        public bool? CreateSnapshot{ get; set; }

        /// <summary>
        /// <p>快照名称，CreateSnapshot为true时有效入参限制：最长60个字符超长自动截断</p>
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// <p>快照保存天数，CreateSnapshot为true时有效</p>
        /// </summary>
        [JsonProperty("SaveDays")]
        public long? SaveDays{ get; set; }

        /// <summary>
        /// 集团账号的成员id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FixItems.", this.FixItems);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "CreateSnapshot", this.CreateSnapshot);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "SaveDays", this.SaveDays);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

