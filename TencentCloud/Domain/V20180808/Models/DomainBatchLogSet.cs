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

    public class DomainBatchLogSet : AbstractModel
    {
        
        /// <summary>
        /// 日志ID
        /// </summary>
        [JsonProperty("LogId")]
        public long? LogId{ get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Number")]
        public long? Number{ get; set; }

        /// <summary>
        /// 执行状态：
        /// doing 执行中。
        /// done 执行完成。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 批量操作成功个数
        /// </summary>
        [JsonProperty("Success")]
        public long? Success{ get; set; }

        /// <summary>
        /// 批量操作处理中个数
        /// </summary>
        [JsonProperty("Doing")]
        public long? Doing{ get; set; }

        /// <summary>
        /// 批量操作失败个数
        /// </summary>
        [JsonProperty("Failed")]
        public long? Failed{ get; set; }

        /// <summary>
        /// 是否付费
        /// </summary>
        [JsonProperty("PayStatus")]
        public bool? PayStatus{ get; set; }

        /// <summary>
        /// 大订单ID
        /// </summary>
        [JsonProperty("BigDealId")]
        public string BigDealId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "Success", this.Success);
            this.SetParamSimple(map, prefix + "Doing", this.Doing);
            this.SetParamSimple(map, prefix + "Failed", this.Failed);
            this.SetParamSimple(map, prefix + "PayStatus", this.PayStatus);
            this.SetParamSimple(map, prefix + "BigDealId", this.BigDealId);
        }
    }
}

