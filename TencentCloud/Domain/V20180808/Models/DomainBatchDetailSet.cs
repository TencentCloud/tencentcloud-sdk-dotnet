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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainBatchDetailSet : AbstractModel
    {
        
        /// <summary>
        /// 详情ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 类型  
        /// new：注册域名
        /// renew：续费域名
        /// batch_transfer_prohibition_on：开启禁止转移锁
        /// batch_transfer_prohibition_off：关闭禁止转移锁
        /// batch_update_prohibition_on：开启禁止更新锁
        /// batch_update_prohibition_off：关闭禁止更新锁
        /// batch_modify_owner：域名转移
        /// batch_modify_domain_info：域名信息修改
        /// batch_transfer_in：域名转入
        /// batch_cancel_transfer_out：域名取消转出
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 执行状态：
        /// doing 执行中。
        /// failed 操作失败。
        /// success  操作成功。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 失败原因，如果状态成功(Status:success),则该字段为空
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("BigDealId")]
        public string BigDealId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "BigDealId", this.BigDealId);
        }
    }
}

