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

    public class ScanVulRequest : AbstractModel
    {
        
        /// <summary>
        /// 危害等级：1-低危；2-中危；3-高危；4-严重 (多选英文;分隔)
        /// </summary>
        [JsonProperty("VulLevels")]
        public string VulLevels{ get; set; }

        /// <summary>
        /// 服务器分类：1:专业版服务器；2:自选服务器
        /// </summary>
        [JsonProperty("HostType")]
        public ulong? HostType{ get; set; }

        /// <summary>
        /// 漏洞类型：1: web-cms漏洞 2:应用漏洞  4: Linux软件漏洞 5: Windows系统漏洞 (多选英文;分隔)
        /// </summary>
        [JsonProperty("VulCategories")]
        public string VulCategories{ get; set; }

        /// <summary>
        /// 自选服务器时生效，主机quuid的string数组
        /// </summary>
        [JsonProperty("QuuidList")]
        public string[] QuuidList{ get; set; }

        /// <summary>
        /// 是否是应急漏洞 0 否 1 是
        /// </summary>
        [JsonProperty("VulEmergency")]
        public ulong? VulEmergency{ get; set; }

        /// <summary>
        /// 超时时长 单位秒 默认 3600 秒
        /// </summary>
        [JsonProperty("TimeoutPeriod")]
        public ulong? TimeoutPeriod{ get; set; }

        /// <summary>
        /// 需要扫描的漏洞id
        /// </summary>
        [JsonProperty("VulIds")]
        public ulong?[] VulIds{ get; set; }

        /// <summary>
        /// 0版本比对，2版本比对+poc
        /// </summary>
        [JsonProperty("ScanMethod")]
        public ulong? ScanMethod{ get; set; }

        /// <summary>
        /// kb编号
        /// </summary>
        [JsonProperty("KBNumber")]
        public string[] KBNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulLevels", this.VulLevels);
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "VulCategories", this.VulCategories);
            this.SetParamArraySimple(map, prefix + "QuuidList.", this.QuuidList);
            this.SetParamSimple(map, prefix + "VulEmergency", this.VulEmergency);
            this.SetParamSimple(map, prefix + "TimeoutPeriod", this.TimeoutPeriod);
            this.SetParamArraySimple(map, prefix + "VulIds.", this.VulIds);
            this.SetParamSimple(map, prefix + "ScanMethod", this.ScanMethod);
            this.SetParamArraySimple(map, prefix + "KBNumber.", this.KBNumber);
        }
    }
}

