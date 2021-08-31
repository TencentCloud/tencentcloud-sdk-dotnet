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

    public class EmergencyVul : AbstractModel
    {
        
        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// 漏洞级别
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        [JsonProperty("PublishDate")]
        public string PublishDate{ get; set; }

        /// <summary>
        /// 漏洞分类
        /// </summary>
        [JsonProperty("Category")]
        public ulong? Category{ get; set; }

        /// <summary>
        /// 漏洞状态 0未检测 1有风险 ，2无风险 ，3 检查中展示progress
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 最后扫描时间
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// 扫描进度
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "PublishDate", this.PublishDate);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
        }
    }
}

