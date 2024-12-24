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

    public class DurgPropertyInfo : AbstractModel
    {
        
        /// <summary>
        /// 药品类型 1:西药,2:中成药,3:中药,4:化学药品,5:生物制药
        /// </summary>
        [JsonProperty("DrugType")]
        public long? DrugType{ get; set; }

        /// <summary>
        /// 抗菌药分类 1:抗真菌药物, 2:抗细菌药物, 3:抗结核药物, 4:其他抗菌药, 0:普通药品
        /// </summary>
        [JsonProperty("AntibacterialType")]
        public long? AntibacterialType{ get; set; }

        /// <summary>
        /// 抗菌药级别 1:非限制级, 2:限制级, 3:特殊使用级 
        /// </summary>
        [JsonProperty("AntibacterialClass")]
        public long? AntibacterialClass{ get; set; }

        /// <summary>
        /// 特殊药品类型 1:毒性药品, 2:麻醉药品, 3:放射药品, 4:精神一类药品, 5:精神二类药品, 6:其他特管药品， 7:贵重药品
        /// </summary>
        [JsonProperty("SpeciallyDrugType")]
        public long? SpeciallyDrugType{ get; set; }

        /// <summary>
        /// 是否为基本药物 1:是, 2:否, 0:未知
        /// </summary>
        [JsonProperty("IsBasicDrug")]
        public long? IsBasicDrug{ get; set; }

        /// <summary>
        /// 社保药品 1:甲类药品, 2:乙类药品, 3:双跨药品, 4:自费药品, 0:未知
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrugType", this.DrugType);
            this.SetParamSimple(map, prefix + "AntibacterialType", this.AntibacterialType);
            this.SetParamSimple(map, prefix + "AntibacterialClass", this.AntibacterialClass);
            this.SetParamSimple(map, prefix + "SpeciallyDrugType", this.SpeciallyDrugType);
            this.SetParamSimple(map, prefix + "IsBasicDrug", this.IsBasicDrug);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
        }
    }
}

