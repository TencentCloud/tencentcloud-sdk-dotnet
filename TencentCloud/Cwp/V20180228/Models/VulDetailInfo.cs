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

    public class VulDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 漏洞ID
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
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// cve编号
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// 1: web-cms漏洞 2:应用漏洞  4: Linux软件漏洞 5: Windows系统漏洞 0= 应急漏洞
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }

        /// <summary>
        /// 漏洞描述
        /// </summary>
        [JsonProperty("Descript")]
        public string Descript{ get; set; }

        /// <summary>
        /// 修复建议
        /// </summary>
        [JsonProperty("Fix")]
        public string Fix{ get; set; }

        /// <summary>
        /// 参考链接
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// CVSS评分
        /// </summary>
        [JsonProperty("CvssScore")]
        public float? CvssScore{ get; set; }

        /// <summary>
        /// CVSS详情
        /// </summary>
        [JsonProperty("Cvss")]
        public string Cvss{ get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
            this.SetParamSimple(map, prefix + "Descript", this.Descript);
            this.SetParamSimple(map, prefix + "Fix", this.Fix);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamSimple(map, prefix + "Cvss", this.Cvss);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
        }
    }
}

