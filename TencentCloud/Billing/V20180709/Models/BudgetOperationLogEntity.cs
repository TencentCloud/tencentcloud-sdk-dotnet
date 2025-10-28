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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BudgetOperationLogEntity : AbstractModel
    {
        
        /// <summary>
        /// 支付者Uin
        /// </summary>
        [JsonProperty("PayerUin")]
        public ulong? PayerUin{ get; set; }

        /// <summary>
        /// 使用者Uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public ulong? OwnerUin{ get; set; }

        /// <summary>
        /// 操作用户Uin
        /// </summary>
        [JsonProperty("OperateUin")]
        public ulong? OperateUin{ get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("BillDay")]
        public ulong? BillDay{ get; set; }

        /// <summary>
        /// 月份
        /// </summary>
        [JsonProperty("BillMonth")]
        public string BillMonth{ get; set; }

        /// <summary>
        /// 修改类型：ADD(新增)、UPDATE(更新)、DELETE(删除)
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 变更信息
        /// </summary>
        [JsonProperty("DiffValue")]
        public BudgetInfoDiffEntity[] DiffValue{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 修改渠道：CONSOLE/API
        /// </summary>
        [JsonProperty("OperationChannel")]
        public string OperationChannel{ get; set; }

        /// <summary>
        /// 预算项目id
        /// </summary>
        [JsonProperty("BudgetId")]
        public string BudgetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "BillDay", this.BillDay);
            this.SetParamSimple(map, prefix + "BillMonth", this.BillMonth);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamArrayObj(map, prefix + "DiffValue.", this.DiffValue);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OperationChannel", this.OperationChannel);
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
        }
    }
}

