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

    public class ImageVulBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>受影响的组件信息</p>
        /// </summary>
        [JsonProperty("AffectedComponents")]
        public VulAffectedComponent[] AffectedComponents{ get; set; }

        /// <summary>
        /// <p>漏洞名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>漏洞CVEID</p>
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// <p>漏洞类别</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>漏洞发布时间</p>
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// <p>漏洞检测方式</p>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// <p>是否支持防御</p><p>枚举值：</p><ul><li>ENABLED： 支持防御</li><li>NOT_ENABLED： 不支持防御</li></ul>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// <p>是否支持修复</p>
        /// </summary>
        [JsonProperty("SupportFix")]
        public bool? SupportFix{ get; set; }

        /// <summary>
        /// <p>CVSS分数</p>
        /// </summary>
        [JsonProperty("CvssScore")]
        public string CvssScore{ get; set; }

        /// <summary>
        /// <p>漏洞危害描述</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>漏洞描述</p>
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// <p>危害等级</p>
        /// </summary>
        [JsonProperty("CVSSLevel")]
        public string CVSSLevel{ get; set; }

        /// <summary>
        /// <p>主要影响类型</p>
        /// </summary>
        [JsonProperty("VulAffect")]
        public string VulAffect{ get; set; }

        /// <summary>
        /// <p>是否存在在野利用</p>
        /// </summary>
        [JsonProperty("KVERecord")]
        public bool? KVERecord{ get; set; }

        /// <summary>
        /// <p>EPSS 概率分数</p>
        /// </summary>
        [JsonProperty("EPSSScore")]
        public float? EPSSScore{ get; set; }

        /// <summary>
        /// <p>影响厂商</p>
        /// </summary>
        [JsonProperty("AffectVendor")]
        public string AffectVendor{ get; set; }

        /// <summary>
        /// <p>影响目标产品</p>
        /// </summary>
        [JsonProperty("AffectProduct")]
        public string AffectProduct{ get; set; }

        /// <summary>
        /// <p>漏洞原理</p>
        /// </summary>
        [JsonProperty("Mechanism")]
        public string Mechanism{ get; set; }

        /// <summary>
        /// <p>攻击前提条件</p>
        /// </summary>
        [JsonProperty("Precondition")]
        public string Precondition{ get; set; }

        /// <summary>
        /// <p>漏洞修复建议</p>
        /// </summary>
        [JsonProperty("FixSolution")]
        public string FixSolution{ get; set; }

        /// <summary>
        /// <p>漏洞相关链接</p>
        /// </summary>
        [JsonProperty("RefLink")]
        public string RefLink{ get; set; }

        /// <summary>
        /// <p>漏洞标签</p>
        /// </summary>
        [JsonProperty("Label")]
        public string[] Label{ get; set; }

        /// <summary>
        /// <p>漏洞Id</p>
        /// </summary>
        [JsonProperty("PocId")]
        public string PocId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AffectedComponents.", this.AffectedComponents);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "SupportFix", this.SupportFix);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "CVSSLevel", this.CVSSLevel);
            this.SetParamSimple(map, prefix + "VulAffect", this.VulAffect);
            this.SetParamSimple(map, prefix + "KVERecord", this.KVERecord);
            this.SetParamSimple(map, prefix + "EPSSScore", this.EPSSScore);
            this.SetParamSimple(map, prefix + "AffectVendor", this.AffectVendor);
            this.SetParamSimple(map, prefix + "AffectProduct", this.AffectProduct);
            this.SetParamSimple(map, prefix + "Mechanism", this.Mechanism);
            this.SetParamSimple(map, prefix + "Precondition", this.Precondition);
            this.SetParamSimple(map, prefix + "FixSolution", this.FixSolution);
            this.SetParamSimple(map, prefix + "RefLink", this.RefLink);
            this.SetParamArraySimple(map, prefix + "Label.", this.Label);
            this.SetParamSimple(map, prefix + "PocId", this.PocId);
        }
    }
}

