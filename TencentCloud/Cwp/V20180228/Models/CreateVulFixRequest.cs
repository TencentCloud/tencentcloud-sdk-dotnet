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

    public class CreateVulFixRequest : AbstractModel
    {
        
        /// <summary>
        /// 漏洞对应要修复的主机列表
        /// </summary>
        [JsonProperty("CreateVulFixTaskQuuids")]
        public CreateVulFixTaskQuuids[] CreateVulFixTaskQuuids{ get; set; }

        /// <summary>
        /// 快照保存天数，  0 天表示不创建快照。24小时没有快照的主机必须要创建快照才能修复
        /// </summary>
        [JsonProperty("SaveDays")]
        public ulong? SaveDays{ get; set; }

        /// <summary>
        /// 快照名称
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CreateVulFixTaskQuuids.", this.CreateVulFixTaskQuuids);
            this.SetParamSimple(map, prefix + "SaveDays", this.SaveDays);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
        }
    }
}

