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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchStatus : AbstractModel
    {
        
        /// <summary>
        /// 批量任务id
        /// </summary>
        [JsonProperty("LogId")]
        public ulong? LogId{ get; set; }

        /// <summary>
        /// 批量任务状态  doing：进行中  success：成功  failed：失败  partial_success：部分成功
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 批量任务类型
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
        [JsonProperty("BatchAction")]
        public string BatchAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BatchAction", this.BatchAction);
        }
    }
}

