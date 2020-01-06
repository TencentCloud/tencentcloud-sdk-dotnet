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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulList : AbstractModel
    {
        
        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("VulId")]
        public string VulId{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 漏洞代码
        /// </summary>
        [JsonProperty("VulCode")]
        public string VulCode{ get; set; }

        /// <summary>
        /// 漏洞描述
        /// </summary>
        [JsonProperty("VulDesc")]
        public string VulDesc{ get; set; }

        /// <summary>
        /// 漏洞解决方案
        /// </summary>
        [JsonProperty("VulSolution")]
        public string VulSolution{ get; set; }

        /// <summary>
        /// 漏洞来源类别，0默认自身，1第三方插件
        /// </summary>
        [JsonProperty("VulSrcType")]
        public long? VulSrcType{ get; set; }

        /// <summary>
        /// 漏洞位置
        /// </summary>
        [JsonProperty("VulFilepath")]
        public string VulFilepath{ get; set; }

        /// <summary>
        /// 风险级别：1 低风险 ；2中等风险；3 高风险
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulCode", this.VulCode);
            this.SetParamSimple(map, prefix + "VulDesc", this.VulDesc);
            this.SetParamSimple(map, prefix + "VulSolution", this.VulSolution);
            this.SetParamSimple(map, prefix + "VulSrcType", this.VulSrcType);
            this.SetParamSimple(map, prefix + "VulFilepath", this.VulFilepath);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
        }
    }
}

