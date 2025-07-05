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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceReturnable : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例是否可退还。
        /// </summary>
        [JsonProperty("IsReturnable")]
        public bool? IsReturnable{ get; set; }

        /// <summary>
        /// 实例退还失败错误码。取值:
        /// 0: 可以退还
        /// 1: 资源已退货。如为退货后续费资源，请于购买6小时后操作
        /// 2: 资源已到期
        /// 3: 资源购买超过5天不支持退款
        /// 4: 非预付费资源不支持退款
        /// 8: 退货数量超出限额
        /// 9: 涉及活动订单不支持退款
        /// 10: 资源不支持自助退，请走工单退款
        /// 11: 涉及推广奖励渠道订单，请提工单咨询
        /// 12: 根据业务侧产品规定，该资源不允许退款
        /// </summary>
        [JsonProperty("ReturnFailCode")]
        public long? ReturnFailCode{ get; set; }

        /// <summary>
        /// 实例退还失败错误信息。
        /// </summary>
        [JsonProperty("ReturnFailMessage")]
        public string ReturnFailMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "IsReturnable", this.IsReturnable);
            this.SetParamSimple(map, prefix + "ReturnFailCode", this.ReturnFailCode);
            this.SetParamSimple(map, prefix + "ReturnFailMessage", this.ReturnFailMessage);
        }
    }
}

