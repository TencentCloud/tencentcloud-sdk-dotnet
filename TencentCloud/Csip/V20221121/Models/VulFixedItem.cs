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

    public class VulFixedItem : AbstractModel
    {
        
        /// <summary>
        /// <p>漏洞ID</p>
        /// </summary>
        [JsonProperty("VulId")]
        public long? VulId{ get; set; }

        /// <summary>
        /// <p>漏洞名称</p>
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// <p>漏洞等级<br>枚举值：<br>LOW：低危<br>MEDIUM：中危<br>HIGH：高危<br>CRITICAL：严重</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>VPR 评级信息（包含评级结果、说明和分阶段评分），与 DescribeHostVulRiskList 一致</p>
        /// </summary>
        [JsonProperty("VRPRatingInfo")]
        public VPRRatingInfo VRPRatingInfo{ get; set; }

        /// <summary>
        /// <p>漏洞类型<br>枚举值：<br>LINUX：Linux软件漏洞<br>WINDOWS：Windows系统补丁漏洞<br>WEB_CMS：Web-CMS漏洞<br>APPLICATION：应用漏洞<br>EMERGENCY：应急漏洞</p>
        /// </summary>
        [JsonProperty("VulCategory")]
        public string VulCategory{ get; set; }

        /// <summary>
        /// <p>CVE编号</p>
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// <p>修复主机名称</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>修复主机实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>关联组件&amp;路径数量</p>
        /// </summary>
        [JsonProperty("ComponentCount")]
        public long? ComponentCount{ get; set; }

        /// <summary>
        /// <p>关联组件&amp;路径列表</p>
        /// </summary>
        [JsonProperty("Components")]
        public string[] Components{ get; set; }

        /// <summary>
        /// <p>最近一次修复时间<br>参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）</p>
        /// </summary>
        [JsonProperty("LatestFixTime")]
        public string LatestFixTime{ get; set; }

        /// <summary>
        /// <p>VPR评级依据</p>
        /// </summary>
        [JsonProperty("VPRExplainInfo")]
        public VPRExplainInfo VPRExplainInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamObj(map, prefix + "VRPRatingInfo.", this.VRPRatingInfo);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ComponentCount", this.ComponentCount);
            this.SetParamArraySimple(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "LatestFixTime", this.LatestFixTime);
            this.SetParamObj(map, prefix + "VPRExplainInfo.", this.VPRExplainInfo);
        }
    }
}

