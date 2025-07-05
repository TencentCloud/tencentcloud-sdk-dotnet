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

    public class DataSearchBug : AbstractModel
    {
        
        /// <summary>
        /// 返回查询状态
        /// </summary>
        [JsonProperty("StateCode")]
        public string StateCode{ get; set; }

        /// <summary>
        /// 漏洞详情
        /// </summary>
        [JsonProperty("DataBug")]
        public BugInfoDetail[] DataBug{ get; set; }

        /// <summary>
        /// 漏洞影响资产详情
        /// </summary>
        [JsonProperty("DataAsset")]
        public AssetInfoDetail[] DataAsset{ get; set; }

        /// <summary>
        /// true支持扫描。false不支持扫描
        /// </summary>
        [JsonProperty("VSSScan")]
        public bool? VSSScan{ get; set; }

        /// <summary>
        /// 0不支持，1支持
        /// </summary>
        [JsonProperty("CWPScan")]
        public string CWPScan{ get; set; }

        /// <summary>
        /// 1支持虚拟补丁，0或空不支持
        /// </summary>
        [JsonProperty("CFWPatch")]
        public string CFWPatch{ get; set; }

        /// <summary>
        /// 0不支持，1支持
        /// </summary>
        [JsonProperty("WafPatch")]
        public long? WafPatch{ get; set; }

        /// <summary>
        /// 0不支持，1支持
        /// </summary>
        [JsonProperty("CWPFix")]
        public long? CWPFix{ get; set; }

        /// <summary>
        /// 产品支持状态
        /// </summary>
        [JsonProperty("DataSupport")]
        public ProductSupport[] DataSupport{ get; set; }

        /// <summary>
        /// cveId
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StateCode", this.StateCode);
            this.SetParamArrayObj(map, prefix + "DataBug.", this.DataBug);
            this.SetParamArrayObj(map, prefix + "DataAsset.", this.DataAsset);
            this.SetParamSimple(map, prefix + "VSSScan", this.VSSScan);
            this.SetParamSimple(map, prefix + "CWPScan", this.CWPScan);
            this.SetParamSimple(map, prefix + "CFWPatch", this.CFWPatch);
            this.SetParamSimple(map, prefix + "WafPatch", this.WafPatch);
            this.SetParamSimple(map, prefix + "CWPFix", this.CWPFix);
            this.SetParamArrayObj(map, prefix + "DataSupport.", this.DataSupport);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
        }
    }
}

