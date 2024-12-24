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

    public class Drug : AbstractModel
    {
        
        /// <summary>
        /// 医院药品id
        /// </summary>
        [JsonProperty("DrugOrgId")]
        public string DrugOrgId{ get; set; }

        /// <summary>
        /// 医院药品通用名
        /// </summary>
        [JsonProperty("DrugName")]
        public string DrugName{ get; set; }

        /// <summary>
        /// 医院药品商品名
        /// </summary>
        [JsonProperty("DrugCommodityName")]
        public string DrugCommodityName{ get; set; }

        /// <summary>
        /// 医院药品规格
        /// </summary>
        [JsonProperty("Specifications")]
        public string Specifications{ get; set; }

        /// <summary>
        /// 医院药品批准文号
        /// </summary>
        [JsonProperty("ApprovalNumber")]
        public string ApprovalNumber{ get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// 剂型
        /// </summary>
        [JsonProperty("DosageForm")]
        public string DosageForm{ get; set; }

        /// <summary>
        /// 使用状态 0:启用 1:停用
        /// </summary>
        [JsonProperty("Unuse")]
        public long? Unuse{ get; set; }

        /// <summary>
        /// 剂型编码
        /// </summary>
        [JsonProperty("DosageFormCode")]
        public string DosageFormCode{ get; set; }

        /// <summary>
        /// 抗菌药DDD值
        /// </summary>
        [JsonProperty("DefinedDailyDose")]
        public string DefinedDailyDose{ get; set; }

        /// <summary>
        /// 药品单价
        /// </summary>
        [JsonProperty("Amount")]
        public string Amount{ get; set; }

        /// <summary>
        /// 国家医保编码
        /// </summary>
        [JsonProperty("YbCode")]
        public string YbCode{ get; set; }

        /// <summary>
        /// 药品本位码
        /// </summary>
        [JsonProperty("DrugBasicCode")]
        public string DrugBasicCode{ get; set; }

        /// <summary>
        /// 药品属性
        /// </summary>
        [JsonProperty("PropertyInfo")]
        public DurgPropertyInfo PropertyInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrugOrgId", this.DrugOrgId);
            this.SetParamSimple(map, prefix + "DrugName", this.DrugName);
            this.SetParamSimple(map, prefix + "DrugCommodityName", this.DrugCommodityName);
            this.SetParamSimple(map, prefix + "Specifications", this.Specifications);
            this.SetParamSimple(map, prefix + "ApprovalNumber", this.ApprovalNumber);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "DosageForm", this.DosageForm);
            this.SetParamSimple(map, prefix + "Unuse", this.Unuse);
            this.SetParamSimple(map, prefix + "DosageFormCode", this.DosageFormCode);
            this.SetParamSimple(map, prefix + "DefinedDailyDose", this.DefinedDailyDose);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "YbCode", this.YbCode);
            this.SetParamSimple(map, prefix + "DrugBasicCode", this.DrugBasicCode);
            this.SetParamObj(map, prefix + "PropertyInfo.", this.PropertyInfo);
        }
    }
}

