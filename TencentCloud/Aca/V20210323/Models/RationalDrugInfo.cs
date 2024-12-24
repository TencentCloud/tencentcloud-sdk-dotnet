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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RationalDrugInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否有风险
        /// </summary>
        [JsonProperty("Hit")]
        public bool? Hit{ get; set; }

        /// <summary>
        /// 药品用量风险
        /// </summary>
        [JsonProperty("DrugUsages")]
        public RiskInfo[] DrugUsages{ get; set; }

        /// <summary>
        /// 重复用药风险
        /// </summary>
        [JsonProperty("DrugRepeats")]
        public RiskInfo[] DrugRepeats{ get; set; }

        /// <summary>
        /// 用药途径风险
        /// </summary>
        [JsonProperty("DrugRoutes")]
        public RiskInfo[] DrugRoutes{ get; set; }

        /// <summary>
        /// 特殊人群风险
        /// </summary>
        [JsonProperty("SpecialPopulations")]
        public RiskInfo[] SpecialPopulations{ get; set; }

        /// <summary>
        /// 禁忌症风险
        /// </summary>
        [JsonProperty("DrugTaboos")]
        public RiskInfo[] DrugTaboos{ get; set; }

        /// <summary>
        /// 相互作用风险
        /// </summary>
        [JsonProperty("DrugInteractions")]
        public RiskInfo[] DrugInteractions{ get; set; }

        /// <summary>
        /// 配伍禁忌风险
        /// </summary>
        [JsonProperty("DrugIncompatibility")]
        public RiskInfo[] DrugIncompatibility{ get; set; }

        /// <summary>
        /// 过敏风险
        /// </summary>
        [JsonProperty("DrugAllergys")]
        public RiskInfo[] DrugAllergys{ get; set; }

        /// <summary>
        /// 适应症风险
        /// </summary>
        [JsonProperty("DrugIndications")]
        public RiskInfo[] DrugIndications{ get; set; }

        /// <summary>
        /// 异常提醒
        /// </summary>
        [JsonProperty("Abnormals")]
        public Abnormals[] Abnormals{ get; set; }

        /// <summary>
        /// 药品列表
        /// </summary>
        [JsonProperty("DrugList")]
        public DrugList[] DrugList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Hit", this.Hit);
            this.SetParamArrayObj(map, prefix + "DrugUsages.", this.DrugUsages);
            this.SetParamArrayObj(map, prefix + "DrugRepeats.", this.DrugRepeats);
            this.SetParamArrayObj(map, prefix + "DrugRoutes.", this.DrugRoutes);
            this.SetParamArrayObj(map, prefix + "SpecialPopulations.", this.SpecialPopulations);
            this.SetParamArrayObj(map, prefix + "DrugTaboos.", this.DrugTaboos);
            this.SetParamArrayObj(map, prefix + "DrugInteractions.", this.DrugInteractions);
            this.SetParamArrayObj(map, prefix + "DrugIncompatibility.", this.DrugIncompatibility);
            this.SetParamArrayObj(map, prefix + "DrugAllergys.", this.DrugAllergys);
            this.SetParamArrayObj(map, prefix + "DrugIndications.", this.DrugIndications);
            this.SetParamArrayObj(map, prefix + "Abnormals.", this.Abnormals);
            this.SetParamArrayObj(map, prefix + "DrugList.", this.DrugList);
        }
    }
}

