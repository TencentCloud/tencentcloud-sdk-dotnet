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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RebateInfoElem : AbstractModel
    {
        
        /// <summary>
        /// 代理商账号ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 返佣月份，如2018-02
        /// </summary>
        [JsonProperty("RebateMonth")]
        public string RebateMonth{ get; set; }

        /// <summary>
        /// 返佣金额，单位分
        /// </summary>
        [JsonProperty("Amt")]
        public ulong? Amt{ get; set; }

        /// <summary>
        /// 月度业绩，单位分
        /// </summary>
        [JsonProperty("MonthSales")]
        public ulong? MonthSales{ get; set; }

        /// <summary>
        /// 季度业绩，单位分
        /// </summary>
        [JsonProperty("QuarterSales")]
        public ulong? QuarterSales{ get; set; }

        /// <summary>
        /// NORMAL(正常)/HAS_OVERDUE_BILL(欠费)/NO_CONTRACT(缺合同)
        /// </summary>
        [JsonProperty("ExceptionFlag")]
        public string ExceptionFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "RebateMonth", this.RebateMonth);
            this.SetParamSimple(map, prefix + "Amt", this.Amt);
            this.SetParamSimple(map, prefix + "MonthSales", this.MonthSales);
            this.SetParamSimple(map, prefix + "QuarterSales", this.QuarterSales);
            this.SetParamSimple(map, prefix + "ExceptionFlag", this.ExceptionFlag);
        }
    }
}

