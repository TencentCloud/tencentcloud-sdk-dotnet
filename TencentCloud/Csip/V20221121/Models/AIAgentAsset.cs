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

    public class AIAgentAsset : AbstractModel
    {
        
        /// <summary>
        /// <p>ID 标识</p>
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>agent 名称</p>
        /// </summary>
        [JsonProperty("AgentName")]
        public string AgentName{ get; set; }

        /// <summary>
        /// <p>agent 使用模型名称</p>
        /// </summary>
        [JsonProperty("AgentModel")]
        public string[] AgentModel{ get; set; }

        /// <summary>
        /// <p>实例 ID</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>metadata 风险列表。有如下枚举值: 1. AK_TMP  2. USER_DATA</p>
        /// </summary>
        [JsonProperty("MetadataRiskList")]
        public string[] MetadataRiskList{ get; set; }

        /// <summary>
        /// <p>首次检出时间</p>
        /// </summary>
        [JsonProperty("IdentityTimeFirst")]
        public string IdentityTimeFirst{ get; set; }

        /// <summary>
        /// <p>最近检出时间</p>
        /// </summary>
        [JsonProperty("IdentityTimeLast")]
        public string IdentityTimeLast{ get; set; }

        /// <summary>
        /// <p>检出方式。有如下枚举值 1. FINGER 资产指纹方式检出 2. NETWORK 网络访问方式检出</p>
        /// </summary>
        [JsonProperty("IdentityMethod")]
        public string IdentityMethod{ get; set; }

        /// <summary>
        /// <p>暴露状态。有如下枚举值。1. EXPOSED；2.UNEXPOSED；</p><ol start="3"><li>UNKNOWN;</li></ol>
        /// </summary>
        [JsonProperty("ExposureStatus")]
        public string ExposureStatus{ get; set; }

        /// <summary>
        /// <p>metadata 有风险时对应路径</p>
        /// </summary>
        [JsonProperty("MetadataRiskURL")]
        public string MetadataRiskURL{ get; set; }

        /// <summary>
        /// <p>无</p>
        /// </summary>
        [JsonProperty("SkillState")]
        public SkillState SkillState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AgentName", this.AgentName);
            this.SetParamArraySimple(map, prefix + "AgentModel.", this.AgentModel);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "MetadataRiskList.", this.MetadataRiskList);
            this.SetParamSimple(map, prefix + "IdentityTimeFirst", this.IdentityTimeFirst);
            this.SetParamSimple(map, prefix + "IdentityTimeLast", this.IdentityTimeLast);
            this.SetParamSimple(map, prefix + "IdentityMethod", this.IdentityMethod);
            this.SetParamSimple(map, prefix + "ExposureStatus", this.ExposureStatus);
            this.SetParamSimple(map, prefix + "MetadataRiskURL", this.MetadataRiskURL);
            this.SetParamObj(map, prefix + "SkillState.", this.SkillState);
        }
    }
}

