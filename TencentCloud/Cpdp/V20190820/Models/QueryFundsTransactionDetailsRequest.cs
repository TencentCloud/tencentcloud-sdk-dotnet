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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryFundsTransactionDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询的交易发生时间类型。
        /// __1__：当日
        /// __2__：历史
        /// </summary>
        [JsonProperty("QueryDateType")]
        public string QueryDateType{ get; set; }

        /// <summary>
        /// 查询的交易类型。
        /// __2__：提现/退款
        /// __3__：清分/充值
        /// </summary>
        [JsonProperty("QueryTranType")]
        public string QueryTranType{ get; set; }

        /// <summary>
        /// 父账户账号。
        /// _平安渠道为资金汇总账号_
        /// </summary>
        [JsonProperty("BankAccountNumber")]
        public string BankAccountNumber{ get; set; }

        /// <summary>
        /// 子账户账号。
        /// _平安渠道为见证子账户的账号_
        /// </summary>
        [JsonProperty("SubAccountNumber")]
        public string SubAccountNumber{ get; set; }

        /// <summary>
        /// 分页号, 起始值为1。
        /// </summary>
        [JsonProperty("PageOffSet")]
        public string PageOffSet{ get; set; }

        /// <summary>
        /// 查询开始日期，格式：yyyyMMdd。
        /// __若是历史查询，则必输，当日查询时，不起作用；开始日期不能超过当前日期__
        /// </summary>
        [JsonProperty("QueryStartDate")]
        public string QueryStartDate{ get; set; }

        /// <summary>
        /// 查询终止日期，格式：yyyyMMdd。
        /// __若是历史查询，则必输，当日查询时，不起作用；终止日期不能超过当前日期__
        /// </summary>
        [JsonProperty("QueryEndDate")]
        public string QueryEndDate{ get; set; }

        /// <summary>
        /// 环境名。
        /// __release__: 现网环境
        /// __sandbox__: 沙箱环境
        /// __development__: 开发环境
        /// _缺省: release_
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueryDateType", this.QueryDateType);
            this.SetParamSimple(map, prefix + "QueryTranType", this.QueryTranType);
            this.SetParamSimple(map, prefix + "BankAccountNumber", this.BankAccountNumber);
            this.SetParamSimple(map, prefix + "SubAccountNumber", this.SubAccountNumber);
            this.SetParamSimple(map, prefix + "PageOffSet", this.PageOffSet);
            this.SetParamSimple(map, prefix + "QueryStartDate", this.QueryStartDate);
            this.SetParamSimple(map, prefix + "QueryEndDate", this.QueryEndDate);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
        }
    }
}

