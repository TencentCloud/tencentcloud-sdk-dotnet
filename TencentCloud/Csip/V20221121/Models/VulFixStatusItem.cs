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

    public class VulFixStatusItem : AbstractModel
    {
        
        /// <summary>
        /// 漏洞ID（KB补丁修复任务时为空）
        /// </summary>
        [JsonProperty("VulId")]
        public long? VulId{ get; set; }

        /// <summary>
        /// KB补丁ID（漏洞修复任务时为空）
        /// </summary>
        [JsonProperty("KBId")]
        public long? KBId{ get; set; }

        /// <summary>
        /// 漏洞名称或KB补丁名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 该漏洞的修复状态
        /// 枚举值：
        /// 0：修复中
        /// 1：全部成功
        /// 2：部分失败
        /// 3：全部失败
        /// </summary>
        [JsonProperty("FixStatus")]
        public long? FixStatus{ get; set; }

        /// <summary>
        /// 该漏洞/KB补丁关联的主机总数
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// 该漏洞/KB补丁修复成功的主机数
        /// </summary>
        [JsonProperty("SuccessHostCount")]
        public long? SuccessHostCount{ get; set; }

        /// <summary>
        /// 该漏洞/KB补丁修复失败的主机数
        /// </summary>
        [JsonProperty("FailHostCount")]
        public long? FailHostCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "KBId", this.KBId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "SuccessHostCount", this.SuccessHostCount);
            this.SetParamSimple(map, prefix + "FailHostCount", this.FailHostCount);
        }
    }
}

