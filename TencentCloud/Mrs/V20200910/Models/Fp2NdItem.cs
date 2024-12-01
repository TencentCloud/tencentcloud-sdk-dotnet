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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Fp2NdItem : AbstractModel
    {
        
        /// <summary>
        /// 手术编码
        /// </summary>
        [JsonProperty("Code")]
        public BaseItem Code{ get; set; }

        /// <summary>
        /// 手术名称
        /// </summary>
        [JsonProperty("Name")]
        public BaseItem Name{ get; set; }

        /// <summary>
        /// 手术开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public BaseItem StartTime{ get; set; }

        /// <summary>
        /// 手术结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public BaseItem EndTime{ get; set; }

        /// <summary>
        /// 手术等级
        /// </summary>
        [JsonProperty("Level")]
        public BaseItem Level{ get; set; }

        /// <summary>
        /// 手术类型
        /// </summary>
        [JsonProperty("Type")]
        public BaseItem Type{ get; set; }

        /// <summary>
        /// 醉愈合方式
        /// </summary>
        [JsonProperty("IncisionHealingGrade")]
        public BaseItem IncisionHealingGrade{ get; set; }

        /// <summary>
        /// 麻醉方法
        /// </summary>
        [JsonProperty("AnesthesiaMethod")]
        public BaseItem AnesthesiaMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Code.", this.Code);
            this.SetParamObj(map, prefix + "Name.", this.Name);
            this.SetParamObj(map, prefix + "StartTime.", this.StartTime);
            this.SetParamObj(map, prefix + "EndTime.", this.EndTime);
            this.SetParamObj(map, prefix + "Level.", this.Level);
            this.SetParamObj(map, prefix + "Type.", this.Type);
            this.SetParamObj(map, prefix + "IncisionHealingGrade.", this.IncisionHealingGrade);
            this.SetParamObj(map, prefix + "AnesthesiaMethod.", this.AnesthesiaMethod);
        }
    }
}

