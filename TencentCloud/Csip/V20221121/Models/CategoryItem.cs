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

    public class CategoryItem : AbstractModel
    {
        
        /// <summary>
        /// <p>子项ID<br>枚举值：<br>vulnerability：漏洞治理<br>cloud_config：云产品配置治理<br>system_baseline：系统基线风险<br>intrusion_alert：入侵威胁告警<br>cloud_api_alert：云API告警<br>ai_agent_alert：AI Agent安全告警<br>object_storage_alert：对象存储异常告警<br>database_alert：数据库安全告警<br>protection_config：推荐防护配置未开启<br>edition_coverage：专业版/旗舰版覆盖率不足<br>product_expiry：产品7天内到期</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>子项名称</p>
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// <p>子类说明</p>
        /// </summary>
        [JsonProperty("CategoryDesc")]
        public string CategoryDesc{ get; set; }

        /// <summary>
        /// <p>子项扣分上限</p>
        /// </summary>
        [JsonProperty("MaxDeductScore")]
        public long? MaxDeductScore{ get; set; }

        /// <summary>
        /// <p>子项实际扣分</p>
        /// </summary>
        [JsonProperty("DeductScore")]
        public long? DeductScore{ get; set; }

        /// <summary>
        /// <p>风险总数</p>
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// <p>等级明细，风险/威胁类子项有值</p>
        /// </summary>
        [JsonProperty("SeverityItems")]
        public SeverityItem[] SeverityItems{ get; set; }

        /// <summary>
        /// <p>扣分原因描述</p>
        /// </summary>
        [JsonProperty("DeductReason")]
        public string DeductReason{ get; set; }

        /// <summary>
        /// <p>处理建议文案</p>
        /// </summary>
        [JsonProperty("ActionText")]
        public string ActionText{ get; set; }

        /// <summary>
        /// <p>防护配置详情，仅防护配置维度子项返回</p>
        /// </summary>
        [JsonProperty("ProtectionDetail")]
        public ProtectionDetail ProtectionDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "CategoryDesc", this.CategoryDesc);
            this.SetParamSimple(map, prefix + "MaxDeductScore", this.MaxDeductScore);
            this.SetParamSimple(map, prefix + "DeductScore", this.DeductScore);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamArrayObj(map, prefix + "SeverityItems.", this.SeverityItems);
            this.SetParamSimple(map, prefix + "DeductReason", this.DeductReason);
            this.SetParamSimple(map, prefix + "ActionText", this.ActionText);
            this.SetParamObj(map, prefix + "ProtectionDetail.", this.ProtectionDetail);
        }
    }
}

