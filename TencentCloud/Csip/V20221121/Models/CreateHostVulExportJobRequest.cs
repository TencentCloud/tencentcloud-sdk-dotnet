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

    public class CreateHostVulExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>导出的action</p><p>枚举值：</p><ul><li>LinuxHostVulRiskList： linux漏洞风险列表</li><li>WebCmsHostVulRiskList： WebCms漏洞风险列表</li><li>AppHostVulRiskList： App漏洞风险列表</li><li>EmergencyHostVulRiskList： 紧急漏洞风险列表</li><li>KBRiskList： Windows kb风险列表</li><li>RelateHostList： 关联主机列表</li><li>WhiteList： 漏洞白名单</li></ul>
        /// </summary>
        [JsonProperty("BusinessAction")]
        public string BusinessAction{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>筛选条件数组，多条件之间为 AND 关系<br>支持的 Filter.Name：<br>KbID：KB风险关联主机情况下需要额外加入KB风险ID<br>VulID：漏洞风险关联主机情况下需要额外加入vul风险ID</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessAction", this.BusinessAction);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

